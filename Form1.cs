using System.Diagnostics.Eventing.Reader;

namespace text_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //New file form creation
        private void CreateNewFileForm()
        {
            NewFile @new = new NewFile();
            @new.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e) => CreateNewFileForm();

        //Shortcut keys handling
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                        CreateNewFileForm();
                        break;
                    case Keys.O:
                        break;
                    case Keys.E:
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) => this.Close();
    }
}
