using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechProg_Lab4_Lebed
{
    public partial class InfoAboutAuthor : Form
    {
        public InfoAboutAuthor()
        {
            InitializeComponent();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
            label4.Text = "Tel: +380 686273365";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
            label4.Text = "Tel: +380 XXXXXXXXX";
        }
    }
}
