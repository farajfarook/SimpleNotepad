using System.IO;

namespace SimpleNotepad;

public partial class Form1 : Form
{
    private string? currentFilePath = null;
    private bool isDirty = false;
    private const string DefaultFileName = "Untitled";

    public Form1()
    {
        InitializeComponent();
        this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
        this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
        this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
        this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
        this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
        this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
        this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
        this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
        this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
        this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

        UpdateTitle();
    }

    private void UpdateTitle()
    {
        string fileName = (currentFilePath == null) ? DefaultFileName : Path.GetFileName(currentFilePath);
        this.Text = $"{(isDirty ? "*" : "")}{fileName} - Simple Notepad";
    }

    private void mainTextBox_TextChanged(object? sender, EventArgs e)
    {
        if (!isDirty)
        {
            isDirty = true;
            UpdateTitle();
        }
    }

    private DialogResult PromptToSave()
    {
        if (!isDirty) return DialogResult.No;

        string message = $"Do you want to save changes to {(currentFilePath == null ? DefaultFileName : Path.GetFileName(currentFilePath))}?";
        return MessageBox.Show(message, "Simple Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
    }

    private bool SaveFile()
    {
        if (currentFilePath == null)
        {
            return SaveFileAs();
        }
        else
        {
            try
            {
                File.WriteAllText(currentFilePath, mainTextBox.Text);
                isDirty = false;
                UpdateTitle();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    private bool SaveFileAs()
    {
        saveFileDialog1.FileName = currentFilePath ?? DefaultFileName + ".txt";
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            currentFilePath = saveFileDialog1.FileName;
            return SaveFile();
        }
        return false;
    }

    private void newToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        DialogResult result = PromptToSave();
        if (result == DialogResult.Cancel) return;
        if (result == DialogResult.Yes)
        {
            if (!SaveFile()) return;
        }

        mainTextBox.Clear();
        currentFilePath = null;
        isDirty = false;
        UpdateTitle();
    }

    private void openToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        DialogResult result = PromptToSave();
        if (result == DialogResult.Cancel) return;
        if (result == DialogResult.Yes)
        {
            if (!SaveFile()) return;
        }

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            try
            {
                currentFilePath = openFileDialog1.FileName;
                mainTextBox.Text = File.ReadAllText(currentFilePath);
                isDirty = false;
                UpdateTitle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentFilePath = null;
                mainTextBox.Clear();
                isDirty = false;
                UpdateTitle();
            }
        }
    }

    private void saveToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        SaveFile();
    }

    private void saveAsToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        SaveFileAs();
    }

    private void exitToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void undoToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (mainTextBox.CanUndo)
        {
            mainTextBox.Undo();
        }
    }

    private void cutToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (mainTextBox.SelectionLength > 0)
        {
            mainTextBox.Cut();
        }
    }

    private void copyToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (mainTextBox.SelectionLength > 0)
        {
            mainTextBox.Copy();
        }
    }

    private void pasteToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (Clipboard.ContainsText())
        {
            mainTextBox.Paste();
        }
    }

    private void selectAllToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        mainTextBox.SelectAll();
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        DialogResult result = PromptToSave();
        if (result == DialogResult.Cancel)
        {
            e.Cancel = true;
        }
        else if (result == DialogResult.Yes)
        {
            if (!SaveFile())
            {
                e.Cancel = true;
            }
        }
    }
}
