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
            // Initialize components
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
            btnTag = new Button();
            titleLabel = new Label();
            headerPanel = new Panel();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            // Form settings
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(600, 400);
            Text = "Car Registration Manager";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Header panel
            headerPanel.BackColor = Color.SteelBlue;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 60;
            headerPanel.Controls.Add(titleLabel);

            // Title label
            titleLabel.Text = "Car Registration Manager";
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(20, 15);

            // Status strip
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 380);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(600, 20);

            // Status label
            toolStripStatusLabel1.Text = "Ready";

            // Registration input
            regoInput.Location = new Point(20, 80);
            regoInput.Size = new Size(200, 23);
            regoInput.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Label for registration input
            label1.Text = "Enter Registration Plate:";
            label1.Location = new Point(20, 60);
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // List box for registration plates
            listBoxRego.Location = new Point(20, 120);
            listBoxRego.Size = new Size(200, 200);
            listBoxRego.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Buttons
            btnOpen.Text = "Open File";
            btnOpen.Location = new Point(250, 80);
            btnOpen.Size = new Size(100, 30);
            btnOpen.BackColor = Color.LightSteelBlue;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Click += btnOpen_Click;

            btnSave.Text = "Save File";
            btnSave.Location = new Point(250, 120);
            btnSave.Size = new Size(100, 30);
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Click += btnSave_Click;

            btnEnter.Text = "Add";
            btnEnter.Location = new Point(250, 160);
            btnEnter.Size = new Size(100, 30);
            btnEnter.BackColor = Color.LightGreen;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Click += btnEnter_Click;

            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(250, 200);
            btnDelete.Size = new Size(100, 30);
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Click += btnDelete_Click;

            btnEdit.Text = "Edit";
            btnEdit.Location = new Point(250, 240);
            btnEdit.Size = new Size(100, 30);
            btnEdit.BackColor = Color.LightGoldenrodYellow;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Click += btnEdit_Click;

            btnReset.Text = "Reset";
            btnReset.Location = new Point(250, 280);
            btnReset.Size = new Size(100, 30);
            btnReset.BackColor = Color.LightCoral;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Click += btnReset_Click;

            btnBinarySearch.Text = "Binary Search";
            btnBinarySearch.Location = new Point(400, 80);
            btnBinarySearch.Size = new Size(150, 30);
            btnBinarySearch.BackColor = Color.LightSkyBlue;
            btnBinarySearch.FlatStyle = FlatStyle.Flat;
            btnBinarySearch.Click += btnBinarySearch_Click;

            btnLinearSearch.Text = "Linear Search";
            btnLinearSearch.Location = new Point(400, 120);
            btnLinearSearch.Size = new Size(150, 30);
            btnLinearSearch.BackColor = Color.LightSkyBlue;
            btnLinearSearch.FlatStyle = FlatStyle.Flat;
            btnLinearSearch.Click += btnLinearSearch_Click;

            btnTag.Text = "Tag";
            btnTag.Location = new Point(400, 160);
            btnTag.Size = new Size(150, 30);
            btnTag.BackColor = Color.LightPink;
            btnTag.FlatStyle = FlatStyle.Flat;
            btnTag.Click += btnTag_Click;

            // Add controls to the form
            Controls.Add(headerPanel);
            Controls.Add(statusStrip1);
            Controls.Add(regoInput);
            Controls.Add(label1);
            Controls.Add(listBoxRego);
            Controls.Add(btnOpen);
            Controls.Add(btnSave);
            Controls.Add(btnEnter);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnReset);
            Controls.Add(btnBinarySearch);
            Controls.Add(btnLinearSearch);
            Controls.Add(btnTag);

            statusStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private Label titleLabel;
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
        private Button btnTag;
    }
}