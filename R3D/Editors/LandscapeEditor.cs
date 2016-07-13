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

        public LandscapeEditor(ref R3D.Lib.LandscapeDefinition Land)
        {
            InitializeComponent();
            _land = Land;
        }


        public string GetResult()
        {
            string result = tHeightmap.Text + "|" + tTexture.Text + "|" + tDetail.Text;
            return result;
        }

        private void bHeight_Click(object sender, EventArgs e)
        {
           DialogResult result = openFileDialog1.ShowDialog();
        
            if (result == DialogResult.OK)
            {
                tHeightmap.Text = openFileDialog1.FileName;
                _land.Heightmap = openFileDialog1.FileName;
            }

        }

        private void bTexture_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tTexture.Text = openFileDialog1.FileName;
                _land.LandTexture = openFileDialog1.FileName;
            }
        }

        private void bDetail_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tDetail.Text = openFileDialog1.FileName;
                _land.LandDetail = openFileDialog1.FileName;
            }
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
