namespace Logbook.UserControls
{
    partial class UC_Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBox_profile = new System.Windows.Forms.PictureBox();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_no = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_lastIn = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rBtn_3 = new System.Windows.Forms.RadioButton();
            this.rBtn_2 = new System.Windows.Forms.RadioButton();
            this.rBtn_1 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cBox_lab = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cBox_class = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_diamond_3 = new System.Windows.Forms.Button();
            this.btn_diamond_2 = new System.Windows.Forms.Button();
            this.btn_diamond_1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_comment = new System.Windows.Forms.Button();
            this.lbl_border_bottom = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_profile)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 7;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.57094F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.82287F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.89768F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.74807F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.74807F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.86586F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.34652F));
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel.Controls.Add(this.panel7, 6, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1183, 55);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBox_profile);
            this.panel1.Controls.Add(this.lbl_fullname);
            this.panel1.Controls.Add(this.lbl_no);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 55);
            this.panel1.TabIndex = 0;
            // 
            // pBox_profile
            // 
            this.pBox_profile.Image = global::Logbook.Properties.Resources.avatar_default;
            this.pBox_profile.Location = new System.Drawing.Point(25, 3);
            this.pBox_profile.Name = "pBox_profile";
            this.pBox_profile.Size = new System.Drawing.Size(50, 50);
            this.pBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_profile.TabIndex = 1;
            this.pBox_profile.TabStop = false;
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Location = new System.Drawing.Point(78, 20);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(58, 15);
            this.lbl_fullname.TabIndex = 0;
            this.lbl_fullname.Text = "FullName";
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Location = new System.Drawing.Point(1, 20);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(23, 15);
            this.lbl_no.TabIndex = 0;
            this.lbl_no.Text = "No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_lastIn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 55);
            this.panel2.TabIndex = 1;
            // 
            // lbl_lastIn
            // 
            this.lbl_lastIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lastIn.AutoSize = true;
            this.lbl_lastIn.Location = new System.Drawing.Point(49, 20);
            this.lbl_lastIn.Name = "lbl_lastIn";
            this.lbl_lastIn.Size = new System.Drawing.Size(41, 15);
            this.lbl_lastIn.TabIndex = 0;
            this.lbl_lastIn.Text = "Last in";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.rBtn_3);
            this.panel3.Controls.Add(this.rBtn_2);
            this.panel3.Controls.Add(this.rBtn_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(406, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 55);
            this.panel3.TabIndex = 2;
            // 
            // rBtn_3
            // 
            this.rBtn_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtn_3.AutoSize = true;
            this.rBtn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_3.Location = new System.Drawing.Point(89, 21);
            this.rBtn_3.Name = "rBtn_3";
            this.rBtn_3.Size = new System.Drawing.Size(14, 13);
            this.rBtn_3.TabIndex = 0;
            this.rBtn_3.UseVisualStyleBackColor = true;
            // 
            // rBtn_2
            // 
            this.rBtn_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtn_2.AutoSize = true;
            this.rBtn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_2.Location = new System.Drawing.Point(69, 21);
            this.rBtn_2.Name = "rBtn_2";
            this.rBtn_2.Size = new System.Drawing.Size(14, 13);
            this.rBtn_2.TabIndex = 0;
            this.rBtn_2.UseVisualStyleBackColor = true;
            // 
            // rBtn_1
            // 
            this.rBtn_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtn_1.AutoSize = true;
            this.rBtn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_1.Location = new System.Drawing.Point(49, 21);
            this.rBtn_1.Name = "rBtn_1";
            this.rBtn_1.Size = new System.Drawing.Size(14, 13);
            this.rBtn_1.TabIndex = 0;
            this.rBtn_1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.cBox_lab);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(558, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 55);
            this.panel4.TabIndex = 3;
            // 
            // cBox_lab
            // 
            this.cBox_lab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_lab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_lab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_lab.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBox_lab.FormattingEnabled = true;
            this.cBox_lab.Items.AddRange(new object[] {
            "     -",
            "     1",
            "     2",
            "     3",
            "     4",
            "     5",
            "     6",
            "     7",
            "     8",
            "     9",
            "    10",
            "    11",
            "    12"});
            this.cBox_lab.Location = new System.Drawing.Point(35, 15);
            this.cBox_lab.Name = "cBox_lab";
            this.cBox_lab.Size = new System.Drawing.Size(57, 25);
            this.cBox_lab.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.cBox_class);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(685, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 55);
            this.panel5.TabIndex = 4;
            // 
            // cBox_class
            // 
            this.cBox_class.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBox_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_class.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBox_class.FormattingEnabled = true;
            this.cBox_class.Items.AddRange(new object[] {
            "     -",
            "     1",
            "     2",
            "     3",
            "     4",
            "     5",
            "     6",
            "     7",
            "     8",
            "     9",
            "    10",
            "    11",
            "    12"});
            this.cBox_class.Location = new System.Drawing.Point(35, 15);
            this.cBox_class.Name = "cBox_class";
            this.cBox_class.Size = new System.Drawing.Size(57, 25);
            this.cBox_class.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btn_clear);
            this.panel6.Controls.Add(this.btn_diamond_3);
            this.panel6.Controls.Add(this.btn_diamond_2);
            this.panel6.Controls.Add(this.btn_diamond_1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(812, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(140, 55);
            this.panel6.TabIndex = 5;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Location = new System.Drawing.Point(90, 16);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(23, 23);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_diamond_3
            // 
            this.btn_diamond_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_diamond_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_diamond_3.Location = new System.Drawing.Point(69, 16);
            this.btn_diamond_3.Name = "btn_diamond_3";
            this.btn_diamond_3.Size = new System.Drawing.Size(23, 23);
            this.btn_diamond_3.TabIndex = 0;
            this.btn_diamond_3.Text = "D";
            this.btn_diamond_3.UseVisualStyleBackColor = true;
            // 
            // btn_diamond_2
            // 
            this.btn_diamond_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_diamond_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_diamond_2.Location = new System.Drawing.Point(48, 16);
            this.btn_diamond_2.Name = "btn_diamond_2";
            this.btn_diamond_2.Size = new System.Drawing.Size(23, 23);
            this.btn_diamond_2.TabIndex = 0;
            this.btn_diamond_2.Text = "D";
            this.btn_diamond_2.UseVisualStyleBackColor = true;
            // 
            // btn_diamond_1
            // 
            this.btn_diamond_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_diamond_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_diamond_1.Location = new System.Drawing.Point(27, 16);
            this.btn_diamond_1.Name = "btn_diamond_1";
            this.btn_diamond_1.Size = new System.Drawing.Size(23, 23);
            this.btn_diamond_1.TabIndex = 0;
            this.btn_diamond_1.Text = "D";
            this.btn_diamond_1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.btn_comment);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(952, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 55);
            this.panel7.TabIndex = 6;
            // 
            // btn_comment
            // 
            this.btn_comment.AutoSize = true;
            this.btn_comment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comment.Location = new System.Drawing.Point(15, 15);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(71, 25);
            this.btn_comment.TabIndex = 0;
            this.btn_comment.Text = "Comment";
            this.btn_comment.UseVisualStyleBackColor = true;
            // 
            // lbl_border_bottom
            // 
            this.lbl_border_bottom.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_border_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_border_bottom.Location = new System.Drawing.Point(0, 54);
            this.lbl_border_bottom.Name = "lbl_border_bottom";
            this.lbl_border_bottom.Size = new System.Drawing.Size(1183, 1);
            this.lbl_border_bottom.TabIndex = 1;
            // 
            // UC_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_border_bottom);
            this.Controls.Add(this.tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(900, 0);
            this.Name = "UC_Student";
            this.Size = new System.Drawing.Size(1183, 55);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_profile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label lbl_border_bottom;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pBox_profile;
        private Label lbl_fullname;
        private Label lbl_no;
        private Label lbl_lastIn;
        private RadioButton rBtn_3;
        private RadioButton rBtn_2;
        private RadioButton rBtn_1;
        private ComboBox cBox_lab;
        private ComboBox cBox_class;
        private Button btn_clear;
        private Button btn_diamond_3;
        private Button btn_diamond_2;
        private Button btn_diamond_1;
        private Button btn_comment;
    }
}
