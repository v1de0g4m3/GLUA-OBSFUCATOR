namespace glua_obsfucator
{
    partial class main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            this.not_ob_text = new System.Windows.Forms.RichTextBox();
            this.ob_text = new System.Windows.Forms.RichTextBox();
            this.obsfucate_lua = new System.Windows.Forms.Button();
            this.obsfucation_status = new System.Windows.Forms.ListBox();
            this.obs_striplines = new System.Windows.Forms.CheckBox();
            this.obs_variables = new System.Windows.Forms.CheckBox();
            this.obs_strings = new System.Windows.Forms.CheckBox();
            this.obs_hexfunctions = new System.Windows.Forms.CheckBox();
            this.about = new System.Windows.Forms.Button();
            this.obs_spacecode = new System.Windows.Forms.CheckBox();
            this.obs_removecomments = new System.Windows.Forms.CheckBox();
            this.obs_commentspam = new System.Windows.Forms.CheckBox();
            this.obs_lowratio = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // not_ob_text
            // 
            this.not_ob_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.not_ob_text.Location = new System.Drawing.Point(0, 0);
            this.not_ob_text.Name = "not_ob_text";
            this.not_ob_text.Size = new System.Drawing.Size(507, 150);
            this.not_ob_text.TabIndex = 0;
            this.not_ob_text.Text = "Enter Lua Here";
            // 
            // ob_text
            // 
            this.ob_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.ob_text.Location = new System.Drawing.Point(0, 150);
            this.ob_text.Name = "ob_text";
            this.ob_text.ReadOnly = true;
            this.ob_text.Size = new System.Drawing.Size(507, 150);
            this.ob_text.TabIndex = 1;
            this.ob_text.Text = "";
            // 
            // obsfucate_lua
            // 
            this.obsfucate_lua.Dock = System.Windows.Forms.DockStyle.Top;
            this.obsfucate_lua.Location = new System.Drawing.Point(0, 300);
            this.obsfucate_lua.Name = "obsfucate_lua";
            this.obsfucate_lua.Size = new System.Drawing.Size(507, 27);
            this.obsfucate_lua.TabIndex = 2;
            this.obsfucate_lua.Text = "Obsfucate LUA";
            this.obsfucate_lua.UseVisualStyleBackColor = true;
            this.obsfucate_lua.Click += new System.EventHandler(this.obsfucate_lua_Click);
            // 
            // obsfucation_status
            // 
            this.obsfucation_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.obsfucation_status.FormattingEnabled = true;
            this.obsfucation_status.Location = new System.Drawing.Point(0, 472);
            this.obsfucation_status.Name = "obsfucation_status";
            this.obsfucation_status.Size = new System.Drawing.Size(507, 160);
            this.obsfucation_status.TabIndex = 3;
            // 
            // obs_striplines
            // 
            this.obs_striplines.AutoSize = true;
            this.obs_striplines.Location = new System.Drawing.Point(6, 19);
            this.obs_striplines.Name = "obs_striplines";
            this.obs_striplines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.obs_striplines.Size = new System.Drawing.Size(97, 17);
            this.obs_striplines.TabIndex = 4;
            this.obs_striplines.Text = "Strip NewLines";
            this.obs_striplines.UseVisualStyleBackColor = true;
            // 
            // obs_variables
            // 
            this.obs_variables.AutoSize = true;
            this.obs_variables.Location = new System.Drawing.Point(214, 65);
            this.obs_variables.Name = "obs_variables";
            this.obs_variables.Size = new System.Drawing.Size(121, 17);
            this.obs_variables.TabIndex = 6;
            this.obs_variables.Text = "Obsfucate Variables";
            this.obs_variables.UseVisualStyleBackColor = true;
            // 
            // obs_strings
            // 
            this.obs_strings.AutoSize = true;
            this.obs_strings.Location = new System.Drawing.Point(214, 19);
            this.obs_strings.Name = "obs_strings";
            this.obs_strings.Size = new System.Drawing.Size(98, 17);
            this.obs_strings.TabIndex = 8;
            this.obs_strings.Text = "Encode Strings";
            this.obs_strings.UseVisualStyleBackColor = true;
            // 
            // obs_hexfunctions
            // 
            this.obs_hexfunctions.AutoSize = true;
            this.obs_hexfunctions.Location = new System.Drawing.Point(214, 42);
            this.obs_hexfunctions.Name = "obs_hexfunctions";
            this.obs_hexfunctions.Size = new System.Drawing.Size(144, 17);
            this.obs_hexfunctions.TabIndex = 9;
            this.obs_hexfunctions.Text = "Obsfucate Funcs/Strings";
            this.obs_hexfunctions.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Dock = System.Windows.Forms.DockStyle.Top;
            this.about.Location = new System.Drawing.Point(0, 327);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(507, 27);
            this.about.TabIndex = 10;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // obs_spacecode
            // 
            this.obs_spacecode.AutoSize = true;
            this.obs_spacecode.Location = new System.Drawing.Point(109, 19);
            this.obs_spacecode.Name = "obs_spacecode";
            this.obs_spacecode.Size = new System.Drawing.Size(85, 17);
            this.obs_spacecode.TabIndex = 11;
            this.obs_spacecode.Text = "Space Code";
            this.obs_spacecode.UseVisualStyleBackColor = true;
            this.obs_spacecode.CheckedChanged += new System.EventHandler(this.obs_spacecode_CheckedChanged);
            // 
            // obs_removecomments
            // 
            this.obs_removecomments.AutoSize = true;
            this.obs_removecomments.Location = new System.Drawing.Point(6, 42);
            this.obs_removecomments.Name = "obs_removecomments";
            this.obs_removecomments.Size = new System.Drawing.Size(99, 17);
            this.obs_removecomments.TabIndex = 12;
            this.obs_removecomments.Text = "Strip Comments";
            this.obs_removecomments.UseVisualStyleBackColor = true;
            // 
            // obs_commentspam
            // 
            this.obs_commentspam.AutoSize = true;
            this.obs_commentspam.Location = new System.Drawing.Point(6, 65);
            this.obs_commentspam.Name = "obs_commentspam";
            this.obs_commentspam.Size = new System.Drawing.Size(100, 17);
            this.obs_commentspam.TabIndex = 13;
            this.obs_commentspam.Text = "Comment Spam";
            this.obs_commentspam.UseVisualStyleBackColor = true;
            // 
            // obs_lowratio
            // 
            this.obs_lowratio.AutoSize = true;
            this.obs_lowratio.Location = new System.Drawing.Point(109, 42);
            this.obs_lowratio.Name = "obs_lowratio";
            this.obs_lowratio.Size = new System.Drawing.Size(99, 17);
            this.obs_lowratio.TabIndex = 14;
            this.obs_lowratio.Text = "Low OBS Ratio";
            this.obs_lowratio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obs_striplines);
            this.groupBox1.Controls.Add(this.obs_lowratio);
            this.groupBox1.Controls.Add(this.obs_removecomments);
            this.groupBox1.Controls.Add(this.obs_spacecode);
            this.groupBox1.Controls.Add(this.obs_strings);
            this.groupBox1.Controls.Add(this.obs_hexfunctions);
            this.groupBox1.Controls.Add(this.obs_commentspam);
            this.groupBox1.Controls.Add(this.obs_variables);
            this.groupBox1.Location = new System.Drawing.Point(12, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 106);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obsfucation Settings";
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.about);
            this.Controls.Add(this.obsfucation_status);
            this.Controls.Add(this.obsfucate_lua);
            this.Controls.Add(this.ob_text);
            this.Controls.Add(this.not_ob_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_window";
            this.Text = "GLua-Obsfucator";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox not_ob_text;
        private System.Windows.Forms.RichTextBox ob_text;
        private System.Windows.Forms.Button obsfucate_lua;
        private System.Windows.Forms.ListBox obsfucation_status;
        private System.Windows.Forms.CheckBox obs_striplines;
        private System.Windows.Forms.CheckBox obs_variables;
        private System.Windows.Forms.CheckBox obs_strings;
        private System.Windows.Forms.CheckBox obs_hexfunctions;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.CheckBox obs_spacecode;
        private System.Windows.Forms.CheckBox obs_removecomments;
        private System.Windows.Forms.CheckBox obs_commentspam;
        private System.Windows.Forms.CheckBox obs_lowratio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

