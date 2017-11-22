namespace MyAlbumData
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAlbum = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pageAlbum = new System.Windows.Forms.TabPage();
            this.pagePhoto = new System.Windows.Forms.TabPage();
            this.gridPhotoAlbum = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtPhotographer = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dtpDateTaken = new System.Windows.Forms.DateTimePicker();
            this.bsAlbum = new System.Windows.Forms.BindingSource(this.components);
            this.tabMain.SuspendLayout();
            this.pageAlbum.SuspendLayout();
            this.pagePhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Album:";
            // 
            // cboAlbum
            // 
            this.cboAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlbum.DropDownWidth = 500;
            this.cboAlbum.FormattingEnabled = true;
            this.cboAlbum.Location = new System.Drawing.Point(58, 10);
            this.cboAlbum.Name = "cboAlbum";
            this.cboAlbum.Size = new System.Drawing.Size(219, 21);
            this.cboAlbum.TabIndex = 1;
            this.cboAlbum.SelectionChangeCommitted += new System.EventHandler(this.cboAlbum_SelectionChangeCommitted);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(347, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.pageAlbum);
            this.tabMain.Controls.Add(this.pagePhoto);
            this.tabMain.Location = new System.Drawing.Point(16, 37);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(406, 211);
            this.tabMain.TabIndex = 4;
            // 
            // pageAlbum
            // 
            this.pageAlbum.Controls.Add(this.gridPhotoAlbum);
            this.pageAlbum.Location = new System.Drawing.Point(4, 22);
            this.pageAlbum.Name = "pageAlbum";
            this.pageAlbum.Padding = new System.Windows.Forms.Padding(3);
            this.pageAlbum.Size = new System.Drawing.Size(398, 157);
            this.pageAlbum.TabIndex = 0;
            this.pageAlbum.Text = "Album";
            this.pageAlbum.UseVisualStyleBackColor = true;
            // 
            // pagePhoto
            // 
            this.pagePhoto.Controls.Add(this.dtpDateTaken);
            this.pagePhoto.Controls.Add(this.btnNext);
            this.pagePhoto.Controls.Add(this.btnPrevious);
            this.pagePhoto.Controls.Add(this.pbxPhoto);
            this.pagePhoto.Controls.Add(this.label6);
            this.pagePhoto.Controls.Add(this.label5);
            this.pagePhoto.Controls.Add(this.label4);
            this.pagePhoto.Controls.Add(this.txtNotes);
            this.pagePhoto.Controls.Add(this.txtPhotographer);
            this.pagePhoto.Controls.Add(this.txtCaption);
            this.pagePhoto.Controls.Add(this.label3);
            this.pagePhoto.Controls.Add(this.txtFileName);
            this.pagePhoto.Controls.Add(this.label2);
            this.pagePhoto.Location = new System.Drawing.Point(4, 22);
            this.pagePhoto.Name = "pagePhoto";
            this.pagePhoto.Padding = new System.Windows.Forms.Padding(3);
            this.pagePhoto.Size = new System.Drawing.Size(398, 185);
            this.pagePhoto.TabIndex = 1;
            this.pagePhoto.Text = "Photo";
            this.pagePhoto.UseVisualStyleBackColor = true;
            // 
            // gridPhotoAlbum
            // 
            this.gridPhotoAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhotoAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhotoAlbum.Location = new System.Drawing.Point(3, 3);
            this.gridPhotoAlbum.Name = "gridPhotoAlbum";
            this.gridPhotoAlbum.Size = new System.Drawing.Size(392, 151);
            this.gridPhotoAlbum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(65, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(327, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Caption:";
            // 
            // txtCaption
            // 
            this.txtCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaption.Location = new System.Drawing.Point(248, 30);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(144, 20);
            this.txtCaption.TabIndex = 3;
            // 
            // txtPhotographer
            // 
            this.txtPhotographer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhotographer.Location = new System.Drawing.Point(248, 56);
            this.txtPhotographer.Name = "txtPhotographer";
            this.txtPhotographer.Size = new System.Drawing.Size(144, 20);
            this.txtPhotographer.TabIndex = 5;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(171, 125);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(221, 54);
            this.txtNotes.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Photographer:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Notes:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Date Taken:";
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPhoto.Location = new System.Drawing.Point(6, 26);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(156, 124);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 9;
            this.pbxPhoto.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Location = new System.Drawing.Point(6, 156);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Pre&vious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(87, 156);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Nex&t";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dtpDateTaken
            // 
            this.dtpDateTaken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTaken.Location = new System.Drawing.Point(248, 82);
            this.dtpDateTaken.Name = "dtpDateTaken";
            this.dtpDateTaken.Size = new System.Drawing.Size(144, 20);
            this.dtpDateTaken.TabIndex = 7;
            // 
            // bsAlbum
            // 
            this.bsAlbum.CurrentChanged += new System.EventHandler(this.bsAlbum_CurrentChanged);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 289);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboAlbum);
            this.Controls.Add(this.label1);
            this.Name = "DataForm";
            this.Text = "MyAlbumData";
            this.tabMain.ResumeLayout(false);
            this.pageAlbum.ResumeLayout(false);
            this.pagePhoto.ResumeLayout(false);
            this.pagePhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAlbum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pageAlbum;
        private System.Windows.Forms.DataGridView gridPhotoAlbum;
        private System.Windows.Forms.TabPage pagePhoto;
        private System.Windows.Forms.DateTimePicker dtpDateTaken;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPhotographer;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsAlbum;
    }
}

