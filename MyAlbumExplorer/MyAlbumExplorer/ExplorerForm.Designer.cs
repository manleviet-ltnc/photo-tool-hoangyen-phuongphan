namespace MyAlbumExplorer
{
    partial class ExplorerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.lvAlbumList = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.spbxPhoto = new Manning.MyPhotoControls.ScrollablePictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.atvAlbumTree = new MyAlbumExplorer.AlbumTreeView();
            this.menuEditProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditLabel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbxPhoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.atvAlbumTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvAlbumList);
            this.splitContainer1.Panel2.Controls.Add(this.spbxPhoto);
            this.splitContainer1.Size = new System.Drawing.Size(434, 237);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Photo");
            this.imageListSmall.Images.SetKeyName(1, "Album");
            this.imageListSmall.Images.SetKeyName(2, "AlbumSelect");
            this.imageListSmall.Images.SetKeyName(3, "AlbumError");
            this.imageListSmall.Images.SetKeyName(4, "AlbumLock");
            this.imageListSmall.Images.SetKeyName(5, "AlbumDir");
            // 
            // lvAlbumList
            // 
            this.lvAlbumList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAlbumList.FullRowSelect = true;
            this.lvAlbumList.LabelEdit = true;
            this.lvAlbumList.LargeImageList = this.imageListLarge;
            this.lvAlbumList.Location = new System.Drawing.Point(0, 0);
            this.lvAlbumList.Name = "lvAlbumList";
            this.lvAlbumList.Size = new System.Drawing.Size(286, 237);
            this.lvAlbumList.SmallImageList = this.imageListSmall;
            this.lvAlbumList.TabIndex = 1;
            this.lvAlbumList.UseCompatibleStateImageBehavior = false;
            this.lvAlbumList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvAlbumList_AfterLabelEdit);
            this.lvAlbumList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAlbumList_ColumnClick);
            this.lvAlbumList.ItemActivate += new System.EventHandler(this.lvAlbumList_ItemActivate);
            this.lvAlbumList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvAlbumList_KeyDown);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "Photo");
            this.imageListLarge.Images.SetKeyName(1, "Album");
            this.imageListLarge.Images.SetKeyName(2, "AlbumSelect");
            this.imageListLarge.Images.SetKeyName(3, "AlbumError");
            this.imageListLarge.Images.SetKeyName(4, "AlbumLock");
            this.imageListLarge.Images.SetKeyName(5, "AlbumDir");
            // 
            // spbxPhoto
            // 
            this.spbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spbxPhoto.Image = null;
            this.spbxPhoto.Location = new System.Drawing.Point(0, 0);
            this.spbxPhoto.Name = "spbxPhoto";
            this.spbxPhoto.Size = new System.Drawing.Size(286, 237);
            this.spbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spbxPhoto.TabIndex = 0;
            this.spbxPhoto.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(92, 22);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditLabel,
            this.menuEditProperties});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.DropDownOpening += new System.EventHandler(this.menuEdit_DropDownOpening);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewLarge,
            this.menuViewSmall,
            this.menuViewList,
            this.menuViewDetails,
            this.menuViewTiles});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            this.menuView.DropDownOpening += new System.EventHandler(this.menuView_DropDownOpening);
            this.menuView.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuView_DropDownItemClicked);
            // 
            // menuViewLarge
            // 
            this.menuViewLarge.Name = "menuViewLarge";
            this.menuViewLarge.Size = new System.Drawing.Size(134, 22);
            this.menuViewLarge.Tag = "LargeIcon";
            this.menuViewLarge.Text = "Lar&ge Icons";
            // 
            // menuViewSmall
            // 
            this.menuViewSmall.Name = "menuViewSmall";
            this.menuViewSmall.Size = new System.Drawing.Size(134, 22);
            this.menuViewSmall.Tag = "SmallIcon";
            this.menuViewSmall.Text = "S&mall Icons";
            // 
            // menuViewList
            // 
            this.menuViewList.Name = "menuViewList";
            this.menuViewList.Size = new System.Drawing.Size(134, 22);
            this.menuViewList.Tag = "List";
            this.menuViewList.Text = "&List";
            // 
            // menuViewDetails
            // 
            this.menuViewDetails.Name = "menuViewDetails";
            this.menuViewDetails.Size = new System.Drawing.Size(134, 22);
            this.menuViewDetails.Tag = "Details";
            this.menuViewDetails.Text = "&Details";
            // 
            // menuViewTiles
            // 
            this.menuViewTiles.Name = "menuViewTiles";
            this.menuViewTiles.Size = new System.Drawing.Size(134, 22);
            this.menuViewTiles.Tag = "Tile";
            this.menuViewTiles.Text = "&Tiles";
            // 
            // atvAlbumTree
            // 
            this.atvAlbumTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atvAlbumTree.HideSelection = false;
            this.atvAlbumTree.ImageIndex = 0;
            this.atvAlbumTree.ImageList = this.imageListSmall;
            this.atvAlbumTree.LabelEdit = true;
            this.atvAlbumTree.Location = new System.Drawing.Point(0, 0);
            this.atvAlbumTree.Name = "atvAlbumTree";
            this.atvAlbumTree.SelectedImageIndex = 0;
            this.atvAlbumTree.Size = new System.Drawing.Size(144, 237);
            this.atvAlbumTree.TabIndex = 0;
            this.atvAlbumTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.atvAlbumTree_BeforeSelect);
            this.atvAlbumTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.atvAlbumTree_AfterSelect);
            // 
            // menuEditProperties
            // 
            this.menuEditProperties.Name = "menuEditProperties";
            this.menuEditProperties.Size = new System.Drawing.Size(152, 22);
            this.menuEditProperties.Text = "&Properties...";
            this.menuEditProperties.Click += new System.EventHandler(this.menuEditProperties_Click);
            // 
            // menuEditLabel
            // 
            this.menuEditLabel.Name = "menuEditLabel";
            this.menuEditLabel.Size = new System.Drawing.Size(152, 22);
            this.menuEditLabel.Text = "&Label";
            this.menuEditLabel.Click += new System.EventHandler(this.menuEditLabel_Click);
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExplorerForm";
            this.Text = "Album Explorer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spbxPhoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private AlbumTreeView atvAlbumTree;
        private System.Windows.Forms.ListView lvAlbumList;
        private Manning.MyPhotoControls.ScrollablePictureBox spbxPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewLarge;
        private System.Windows.Forms.ToolStripMenuItem menuViewSmall;
        private System.Windows.Forms.ToolStripMenuItem menuViewList;
        private System.Windows.Forms.ToolStripMenuItem menuViewDetails;
        private System.Windows.Forms.ToolStripMenuItem menuViewTiles;
        private System.Windows.Forms.ToolStripMenuItem menuEditProperties;
        private System.Windows.Forms.ToolStripMenuItem menuEditLabel;
    }
}

