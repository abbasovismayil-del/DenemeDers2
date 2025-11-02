namespace Library.UI
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
            button1 = new Button();
            lstBooks = new ListBox();
            lstAuthors = new ListBox();
            lstMembers = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 381);
            button1.Name = "button1";
            button1.Size = new Size(318, 57);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstBooks
            // 
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(2, 12);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(786, 104);
            lstBooks.TabIndex = 1;
            // 
            // lstAuthors
            // 
            lstAuthors.FormattingEnabled = true;
            lstAuthors.Location = new Point(2, 122);
            lstAuthors.Name = "lstAuthors";
            lstAuthors.Size = new Size(786, 104);
            lstAuthors.TabIndex = 2;
            // 
            // lstMembers
            // 
            lstMembers.FormattingEnabled = true;
            lstMembers.Location = new Point(2, 232);
            lstMembers.Name = "lstMembers";
            lstMembers.Size = new Size(786, 104);
            lstMembers.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(352, 381);
            button2.Name = "button2";
            button2.Size = new Size(238, 57);
            button2.TabIndex = 4;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(lstMembers);
            Controls.Add(lstAuthors);
            Controls.Add(lstBooks);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox lstBooks;
        private ListBox lstAuthors;
        private ListBox lstMembers;
        private Button button2;
    }
}
