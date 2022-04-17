using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erdaulet_dairy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/data.dat"))
                database.ReadXml($"{Application.StartupPath}/data.dat");
        }

        private void phoneBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            phoneBooksBindingSource.EndEdit();
            database.WriteXml($"{Application.StartupPath}/data.dat");
            MessageBox.Show("Your data has been succesfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
