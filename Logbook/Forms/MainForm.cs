using Logbook.Repository;
using Logbook.UserControls;

namespace Logbook.Forms;



public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }


    private void MainForm_Load(object sender, EventArgs e)
    {
        var students = FakeRepo.GetStudents();

        for (int i = students.Count - 1; i >= 0; i--)
        {
            UC_Student uc = new(students[i]);
            uc.Dock = DockStyle.Top;
            pnl_content.Controls.Add(uc);
        }
    }
}
