
using System.Windows.Forms;

namespace MenuStrip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuRun});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuSave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(59, 20);
            this.menuFile.Text = "ファイル&F";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(135, 22);
            this.menuOpen.Text = "開く";
            this.menuOpen.Click += MenuOpen_Click;
            // 
            // menuSave
            // 
            this.menuSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewSave,
            this.menuUpdate});
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(135, 22);
            this.menuSave.Text = "保存";
            // 
            // menuNewSave
            // 
            this.menuNewSave.Name = "menuNewSave";
            this.menuNewSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuNewSave.Size = new System.Drawing.Size(193, 22);
            this.menuNewSave.Text = "新規保存";
            this.menuNewSave.Click += MenuNewSave_Click;
            // 
            // menuUpdate
            // 
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuUpdate.Size = new System.Drawing.Size(193, 22);
            this.menuUpdate.Text = "上書保存";
            this.menuUpdate.Click += MenuUpdate_Click;
            // 
            // menuRun
            // 
            this.menuRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClose});
            this.menuRun.Name = "menuRun";
            this.menuRun.Size = new System.Drawing.Size(50, 20);
            this.menuRun.Text = "実行&R";
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(98, 22);
            this.menuClose.Text = "終了";
            this.menuClose.Click += MenuClose_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// 終了メニューのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuClose_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("終了してよろしいですか？", "通知", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 上書保存メニューのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuUpdate_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("上書保存しました", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 新規保存メニューのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuNewSave_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "保存するファイルを指定して下さい";
            dialog.FileName = "default.txt";
            dialog.InitialDirectory = @"C:\";
            dialog.OverwritePrompt = false;
            dialog.CheckPathExists = false;


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.FileName + "を新規保存しました", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 開くメニューのクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuOpen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "ファイルを選択して下さい";
            dialog.FileName = "default.txt";
            dialog.InitialDirectory = @"C:\";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.FileName + "を開きました。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return;
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuNewSave;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuRun;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
    }
}

