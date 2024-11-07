namespace WinFormsApp1
{
    partial class Overlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            Add = new Button();
            Eingabename = new TextBox();
            Liste = new CheckedListBox();
            Remove = new Button();
            labelName = new Label();
            labelDate = new Label();
            Description = new TextBox();
            labelDescription = new Label();
            datum = new DateTimePicker();
            labelTodo = new Label();
            RemoveName = new TextBox();
            label1 = new Label();
            removeall = new Button();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Add.BackColor = Color.AliceBlue;
            Add.Location = new Point(659, 21);
            Add.Name = "Add";
            Add.Size = new Size(99, 24);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Eingabename
            // 
            Eingabename.BackColor = Color.AliceBlue;
            Eingabename.Location = new Point(12, 23);
            Eingabename.Name = "Eingabename";
            Eingabename.ScrollBars = ScrollBars.Horizontal;
            Eingabename.Size = new Size(151, 23);
            Eingabename.TabIndex = 1;
            // 
            // Liste
            // 
            Liste.BackColor = Color.AliceBlue;
            Liste.FormattingEnabled = true;
            Liste.Location = new Point(13, 76);
            Liste.Name = "Liste";
            Liste.Size = new Size(640, 382);
            Liste.TabIndex = 2;
            Liste.ItemCheck += Liste_ItemCheck;
            // 
            // Remove
            // 
            Remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Remove.BackColor = Color.AliceBlue;
            Remove.Location = new Point(659, 123);
            Remove.Name = "Remove";
            Remove.Size = new Size(99, 24);
            Remove.TabIndex = 3;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 5);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(538, 5);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 6;
            labelDate.Text = "Date";
            // 
            // Description
            // 
            Description.BackColor = Color.AliceBlue;
            Description.Location = new Point(169, 23);
            Description.Name = "Description";
            Description.Size = new Size(363, 23);
            Description.TabIndex = 8;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(169, 5);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(67, 15);
            labelDescription.TabIndex = 9;
            labelDescription.Text = "Description";
            // 
            // datum
            // 
            datum.CalendarMonthBackground = Color.CornflowerBlue;
            datum.Format = DateTimePickerFormat.Short;
            datum.Location = new Point(538, 23);
            datum.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            datum.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            datum.Name = "datum";
            datum.Size = new Size(115, 23);
            datum.TabIndex = 10;
            // 
            // labelTodo
            // 
            labelTodo.AutoSize = true;
            labelTodo.Location = new Point(12, 58);
            labelTodo.Name = "labelTodo";
            labelTodo.Size = new Size(47, 15);
            labelTodo.TabIndex = 11;
            labelTodo.Text = "To-Do's";
            // 
            // RemoveName
            // 
            RemoveName.BackColor = Color.AliceBlue;
            RemoveName.Location = new Point(659, 94);
            RemoveName.Name = "RemoveName";
            RemoveName.Size = new Size(201, 23);
            RemoveName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 76);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 13;
            label1.Text = "Remove Name";
            // 
            // removeall
            // 
            removeall.BackColor = Color.AliceBlue;
            removeall.Location = new Point(13, 464);
            removeall.Name = "removeall";
            removeall.Size = new Size(106, 24);
            removeall.TabIndex = 19;
            removeall.Text = "Remove All";
            removeall.UseVisualStyleBackColor = false;
            removeall.Click += removeall_Click;
            // 
            // Overlay
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.Bisque;
            ClientSize = new Size(979, 552);
            Controls.Add(removeall);
            Controls.Add(label1);
            Controls.Add(RemoveName);
            Controls.Add(labelTodo);
            Controls.Add(datum);
            Controls.Add(labelDescription);
            Controls.Add(Description);
            Controls.Add(labelDate);
            Controls.Add(labelName);
            Controls.Add(Remove);
            Controls.Add(Liste);
            Controls.Add(Eingabename);
            Controls.Add(Add);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(400, 400);
            Name = "Overlay";
            Text = "To-Do";
            TransparencyKey = SystemColors.ControlLight;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private TextBox Eingabename;
        private CheckedListBox Liste;
        private Button Remove;
        private Label labelName;
        private Label labelDate;
        private TextBox Description;
        private Label labelDescription;
        private DateTimePicker datum;
        private Label labelTodo;
        private TextBox RemoveName;
        private Label label1;
        private Button removeall;
    }
}
