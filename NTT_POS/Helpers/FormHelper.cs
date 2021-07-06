using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.Helpers
{
    public class FormHelper
    {

        public static bool CheckIfFormOpen(string formName) {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == formName)
                {
                   return true;
                }
                
            }

            return false;
        }
    }
}
