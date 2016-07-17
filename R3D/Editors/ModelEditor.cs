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
    public partial class ModelEditor : Form
    {
        private R3D.Lib.ModelDefinition _model;

        int mIndex = 0;
        public ModelEditor(ref R3D.Lib.ModelDefinition Model)
        {
            InitializeComponent();
            _model = Model;

            //set working dir
            FD.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Media\\";

            if (_model != null)
            {
                tName.Text = _model.ModelName;
                tFilePath.Text = _model.FilePath;
                tTexName.Text = _model.TextureName;
                tTexFilePath.Text = _model.TextureFilePath;
                tPosX.Text = _model.PosX.ToString();
                tPosY.Text = _model.PosY.ToString();
                tPosZ.Text = _model.PosZ.ToString();
                tScaleX.Text = _model.ScaleX.ToString();
                tScaleY.Text = _model.ScaleY.ToString();
                tScaleZ.Text = _model.ScaleZ.ToString();
                chAutoLoadTex.Checked = _model.AutoLoadTextures;
                chAutoLoadMat.Checked = _model.AutoLoadMaterials;
                //cbCulling.SelectedValue = _model.CullMode;
            }
        }

        private void bApply_Click(object sender, EventArgs e)
        {

            _model.ModelName = tName.Text;
            _model.FilePath = tFilePath.Text;
            _model.TextureName = tTexName.Text;
            _model.TextureFilePath = tTexFilePath.Text;
            _model.PosX = float.Parse(tPosX.Text);
            _model.PosY = float.Parse(tPosY.Text);
            _model.PosZ = float.Parse(tPosZ.Text);
            _model.ScaleX = float.Parse(tScaleX.Text);
            _model.ScaleY = float.Parse(tScaleY.Text);
            _model.ScaleZ = float.Parse(tScaleZ.Text);
            _model.AutoLoadTextures = chAutoLoadTex.Checked;
            _model.AutoLoadMaterials = chAutoLoadMat.Checked;
            //_model.CullMode = cbCulling.SelectedValue;

            this.Close();
            DialogResult = DialogResult.OK;

        }

        private void bFileBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = FD.ShowDialog();

            if (result == DialogResult.OK)
            {
                mIndex = FD.FileName.IndexOf("\\Media\\");
                tFilePath.Text = FD.FileName.Substring(mIndex + 7, FD.FileName.Length - (mIndex + 7));
            }
        }

        private void bTexBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = FD.ShowDialog();

            if (result == DialogResult.OK)
            {
                mIndex = FD.FileName.IndexOf("\\Media\\");
                tTexFilePath.Text = FD.FileName.Substring(mIndex + 7, FD.FileName.Length - (mIndex + 7));
            }
        }
    }
}
