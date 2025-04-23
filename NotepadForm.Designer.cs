namespace SimpleNotepad;

partial class NotepadForm
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
        this.components = new System.ComponentModel.Container();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.contentTextBox = new System.Windows.Forms.TextBox();
        this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
        this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        //
        // menuStrip1
        //
        this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2); // Use Padding consistent with project settings
        this.menuStrip1.Size = new System.Drawing.Size(784, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        //
        // fileToolStripMenuItem
        //
        this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        this.fileToolStripMenuItem.Text = "&File";
        //
        // newToolStripMenuItem
        //
        this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        this.newToolStripMenuItem.Text = "&New";
        //
        // openToolStripMenuItem
        //
        this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        this.openToolStripMenuItem.Text = "&Open...";
        //
        // saveToolStripMenuItem
        //
        this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        this.saveToolStripMenuItem.Text = "&Save";
        //
        // saveAsToolStripMenuItem
        //
        this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.S)));
        this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        this.saveAsToolStripMenuItem.Text = "Save &As...";
        //
        // toolStripSeparator1
        //
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
        //
        // exitToolStripMenuItem
        //
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        this.exitToolStripMenuItem.Text = "E&xit";
        //
        // editToolStripMenuItem
        //
        this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem});
        this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        this.editToolStripMenuItem.Text = "&Edit";
        //
        // undoToolStripMenuItem
        //
        this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
        this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
        this.undoToolStripMenuItem.Text = "&Undo";
        //
        // toolStripSeparator2
        //
        this.toolStripSeparator2.Name = "toolStripSeparator2";
        this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
        //
        // cutToolStripMenuItem
        //
        this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
        this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
        this.cutToolStripMenuItem.Text = "Cu&t";
        //
        // copyToolStripMenuItem
        //
        this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
        this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
        this.copyToolStripMenuItem.Text = "&Copy";
        //
        // pasteToolStripMenuItem
        //
        this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
        this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
        this.pasteToolStripMenuItem.Text = "&Paste";
        //
        // toolStripSeparator3
        //
        this.toolStripSeparator3.Name = "toolStripSeparator3";
        this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
        //
        // selectAllToolStripMenuItem
        //
        this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
        this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
        this.selectAllToolStripMenuItem.Text = "Select &All";
        //
        // contentTextBox
        //
        this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.contentTextBox.Location = new System.Drawing.Point(0, 24);
        this.contentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2); // Use Margin consistent with project settings
        this.contentTextBox.Multiline = true;
        this.contentTextBox.Name = "contentTextBox";
        this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.contentTextBox.Size = new System.Drawing.Size(784, 537);
        this.contentTextBox.TabIndex = 1;
        this.contentTextBox.WordWrap = false;
        //
        // openFileDialog
        //
        this.openFileDialog.DefaultExt = "txt";
        this.openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //
        // saveFileDialog
        //
        this.saveFileDialog.DefaultExt = "txt";
        this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        //
        // NotepadForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(784, 561);
        this.Controls.Add(this.contentTextBox);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2); // Use Margin consistent with project settings
        this.Name = "NotepadForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Center the form
        this.Text = "Simple Notepad";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.TextBox contentTextBox;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
}
