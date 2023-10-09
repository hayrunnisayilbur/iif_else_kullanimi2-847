using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_kulanımı_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbMavi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMavi.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.White;
            }

            }

        private void cbSari_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSari.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.White;
            }

            }

        private void cbKirmizi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKirmizi.Checked)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbYesil_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYesil.Checked)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbMor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMor.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
    }
    

