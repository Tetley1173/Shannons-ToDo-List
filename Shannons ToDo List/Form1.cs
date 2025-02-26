using System;
using System.DirectoryServices;
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
            ToDoItem item = new ToDoItem(flowLayoutPanelTab1.Controls.Count, "", flowLayoutPanelTab1, deleteListItem_click!);
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
            //What should I do about the nullable warning? Maybe a try catch?
            Button? btn = sender as Button;
            ToDoItem? item = btn.Parent as ToDoItem;

            flowLayoutPanelTab1.Controls.Remove(btn.Parent);

            foreach(ToDoItem items in flowLayoutPanelTab1.Controls)
            {
                int workingIndex = flowLayoutPanelTab1.Controls.IndexOf(items);
                items.ItemIndex = workingIndex;
                
                //Check if ok to overide text then do so. May need to rerender.
                if (items.TextBox.Text.StartsWith("List item: "))
                {
                    items.ToDoText = "List item: " + workingIndex;
                    items.TextBox.Text = items.ToDoText;
                    Console.WriteLine(items.ToDoText);
                }

               
            }
        }
    }

    //An extension of the FlowlayoutPanel class that populates the panel with child controls that represent an item on the to do list.
    class ToDoItem : FlowLayoutPanel
    {
        private int itemIndex;
        private int tab;
        private string? toDoText;
        private Button deleteBTN;
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

        public RichTextBox TextBox 
        { 
            get {  return textBox; } 
            set { textBox = value; } 
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
