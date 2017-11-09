using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyPhotos
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            CreateMdiChild(new MainForm());
        }

        private void CreateMdiChild(Form child)
        {
            child.MdiParent = this;
            child.Show();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenAlbum();
        }

        private void OpenAlbum()
        {
            string path = null;
            string pwd = null;
            if (AlbumController.OpenAlbumDialog(
            ref path, ref pwd))
            {
                try
                {
                    foreach (Form f in MdiChildren)
                    {
                        MainForm mf = f as MainForm;
                        if (mf != null && mf.AlbumPath == path)
                        {
                            // Show existing child
                            if (mf.WindowState == FormWindowState.Minimized)
                                mf.WindowState = FormWindowState.Normal;
                            mf.BringToFront();
                            return;
                        }
                    }

                    // Not found, so create a new child
                    CreateMdiChild(new MainForm(path, pwd));
                }
                catch (AlbumStorageException aex)
                {
                    MessageBox.Show(this,
                    "Unable to open album " + path + "\n [" + aex.Message + "]", "Open Album Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void menuFileClose_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void menuFile_DropDownOpening(object sender, EventArgs e)
        {
            menuFileClose.Enabled= (this.ActiveMdiChild != null);
        }

        protected override void OnLoad(EventArgs e)
        {
            ComponentResourceManager resources= new ComponentResourceManager(typeof(MainForm));

            Image newImage = (Image)resources.GetObject("mnuFileNew.Image");
            Image openImage = (Image)resources.GetObject("mnuFileOpen.Image");
            menuFileNew.Image = newImage;
            menuFileOpen.Image = openImage;
            tsbNew.Image = newImage;
            tsbOpen.Image = openImage;

            PixelDialog.GlobalMdiParent = this;

            SetTitleBar();
            base.OnLoad(e);
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            CreateMdiChild(new MainForm());
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenAlbum();
        }

        protected override void OnMdiChildActivate(EventArgs e)
        {
            ToolStripManager.RevertMerge(toolStripParent);
            MainForm f = ActiveMdiChild as MainForm;
            if (f != null)
            {
                ToolStripManager.Merge(f.MainToolStrip,toolStripParent.Name);
                toolStripParent.ImageList = f.MainToolStrip.ImageList;
            }
            SetTitleBar();
            base.OnMdiChildActivate(e);
        }

        protected void SetTitleBar()
        {
            Version ver = new Version(Application.ProductVersion);
            string titleBarFormat = "{0} - MyPhotos MDI {1:#}.{2:#}";
            string childName = "Untitled";

            MainForm mf = ActiveMdiChild as MainForm;
            if (mf != null && !String.IsNullOrEmpty(mf.AlbumTitle))
                childName = mf.AlbumTitle;
            else if (ActiveMdiChild is PixelDialog)
                childName = "Pixel Data";
            Text = String.Format(titleBarFormat,childName, ver.Major, ver.Minor);
        }

        private void menuWindowItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (item != null)
            {
                string enumVal = item.Tag as string;
                if (enumVal != null)
                {
                    LayoutMdi((MdiLayout)Enum.Parse(typeof(MdiLayout), enumVal));
                }
            }
        }

    }
}
