using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumExplorer
{
    internal class AlbumTreeView : TreeView
    {
        public AlbumDirectoryNode AddAlbumDirectory(string name, string albumDir)
        {
            // Create a new top-level node
            AlbumDirectoryNode node
            = new AlbumDirectoryNode(name, albumDir);
            this.Nodes.Add(node);
            return node;
        }

        protected override void OnBeforeExpand(TreeViewCancelEventArgs e)
        {
            base.OnBeforeExpand(e);
            if (e.Node is AlbumDirectoryNode)
                ExpandAlbumDirectory(
                e.Node as AlbumDirectoryNode);
            else if (e.Node is AlbumNode)
                ExpandAlbum(e.Node as AlbumNode);
        }

        private void ExpandAlbumDirectory(AlbumDirectoryNode node)
        {
            // Add a node per album
            BeginUpdate();
            try
            {
                // Make sure the album nodes exist
                node.CreateAlbumNodes();
            }
            finally { EndUpdate(); }
        }

        private void ExpandAlbum(AlbumNode node)
        {
            AlbumManager mgr = node.GetManager(true);
            if (mgr != null)
            {
                BeginUpdate();
                try
                {
                    node.Nodes.Clear();
                    foreach (Photograph p in mgr.Album)
                    {
                        PhotoNode newNode = new PhotoNode(p);
                        node.Nodes.Add(newNode);
                    }
                }
                finally { EndUpdate(); }
            }
        }

        public void SelectChild(AlbumNode node, Photograph photo)
        {
            foreach (TreeNode n in node.Nodes)
            {
                PhotoNode pNode = n as PhotoNode;
                if (pNode != null
                && pNode.Photograph == photo)
                {
                    SelectedNode = n;
                    break;
                }
            }
        }

        public void SelectChild(AlbumDirectoryNode node, string albumPath)
        {
            foreach (TreeNode n in node.Nodes)
            {
                AlbumNode aNode = n as AlbumNode;
                if (aNode != null
                && String.Equals(aNode.AlbumPath,
                albumPath, StringComparison.
                InvariantCultureIgnoreCase))
                {
                    SelectedNode = n;
                    break;
                }
            }
        }

        protected override void OnAfterLabelEdit(NodeLabelEditEventArgs e)
        {
            if (String.IsNullOrEmpty(e.Label))
            {
                e.CancelEdit = true;
                return;
            }
            if (e.Node is AlbumNode)
            {
                // Rename the underlying album
                AlbumNode node = e.Node as AlbumNode;
                e.CancelEdit = !node.RenameAlbum(e.Label);
            }
            else if (e.Node is PhotoNode)
            {
                // Modify the photo caption
                PhotoNode node = e.Node as PhotoNode;
                node.Photograph.Caption = e.Label;
                SaveAlbumChanges();
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (SelectedNode != null)
                    SelectedNode.BeginEdit();
                e.Handled = true;
            }
        }

        public void RefreshNode()
        {
            IRefreshableNode refresh
            = SelectedNode as IRefreshableNode;
            if (refresh != null)
                refresh.RefreshNode();
        }

        internal void SaveAlbumChanges()
        {
            // Find the album to save
            AlbumNode aNode = SelectedNode as AlbumNode;
            if (aNode == null)
            {
                PhotoNode pNode = SelectedNode as PhotoNode;
                if (pNode != null)
                    aNode = pNode.Parent as AlbumNode;
            }
            if (aNode != null)
            {
                AlbumManager mgr = aNode.GetManager(true);
                if (mgr.Album.HasChanged)
                {
                    // Save data and update node
                    mgr.Save();
                    aNode.RefreshNode();

                    if (aNode.IsExpanded)
                    {
                        // Update photographs, as necessary
                        foreach (PhotoNode pNode in aNode.Nodes)
                        {
                            // Assumes no photos added / deleted
                            pNode.RefreshNode();
                        }
                    }
                }
            }
        }

        internal AlbumNode FindAlbumNode(string path)
        {
            AlbumDirectoryNode dirNode
            = SelectedNode as AlbumDirectoryNode;
            if (dirNode != null)
            {
                foreach (AlbumNode node in dirNode.AlbumNodes)
                {
                    if (String.Equals(node.AlbumPath, path,
                    StringComparison.
                    InvariantCultureIgnoreCase))
                        return node;
                }
            }
            return null;
        }

        internal PhotoNode FindPhotoNode(Photograph photo)
        {
            AlbumNode albumNode = SelectedNode as AlbumNode;
            if (albumNode != null)
            {
                albumNode.Expand();
                foreach (PhotoNode node in albumNode.Nodes)
                {
                    if (node.Photograph == photo)
                        return node;
                }
            }
            return null;
        }
    }
}
