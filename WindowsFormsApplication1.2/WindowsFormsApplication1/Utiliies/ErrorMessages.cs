using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Utiliies
{
    public static class ErrorMessages
    {
        public static void IdenticalAppointmentsFound()
        {
            MessageBox.Show("Identical appointments found. Enter another date or time", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
        }

        public static void OutsideOfScheduledTimeOfAppointments()
        {
            MessageBox.Show("Invalid time for appointments.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button1);
        }

        public static void ConflictingWithOtherAppointments()
        {
            MessageBox.Show("Conflicting with other appointments.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1);
        }

        public static void HasAlreadyPassed()
        {
            MessageBox.Show("Invalid date and time.", "Error",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                                                        MessageBoxDefaultButton.Button1);
        }
    }
}
