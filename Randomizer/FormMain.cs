using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                listBoxInput.Items.AddRange(openFileDialogInput.FileNames.ToArray<object>());
            }
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            var dotList = new List<string>();
            for (var i = 0; i < listBoxInput.Items.Count-1; i++)
            {
                dotList.Add(".");
            }

            listBoxOutput.Items.AddRange(dotList.ToArray<object>());
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
                    Application.DoEvents();
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

            return result.ToArray<object>();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogOutput.ShowDialog() == DialogResult.OK)
            {
                var padLength = listBoxOutput.Items.Count.ToString().Length;
                Parallel.For(0, listBoxOutput.Items.Count - 1, i =>
                {
                    var destFileName = i.ToString().PadLeft(padLength, '0');
                    var inputFileName = listBoxOutput.Items[i].ToString();
                    destFileName = Path.Combine(folderBrowserDialogOutput.SelectedPath, destFileName);
                    destFileName = string.Concat(destFileName, Path.GetExtension(inputFileName));
                    File.Copy(listBoxOutput.Items[i].ToString(), destFileName);
                });
                MessageBox.Show("a");
            }
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            var source = ((sender as ToolStripMenuItem)?.Owner as ContextMenuStrip)?.SourceControl as ListBox;
            if (source == null) return;
            if (source.SelectedItems.Count < 1) return;
            for (var i = source.SelectedItems.Count - 1; i  >= 0; i--)
            {
                source.Items.Remove(source.SelectedItems[i]);
            }
        }
    }
}
