namespace MultiMediaFileManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDirectoryPath = new System.Windows.Forms.Button();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnLoadDirectory = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonGroupA = new System.Windows.Forms.RadioButton();
            this.radioButtonGroupB = new System.Windows.Forms.RadioButton();
            this.radioButtonGroupC = new System.Windows.Forms.RadioButton();
            this.btnAddToGroup = new System.Windows.Forms.Button();
            this.listBoxGroupA = new System.Windows.Forms.ListBox();
            this.listBoxGroupB = new System.Windows.Forms.ListBox();
            this.listBoxGroupC = new System.Windows.Forms.ListBox();
            this.labelImagePreview = new System.Windows.Forms.Label();
            this.textBoxGroupAUf2Address = new System.Windows.Forms.TextBox();
            this.labelGroupAUf2 = new System.Windows.Forms.Label();
            this.btnGroupAUf2 = new System.Windows.Forms.Button();
            this.btnGroupARemove = new System.Windows.Forms.Button();
            this.btnGroupBRemove = new System.Windows.Forms.Button();
            this.btnGroupBUf2 = new System.Windows.Forms.Button();
            this.labelGroupBUf2 = new System.Windows.Forms.Label();
            this.textBoxGroupBUf2Address = new System.Windows.Forms.TextBox();
            this.btnGroupCRemove = new System.Windows.Forms.Button();
            this.btnGroupCUf2 = new System.Windows.Forms.Button();
            this.labelGroupCUf2 = new System.Windows.Forms.Label();
            this.textBoxGroupCUf2Address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 84);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(363, 489);
            this.treeView1.StateImageList = this.imageList1;
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder_256x256.png");
            this.imageList1.Images.SetKeyName(1, "document-management-big.png");
            // 
            // btnDirectoryPath
            // 
            this.btnDirectoryPath.Location = new System.Drawing.Point(257, 15);
            this.btnDirectoryPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnDirectoryPath.Name = "btnDirectoryPath";
            this.btnDirectoryPath.Size = new System.Drawing.Size(119, 28);
            this.btnDirectoryPath.TabIndex = 14;
            this.btnDirectoryPath.Text = "Browse...";
            this.btnDirectoryPath.UseVisualStyleBackColor = true;
            this.btnDirectoryPath.Click += new System.EventHandler(this.btnDirectoryPath_Click);
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(13, 18);
            this.txtDirectoryPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(236, 22);
            this.txtDirectoryPath.TabIndex = 13;
            // 
            // btnLoadDirectory
            // 
            this.btnLoadDirectory.Location = new System.Drawing.Point(257, 48);
            this.btnLoadDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDirectory.Name = "btnLoadDirectory";
            this.btnLoadDirectory.Size = new System.Drawing.Size(119, 28);
            this.btnLoadDirectory.TabIndex = 15;
            this.btnLoadDirectory.Text = "Refresh Tree";
            this.btnLoadDirectory.UseVisualStyleBackColor = true;
            this.btnLoadDirectory.Click += new System.EventHandler(this.btnLoadDirectory_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 48);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(236, 28);
            this.progressBar1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(384, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonGroupA
            // 
            this.radioButtonGroupA.AutoSize = true;
            this.radioButtonGroupA.Checked = true;
            this.radioButtonGroupA.Location = new System.Drawing.Point(416, 463);
            this.radioButtonGroupA.Name = "radioButtonGroupA";
            this.radioButtonGroupA.Size = new System.Drawing.Size(82, 21);
            this.radioButtonGroupA.TabIndex = 21;
            this.radioButtonGroupA.TabStop = true;
            this.radioButtonGroupA.Text = "Group A";
            this.radioButtonGroupA.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroupB
            // 
            this.radioButtonGroupB.AutoSize = true;
            this.radioButtonGroupB.Location = new System.Drawing.Point(416, 490);
            this.radioButtonGroupB.Name = "radioButtonGroupB";
            this.radioButtonGroupB.Size = new System.Drawing.Size(82, 21);
            this.radioButtonGroupB.TabIndex = 22;
            this.radioButtonGroupB.Text = "Group B";
            this.radioButtonGroupB.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroupC
            // 
            this.radioButtonGroupC.AutoSize = true;
            this.radioButtonGroupC.Location = new System.Drawing.Point(416, 517);
            this.radioButtonGroupC.Name = "radioButtonGroupC";
            this.radioButtonGroupC.Size = new System.Drawing.Size(82, 21);
            this.radioButtonGroupC.TabIndex = 23;
            this.radioButtonGroupC.Text = "Group C";
            this.radioButtonGroupC.UseVisualStyleBackColor = true;
            // 
            // btnAddToGroup
            // 
            this.btnAddToGroup.Location = new System.Drawing.Point(552, 486);
            this.btnAddToGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToGroup.Name = "btnAddToGroup";
            this.btnAddToGroup.Size = new System.Drawing.Size(119, 28);
            this.btnAddToGroup.TabIndex = 24;
            this.btnAddToGroup.Text = "Add to Group";
            this.btnAddToGroup.UseVisualStyleBackColor = true;
            this.btnAddToGroup.Click += new System.EventHandler(this.btnAddToGroup_Click);
            // 
            // listBoxGroupA
            // 
            this.listBoxGroupA.FormattingEnabled = true;
            this.listBoxGroupA.ItemHeight = 16;
            this.listBoxGroupA.Location = new System.Drawing.Point(755, 84);
            this.listBoxGroupA.Name = "listBoxGroupA";
            this.listBoxGroupA.Size = new System.Drawing.Size(254, 84);
            this.listBoxGroupA.TabIndex = 25;
            // 
            // listBoxGroupB
            // 
            this.listBoxGroupB.FormattingEnabled = true;
            this.listBoxGroupB.ItemHeight = 16;
            this.listBoxGroupB.Location = new System.Drawing.Point(755, 257);
            this.listBoxGroupB.Name = "listBoxGroupB";
            this.listBoxGroupB.Size = new System.Drawing.Size(254, 84);
            this.listBoxGroupB.TabIndex = 26;
            // 
            // listBoxGroupC
            // 
            this.listBoxGroupC.FormattingEnabled = true;
            this.listBoxGroupC.ItemHeight = 16;
            this.listBoxGroupC.Location = new System.Drawing.Point(755, 424);
            this.listBoxGroupC.Name = "listBoxGroupC";
            this.listBoxGroupC.Size = new System.Drawing.Size(254, 84);
            this.listBoxGroupC.TabIndex = 27;
            // 
            // labelImagePreview
            // 
            this.labelImagePreview.AutoSize = true;
            this.labelImagePreview.Location = new System.Drawing.Point(484, 84);
            this.labelImagePreview.Name = "labelImagePreview";
            this.labelImagePreview.Size = new System.Drawing.Size(99, 17);
            this.labelImagePreview.TabIndex = 28;
            this.labelImagePreview.Text = "Image Preview";
            // 
            // textBoxGroupAUf2Address
            // 
            this.textBoxGroupAUf2Address.Location = new System.Drawing.Point(934, 175);
            this.textBoxGroupAUf2Address.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupAUf2Address.Name = "textBoxGroupAUf2Address";
            this.textBoxGroupAUf2Address.Size = new System.Drawing.Size(75, 22);
            this.textBoxGroupAUf2Address.TabIndex = 29;
            this.textBoxGroupAUf2Address.Text = "0x200000";
            // 
            // labelGroupAUf2
            // 
            this.labelGroupAUf2.AutoSize = true;
            this.labelGroupAUf2.Location = new System.Drawing.Point(837, 178);
            this.labelGroupAUf2.Name = "labelGroupAUf2";
            this.labelGroupAUf2.Size = new System.Drawing.Size(90, 17);
            this.labelGroupAUf2.TabIndex = 30;
            this.labelGroupAUf2.Text = "UF2 Address";
            // 
            // btnGroupAUf2
            // 
            this.btnGroupAUf2.Location = new System.Drawing.Point(840, 205);
            this.btnGroupAUf2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupAUf2.Name = "btnGroupAUf2";
            this.btnGroupAUf2.Size = new System.Drawing.Size(169, 28);
            this.btnGroupAUf2.TabIndex = 31;
            this.btnGroupAUf2.Text = "Convert to UF2";
            this.btnGroupAUf2.UseVisualStyleBackColor = true;
            this.btnGroupAUf2.Click += new System.EventHandler(this.btnGroupAUf2_Click);
            // 
            // btnGroupARemove
            // 
            this.btnGroupARemove.Location = new System.Drawing.Point(755, 175);
            this.btnGroupARemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupARemove.Name = "btnGroupARemove";
            this.btnGroupARemove.Size = new System.Drawing.Size(77, 58);
            this.btnGroupARemove.TabIndex = 32;
            this.btnGroupARemove.Text = "Remove";
            this.btnGroupARemove.UseVisualStyleBackColor = true;
            // 
            // btnGroupBRemove
            // 
            this.btnGroupBRemove.Location = new System.Drawing.Point(755, 348);
            this.btnGroupBRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupBRemove.Name = "btnGroupBRemove";
            this.btnGroupBRemove.Size = new System.Drawing.Size(77, 58);
            this.btnGroupBRemove.TabIndex = 36;
            this.btnGroupBRemove.Text = "Remove";
            this.btnGroupBRemove.UseVisualStyleBackColor = true;
            // 
            // btnGroupBUf2
            // 
            this.btnGroupBUf2.Location = new System.Drawing.Point(840, 378);
            this.btnGroupBUf2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupBUf2.Name = "btnGroupBUf2";
            this.btnGroupBUf2.Size = new System.Drawing.Size(169, 28);
            this.btnGroupBUf2.TabIndex = 35;
            this.btnGroupBUf2.Text = "Convert to UF2";
            this.btnGroupBUf2.UseVisualStyleBackColor = true;
            // 
            // labelGroupBUf2
            // 
            this.labelGroupBUf2.AutoSize = true;
            this.labelGroupBUf2.Location = new System.Drawing.Point(837, 351);
            this.labelGroupBUf2.Name = "labelGroupBUf2";
            this.labelGroupBUf2.Size = new System.Drawing.Size(90, 17);
            this.labelGroupBUf2.TabIndex = 34;
            this.labelGroupBUf2.Text = "UF2 Address";
            // 
            // textBoxGroupBUf2Address
            // 
            this.textBoxGroupBUf2Address.Location = new System.Drawing.Point(934, 348);
            this.textBoxGroupBUf2Address.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupBUf2Address.Name = "textBoxGroupBUf2Address";
            this.textBoxGroupBUf2Address.Size = new System.Drawing.Size(75, 22);
            this.textBoxGroupBUf2Address.TabIndex = 33;
            this.textBoxGroupBUf2Address.Text = "0x200000";
            // 
            // btnGroupCRemove
            // 
            this.btnGroupCRemove.Location = new System.Drawing.Point(755, 515);
            this.btnGroupCRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupCRemove.Name = "btnGroupCRemove";
            this.btnGroupCRemove.Size = new System.Drawing.Size(77, 58);
            this.btnGroupCRemove.TabIndex = 40;
            this.btnGroupCRemove.Text = "Remove";
            this.btnGroupCRemove.UseVisualStyleBackColor = true;
            // 
            // btnGroupCUf2
            // 
            this.btnGroupCUf2.Location = new System.Drawing.Point(840, 545);
            this.btnGroupCUf2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupCUf2.Name = "btnGroupCUf2";
            this.btnGroupCUf2.Size = new System.Drawing.Size(169, 28);
            this.btnGroupCUf2.TabIndex = 39;
            this.btnGroupCUf2.Text = "Convert to UF2";
            this.btnGroupCUf2.UseVisualStyleBackColor = true;
            // 
            // labelGroupCUf2
            // 
            this.labelGroupCUf2.AutoSize = true;
            this.labelGroupCUf2.Location = new System.Drawing.Point(837, 518);
            this.labelGroupCUf2.Name = "labelGroupCUf2";
            this.labelGroupCUf2.Size = new System.Drawing.Size(90, 17);
            this.labelGroupCUf2.TabIndex = 38;
            this.labelGroupCUf2.Text = "UF2 Address";
            // 
            // textBoxGroupCUf2Address
            // 
            this.textBoxGroupCUf2Address.Location = new System.Drawing.Point(934, 515);
            this.textBoxGroupCUf2Address.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupCUf2Address.Name = "textBoxGroupCUf2Address";
            this.textBoxGroupCUf2Address.Size = new System.Drawing.Size(75, 22);
            this.textBoxGroupCUf2Address.TabIndex = 37;
            this.textBoxGroupCUf2Address.Text = "0x200000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 592);
            this.Controls.Add(this.btnGroupCRemove);
            this.Controls.Add(this.btnGroupCUf2);
            this.Controls.Add(this.labelGroupCUf2);
            this.Controls.Add(this.textBoxGroupCUf2Address);
            this.Controls.Add(this.btnGroupBRemove);
            this.Controls.Add(this.btnGroupBUf2);
            this.Controls.Add(this.labelGroupBUf2);
            this.Controls.Add(this.textBoxGroupBUf2Address);
            this.Controls.Add(this.btnGroupARemove);
            this.Controls.Add(this.btnGroupAUf2);
            this.Controls.Add(this.labelGroupAUf2);
            this.Controls.Add(this.textBoxGroupAUf2Address);
            this.Controls.Add(this.labelImagePreview);
            this.Controls.Add(this.listBoxGroupC);
            this.Controls.Add(this.listBoxGroupB);
            this.Controls.Add(this.listBoxGroupA);
            this.Controls.Add(this.btnAddToGroup);
            this.Controls.Add(this.radioButtonGroupC);
            this.Controls.Add(this.radioButtonGroupB);
            this.Controls.Add(this.radioButtonGroupA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLoadDirectory);
            this.Controls.Add(this.btnDirectoryPath);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Multimedia File UF2 Converter v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnDirectoryPath;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnLoadDirectory;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonGroupA;
        private System.Windows.Forms.RadioButton radioButtonGroupB;
        private System.Windows.Forms.RadioButton radioButtonGroupC;
        private System.Windows.Forms.Button btnAddToGroup;
        private System.Windows.Forms.ListBox listBoxGroupA;
        private System.Windows.Forms.ListBox listBoxGroupB;
        private System.Windows.Forms.ListBox listBoxGroupC;
        private System.Windows.Forms.Label labelImagePreview;
        private System.Windows.Forms.TextBox textBoxGroupAUf2Address;
        private System.Windows.Forms.Label labelGroupAUf2;
        private System.Windows.Forms.Button btnGroupAUf2;
        private System.Windows.Forms.Button btnGroupARemove;
        private System.Windows.Forms.Button btnGroupBRemove;
        private System.Windows.Forms.Button btnGroupBUf2;
        private System.Windows.Forms.Label labelGroupBUf2;
        private System.Windows.Forms.TextBox textBoxGroupBUf2Address;
        private System.Windows.Forms.Button btnGroupCRemove;
        private System.Windows.Forms.Button btnGroupCUf2;
        private System.Windows.Forms.Label labelGroupCUf2;
        private System.Windows.Forms.TextBox textBoxGroupCUf2Address;
    }
}

