using System;
using System.Dynamic;
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
        //List<Control> toDoItems = new List<Control>();
        private void buttonAddListTab1_Click(object sender, EventArgs e)
        {
            ToDoItem item = new ToDoItem(flowLayoutPanelTab1.Controls.Count, "", flowLayoutPanelTab1, deleteListItem_click);
            //toDoItems.Add(item);
        }

        private void buttonRemoveListTab1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelTab1.Controls.Clear();
            //toDoItems.Clear();
            //listCount = 0;
        }

        private void deleteListItem_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ToDoItem item = btn.Parent as ToDoItem;
            int test = item.ItemIndex;

            // Do something here
            flowLayoutPanelTab1.Controls.Remove(btn.Parent);
            //toDoItems.IndexOf(item.Parent);
            //toDoItems.RemoveAt(item.ItemIndex);
        }
    }

    //Class that creates objects containing buttons and text boxes needed to create each item in a list.
    //It also adds itself to its parent control.
    //This is a Composite Control, info on how to make this is here:
    //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/windows-forms-control-development-basics?view=netframeworkdesktop-4.8
    //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-author-composite-controls?view=netframeworkdesktop-4.8
    class ToDoItem : FlowLayoutPanel
    {
        private int itemIndex;
        private int tab;
        private string? toDoText;
        private Button deleteBTN;
        //private FlowLayoutPanel container;
        private RichTextBox textBox;
        

        public int ItemIndex
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

        public ToDoItem(int position, string inPutText, FlowLayoutPanel parent, EventHandler passedEvent)
        {
            
            //Set text content
            if (inPutText == "")
            {
                ToDoText = "List item: ";
            }
            else
            {
                ToDoText = inPutText;
            }          
            
            ItemIndex = position;

            //Tab = tabPosition;

            //Create UI elements
            //Style UI here
            //container = new FlowLayoutPanel(); 
            this.Name = "tab1Item" + position;
            this.Size = new System.Drawing.Size(parent.Width - 20, 132);
            this.BackColor = System.Drawing.Color.Blue;
            parent.Controls.Add(this);

            textBox = new RichTextBox() { Text = ToDoText + position, Height = 90, Width = 430, Parent = this };
            this.Controls.Add(textBox);
            deleteBTN = new Button() { Parent = this, Text = "Delete", Height = 30, TextAlign = ContentAlignment.MiddleCenter};
            this.Controls.Add(deleteBTN);
            deleteBTN.Click += new EventHandler(passedEvent);
        }
    }

}
