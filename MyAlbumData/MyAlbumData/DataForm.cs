using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumData
{
    public partial class DataForm : Form
    {
        private AlbumManager _manager;
        internal AlbumManager Manager
        {
            get { return _manager; }
        }

        public DataForm()
        {
            InitializeComponent();
            SetupGrid();
        }

        protected override void OnLoad(EventArgs e)
        {
            Version ver = new Version(Application.ProductVersion);
            Text = String.Format("MyAlbumData {0:#}.{1:#}", ver.Major, ver.Minor);

            _manager = new AlbumManager();
            cboAlbum.DataSource = Directory.GetFiles(AlbumManager.DefaultPath, "*.abm");
            SetBindings();
            OpenAlbum();
            SetDataSources();
        }

        private void SetBindings()
        {
            gridPhotoAlbum.DataSource = bsAlbum;

            txtFileName.DataBindings.Add("Text", bsAlbum, "FileName");
            txtCaption.DataBindings.Add("Text", bsAlbum, "Caption");
            txtPhotographer.DataBindings.Add("Text", bsAlbum, "Photographer");
            dtpDateTaken.DataBindings.Add("Value", bsAlbum, "DateTaken");
            txtNotes.DataBindings.Add("Text", bsAlbum, "Notes");
            pbxPhoto.DataBindings.Add("Image", bsAlbum, "Image");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboAlbum_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OpenAlbum();
            SetDataSources();
        }

        private void OpenAlbum()
        {
            string albumPath = cboAlbum.SelectedItem.ToString();
            if (Manager.FullName == albumPath)
                return;
            if (CloseAlbum() == false)
                return;

            try
            {
                _manager = new AlbumManager(albumPath);
            }
            catch (AlbumStorageException aex)
            {
                _manager = new AlbumManager();
                MessageBox.Show("Unable to open album - " + aex.Message);
            }
        }

        private bool CloseAlbum()
        {
            if (Manager.Album != null)
            {
                if (Manager.Album.HasChanged)
                {
                    DialogResult result = AlbumController.AskForSave(Manager);
                    if (result == DialogResult.Cancel)
                        return false;   // don't dispose
                    if (result == DialogResult.Yes)
                        Manager.Save();
                }

                Manager.Album.Dispose();
            }
            return true;
        }

        private void SetDataSources()
        {
            bsAlbum.DataSource = Manager.Album;
            SetComboColumnDataSource();
        }

        private void SetComboColumnDataSource()
        {
            DataGridViewComboBoxColumn pgCol = gridPhotoAlbum.Columns["Photographer"] as DataGridViewComboBoxColumn;
            if (pgCol != null)
                pgCol.DataSource = Manager.Photographers;
        }

        private void SetupGrid()
        {
            gridPhotoAlbum.SuspendLayout();
            gridPhotoAlbum.AutoGenerateColumns = false;
            gridPhotoAlbum.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            DataGridViewImageColumn thumbCol = new DataGridViewImageColumn();
            thumbCol.DataPropertyName = "Image";
            thumbCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            thumbCol.Name = "Image";
            thumbCol.Width = 50;

            DataGridViewColumn captionCol = new DataGridViewTextBoxColumn();
            captionCol.DataPropertyName = "Caption";
            captionCol.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            captionCol.Name = "Caption";

            DataGridViewColumn takenCol = new DataGridViewTextBoxColumn();
            takenCol.DataPropertyName = "DateTaken";
            takenCol.Name = "Date Taken";

            DataGridViewComboBoxColumn pgCol = new DataGridViewComboBoxColumn();
            pgCol.AutoComplete = true;
            pgCol.DataPropertyName = "Photographer";
            pgCol.MaxDropDownItems = 4;
            pgCol.Name = "Photographer";

            DataGridViewTextBoxColumn fileCol = new DataGridViewTextBoxColumn();
            fileCol.DataPropertyName = "FileName";
            fileCol.Name = "File Name";

            gridPhotoAlbum.Columns.AddRange(new DataGridViewColumn[] { thumbCol,
                                                                       captionCol,
                                                                       takenCol,
                                                                       pgCol,
                                                                       fileCol });
            gridPhotoAlbum.ResumeLayout();
        }

        private void gridPhotoAlbum_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = gridPhotoAlbum.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[e.ColumnIndex];
                int dateIndex = gridPhotoAlbum.Columns["Date Taken"].Index;
                if (dateIndex == e.ColumnIndex)
                    ShowCalendarDropdown(cell);
                else
                {
                    ContextMenuStrip menu = new ContextMenuStrip();
                    ToolStripItem item = menu.Items.Add("Edit...");
                    item.Tag = gridPhotoAlbum.Rows[e.RowIndex];
                    item.Click += new EventHandler(editMenu_Click);

                    menu.Show(MousePosition);
                }
            }
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (item != null && item.Tag is DataGridViewRow)
            {
                DataGridViewRow row = item.Tag as DataGridViewRow;
                Photograph photo = row.DataBoundItem as Photograph;
                using (PhotoEditDialog dlg = new PhotoEditDialog(photo))
                {
                    if (dlg.ShowDialog() == DialogResult.OK && photo.HasChanged)
                        SetComboColumnDataSource();
                }
            }
        }

        private void ShowCalendarDropdown(DataGridViewCell cell)
        {
            DateTime current = (DateTime)cell.Value;
            MonthCalendar cal = new MonthCalendar();
            Panel panel = new Panel();
            Form f = new Form();

            cal.MaxSelectionCount = 1;
            cal.SetDate(current);
            cal.DateSelected += new
            DateRangeEventHandler(cal_DateSelected);

            panel.Width = cal.Width + 2;
            panel.Height = cal.Height + 2;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(cal);

            f.FormBorderStyle = FormBorderStyle.None;
            f.ShowInTaskbar = false;
            f.Size = panel.Size;
            f.Location = MousePosition;
            f.StartPosition = FormStartPosition.Manual;
            f.Controls.Add(panel);

            f.Deactivate += delegate { f.Close(); };

            f.FormClosing += delegate
            {
                if (cal.SelectionStart != current)
                    cell.Value = cal.SelectionStart;
            };

            f.Show();
        }

        private void cal_DateSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendar cal = sender as MonthCalendar;
            Form f = cal.FindForm();
            f.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = !CloseAlbum();
            base.OnFormClosing(e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsAlbum.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bsAlbum.MoveNext();
        }

        private void bsAlbum_CurrentChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = (bsAlbum.Position < bsAlbum.Count - 1);
            btnPrevious.Enabled = (bsAlbum.Position > 0);
        }
    }
}