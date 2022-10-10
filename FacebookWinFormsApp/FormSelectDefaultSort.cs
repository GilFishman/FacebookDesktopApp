using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopFacebookLogic; 

namespace DesktopFacebookUI
{
    public partial class FormSelectDefaultSort : Form, IFeature
    {
        public enum ePriority
        {
            Red,
            Yellow,
            Green
        }

        public FormSelectDefaultSort()
        {
            InitializeComponent();
        }

        private void m_buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ePriority GetPriority()
        {
            ePriority priority;

            if (m_RadioButtonNeedToComment.Checked)
            {
                priority = ePriority.Red;
            }
            else if (m_RadioButtonNeedToLike.Checked)
            {
                priority = ePriority.Yellow;
            }
            else
            {
                priority = ePriority.Green;
            }

            return priority;
        }

        public void RunFeature()
        {
            this.ShowDialog();
        }
    }
}
