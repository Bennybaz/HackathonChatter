using FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace videochatsample
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.listBox1.Items.AddRange(new string[]{Globals.USER_1, Globals.USER_2, Globals.USER_3});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatForm frm = new ChatForm();
            
            this.Hide();
            frm.textUserID.Text = this.listBox1.SelectedItem.ToString();
            frm.Show();
        }
    }
}
