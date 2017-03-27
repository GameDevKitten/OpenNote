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

namespace OpenNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            openFileDialog1.ShowDialog();
            textBox1.Text = File.ReadAllText(openFileDialog1.FileName);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(openFileDialog1.FileName, textBox1.Text);
        }
    }
}
