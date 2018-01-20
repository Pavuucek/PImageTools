using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PImageTools.Randomizer
{
    public partial class FormMain : Form
    {
        private const string SupportedFormats="*.jpg,*.png";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Text = (Text + " " + Application.ProductVersion).Trim();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialogInput.ShowDialog() == DialogResult.OK)
            {
                listBoxInput.Items.AddRange(openFileDialogInput.FileNames);
            }
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            foreach (var item in listBoxInput.Items)
            {
                listBoxOutput.Items.Add(".");
            }
            var rnd = new Random();
            for (var i = 0; i < listBoxInput.Items.Count-1; i++)
            {
                var placed = false;
                while (placed==false)
                {
                    var newpos = rnd.Next(0, listBoxInput.Items.Count - 1);
                    if ((listBoxOutput.Items[newpos] as string) != ".") continue;
                    listBoxOutput.Items[newpos] = listBoxInput.Items[i];
                    placed = true;
                }

            }
        }

        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogInput.ShowDialog() == DialogResult.OK)
            {
                listBoxInput.Items.AddRange(GetFiles(folderBrowserDialogInput.SelectedPath, SupportedFormats));
            }
        }

        private static object[] GetFiles(string path, string searchPattern)
        {
            var patterns = searchPattern.Split(',');
            var result = new List<string>();
            foreach (var pattern in patterns)
            {
                result.AddRange(Directory.GetFiles(path, pattern, SearchOption.AllDirectories));
            }

            return result.ToArray();
        }
    }
}
