using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiguelsAndJosh_Module8
{
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        private void tmrIntro_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tmrIntro.Start();
        }
    }
}
