using System;
using System.Windows.Forms;

namespace ESSU_Student_Information_System
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Center_Control(Control my_control, String dimension)
        {
            if (dimension == "horizontal")
            {
                my_control.Left = (my_control.Parent.ClientSize.Width - my_control.Width) / 2;
            }

            if (dimension == "vertical")
            {
                my_control.Top = (my_control.Parent.ClientSize.Height - my_control.Height) / 2;
            }

            if (dimension == "both")
            {
                my_control.Left = (my_control.Parent.ClientSize.Width - my_control.Width) / 2;
                my_control.Top = (my_control.Parent.ClientSize.Height - my_control.Height) / 2;
            }
        }

        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            Center_Control(pnl_active_students, "horizontal");

            if (lv_recent_activities.Columns.Count == 3)
            {
                lv_recent_activities.Columns[0].Width = 0;

                int totalWidth = lv_recent_activities.ClientSize.Width;
                int secondColumnWidth = (int)(totalWidth * 0.30);
                int thirdColumnWidth = (int)(totalWidth * 0.70);

                lv_recent_activities.Columns[1].Width = secondColumnWidth;
                lv_recent_activities.Columns[2].Width = thirdColumnWidth;
            }
        }
    }
}
