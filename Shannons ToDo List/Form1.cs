using System.Windows.Forms;

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
        //Refactor to use the toDoItems list once its implemented.
        int listCount = 0;
        List<ToDoItem> toDoItems = new List<ToDoItem>();
        private void buttonAddListTab1_Click(object sender, EventArgs e)
        {
            toDoItems.Add(new ToDoItem(toDoItems.Count(), "", flowLayoutPanelTab1));
            listCount++;
        }

        private void buttonRemoveListTab1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelTab1.Controls.Clear();
            toDoItems.Clear();
            listCount = 0;
        }
    }

    //Class that creates objects containing buttons and text boxes needed to create each item in a list.
    //It also adds itself to its parent control.
    //This is a Composite Control, info on how to make this is here:
    //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/windows-forms-control-development-basics?view=netframeworkdesktop-4.8
    //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-author-composite-controls?view=netframeworkdesktop-4.8
    class ToDoItem : UserControl
    {
        private int index;
        private int tab;
        private string toDoText;
        private Button deleteBTN;
        private FlowLayoutPanel container;
        private RichTextBox textBox;
        

        public int Index
        {
            get;
            set;
        }
        public int Tab
        {
            get;
            set;
        }
        public string ToDoText
        {
            get;
            set;
        }

        public ToDoItem(int index, string inText, FlowLayoutPanel parent)
        {
            
            //Set text content
            if (inText == "")
            {
                ToDoText = "List item: ";
            }
            else
            {
                ToDoText = inText;
            }            
            //Create UI elements
            //Style UI here
            FlowLayoutPanel container = new FlowLayoutPanel(); 
            container.Name = "tab1Item" + index;
            container.Size = new System.Drawing.Size(parent.Width - 20, 132);
            container.BackColor = System.Drawing.Color.Blue;
            parent.Controls.Add(container);

            textBox = new RichTextBox() { Text = ToDoText + index, Height = 90, Width = 430, Parent = container };
            container.Controls.Add(textBox);
            deleteBTN = new Button() { Parent = container, Text = "Delete", Height = 30, TextAlign = ContentAlignment.MiddleCenter};
            container.Controls.Add(deleteBTN);
        }

    }

}
