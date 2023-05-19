using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHospital
{
    public class Fonksiyonlar
    {
        public static void Temizle(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox) { ((TextBox)item).Clear(); }
                else if (item is ComboBox) { ((ComboBox)item).SelectedIndex=-1; }
                else if (item is GroupBox) 
                { 
                    GroupBox g= (GroupBox)item;
                    foreach (RadioButton cntrl in g.Controls)
                    {
                        if (cntrl is RadioButton) { cntrl.Checked = default; }
                       
                    }
                    
                }
                
            }

        }

    }
}
