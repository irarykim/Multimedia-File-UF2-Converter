using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultiMediaFileManager
{
    public partial class Form1 : Form
    {
        public int box_height = 0;
        public int box_width = 0;
        public string current_path = "";
        public string image_directory_path = "";
        int[] group_index = new int[3];
        string[,] group_files = new string[3, 10];
        string selected_file = "";

        public Form1()
        {
            InitializeComponent(); 
            box_height = pictureBox1.Height;
            box_width = pictureBox1.Width;
            current_path = Directory.GetCurrentDirectory();

            txtDirectoryPath.Text = current_path;
            if (File.Exists(current_path + "\\uf2conv.exe") == false)
            {
                File.WriteAllBytes(current_path + "\\uf2conv.exe", MultiMediaFileManager.Properties.Resources.uf2conv);
            }

            if (Directory.Exists(current_path + "\\image") == false)
            {
                Directory.CreateDirectory(current_path + "\\image");
            }

            Bitmap my_image;

            if (File.Exists(current_path + "\\image\\test_image_1.png") == false)
            {
                my_image = MultiMediaFileManager.Properties.Resources.test_image_1;
                my_image.Save(current_path + "\\image\\test_image_1.png");
            }
            if (File.Exists(current_path + "\\image\\test_image_2.jpg") == false)
            {
                my_image = MultiMediaFileManager.Properties.Resources.test_image_2;
                my_image.Save(current_path + "\\image\\test_image_2.jpg");
            }
            if (File.Exists(current_path + "\\image\\test_image_3.jpg") == false)
            {
                my_image = MultiMediaFileManager.Properties.Resources.test_image_3;
                my_image.Save(current_path + "\\image\\test_image_3.jpg");
            }
            

            btnLoadDirectory_Click(null, EventArgs.Empty);

            for (int i = 0; i < group_files.GetLength(0); i++)
            {
                group_index[i] = 0;
                for (int j = 0; j < group_files.GetLength(1); j++)
                {
                    group_files[i, j] = "";
                }
            }
        }

        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };

        private void btnDirectoryPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDirectoryPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtDirectoryPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnLoadDirectory_Click(object sender, EventArgs e)
        {
            // Setting Inital Value of Progress Bar
            progressBar1.Value = 0;
            // Clear All Nodes if Already Exists
            treeView1.Nodes.Clear();
            toolTip1.ShowAlways = true;
            if (txtDirectoryPath.Text != "" && Directory.Exists(txtDirectoryPath.Text))
                LoadDirectory(txtDirectoryPath.Text);
            else
                MessageBox.Show("Select Directory!!");
        }

        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value
            progressBar1.Maximum = Directory.GetFiles(Dir, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
            treeView1.Nodes[0].Toggle();
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                UpdateProgress();
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                UpdateProgress();
            }
        }

        private void UpdateProgress()
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));

                Application.DoEvents();
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the node at the current mouse pointer location.
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.
                if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeView1))
                    this.toolTip1.SetToolTip(this.treeView1, theNode.Tag.ToString());
            }
            else     // Pointer is not over a node so clear the ToolTip.
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview.nodemouseclick?view=netcore-3.1
        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox1.Text = e.Node.Tag.ToString();
            if (ImageExtensions.Contains(Path.GetExtension(e.Node.FullPath).ToUpperInvariant()))
            {
                Image image1 = Image.FromFile(e.Node.Tag.ToString());

                int image_height = image1.Height;
                int image_width = image1.Width;

                if (image_height > 0 && image_width > 0)
                {
                    if (box_width * image_height / image_width <= box_height)
                    {
                        pictureBox1.Height = box_width * image_height / image_width;
                    }
                    else
                    {
                        pictureBox1.Width = box_height * image_width / image_height;
                    }

                    pictureBox1.Image = image1;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    selected_file = e.Node.Tag.ToString();
                }
                else
                {
                    MessageBox.Show("Empty image file!");
                }
            }
        }

        private void btnAddToGroup_Click(object sender, EventArgs e)
        {
            if (selected_file != "")
            {
                if (radioButtonGroupA.Checked == true)
                {
                    if (listBoxGroupA.Items.Contains(Path.GetFileName(selected_file)) == true)
                    {
                        MessageBox.Show("Already added!");
                    }
                    else if (group_index[0] < group_files.GetLength(1))
                    {
                        listBoxGroupA.Items.Add(Path.GetFileName(selected_file));
                        group_files[0, group_index[0]] = selected_file;
                        group_index[0]++;
                    }
                    else
                    {
                        MessageBox.Show("List is full!");
                    }
                }
                else if (radioButtonGroupB.Checked == true)
                {
                    if (listBoxGroupB.Items.Contains(Path.GetFileName(selected_file)) == true)
                    {
                        MessageBox.Show("Already added!");
                    }
                    else if (group_index[1] < group_files.GetLength(1))
                    {
                        listBoxGroupB.Items.Add(Path.GetFileName(selected_file));
                        group_index[1]++;
                    }
                    else
                    {
                        MessageBox.Show("List is full!");
                    }
                }
                else if (radioButtonGroupC.Checked == true)
                {
                    if (listBoxGroupC.Items.Contains(Path.GetFileName(selected_file)) == true)
                    {
                        MessageBox.Show("Already added!");
                    }
                    else if (group_index[2] < group_files.GetLength(1))
                    {
                        listBoxGroupC.Items.Add(Path.GetFileName(selected_file));
                        group_index[2]++;
                    }
                    else
                    {
                        MessageBox.Show("List is full!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No file selected!");
            }
        }

        private void btnGroupAUf2_Click(object sender, EventArgs e)
        {
            if (listBoxGroupA.Items.Count > 0)
            {
                string filename = Path.Combine(current_path, "uf2conv.exe");
                string parameters = String.Format("\"{0}\" -c -b {1} -f 0xADA52840 -o \"{2}\"", group_files[0, 0].ToString(), textBoxGroupAUf2Address.Text, "GroupA_" + listBoxGroupA.Items[0].ToString() + ".uf2");
                textBox1.Text = parameters;
                var proc = System.Diagnostics.Process.Start(filename, parameters);
                proc.WaitForExit();
                btnLoadDirectory.PerformClick();
            }
            else
            {
                MessageBox.Show("No item added!");
            }
        }
    }
}
