﻿namespace EventApp
{
    partial class UserControlCreateEvent
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
            this.category_box = new System.Windows.Forms.ComboBox();
            this.loadimage_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.preview_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.location_txt = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // category_box
            // 
            this.category_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.category_box.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.category_box.ForeColor = System.Drawing.Color.Gray;
            this.category_box.FormattingEnabled = true;
            this.category_box.Items.AddRange(new object[] {
            "Anything",
            "All Events",
            "Concerts",
            "Comedy",
            "Education",
            "Festival",
            "Food",
            "Galleries",
            "Health",
            "Holiday",
            "Movies",
            "Museums",
            "Networking",
            "Politics",
            "Technology",
            "Other"});
            this.category_box.Location = new System.Drawing.Point(135, 206);
            this.category_box.Margin = new System.Windows.Forms.Padding(2);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(356, 29);
            this.category_box.TabIndex = 37;
            this.category_box.Text = "Categories";
            // 
            // loadimage_btn
            // 
            this.loadimage_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadimage_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(122)))));
            this.loadimage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadimage_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.loadimage_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadimage_btn.Location = new System.Drawing.Point(717, 459);
            this.loadimage_btn.Margin = new System.Windows.Forms.Padding(2);
            this.loadimage_btn.Name = "loadimage_btn";
            this.loadimage_btn.Size = new System.Drawing.Size(130, 42);
            this.loadimage_btn.TabIndex = 34;
            this.loadimage_btn.Text = "Load Image";
            this.loadimage_btn.UseVisualStyleBackColor = false;
            this.loadimage_btn.Click += new System.EventHandler(this.loadimage_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel3.Location = new System.Drawing.Point(601, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 2);
            this.panel3.TabIndex = 35;
            // 
            // preview_btn
            // 
            this.preview_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preview_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(122)))));
            this.preview_btn.FlatAppearance.BorderSize = 0;
            this.preview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preview_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.preview_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.preview_btn.Location = new System.Drawing.Point(601, 547);
            this.preview_btn.Margin = new System.Windows.Forms.Padding(2);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(127, 43);
            this.preview_btn.TabIndex = 29;
            this.preview_btn.Text = "Preview";
            this.preview_btn.UseVisualStyleBackColor = false;
            this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(806, 547);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(156, 43);
            this.save_btn.TabIndex = 30;
            this.save_btn.Text = "Save/Continue";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel2.Location = new System.Drawing.Point(135, 487);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 2);
            this.panel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(135, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 2);
            this.panel1.TabIndex = 31;
            // 
            // location_txt
            // 
            this.location_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.location_txt.AutoCompleteCustomSource.AddRange(new string[] {
            "Thessaloniki",
            "Athens",
            "Patra",
            "Larisa",
            "Ioannina",
            "Volos",
            "Herakleion",
            "Kavala",
            "Giannena",
            "Aleksandroupoli"});
            this.location_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.location_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.location_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.location_txt.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.location_txt.ForeColor = System.Drawing.Color.Gray;
            this.location_txt.Location = new System.Drawing.Point(135, 506);
            this.location_txt.Margin = new System.Windows.Forms.Padding(2);
            this.location_txt.Name = "location_txt";
            this.location_txt.Size = new System.Drawing.Size(355, 23);
            this.location_txt.TabIndex = 27;
            this.location_txt.Text = "Search for location";
            this.location_txt.Click += new System.EventHandler(this.location_txt_Click);
            // 
            // description_txt
            // 
            this.description_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description_txt.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.description_txt.ForeColor = System.Drawing.Color.Gray;
            this.description_txt.Location = new System.Drawing.Point(135, 259);
            this.description_txt.Margin = new System.Windows.Forms.Padding(2);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(355, 124);
            this.description_txt.TabIndex = 22;
            this.description_txt.Text = "Add Description...";
            this.description_txt.Click += new System.EventHandler(this.description_txt_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(128, 442);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 46);
            this.label2.TabIndex = 26;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(593, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 46);
            this.label3.TabIndex = 25;
            this.label3.Text = "Date and Time";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(128, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Basic info";
            // 
            // title_txt
            // 
            this.title_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_txt.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.title_txt.ForeColor = System.Drawing.Color.Gray;
            this.title_txt.Location = new System.Drawing.Point(135, 132);
            this.title_txt.Margin = new System.Windows.Forms.Padding(2);
            this.title_txt.Multiline = true;
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(355, 24);
            this.title_txt.TabIndex = 24;
            this.title_txt.Text = "Event Title";
            this.title_txt.Click += new System.EventHandler(this.title_txt_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(601, 132);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker.TabIndex = 36;
            this.dateTimePicker.Value = new System.DateTime(2019, 12, 3, 0, 0, 0, 0);
            // 
            // time_txt
            // 
            this.time_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_txt.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.time_txt.ForeColor = System.Drawing.Color.Gray;
            this.time_txt.Location = new System.Drawing.Point(601, 174);
            this.time_txt.Margin = new System.Windows.Forms.Padding(2);
            this.time_txt.Multiline = true;
            this.time_txt.Name = "time_txt";
            this.time_txt.Size = new System.Drawing.Size(355, 24);
            this.time_txt.TabIndex = 28;
            this.time_txt.Text = "Time";
            this.time_txt.Click += new System.EventHandler(this.time_txt_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 601);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 38;
            // 
            // picBox
            // 
            this.picBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(601, 217);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(355, 221);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 39;
            this.picBox.TabStop = false;
            // 
            // UserControlCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.loadimage_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.preview_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.location_txt);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.time_txt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlCreateEvent";
            this.Size = new System.Drawing.Size(1090, 643);
            this.Load += new System.EventHandler(this.UserControlCreateEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.Button loadimage_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button preview_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox location_txt;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox time_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBox;
    }
}