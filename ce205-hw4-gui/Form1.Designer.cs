namespace ce205_hw4_gui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AlignmentNeedleman = new System.Windows.Forms.Button();
            this.NeedlemanTextBox2 = new System.Windows.Forms.TextBox();
            this.NeedlemanRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NeedlemanTextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SmithrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SmithAlignment = new System.Windows.Forms.Button();
            this.SmithtextBox2 = new System.Windows.Forms.TextBox();
            this.SmithtextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.HuntrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HuntAlignment = new System.Windows.Forms.Button();
            this.HunttextBox2 = new System.Windows.Forms.TextBox();
            this.HunttextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.KnuthrichTextBox = new System.Windows.Forms.RichTextBox();
            this.KnuthtextBox = new System.Windows.Forms.TextBox();
            this.SearchKnuth = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.HorspoolrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HorspooltextBox = new System.Windows.Forms.TextBox();
            this.SearchHorspool = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.BoyerrichTextBox = new System.Windows.Forms.RichTextBox();
            this.BoyertextBox = new System.Windows.Forms.TextBox();
            this.SearchBoyer = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InsertTrie = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SearchTrie = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.AlignmentNeedleman);
            this.tabPage1.Controls.Add(this.NeedlemanTextBox2);
            this.tabPage1.Controls.Add(this.NeedlemanRichTextBox);
            this.tabPage1.Controls.Add(this.NeedlemanTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Needleman-Wunsch";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(377, 47);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Random2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(377, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Random1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlignmentNeedleman
            // 
            this.AlignmentNeedleman.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.AlignmentNeedleman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AlignmentNeedleman.Location = new System.Drawing.Point(519, 30);
            this.AlignmentNeedleman.Margin = new System.Windows.Forms.Padding(4);
            this.AlignmentNeedleman.Name = "AlignmentNeedleman";
            this.AlignmentNeedleman.Size = new System.Drawing.Size(118, 28);
            this.AlignmentNeedleman.TabIndex = 8;
            this.AlignmentNeedleman.Text = "Alignment";
            this.AlignmentNeedleman.UseVisualStyleBackColor = true;
            this.AlignmentNeedleman.Click += new System.EventHandler(this.AlignmentNeedleman_Click);
            // 
            // NeedlemanTextBox2
            // 
            this.NeedlemanTextBox2.Location = new System.Drawing.Point(33, 47);
            this.NeedlemanTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.NeedlemanTextBox2.Multiline = true;
            this.NeedlemanTextBox2.Name = "NeedlemanTextBox2";
            this.NeedlemanTextBox2.Size = new System.Drawing.Size(320, 24);
            this.NeedlemanTextBox2.TabIndex = 7;
            // 
            // NeedlemanRichTextBox
            // 
            this.NeedlemanRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedlemanRichTextBox.Location = new System.Drawing.Point(33, 86);
            this.NeedlemanRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NeedlemanRichTextBox.Name = "NeedlemanRichTextBox";
            this.NeedlemanRichTextBox.Size = new System.Drawing.Size(917, 478);
            this.NeedlemanRichTextBox.TabIndex = 6;
            this.NeedlemanRichTextBox.Text = "";
            // 
            // NeedlemanTextBox1
            // 
            this.NeedlemanTextBox1.Location = new System.Drawing.Point(33, 17);
            this.NeedlemanTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.NeedlemanTextBox1.Multiline = true;
            this.NeedlemanTextBox1.Name = "NeedlemanTextBox1";
            this.NeedlemanTextBox1.Size = new System.Drawing.Size(320, 24);
            this.NeedlemanTextBox1.TabIndex = 5;
            this.NeedlemanTextBox1.TextChanged += new System.EventHandler(this.NeedlemanTextBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.SmithrichTextBox);
            this.tabPage2.Controls.Add(this.SmithAlignment);
            this.tabPage2.Controls.Add(this.SmithtextBox2);
            this.tabPage2.Controls.Add(this.SmithtextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Smith-Waterman";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(377, 47);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 24);
            this.button5.TabIndex = 12;
            this.button5.Text = "Random2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(377, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Random1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SmithrichTextBox
            // 
            this.SmithrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SmithrichTextBox.Location = new System.Drawing.Point(33, 86);
            this.SmithrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SmithrichTextBox.Name = "SmithrichTextBox";
            this.SmithrichTextBox.Size = new System.Drawing.Size(917, 478);
            this.SmithrichTextBox.TabIndex = 7;
            this.SmithrichTextBox.Text = "";
            // 
            // SmithAlignment
            // 
            this.SmithAlignment.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.SmithAlignment.Location = new System.Drawing.Point(519, 30);
            this.SmithAlignment.Margin = new System.Windows.Forms.Padding(4);
            this.SmithAlignment.Name = "SmithAlignment";
            this.SmithAlignment.Size = new System.Drawing.Size(118, 28);
            this.SmithAlignment.TabIndex = 6;
            this.SmithAlignment.Text = "Alignment";
            this.SmithAlignment.UseVisualStyleBackColor = true;
            this.SmithAlignment.Click += new System.EventHandler(this.SmithAlignment_Click_3);
            // 
            // SmithtextBox2
            // 
            this.SmithtextBox2.Location = new System.Drawing.Point(33, 47);
            this.SmithtextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.SmithtextBox2.Multiline = true;
            this.SmithtextBox2.Name = "SmithtextBox2";
            this.SmithtextBox2.Size = new System.Drawing.Size(320, 24);
            this.SmithtextBox2.TabIndex = 5;
            // 
            // SmithtextBox1
            // 
            this.SmithtextBox1.Location = new System.Drawing.Point(33, 17);
            this.SmithtextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SmithtextBox1.Multiline = true;
            this.SmithtextBox1.Name = "SmithtextBox1";
            this.SmithtextBox1.Size = new System.Drawing.Size(320, 24);
            this.SmithtextBox1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.HuntrichTextBox);
            this.tabPage3.Controls.Add(this.HuntAlignment);
            this.tabPage3.Controls.Add(this.HunttextBox2);
            this.tabPage3.Controls.Add(this.HunttextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(976, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hunt-Szymanski";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(377, 47);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 24);
            this.button6.TabIndex = 12;
            this.button6.Text = "Random2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(377, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 24);
            this.button4.TabIndex = 10;
            this.button4.Text = "Random1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HuntrichTextBox
            // 
            this.HuntrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.HuntrichTextBox.Location = new System.Drawing.Point(33, 86);
            this.HuntrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HuntrichTextBox.Name = "HuntrichTextBox";
            this.HuntrichTextBox.Size = new System.Drawing.Size(917, 478);
            this.HuntrichTextBox.TabIndex = 7;
            this.HuntrichTextBox.Text = "";
            this.HuntrichTextBox.TextChanged += new System.EventHandler(this.HuntrichTextBox_TextChanged);
            // 
            // HuntAlignment
            // 
            this.HuntAlignment.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.HuntAlignment.Location = new System.Drawing.Point(519, 30);
            this.HuntAlignment.Margin = new System.Windows.Forms.Padding(4);
            this.HuntAlignment.Name = "HuntAlignment";
            this.HuntAlignment.Size = new System.Drawing.Size(118, 28);
            this.HuntAlignment.TabIndex = 6;
            this.HuntAlignment.Text = "Alignment";
            this.HuntAlignment.UseVisualStyleBackColor = true;
            this.HuntAlignment.Click += new System.EventHandler(this.HuntAlignment_Click);
            // 
            // HunttextBox2
            // 
            this.HunttextBox2.Location = new System.Drawing.Point(33, 47);
            this.HunttextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.HunttextBox2.Multiline = true;
            this.HunttextBox2.Name = "HunttextBox2";
            this.HunttextBox2.Size = new System.Drawing.Size(320, 24);
            this.HunttextBox2.TabIndex = 5;
            // 
            // HunttextBox1
            // 
            this.HunttextBox1.Location = new System.Drawing.Point(33, 17);
            this.HunttextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.HunttextBox1.Multiline = true;
            this.HunttextBox1.Name = "HunttextBox1";
            this.HunttextBox1.Size = new System.Drawing.Size(320, 24);
            this.HunttextBox1.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage4.Controls.Add(this.KnuthrichTextBox);
            this.tabPage4.Controls.Add(this.KnuthtextBox);
            this.tabPage4.Controls.Add(this.SearchKnuth);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(976, 571);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Knuth-Morris-Pratt";
            // 
            // KnuthrichTextBox
            // 
            this.KnuthrichTextBox.Location = new System.Drawing.Point(33, 86);
            this.KnuthrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KnuthrichTextBox.Name = "KnuthrichTextBox";
            this.KnuthrichTextBox.Size = new System.Drawing.Size(917, 478);
            this.KnuthrichTextBox.TabIndex = 5;
            this.KnuthrichTextBox.Text = "";
            // 
            // KnuthtextBox
            // 
            this.KnuthtextBox.Location = new System.Drawing.Point(33, 17);
            this.KnuthtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KnuthtextBox.Multiline = true;
            this.KnuthtextBox.Name = "KnuthtextBox";
            this.KnuthtextBox.Size = new System.Drawing.Size(320, 24);
            this.KnuthtextBox.TabIndex = 4;
            // 
            // SearchKnuth
            // 
            this.SearchKnuth.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.SearchKnuth.Location = new System.Drawing.Point(361, 17);
            this.SearchKnuth.Margin = new System.Windows.Forms.Padding(4);
            this.SearchKnuth.Name = "SearchKnuth";
            this.SearchKnuth.Size = new System.Drawing.Size(100, 28);
            this.SearchKnuth.TabIndex = 3;
            this.SearchKnuth.Text = "Search";
            this.SearchKnuth.UseVisualStyleBackColor = true;
            this.SearchKnuth.Click += new System.EventHandler(this.SearchKnuth_Click_1);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage5.Controls.Add(this.HorspoolrichTextBox);
            this.tabPage5.Controls.Add(this.HorspooltextBox);
            this.tabPage5.Controls.Add(this.SearchHorspool);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(976, 571);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Horspool";
            // 
            // HorspoolrichTextBox
            // 
            this.HorspoolrichTextBox.Location = new System.Drawing.Point(33, 86);
            this.HorspoolrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HorspoolrichTextBox.Name = "HorspoolrichTextBox";
            this.HorspoolrichTextBox.Size = new System.Drawing.Size(917, 478);
            this.HorspoolrichTextBox.TabIndex = 5;
            this.HorspoolrichTextBox.Text = "";
            // 
            // HorspooltextBox
            // 
            this.HorspooltextBox.Location = new System.Drawing.Point(33, 17);
            this.HorspooltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HorspooltextBox.Multiline = true;
            this.HorspooltextBox.Name = "HorspooltextBox";
            this.HorspooltextBox.Size = new System.Drawing.Size(320, 24);
            this.HorspooltextBox.TabIndex = 4;
            // 
            // SearchHorspool
            // 
            this.SearchHorspool.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.SearchHorspool.Location = new System.Drawing.Point(361, 17);
            this.SearchHorspool.Margin = new System.Windows.Forms.Padding(4);
            this.SearchHorspool.Name = "SearchHorspool";
            this.SearchHorspool.Size = new System.Drawing.Size(100, 28);
            this.SearchHorspool.TabIndex = 3;
            this.SearchHorspool.Text = "Search";
            this.SearchHorspool.UseVisualStyleBackColor = true;
            this.SearchHorspool.Click += new System.EventHandler(this.SearchHorspool_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage6.Controls.Add(this.BoyerrichTextBox);
            this.tabPage6.Controls.Add(this.BoyertextBox);
            this.tabPage6.Controls.Add(this.SearchBoyer);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(976, 571);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Boyer-Moore";
            // 
            // BoyerrichTextBox
            // 
            this.BoyerrichTextBox.Location = new System.Drawing.Point(33, 86);
            this.BoyerrichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BoyerrichTextBox.Name = "BoyerrichTextBox";
            this.BoyerrichTextBox.Size = new System.Drawing.Size(917, 478);
            this.BoyerrichTextBox.TabIndex = 5;
            this.BoyerrichTextBox.Text = "";
            // 
            // BoyertextBox
            // 
            this.BoyertextBox.Location = new System.Drawing.Point(33, 17);
            this.BoyertextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BoyertextBox.Multiline = true;
            this.BoyertextBox.Name = "BoyertextBox";
            this.BoyertextBox.Size = new System.Drawing.Size(320, 24);
            this.BoyertextBox.TabIndex = 4;
            // 
            // SearchBoyer
            // 
            this.SearchBoyer.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.SearchBoyer.Location = new System.Drawing.Point(361, 17);
            this.SearchBoyer.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBoyer.Name = "SearchBoyer";
            this.SearchBoyer.Size = new System.Drawing.Size(100, 28);
            this.SearchBoyer.TabIndex = 3;
            this.SearchBoyer.Text = "Search";
            this.SearchBoyer.UseVisualStyleBackColor = true;
            this.SearchBoyer.Click += new System.EventHandler(this.SearchBoyer_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage7.Controls.Add(this.button7);
            this.tabPage7.Controls.Add(this.richTextBox2);
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Controls.Add(this.InsertTrie);
            this.tabPage7.Controls.Add(this.richTextBox1);
            this.tabPage7.Controls.Add(this.SearchTrie);
            this.tabPage7.Controls.Add(this.textBox2);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(976, 571);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Trie";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(513, 65);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(390, 472);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 24);
            this.textBox1.TabIndex = 13;
            // 
            // InsertTrie
            // 
            this.InsertTrie.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.InsertTrie.Location = new System.Drawing.Point(323, 17);
            this.InsertTrie.Margin = new System.Windows.Forms.Padding(4);
            this.InsertTrie.Name = "InsertTrie";
            this.InsertTrie.Size = new System.Drawing.Size(100, 24);
            this.InsertTrie.TabIndex = 12;
            this.InsertTrie.Text = "Insert";
            this.InsertTrie.UseVisualStyleBackColor = true;
            this.InsertTrie.Click += new System.EventHandler(this.InsertTrie_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 65);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(390, 472);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // SearchTrie
            // 
            this.SearchTrie.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.SearchTrie.Location = new System.Drawing.Point(790, 16);
            this.SearchTrie.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTrie.Name = "SearchTrie";
            this.SearchTrie.Size = new System.Drawing.Size(100, 24);
            this.SearchTrie.TabIndex = 10;
            this.SearchTrie.Text = "Search";
            this.SearchTrie.UseVisualStyleBackColor = true;
            this.SearchTrie.Click += new System.EventHandler(this.SearchTrie_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(513, 16);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 24);
            this.textBox2.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Rockwell", 9.2F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(215, 17);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 24);
            this.button7.TabIndex = 15;
            this.button7.Text = "Random";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button AlignmentNeedleman;
        public System.Windows.Forms.TextBox NeedlemanTextBox2;
        public System.Windows.Forms.RichTextBox NeedlemanRichTextBox;
        public System.Windows.Forms.TextBox NeedlemanTextBox1;
        private System.Windows.Forms.RichTextBox SmithrichTextBox;
        private System.Windows.Forms.Button SmithAlignment;
        private System.Windows.Forms.TextBox SmithtextBox2;
        private System.Windows.Forms.TextBox SmithtextBox1;
        private System.Windows.Forms.RichTextBox HuntrichTextBox;
        private System.Windows.Forms.Button HuntAlignment;
        private System.Windows.Forms.TextBox HunttextBox2;
        private System.Windows.Forms.TextBox HunttextBox1;
        public System.Windows.Forms.RichTextBox KnuthrichTextBox;
        public System.Windows.Forms.TextBox KnuthtextBox;
        public System.Windows.Forms.Button SearchKnuth;
        private System.Windows.Forms.RichTextBox HorspoolrichTextBox;
        private System.Windows.Forms.TextBox HorspooltextBox;
        private System.Windows.Forms.Button SearchHorspool;
        public System.Windows.Forms.RichTextBox BoyerrichTextBox;
        public System.Windows.Forms.TextBox BoyertextBox;
        public System.Windows.Forms.Button SearchBoyer;
        public System.Windows.Forms.TabPage tabPage7;
        public System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button InsertTrie;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button SearchTrie;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button7;
    }
}

