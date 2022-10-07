using Logbook.Models;

namespace Logbook.UserControls;



public partial class UC_Student : UserControl
{

    public UC_Student(Student student)
    {
        InitializeComponent();

        cBox_lab.SelectedIndex = 0;
        cBox_class.SelectedIndex = 0;


        lbl_no.Text = student.Number.ToString();

        if(!string.IsNullOrWhiteSpace(student.PictureUrl))
            pBox_profile.Load($"./../../../Resources/{student.PictureUrl}");


        lbl_fullname.Text = student.FullName;
        lbl_lastIn.Text = student.LastIn.ToShortDateString();


        switch (student.Status)
        {
            case ParticipationStatus.Present:
                rBtn_1.Checked = true;
                break;
            case ParticipationStatus.Late:
                rBtn_2.Checked = true;
                break;
            case ParticipationStatus.Absent:
                rBtn_3.Checked = true;
                break;
        }


    }
}
