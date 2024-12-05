namespace Shannons_ToDo_List
{
    public partial class ToDoForm1 : Form
    {
        public ToDoForm1()
        {
            InitializeComponent();

            // Scrool bar for tab 1
            // Tutorial for this = https://www.youtube.com/watch?v=IcPdbEOmeN4
            vScrollBar1.Value = flowLayoutPanelTab1.VerticalScroll.Value;
            vScrollBar1.Minimum = flowLayoutPanelTab1.VerticalScroll.Minimum;
            vScrollBar1.Maximum = flowLayoutPanelTab1.VerticalScroll.Maximum;

        }

        private void btnHelloButton_Click(object sender, EventArgs e)
        {
            lblHelloLabel.Text = "Hello User";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanelTab1.VerticalScroll.Value = vScrollBar1.Value;
        }
    }
}
