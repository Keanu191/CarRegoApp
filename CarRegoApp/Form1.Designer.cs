namespace CarRegoApp
{
    partial class Form1
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
            btnOpen = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            regoInput = new TextBox();
            btnEnter = new Button();
            label1 = new Label();
            listBoxRego = new ListBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnReset = new Button();
            btnBinarySearch = new Button();
            btnLinearSearch = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(8, 7);
            btnOpen.Margin = new Padding(2, 2, 2, 2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(97, 22);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open Text File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 248);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 10, 0);
            statusStrip1.Size = new Size(560, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // regoInput
            // 
            regoInput.Location = new Point(149, 52);
            regoInput.Margin = new Padding(2, 2, 2, 2);
            regoInput.Name = "regoInput";
            regoInput.Size = new Size(106, 23);
            regoInput.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(258, 52);
            btnEnter.Margin = new Padding(2, 2, 2, 2);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(78, 20);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter registration plate:";
            // 
            // listBoxRego
            // 
            listBoxRego.FormattingEnabled = true;
            listBoxRego.ItemHeight = 15;
            listBoxRego.Location = new Point(15, 80);
            listBoxRego.Margin = new Padding(2, 2, 2, 2);
            listBoxRego.Name = "listBoxRego";
            listBoxRego.Size = new Size(195, 154);
            listBoxRego.TabIndex = 5;
            listBoxRego.SelectedIndexChanged += listBoxRego_SelectedIndexChanged;
            listBoxRego.DoubleClick += listBoxRego_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(273, 8);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 20);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(109, 7);
            btnEdit.Margin = new Padding(2, 2, 2, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 20);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(191, 7);
            btnReset.Margin = new Padding(2, 2, 2, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 20);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.Location = new Point(430, 22);
            btnBinarySearch.Margin = new Padding(2, 2, 2, 2);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(119, 22);
            btnBinarySearch.TabIndex = 9;
            btnBinarySearch.Text = "Binary Search";
            btnBinarySearch.UseVisualStyleBackColor = true;
            btnBinarySearch.Click += btnBinarySearch_Click;
            // 
            // btnLinearSearch
            // 
            btnLinearSearch.Location = new Point(430, 52);
            btnLinearSearch.Name = "btnLinearSearch";
            btnLinearSearch.Size = new Size(119, 23);
            btnLinearSearch.TabIndex = 10;
            btnLinearSearch.Text = "Linear Search";
            btnLinearSearch.UseVisualStyleBackColor = true;
            btnLinearSearch.Click += btnLinearSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnLinearSearch);
            Controls.Add(btnBinarySearch);
            Controls.Add(btnReset);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(listBoxRego);
            Controls.Add(label1);
            Controls.Add(btnEnter);
            Controls.Add(regoInput);
            Controls.Add(statusStrip1);
            Controls.Add(btnOpen);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox regoInput;
        private Button btnEnter;
        private Label label1;
        private ListBox listBoxRego;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnReset;
        private Button btnBinarySearch;
        private Button btnLinearSearch;
    }
}
