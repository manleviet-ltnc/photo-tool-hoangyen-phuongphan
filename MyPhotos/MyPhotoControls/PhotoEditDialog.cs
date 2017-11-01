﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using System.Collections.Specialized;

namespace Manning.MyPhotoControls
{
    public partial class PhotoEditDialog : Manning.MyPhotoControls.BaseEditDialog
    {
        private Photograph _photo;
        private Photograph Photo
        {
            get { return _photo; }
        }

        private AlbumManager _manager = null;
        private AlbumManager Manager
        {
            get { return _manager; }
        }

        protected PhotoEditDialog()
        {
            InitializeComponent();
        }

        public PhotoEditDialog(Photograph photo) : this()
        {
            if (photo == null)
                throw new ArgumentNullException("The photo parameter cannot be null");
            InitializeDialog(photo);
        }

        public PhotoEditDialog(AlbumManager mgr) : this()
        {
            if (mgr == null)
                throw new ArgumentNullException("The mgr parameter cannot be null");
            _manager = mgr;
            InitializeDialog(mgr.Current);
        }

        private void InitializeDialog(Photograph photo)
        {
            _photo = photo;
            ResetDialog();
        }

        protected override void ResetDialog()
        {
            // Fill combo box with photographers in album
            cboPhotographer.BeginUpdate();
            cboPhotographer.Items.Clear();

            if (Manager != null)
            {
                StringCollection coll = Manager.Photographers;
                foreach (string s in coll)
                    cboPhotographer.Items.Add(s);
            }
            else
                cboPhotographer.Items.Add(Photo.Photographer);

            cboPhotographer.EndUpdate();

            Photograph photo = Photo;
            if (photo != null)
            {
                txtPhotoFile.Text = photo.FileName;
                txtCaption.Text = photo.Caption;
                dtpDateTakens.Value = photo.DateTaken;
                cboPhotographer.Text = photo.Photographer;
                txtNotes.Text = photo.Notes;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings();
        }

        private void SaveSettings()
        {
            Photograph photo = Photo;
            if (photo != null)
            {
                photo.Caption = txtCaption.Text;
                photo.Photographer = cboPhotographer.Text;
                photo.Notes = txtNotes.Text;
                try
                {
                    photo.DateTaken = dtpDateTakens.Value;
                }
                catch (FormatException) { }
            }
        }

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            Text = txtCaption.Text + " - Properties";
        }

        private void mskDateTaken_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                DialogResult result = MessageBox.Show("The Date Taken entry is valid or "
                                                      + "in the future and may be ignored."
                                                      + "Do you wish to correct this?",
                                                      "Photo Properties",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                e.Cancel = (result == DialogResult.Yes);
            }
        }

        private void cboPhotographer_Leave(object sender, EventArgs e)
        {
            string person = cboPhotographer.Text;
            if (!cboPhotographer.Items.Contains(person))
                cboPhotographer.Items.Add(person);
        }
    }
}