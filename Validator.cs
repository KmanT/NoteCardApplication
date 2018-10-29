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

        public static Boolean isNumeric(string controlName, string check)
        {
            double number = 0.0;

            if (double.TryParse(check, out number) == false)
            {
                MessageBox.Show("You must enter a number", 
                    controlName + "is not a number.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Boolean isInteger(string controlName, string check)
        {
            int number = 0;

            if (int.TryParse(check, out number) == false)
            {
                MessageBox.Show("You must enter an integer. (A number " +
                    "with no decimal.", controlName + "is not an integer.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static Boolean isWithinRange(string controlName, string check,
            double min, double max)
        {
            if (isNumeric(controlName, check) == true)
            {
                double numCheck = Convert.ToDouble(check);

                if (numCheck < min || numCheck > max)
                {
                    MessageBox.Show("The number you entered is outside the "
                        + "range of " + min.ToString() + " to " + max.ToString()
                        + ".",controlName + ": Input out of range.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                return true;
            }
            return false;
        }

    }
}
