namespace WinFormsApp1
{
    public partial class TabbedMDI1 : Form
    {
        public TabbedMDI1()
        {
            InitializeComponent();
            Form frm = new Form();
            frm.Text = "Form1";
            frm.MdiParent = this;
            frm.Show();
            Form frm1 = new Form();
            frm1.MdiParent = this;
            frm1.Text = "Form2";
            frm1.Show();
        }
    }
}
