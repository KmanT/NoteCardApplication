using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCardApplication
{
    class Validator
    {
        public static Boolean isEmpty(string controlName, string check)
        {
            if (check.Equals(""))
            {
                MessageBox.Show("Must write to this field.",
                    controlName + "is empty.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

    }
}
