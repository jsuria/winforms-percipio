using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSave
{
    public partial class FormFileSave : Form
    {
        public FormFileSave()
        {
            InitializeComponent();
        }

        // Save Button
        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string textToSave = richTextBox1.Text;
            string name = saveFileDialog1.FileName;
            File.WriteAllText(name, textToSave);
        }
        // Open Button
        private void button2_Click(object sender, EventArgs e)
        {
            // Initializes file size -1
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Check if file has been read
            {
                string file = openFileDialog1.FileName;

                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    richTextBox1.Text = text + " Completed. Size " + size + " bytes";
                }
                catch (IOException)
                {
                    // None yet...
                }
            }
        }
    }
}
