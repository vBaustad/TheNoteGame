namespace TheNoteGame
{
    partial class BaseProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseProgram));
            this.addNoteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxNote_desc = new System.Windows.Forms.RichTextBox();
            this.addNoteGroup = new System.Windows.Forms.GroupBox();
            this.set_combobox_names = new System.Windows.Forms.ComboBox();
            this.grabNoteGroup = new System.Windows.Forms.GroupBox();
            this.textbox_number_input = new System.Windows.Forms.TextBox();
            this.getNoteButton = new System.Windows.Forms.Button();
            this.get_combobox_names = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeOwnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteGroup.SuspendLayout();
            this.grabNoteGroup.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(267, 192);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(120, 23);
            this.addNoteButton.TabIndex = 4;
            this.addNoteButton.Text = "Add your note";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose the owner of the note: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter the command:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textboxNote_desc
            // 
            this.textboxNote_desc.Location = new System.Drawing.Point(9, 76);
            this.textboxNote_desc.Name = "textboxNote_desc";
            this.textboxNote_desc.Size = new System.Drawing.Size(379, 110);
            this.textboxNote_desc.TabIndex = 11;
            this.textboxNote_desc.Text = "";
            this.textboxNote_desc.TextChanged += new System.EventHandler(this.textboxNote_desc_TextChanged);
            // 
            // addNoteGroup
            // 
            this.addNoteGroup.Controls.Add(this.set_combobox_names);
            this.addNoteGroup.Controls.Add(this.addNoteButton);
            this.addNoteGroup.Controls.Add(this.textboxNote_desc);
            this.addNoteGroup.Controls.Add(this.label2);
            this.addNoteGroup.Controls.Add(this.label3);
            this.addNoteGroup.Location = new System.Drawing.Point(12, 28);
            this.addNoteGroup.Name = "addNoteGroup";
            this.addNoteGroup.Size = new System.Drawing.Size(405, 237);
            this.addNoteGroup.TabIndex = 12;
            this.addNoteGroup.TabStop = false;
            this.addNoteGroup.Text = "Add a note";
            // 
            // set_combobox_names
            // 
            this.set_combobox_names.FormattingEnabled = true;
            this.set_combobox_names.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.set_combobox_names.Location = new System.Drawing.Point(267, 22);
            this.set_combobox_names.Name = "set_combobox_names";
            this.set_combobox_names.Size = new System.Drawing.Size(121, 21);
            this.set_combobox_names.TabIndex = 12;
            this.set_combobox_names.SelectedIndexChanged += new System.EventHandler(this.onSelectedIndexChanged);
            // 
            // grabNoteGroup
            // 
            this.grabNoteGroup.Controls.Add(this.textbox_number_input);
            this.grabNoteGroup.Controls.Add(this.getNoteButton);
            this.grabNoteGroup.Controls.Add(this.get_combobox_names);
            this.grabNoteGroup.Controls.Add(this.label5);
            this.grabNoteGroup.Controls.Add(this.label4);
            this.grabNoteGroup.Location = new System.Drawing.Point(12, 271);
            this.grabNoteGroup.Name = "grabNoteGroup";
            this.grabNoteGroup.Size = new System.Drawing.Size(405, 97);
            this.grabNoteGroup.TabIndex = 13;
            this.grabNoteGroup.TabStop = false;
            this.grabNoteGroup.Text = "Grab a note";
            // 
            // textbox_number_input
            // 
            this.textbox_number_input.Location = new System.Drawing.Point(267, 16);
            this.textbox_number_input.Name = "textbox_number_input";
            this.textbox_number_input.Size = new System.Drawing.Size(121, 20);
            this.textbox_number_input.TabIndex = 12;
            // 
            // getNoteButton
            // 
            this.getNoteButton.Location = new System.Drawing.Point(267, 69);
            this.getNoteButton.Name = "getNoteButton";
            this.getNoteButton.Size = new System.Drawing.Size(121, 23);
            this.getNoteButton.TabIndex = 11;
            this.getNoteButton.Text = "Get your command";
            this.getNoteButton.UseVisualStyleBackColor = true;
            this.getNoteButton.Click += new System.EventHandler(this.getNote_button_click);
            // 
            // get_combobox_names
            // 
            this.get_combobox_names.FormattingEnabled = true;
            this.get_combobox_names.Location = new System.Drawing.Point(267, 42);
            this.get_combobox_names.Name = "get_combobox_names";
            this.get_combobox_names.Size = new System.Drawing.Size(121, 21);
            this.get_combobox_names.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Who made the note?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type inn your number:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(429, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Settings";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOwnerToolStripMenuItem,
            this.removeOwnersToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem1.Text = "Manage owners";
            // 
            // addOwnerToolStripMenuItem
            // 
            this.addOwnerToolStripMenuItem.Name = "addOwnerToolStripMenuItem";
            this.addOwnerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addOwnerToolStripMenuItem.Text = "Add owners";
            this.addOwnerToolStripMenuItem.Click += new System.EventHandler(this.addOwners);
            // 
            // removeOwnersToolStripMenuItem
            // 
            this.removeOwnersToolStripMenuItem.Name = "removeOwnersToolStripMenuItem";
            this.removeOwnersToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.removeOwnersToolStripMenuItem.Text = "Remove owners";
            this.removeOwnersToolStripMenuItem.Click += new System.EventHandler(this.removeOwners);
            // 
            // BaseProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 380);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grabNoteGroup);
            this.Controls.Add(this.addNoteGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BaseProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Note Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addNoteGroup.ResumeLayout(false);
            this.addNoteGroup.PerformLayout();
            this.grabNoteGroup.ResumeLayout(false);
            this.grabNoteGroup.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textboxNote_desc;
        private System.Windows.Forms.GroupBox addNoteGroup;
        private System.Windows.Forms.GroupBox grabNoteGroup;
        private System.Windows.Forms.Button getNoteButton;
        private System.Windows.Forms.ComboBox get_combobox_names;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addOwnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeOwnersToolStripMenuItem;
        private System.Windows.Forms.ComboBox set_combobox_names;
        private System.Windows.Forms.TextBox textbox_number_input;
    }
}

