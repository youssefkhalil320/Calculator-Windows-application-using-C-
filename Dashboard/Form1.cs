using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ".";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "0";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch(count)
            {
                case 1:
                    ans = num - float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;


                case 5:
                    ans = num % float.Parse(textstore.Text);
                    txtresult.Text = txtresult.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;

            }
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "3";
        }

        float num;
        int count;
        private void btnsub_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "-";
                textstore.Clear();
                count = 1;
            }
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "6";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "+";
                textstore.Clear();
                count = 2;
            }
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "9";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "x";
                textstore.Clear();
                count = 3;
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "%";
                textstore.Clear();
                count = 5;
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresult.Text = textstore.Text + "/";
                textstore.Clear();
                count = 4;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textstore.Clear();
            txtresult.Clear();
        }
    }
}
