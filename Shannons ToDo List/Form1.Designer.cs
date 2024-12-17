namespace Shannons_ToDo_List
{
    partial class ToDoForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonRemoveListTab1 = new Button();
            buttonAddListTab1 = new Button();
            flowLayoutPanelTab1 = new FlowLayoutPanel();
            richTextBox2 = new RichTextBox();
            tabPage2 = new TabPage();
            btnHelloButton = new Button();
            lblHelloLabel = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            flowLayoutPanelTab1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(469, 530);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonRemoveListTab1);
            tabPage1.Controls.Add(buttonAddListTab1);
            tabPage1.Controls.Add(flowLayoutPanelTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(461, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveListTab1
            // 
            buttonRemoveListTab1.Location = new Point(106, 16);
            buttonRemoveListTab1.Name = "buttonRemoveListTab1";
            buttonRemoveListTab1.Size = new Size(119, 29);
            buttonRemoveListTab1.TabIndex = 9;
            buttonRemoveListTab1.Text = "Remove Item";
            buttonRemoveListTab1.UseVisualStyleBackColor = true;
            buttonRemoveListTab1.Click += buttonRemoveListTab1_Click;
            // 
            // buttonAddListTab1
            // 
            buttonAddListTab1.Location = new Point(6, 16);
            buttonAddListTab1.Name = "buttonAddListTab1";
            buttonAddListTab1.Size = new Size(94, 29);
            buttonAddListTab1.TabIndex = 8;
            buttonAddListTab1.Text = "Create Item";
            buttonAddListTab1.UseVisualStyleBackColor = true;
            buttonAddListTab1.Click += buttonAddListTab1_Click;
            // 
            // flowLayoutPanelTab1
            // 
            flowLayoutPanelTab1.AutoScroll = true;
            flowLayoutPanelTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelTab1.Controls.Add(richTextBox2);
            flowLayoutPanelTab1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelTab1.Location = new Point(0, 62);
            flowLayoutPanelTab1.Name = "flowLayoutPanelTab1";
            flowLayoutPanelTab1.Size = new Size(460, 435);
            flowLayoutPanelTab1.TabIndex = 7;
            flowLayoutPanelTab1.WrapContents = false;
            flowLayoutPanelTab1.Paint += flowLayoutPanel1_Paint;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(425, 15);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnHelloButton);
            tabPage2.Controls.Add(lblHelloLabel);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(461, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Test Tab";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHelloButton
            // 
            btnHelloButton.Location = new Point(6, 26);
            btnHelloButton.Name = "btnHelloButton";
            btnHelloButton.Size = new Size(104, 31);
            btnHelloButton.TabIndex = 3;
            btnHelloButton.Text = "Hello Button";
            btnHelloButton.UseVisualStyleBackColor = true;
            btnHelloButton.Click += btnHelloButton_Click;
            // 
            // lblHelloLabel
            // 
            lblHelloLabel.AutoSize = true;
            lblHelloLabel.Location = new Point(3, 3);
            lblHelloLabel.Name = "lblHelloLabel";
            lblHelloLabel.Size = new Size(89, 20);
            lblHelloLabel.TabIndex = 2;
            lblHelloLabel.Text = "Hello World";
            // 
            // ToDoForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 531);
            Controls.Add(tabControl1);
            Name = "ToDoForm1";
            Text = "Todo List";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            flowLayoutPanelTab1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnHelloButton;
        private Label lblHelloLabel;
        private FlowLayoutPanel flowLayoutPanelTab1;
        private Button buttonAddListTab1;
        private Button buttonRemoveListTab1;
        private RichTextBox richTextBox2;
    }
}
