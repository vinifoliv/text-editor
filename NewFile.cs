using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_editor
{
    public partial class NewFile : Form
    {
        private const string message = "File name";

        public NewFile()
        {
            InitializeComponent();
        }

        //File name editing
        private void txtFileName_Enter(object sender, EventArgs e)
        {
            if (txtFileName.Text == message)
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
                txtFileName.ForeColor = Color.DarkGray;
                txtFileName.Text = message;
                return;
            }
            txtFileName.Text = "";
            txtFileName.ForeColor = Color.Black;
        }

        //File saving
        private void SaveFile()
        {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveWindow.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveWindow.DefaultExt = ".txt";
            saveWindow.FileName = $"{txtFileName.Text}.txt";

            if (saveWindow.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveWindow.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(txtText.Text);
                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void NewFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile();
            }
        }

        private void txtText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile();
            }
        }

        private void txtFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile();
            }
        }
    }
}
