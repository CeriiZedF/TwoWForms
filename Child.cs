using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoWForms
{
    public partial class Child : Form
    {
        private Parent parent;
        public Child(Parent parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var temp = sender as TextBox;
            parent.UpdateForm(ref temp);
        }
        public void UpdateForm(ref TextBox temp)
        {
            textBox1.Text = temp.Text;
        }
    }
}
