namespace ScrollablePictureBoxTest
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.comboSizeMode = new System.Windows.Forms.ComboBox();
            this.spbxImage = new Manning.MyPhotoControls.ScrollablePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(22, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // comboSizeMode
            // 
            this.comboSizeMode.FormattingEnabled = true;
            this.comboSizeMode.Items.AddRange(new object[] {
            "AutoSize",
            "CenterImage",
            "Normal",
            "StretchImage",
            "Zoom"});
            this.comboSizeMode.Location = new System.Drawing.Point(122, 25);
            this.comboSizeMode.Name = "comboSizeMode";
            this.comboSizeMode.Size = new System.Drawing.Size(181, 21);
            this.comboSizeMode.TabIndex = 1;
            this.comboSizeMode.Text = "Normal";
            this.comboSizeMode.SelectedIndexChanged += new System.EventHandler(this.comboSizeMode_SelectedIndexChanged);
            // 
            // spbxImage
            // 
            this.spbxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spbxImage.Location = new System.Drawing.Point(12, 57);
            this.spbxImage.Name = "spbxImage";
            this.spbxImage.Size = new System.Drawing.Size(291, 230);
            this.spbxImage.TabIndex = 2;
            this.spbxImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 299);
            this.Controls.Add(this.spbxImage);
            this.Controls.Add(this.comboSizeMode);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Scrollable Picture Test";
            ((System.ComponentModel.ISupportInitialize)(this.spbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox comboSizeMode;
        private Manning.MyPhotoControls.ScrollablePictureBox spbxImage;
    }
}

