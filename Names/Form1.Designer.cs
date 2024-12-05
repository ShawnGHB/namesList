namespace Names
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
            lstNames = new ListBox();
            txtName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 25;
            lstNames.Location = new Point(12, 37);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(189, 154);
            lstNames.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(207, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 2;
            label1.Text = "Names";
            label1.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(207, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 218);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Name = "Form1";
            Text = "Names";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNames;
        private TextBox txtName;
        private Label label1;
        private Button btnAdd;
    }
}
