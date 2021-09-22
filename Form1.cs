using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIA_ALUNOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            double N1=0, N2=0, N3=0, Media=0;
            N1 = double.Parse(txt1.Text);
            N2 = double.Parse(txt2.Text);
            N3 = double.Parse(txt3.Text);
            Media = Math.Round((N1 + N2 + N3) / 3,2);
            lblmedia.Text = txtnome.Text + " sua média é: " + Convert.ToString(Media);

            if (Media >=6)
            {
                lblmedia.ForeColor = Color.Green;
                lblmedia.Text = lblmedia.Text + " Você foi APROVADO";
            }
            else
            {
                lblmedia.ForeColor = Color.Red;
                lblmedia.Text = lblmedia.Text + " Você foi REPROVADO";
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            lblmedia.Text = "";
            txtnome.Focus();
        }
    }
}
