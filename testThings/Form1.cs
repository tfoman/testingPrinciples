using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testThings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ny kommentar på samma ställe
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //en liten kommentering, igen
            MessageBox.Show("Hejsan hoppsan !! Jag lägger till en tjingeling !!");
            //här kommer en kommentar efter också
        }
    }
}
