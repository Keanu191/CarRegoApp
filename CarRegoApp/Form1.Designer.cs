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
            btnSave = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(11, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(139, 37);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open Text File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(179, 25);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // regoInput
            // 
            regoInput.Location = new Point(213, 87);
            regoInput.Name = "regoInput";
            regoInput.Size = new Size(150, 31);
            regoInput.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(369, 87);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(111, 33);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 87);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 4;
            label1.Text = "Enter registration plate:";
            // 
            // listBoxRego
            // 
            listBoxRego.FormattingEnabled = true;
            listBoxRego.ItemHeight = 25;
            listBoxRego.Location = new Point(21, 133);
            listBoxRego.Name = "listBoxRego";
            listBoxRego.Size = new Size(277, 254);
            listBoxRego.TabIndex = 5;
            listBoxRego.SelectedIndexChanged += listBoxRego_SelectedIndexChanged;
            listBoxRego.DoubleClick += listBoxRego_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(390, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 33);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(156, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 33);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(273, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 33);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.Location = new Point(614, 37);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(170, 37);
            btnBinarySearch.TabIndex = 9;
            btnBinarySearch.Text = "Binary Search";
            btnBinarySearch.UseVisualStyleBackColor = true;
            btnBinarySearch.Click += btnBinarySearch_Click;
            // 
            // btnLinearSearch
            // 
            btnLinearSearch.Location = new Point(614, 87);
            btnLinearSearch.Margin = new Padding(4, 5, 4, 5);
            btnLinearSearch.Name = "btnLinearSearch";
            btnLinearSearch.Size = new Size(170, 38);
            btnLinearSearch.TabIndex = 10;
            btnLinearSearch.Text = "Linear Search";
            btnLinearSearch.UseVisualStyleBackColor = true;
            btnLinearSearch.Click += btnLinearSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(524, 203);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Text File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
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
        private Button btnSave;
    }
}
