using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso
{
    public partial class Control1 : System.Windows.Forms.TextBox
    {
        public Control1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void validad()
        {
            if (this.Text.Length == 13 && !this.Text.Contains("-"))
            {
                this.ForeColor = Color.Black;
            }
            else
            {
                this.ForeColor = Color.Red;
            }

        }

        private void Control1_TextChanged(object sender, EventArgs e)
        {
            validad();
        }
    }
}
