﻿namespace PImageTools.Randomizer
{
    partial class FormMain
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.contextMenuStripDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.openFileDialogInput = new System.Windows.Forms.OpenFileDialog();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialogInput = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSortInput = new System.Windows.Forms.Button();
            this.contextMenuStripDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxInput
            // 
            this.listBoxInput.ContextMenuStrip = this.contextMenuStripDelete;
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.HorizontalScrollbar = true;
            this.listBoxInput.Location = new System.Drawing.Point(12, 12);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxInput.Size = new System.Drawing.Size(329, 537);
            this.listBoxInput.TabIndex = 0;
            // 
            // contextMenuStripDelete
            // 
            this.contextMenuStripDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelete});
            this.contextMenuStripDelete.Name = "contextMenuStripDelete";
            this.contextMenuStripDelete.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemDelete.Text = "Delete";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.ContextMenuStrip = this.contextMenuStripDelete;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.HorizontalScrollbar = true;
            this.listBoxOutput.Location = new System.Drawing.Point(347, 12);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxOutput.Size = new System.Drawing.Size(329, 537);
            this.listBoxOutput.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(683, 517);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Files";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // openFileDialogInput
            // 
            this.openFileDialogInput.Multiselect = true;
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(776, 517);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomize.TabIndex = 3;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Location = new System.Drawing.Point(683, 485);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFolder.TabIndex = 4;
            this.buttonAddFolder.Text = "Add Folder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(776, 485);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonSortInput
            // 
            this.buttonSortInput.Location = new System.Drawing.Point(683, 456);
            this.buttonSortInput.Name = "buttonSortInput";
            this.buttonSortInput.Size = new System.Drawing.Size(75, 23);
            this.buttonSortInput.TabIndex = 6;
            this.buttonSortInput.Text = "Sort Input";
            this.buttonSortInput.UseVisualStyleBackColor = true;
            this.buttonSortInput.Click += new System.EventHandler(this.buttonSortInput_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 566);
            this.Controls.Add(this.buttonSortInput);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonAddFolder);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.listBoxInput);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Randomizer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStripDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInput;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialogInput;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogInput;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.Button buttonSortInput;
    }
}

