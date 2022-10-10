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
    public partial class FormSelectSort : Form
    {
        public enum eSort
        {
            Priority, 
            Default
        }
        public FormSelectSort()
        {
            InitializeComponent();
            this.ShowDialog(); 
        }

        private void m_buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public eSort GetChosenSort()
        {
            eSort priority;

            if (m_RadioButtonPriority.Checked)
            {
                priority = eSort.Priority;
            }
            else
            {
                priority = eSort.Default;
            }

            return priority;
        }
    }
}
