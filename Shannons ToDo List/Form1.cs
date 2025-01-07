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


        string[] tab1List;
        int listCount = 0;
        private void buttonAddListTab1_Click(object sender, EventArgs e)
        {
            //Having this present enables dynamic elements to be added. Removing it makes them invisible, Y tho?????????????
            // I probably missed a line of code that initialises it that I am not aware of.
            //flowLayoutPanelTab1.Controls.Add(new RichTextBox() { Text = "List item: " + listCount, Height = 5, Width = 430});
            flowLayoutPanelTab1.Controls.Add(new ToDoItem(listCount, "", flowLayoutPanelTab1));
            listCount++;
        }

        private void buttonRemoveListTab1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelTab1.Controls.Clear();
            listCount = 0;
        }
    }

    //Class that creates objects containing buttons and text boxes needed to create each item in a list.
    //This is a Composite Control, info on how to make this is here:
    //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/windows-forms-control-development-basics?view=netframeworkdesktop-4.8
    //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-author-composite-controls?view=netframeworkdesktop-4.8
    class ToDoItem : UserControl
    {
        private int index;
        private string text;
        private Button deleteBTN;
        private FlowLayoutPanel container;
        private RichTextBox textBox;
        

        public int Index
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        public ToDoItem(int index, string inText, FlowLayoutPanel parent)
        {
            
            //Set text content
            if (inText == "")
            {
                Text = "List item: ";
            }
            else
            {
                Text = inText;
            }            
            //Create UI elements
            //Style UI here
            FlowLayoutPanel container = new FlowLayoutPanel(); 
            container.Dock = System.Windows.Forms.DockStyle.Fill;
            //fartherForm.Location = new System.Drawing.Point(0, 0);
            container.Name = "tab1Item" + index;
            container.Size = new System.Drawing.Size(parent.Width - 15, 125);
            parent.Controls.Add(container);

            textBox = new RichTextBox() { Text = Text + index, Height = 90, Width = 430, Parent = container };
            container.Controls.Add(textBox);
            deleteBTN = new Button() { Parent = container, Text = "Delete"};
            container.Controls.Add(deleteBTN);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

    }

}
