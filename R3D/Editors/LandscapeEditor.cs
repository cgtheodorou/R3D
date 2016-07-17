using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTV3D65;

namespace R3D.Landscape
{
    public partial class LandscapeEditor : Form
    {

        private R3D.Lib.LandscapeDefinition _land;

        int mIndex = 0;

        public LandscapeEditor(ref R3D.Lib.LandscapeDefinition Land)
        {
            InitializeComponent();
            _land = Land;

            //set working dir
            FD.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Media\\";
        }


        public string GetResult()
        {
            string result = tHeightmap.Text + "|" + tTexture.Text + "|" + tDetail.Text;
            return result;
        }

        private void bHeight_Click(object sender, EventArgs e)
        {
           DialogResult result = FD.ShowDialog();
        
            if (result == DialogResult.OK)
            {
                mIndex = FD.FileName.IndexOf("\\Media\\");
                tHeightmap.Text = FD.FileName.Substring(mIndex + 7, FD.FileName.Length - (mIndex + 7));
            }

        }

        private void bTexture_Click(object sender, EventArgs e)
        {
            DialogResult result = FD.ShowDialog();

            if (result == DialogResult.OK)
            {
                mIndex = FD.FileName.IndexOf("\\Media\\");
                tTexture.Text = FD.FileName.Substring(mIndex + 7, FD.FileName.Length - (mIndex + 7));
            }
        }

        private void bDetail_Click(object sender, EventArgs e)
        {
            DialogResult result = FD.ShowDialog();

            if (result == DialogResult.OK)
            {
                mIndex = FD.FileName.IndexOf("\\Media\\");
                tDetail.Text = FD.FileName.Substring(mIndex + 7, FD.FileName.Length - (mIndex + 7));
            }
        }

        private void bApply_Click(object sender, EventArgs e)
        {

            _land.Heightmap = tHeightmap.Text;
            _land.LandTexture = tTexture.Text;
            _land.LandDetail = tDetail.Text;

            this.Close();
            DialogResult = DialogResult.OK;

        }
    }
}
