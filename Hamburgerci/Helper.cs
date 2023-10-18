using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci
{
  public class Helper
    {

        public static void Temizle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is MaskedTextBox)
                {
                    MaskedTextBox mb = (MaskedTextBox)control;
                    mb.Clear();
                }
                else if (control is TextBox)
                {
                    TextBox tb = (TextBox)control;
                    tb.Clear();
                }
                else if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Text == "Büyük" || rb.Text == "Orta" || rb.Text == "Küçük")
                    {
                        rb.Checked = true;
                    }
                    else rb.Checked = false;
                }
                else if (control is ComboBox)
                {
                    ComboBox cb = (ComboBox)control;
                    cb.SelectedItem = null;
                }


                else if (control is GroupBox)
                {
                    GroupBox gb = (GroupBox)control;
                    Temizle(gb.Controls);
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)control;
                    cb.Value = 0;
                }




            }
        }



    }
}
