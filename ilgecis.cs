using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gecis
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textbox.Text);
            textbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();

            foreach (var item in listBox1.SelectedItems)
            {
                selectedItems.Add(item);
            }
            foreach (var item in selectedItems)
            {
                 listBox2.Items.Add(item);
                 listBox1.Items.Remove(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();

            foreach (var item in listBox2.SelectedItems)
            {
                selectedItems.Add(item);
            }
            foreach (var item in selectedItems)
            {
                listBox1.Items.Add(item);
                listBox2.Items.Remove(item);
            }
        }
    }
}
