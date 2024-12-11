namespace Shannons_ToDo_List
{
    public partial class ToDoForm1 : Form
    {
        public ToDoForm1()
        {
            InitializeComponent();

        }

        private void btnHelloButton_Click(object sender, EventArgs e)
        {
            lblHelloLabel.Text = "Hello User";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddListTab1_Click(object sender, EventArgs e)
        {
            //Can likely call a class for this line that returns a block of UI objects.
            flowLayoutPanelTab1.Controls.Add(new RichTextBox() { Text = "Some description."});
        }

        private void buttonRemoveListTab1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelTab1.Controls.Clear();
        }
    }
}
