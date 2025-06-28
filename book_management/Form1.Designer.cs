namespace book_management
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
            label1 = new Label();
            label3 = new Label();
            tbAuthor = new TextBox();
            tbName = new TextBox();
            tblBooks = new DataGridView();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)tblBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(120, 70);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(381, 27);
            tbAuthor.TabIndex = 3;
            // 
            // tbName
            // 
            tbName.Location = new Point(120, 27);
            tbName.Name = "tbName";
            tbName.Size = new Size(381, 27);
            tbName.TabIndex = 4;
            // 
            // tblBooks
            // 
            tblBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblBooks.Location = new Point(12, 139);
            tblBooks.Name = "tblBooks";
            tblBooks.RowHeadersWidth = 51;
            tblBooks.Size = new Size(498, 294);
            tblBooks.TabIndex = 5;
            tblBooks.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(596, 27);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 465);
            Controls.Add(btnSave);
            Controls.Add(tblBooks);
            Controls.Add(tbName);
            Controls.Add(tbAuthor);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tblBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox tbAuthor;
        private TextBox tbName;
        private DataGridView tblBooks;
        private Button btnSave;
    }
}
