using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace DesktopFacebookUI
{
    public class TextBoxAdapter
    {
        public TextBox Adoptee { get; set; }

        public TextBoxAdapter (TextBox i_TextBox)
        {
            Adoptee = i_TextBox;
        }

        public string TextBoxName
        {
            get { return Adoptee.Name;  }
            set { Adoptee.Name = value;  }
        }

        public string TextBoxText
        {
            get { return Adoptee.Text; }
            set { Adoptee.Text = value; }
        }

        public Point TextBoxLocation
        {
            get { return Adoptee.Location; }
            set { Adoptee.Location = value; }
        }

        public static TextBoxAdapter CreateTextBoxAdapter (User i_User, TextBox i_Textbox)
        {
            TextBoxAdapter currentTextBoxAdapter = new TextBoxAdapter(i_Textbox);
            return currentTextBoxAdapter;
        }
    }
}
