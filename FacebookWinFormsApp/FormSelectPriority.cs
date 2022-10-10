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
    public partial class FormSelectPriority : Form , IFeature
    {
        public enum ePriority
        {
            Priority1,
            Priority2,
            Priority3
        }

        public FormSelectPriority()
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

            if (m_RadioButtonPriority1.Checked)
            {
                 priority = ePriority.Priority1;
            }
            else if (m_RadioButtonPriority2.Checked)
            {
                priority = ePriority.Priority2;
            }
            else
            {
                priority = ePriority.Priority3;
            }

            return priority;
        }

        public void RunFeature()
        {
            this.ShowDialog();
        }
    }
}
