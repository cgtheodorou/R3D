using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R3D.Editors
{
    public partial class MeshEditor : Form
    {
        private R3D.Lib.MeshDefinition _mesh;
        public MeshEditor(ref R3D.Lib.MeshDefinition Mesh)
        {
            InitializeComponent();
            _mesh = Mesh;

            //set working dir
            FD.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Media\\";

            if (_mesh != null)
            {

                tMeshName.Text = _mesh.MeshName;
                tTexture.Text = _mesh.Texture;
                tTextureName.Text = _mesh.TextureName;

                if (_mesh.IsWall) { rbWall.Checked = true; } else { rbFloor.Checked = true; }

                tX1.Text = _mesh.X1.ToString();
                tX2.Text = _mesh.X2.ToString();
                tZ1.Text = _mesh.Z1.ToString();
                tZ2.Text = _mesh.Z2.ToString();
                tHeight.Text = _mesh.Height.ToString();
                tAltitude.Text = _mesh.Altitude.ToString();
                tTileW.Text = _mesh.TileWidth.ToString();
                tTileH.Text = _mesh.TileHeight.ToString();
            }

        }

        private void bApply_Click(object sender, EventArgs e)
        {

            _mesh.MeshName = tMeshName.Text;
            _mesh.Texture = tTexture.Text;
            _mesh.TextureName = tTextureName.Text;
            
            if (rbWall.Checked) { _mesh.IsWall = true; } else { _mesh.IsWall = false; }

            _mesh.X1 = Int32.Parse(tX1.Text);
            _mesh.X2 = Int32.Parse(tX2.Text);
            _mesh.Z1 = Int32.Parse(tZ1.Text);
            _mesh.Z2 = Int32.Parse(tZ2.Text);
            _mesh.Height = Int32.Parse(tHeight.Text);
            _mesh.Altitude = Int32.Parse(tAltitude.Text);
            _mesh.TileWidth = Int32.Parse(tTileW.Text);
            _mesh.TileHeight = Int32.Parse(tTileH.Text);
            
            this.Close();
            DialogResult = DialogResult.OK;

        }

        private void bLoadTex_Click(object sender, EventArgs e)
        {

            DialogResult result = FD.ShowDialog();

            if (result == DialogResult.OK)
            {
                int mIndex = FD.FileName.IndexOf("\\Media\\");
                tTexture.Text = FD.FileName.Substring(mIndex + 7, FD.FileName.Length - (mIndex + 7));
            }

        }

    }
}
