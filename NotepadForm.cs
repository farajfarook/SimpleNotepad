using System.IO;
using System.Reflection;

namespace SimpleNotepad;

public partial class NotepadForm : Form
{
    private string? currentFilePath = null;
    private bool isDirty = false;
    private const string DefaultFileName = "Untitled";

    public NotepadForm()
    {
        InitializeComponent();

        // Set the form's icon
        try
        {
            // Assumes notepad.ico is in the same directory as the executable
            string? assemblyLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (assemblyLocation != null)
            {
                string iconPath = Path.Combine(assemblyLocation, "notepad.ico");
                if (File.Exists(iconPath))
                {
                    this.Icon = new Icon(iconPath);
                }
                else
                {
                    // Fallback or error handling if icon not found
                    Console.WriteLine("Icon file not found at expected location: " + iconPath);
                }
            }
        }
        catch (Exception ex)
        {
            // Log or handle the exception if icon loading fails
            Console.WriteLine("Error loading icon: " + ex.Message);
        }

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
        this.contentTextBox.TextChanged += new System.EventHandler(this.contentTextBox_TextChanged);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotepadForm_FormClosing);

        UpdateTitle();
    }

    private void UpdateTitle()
    {
        string fileName = (currentFilePath == null) ? DefaultFileName : Path.GetFileName(currentFilePath);
        this.Text = $"{(isDirty ? "*" : "")}{fileName} - Simple Notepad";
    }

    private void contentTextBox_TextChanged(object? sender, EventArgs e)
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
                File.WriteAllText(currentFilePath, contentTextBox.Text);
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
        saveFileDialog.FileName = currentFilePath ?? DefaultFileName + ".txt";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            currentFilePath = saveFileDialog.FileName;
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

        contentTextBox.Clear();
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

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                currentFilePath = openFileDialog.FileName;
                contentTextBox.Text = File.ReadAllText(currentFilePath);
                isDirty = false;
                UpdateTitle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentFilePath = null;
                contentTextBox.Clear();
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
        if (contentTextBox.CanUndo)
        {
            contentTextBox.Undo();
        }
    }

    private void cutToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (contentTextBox.SelectionLength > 0)
        {
            contentTextBox.Cut();
        }
    }

    private void copyToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (contentTextBox.SelectionLength > 0)
        {
            contentTextBox.Copy();
        }
    }

    private void pasteToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (Clipboard.ContainsText())
        {
            contentTextBox.Paste();
        }
    }

    private void selectAllToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        contentTextBox.SelectAll();
    }

    private void NotepadForm_FormClosing(object? sender, FormClosingEventArgs e)
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
