using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace text_editor
{
    public partial class NewFile : Form
    {
        private const string _message = "File name";
        private bool _isFileSaved = false;
        private string _filePath = "";

        public NewFile()
        {
            InitializeComponent();
            txtFileName.Height = 15;
        }

        //File name editing
        private void txtFileName_Enter(object sender, EventArgs e)
        {
            if (txtFileName.Text == _message)
            {
                setForeColor(false);
            }
        }

        private void txtFileName_Leave(object sender, EventArgs e)
        {
            if (txtFileName.Text == "" || txtFileName.Text == null)
            {
                setForeColor(true);
            }
        }

        //Set the default font color for the standard message or user-defined file name
        private void setForeColor(bool isStandardMessage)
        {
            if (isStandardMessage)
            {
                txtFileName.ForeColor = Color.LightGray;
                txtFileName.Text = _message;
                return;
            }
            txtFileName.Text = "";
            txtFileName.ForeColor = Color.White;
        }

        //KeyDown handling
        private void NewFile_KeyDown(object sender, KeyEventArgs e) => HandleShortcutKeys(e);

        private void txtText_KeyDown(object sender, KeyEventArgs e) => HandleShortcutKeys(e);

        private void txtFileName_KeyDown(object sender, KeyEventArgs e) => HandleShortcutKeys(e);
       
        public void HandleShortcutKeys(KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        SaveFile();
                        break;
                    default:
                        break;
                }
            }
        }

        //Menustrip handling
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e) => SaveFile();

        //File saving
        private void SaveFile()
        {
            if (_isFileSaved)
            {
                File.WriteAllText(_filePath, txtText.Text);
                PrintSaveMessage();
            }
            else
            {
                SaveFileDialog saveWindow = new SaveFileDialog();
                saveWindow.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveWindow.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveWindow.DefaultExt = ".txt";
                saveWindow.FileName = $"{txtFileName.Text}.txt";

                if (saveWindow.ShowDialog() == DialogResult.OK)
                {
                    _filePath = saveWindow.FileName;

                    using (StreamWriter writer = new StreamWriter(_filePath))
                    {
                        writer.Write(txtText.Text);
                    }
                }
                _isFileSaved = true;
                PrintSaveMessage();
            }
        }

        private void PrintSaveMessage()
        {
            txtTextInformation.Text = $@"{txtFileName.Text} succesfully saved!";
        }
    }
}
