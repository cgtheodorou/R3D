namespace R3D.Landscape
{
    partial class LandscapeEditor
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
            this.FD = new System.Windows.Forms.OpenFileDialog();
            this.bHeight = new System.Windows.Forms.Button();
            this.tHeightmap = new System.Windows.Forms.TextBox();
            this.lbHeightmap = new System.Windows.Forms.Label();
            this.lbTexture = new System.Windows.Forms.Label();
            this.tTexture = new System.Windows.Forms.TextBox();
            this.bTexture = new System.Windows.Forms.Button();
            this.lbDetail = new System.Windows.Forms.Label();
            this.tDetail = new System.Windows.Forms.TextBox();
            this.bDetail = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.cmbLandPrecision = new System.Windows.Forms.ComboBox();
            this.lbLandPrecision = new System.Windows.Forms.Label();
            this.lbLandAffinity = new System.Windows.Forms.Label();
            this.cmbLandAffinity = new System.Windows.Forms.ComboBox();
            this.tWidth = new System.Windows.Forms.TextBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tHeight = new System.Windows.Forms.TextBox();
            this.lbPosX = new System.Windows.Forms.Label();
            this.tPosX = new System.Windows.Forms.TextBox();
            this.lbPosY = new System.Windows.Forms.Label();
            this.tPosY = new System.Windows.Forms.TextBox();
            this.lbPosZ = new System.Windows.Forms.Label();
            this.tPosZ = new System.Windows.Forms.TextBox();
            this.chkSmoothTerrain = new System.Windows.Forms.CheckBox();
            this.chkLOD = new System.Windows.Forms.CheckBox();
            this.chkProgressiveLOD = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bHeight
            // 
            this.bHeight.Location = new System.Drawing.Point(263, 41);
            this.bHeight.Name = "bHeight";
            this.bHeight.Size = new System.Drawing.Size(75, 20);
            this.bHeight.TabIndex = 0;
            this.bHeight.Text = "Browse";
            this.bHeight.UseVisualStyleBackColor = true;
            this.bHeight.Click += new System.EventHandler(this.bHeight_Click);
            // 
            // tHeightmap
            // 
            this.tHeightmap.Enabled = false;
            this.tHeightmap.Location = new System.Drawing.Point(11, 41);
            this.tHeightmap.Name = "tHeightmap";
            this.tHeightmap.Size = new System.Drawing.Size(233, 20);
            this.tHeightmap.TabIndex = 1;
            // 
            // lbHeightmap
            // 
            this.lbHeightmap.AutoSize = true;
            this.lbHeightmap.Location = new System.Drawing.Point(8, 25);
            this.lbHeightmap.Name = "lbHeightmap";
            this.lbHeightmap.Size = new System.Drawing.Size(58, 13);
            this.lbHeightmap.TabIndex = 2;
            this.lbHeightmap.Text = "Heightmap";
            // 
            // lbTexture
            // 
            this.lbTexture.AutoSize = true;
            this.lbTexture.Location = new System.Drawing.Point(8, 80);
            this.lbTexture.Name = "lbTexture";
            this.lbTexture.Size = new System.Drawing.Size(43, 13);
            this.lbTexture.TabIndex = 5;
            this.lbTexture.Text = "Texture";
            // 
            // tTexture
            // 
            this.tTexture.Enabled = false;
            this.tTexture.Location = new System.Drawing.Point(11, 96);
            this.tTexture.Name = "tTexture";
            this.tTexture.Size = new System.Drawing.Size(233, 20);
            this.tTexture.TabIndex = 4;
            // 
            // bTexture
            // 
            this.bTexture.Location = new System.Drawing.Point(263, 96);
            this.bTexture.Name = "bTexture";
            this.bTexture.Size = new System.Drawing.Size(75, 20);
            this.bTexture.TabIndex = 3;
            this.bTexture.Text = "Browse";
            this.bTexture.UseVisualStyleBackColor = true;
            this.bTexture.Click += new System.EventHandler(this.bTexture_Click);
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Location = new System.Drawing.Point(8, 137);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(34, 13);
            this.lbDetail.TabIndex = 8;
            this.lbDetail.Text = "Detail";
            // 
            // tDetail
            // 
            this.tDetail.Enabled = false;
            this.tDetail.Location = new System.Drawing.Point(11, 153);
            this.tDetail.Name = "tDetail";
            this.tDetail.Size = new System.Drawing.Size(233, 20);
            this.tDetail.TabIndex = 7;
            // 
            // bDetail
            // 
            this.bDetail.Location = new System.Drawing.Point(263, 153);
            this.bDetail.Name = "bDetail";
            this.bDetail.Size = new System.Drawing.Size(75, 20);
            this.bDetail.TabIndex = 6;
            this.bDetail.Text = "Browse";
            this.bDetail.UseVisualStyleBackColor = true;
            this.bDetail.Click += new System.EventHandler(this.bDetail_Click);
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(147, 670);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(83, 26);
            this.bApply.TabIndex = 9;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // cmbLandPrecision
            // 
            this.cmbLandPrecision.FormattingEnabled = true;
            this.cmbLandPrecision.Items.AddRange(new object[] {
            "Best",
            "Average",
            "High",
            "Low",
            "Lowest"});
            this.cmbLandPrecision.Location = new System.Drawing.Point(173, 212);
            this.cmbLandPrecision.Name = "cmbLandPrecision";
            this.cmbLandPrecision.Size = new System.Drawing.Size(138, 21);
            this.cmbLandPrecision.TabIndex = 10;
            // 
            // lbLandPrecision
            // 
            this.lbLandPrecision.AutoSize = true;
            this.lbLandPrecision.Location = new System.Drawing.Point(170, 193);
            this.lbLandPrecision.Name = "lbLandPrecision";
            this.lbLandPrecision.Size = new System.Drawing.Size(106, 13);
            this.lbLandPrecision.TabIndex = 11;
            this.lbLandPrecision.Text = "Landscape Precision";
            // 
            // lbLandAffinity
            // 
            this.lbLandAffinity.AutoSize = true;
            this.lbLandAffinity.Location = new System.Drawing.Point(8, 193);
            this.lbLandAffinity.Name = "lbLandAffinity";
            this.lbLandAffinity.Size = new System.Drawing.Size(94, 13);
            this.lbLandAffinity.TabIndex = 13;
            this.lbLandAffinity.Text = "Landscape Affinity";
            // 
            // cmbLandAffinity
            // 
            this.cmbLandAffinity.FormattingEnabled = true;
            this.cmbLandAffinity.Items.AddRange(new object[] {
            "High",
            "Low",
            "None"});
            this.cmbLandAffinity.Location = new System.Drawing.Point(11, 212);
            this.cmbLandAffinity.Name = "cmbLandAffinity";
            this.cmbLandAffinity.Size = new System.Drawing.Size(138, 21);
            this.cmbLandAffinity.TabIndex = 12;
            // 
            // tWidth
            // 
            this.tWidth.Location = new System.Drawing.Point(154, 256);
            this.tWidth.Name = "tWidth";
            this.tWidth.Size = new System.Drawing.Size(55, 20);
            this.tWidth.TabIndex = 14;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(113, 259);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(35, 13);
            this.lbWidth.TabIndex = 15;
            this.lbWidth.Text = "Width";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(110, 285);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(38, 13);
            this.lbHeight.TabIndex = 17;
            this.lbHeight.Text = "Height";
            // 
            // tHeight
            // 
            this.tHeight.Location = new System.Drawing.Point(154, 282);
            this.tHeight.Name = "tHeight";
            this.tHeight.Size = new System.Drawing.Size(55, 20);
            this.tHeight.TabIndex = 16;
            // 
            // lbPosX
            // 
            this.lbPosX.AutoSize = true;
            this.lbPosX.Location = new System.Drawing.Point(19, 259);
            this.lbPosX.Name = "lbPosX";
            this.lbPosX.Size = new System.Drawing.Size(14, 13);
            this.lbPosX.TabIndex = 19;
            this.lbPosX.Text = "X";
            // 
            // tPosX
            // 
            this.tPosX.Location = new System.Drawing.Point(39, 256);
            this.tPosX.Name = "tPosX";
            this.tPosX.Size = new System.Drawing.Size(55, 20);
            this.tPosX.TabIndex = 18;
            // 
            // lbPosY
            // 
            this.lbPosY.AutoSize = true;
            this.lbPosY.Location = new System.Drawing.Point(19, 285);
            this.lbPosY.Name = "lbPosY";
            this.lbPosY.Size = new System.Drawing.Size(14, 13);
            this.lbPosY.TabIndex = 21;
            this.lbPosY.Text = "Y";
            // 
            // tPosY
            // 
            this.tPosY.Location = new System.Drawing.Point(39, 282);
            this.tPosY.Name = "tPosY";
            this.tPosY.Size = new System.Drawing.Size(55, 20);
            this.tPosY.TabIndex = 20;
            // 
            // lbPosZ
            // 
            this.lbPosZ.AutoSize = true;
            this.lbPosZ.Location = new System.Drawing.Point(19, 311);
            this.lbPosZ.Name = "lbPosZ";
            this.lbPosZ.Size = new System.Drawing.Size(14, 13);
            this.lbPosZ.TabIndex = 23;
            this.lbPosZ.Text = "Z";
            // 
            // tPosZ
            // 
            this.tPosZ.Location = new System.Drawing.Point(39, 308);
            this.tPosZ.Name = "tPosZ";
            this.tPosZ.Size = new System.Drawing.Size(55, 20);
            this.tPosZ.TabIndex = 22;
            // 
            // chkSmoothTerrain
            // 
            this.chkSmoothTerrain.AutoSize = true;
            this.chkSmoothTerrain.Location = new System.Drawing.Point(20, 345);
            this.chkSmoothTerrain.Name = "chkSmoothTerrain";
            this.chkSmoothTerrain.Size = new System.Drawing.Size(98, 17);
            this.chkSmoothTerrain.TabIndex = 24;
            this.chkSmoothTerrain.Text = "Smooth Terrain";
            this.chkSmoothTerrain.UseVisualStyleBackColor = true;
            // 
            // chkLOD
            // 
            this.chkLOD.AutoSize = true;
            this.chkLOD.Location = new System.Drawing.Point(10, 32);
            this.chkLOD.Name = "chkLOD";
            this.chkLOD.Size = new System.Drawing.Size(84, 17);
            this.chkLOD.TabIndex = 25;
            this.chkLOD.Text = "Enable LOD";
            this.chkLOD.UseVisualStyleBackColor = true;
            // 
            // chkProgressiveLOD
            // 
            this.chkProgressiveLOD.AutoSize = true;
            this.chkProgressiveLOD.Location = new System.Drawing.Point(10, 55);
            this.chkProgressiveLOD.Name = "chkProgressiveLOD";
            this.chkProgressiveLOD.Size = new System.Drawing.Size(106, 17);
            this.chkProgressiveLOD.TabIndex = 26;
            this.chkProgressiveLOD.Text = "Progressive LOD";
            this.chkProgressiveLOD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLOD);
            this.groupBox1.Controls.Add(this.chkProgressiveLOD);
            this.groupBox1.Location = new System.Drawing.Point(12, 551);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 99);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSmoothTerrain);
            this.groupBox2.Controls.Add(this.tPosX);
            this.groupBox2.Controls.Add(this.lbLandAffinity);
            this.groupBox2.Controls.Add(this.lbDetail);
            this.groupBox2.Controls.Add(this.cmbLandAffinity);
            this.groupBox2.Controls.Add(this.tDetail);
            this.groupBox2.Controls.Add(this.lbPosZ);
            this.groupBox2.Controls.Add(this.bDetail);
            this.groupBox2.Controls.Add(this.lbLandPrecision);
            this.groupBox2.Controls.Add(this.lbTexture);
            this.groupBox2.Controls.Add(this.tWidth);
            this.groupBox2.Controls.Add(this.tTexture);
            this.groupBox2.Controls.Add(this.cmbLandPrecision);
            this.groupBox2.Controls.Add(this.bTexture);
            this.groupBox2.Controls.Add(this.tPosZ);
            this.groupBox2.Controls.Add(this.lbHeightmap);
            this.groupBox2.Controls.Add(this.tHeightmap);
            this.groupBox2.Controls.Add(this.lbWidth);
            this.groupBox2.Controls.Add(this.bHeight);
            this.groupBox2.Controls.Add(this.lbPosY);
            this.groupBox2.Controls.Add(this.tHeight);
            this.groupBox2.Controls.Add(this.tPosY);
            this.groupBox2.Controls.Add(this.lbHeight);
            this.groupBox2.Controls.Add(this.lbPosX);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 513);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terrain";
            // 
            // LandscapeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 708);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bApply);
            this.Name = "LandscapeEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landscape Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FD;
        private System.Windows.Forms.Button bHeight;
        private System.Windows.Forms.TextBox tHeightmap;
        private System.Windows.Forms.Label lbHeightmap;
        private System.Windows.Forms.Label lbTexture;
        private System.Windows.Forms.TextBox tTexture;
        private System.Windows.Forms.Button bTexture;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.TextBox tDetail;
        private System.Windows.Forms.Button bDetail;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.ComboBox cmbLandPrecision;
        private System.Windows.Forms.Label lbLandPrecision;
        private System.Windows.Forms.Label lbLandAffinity;
        private System.Windows.Forms.ComboBox cmbLandAffinity;
        private System.Windows.Forms.TextBox tWidth;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox tHeight;
        private System.Windows.Forms.Label lbPosX;
        private System.Windows.Forms.TextBox tPosX;
        private System.Windows.Forms.Label lbPosY;
        private System.Windows.Forms.TextBox tPosY;
        private System.Windows.Forms.Label lbPosZ;
        private System.Windows.Forms.TextBox tPosZ;
        private System.Windows.Forms.CheckBox chkSmoothTerrain;
        private System.Windows.Forms.CheckBox chkLOD;
        private System.Windows.Forms.CheckBox chkProgressiveLOD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}