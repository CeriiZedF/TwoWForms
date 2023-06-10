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
    public partial class Parent : Form
    {
        Child child;
        public Parent()
        {
            InitializeComponent();
            child = new Child(this);
            child.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var temp = sender as TextBox;
            child.UpdateForm(ref temp);
        }

        public void UpdateForm(ref TextBox temp)
        {
            textBox1.Text = temp.Text;
        }

        private void Parent_Load(object sender, EventArgs e)
        {

        }
    }
}
