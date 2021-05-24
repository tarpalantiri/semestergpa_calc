
namespace SGPA_Calc {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.APGrade = new System.Windows.Forms.ComboBox();
            this.CALCGrade = new System.Windows.Forms.ComboBox();
            this.ENGGrade = new System.Windows.Forms.ComboBox();
            this.COMPGrade = new System.Windows.Forms.ComboBox();
            this.PROGGrade = new System.Windows.Forms.ComboBox();
            this.ISLGrade = new System.Windows.Forms.ComboBox();
            this.COMPLABGrade = new System.Windows.Forms.ComboBox();
            this.PROGLABGrade = new System.Windows.Forms.ComboBox();
            this.APLABGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // APGrade
            // 
            this.APGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.APGrade.Location = new System.Drawing.Point(216, 17);
            this.APGrade.Name = "APGrade";
            this.APGrade.Size = new System.Drawing.Size(56, 21);
            this.APGrade.TabIndex = 0;
            this.APGrade.SelectedValueChanged += new System.EventHandler(this.APGrade_SelectionChanged);
            // 
            // CALCGrade
            // 
            this.CALCGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CALCGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CALCGrade.Location = new System.Drawing.Point(216, 44);
            this.CALCGrade.Name = "CALCGrade";
            this.CALCGrade.Size = new System.Drawing.Size(56, 21);
            this.CALCGrade.TabIndex = 1;
            this.CALCGrade.SelectedValueChanged += new System.EventHandler(this.CALCGrade_SelectedValueChanged);
            // 
            // ENGGrade
            // 
            this.ENGGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ENGGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ENGGrade.Location = new System.Drawing.Point(216, 71);
            this.ENGGrade.Name = "ENGGrade";
            this.ENGGrade.Size = new System.Drawing.Size(56, 21);
            this.ENGGrade.TabIndex = 2;
            this.ENGGrade.SelectedValueChanged += new System.EventHandler(this.ENGGrade_SelectedValueChanged);
            // 
            // COMPGrade
            // 
            this.COMPGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.COMPGrade.Location = new System.Drawing.Point(216, 98);
            this.COMPGrade.Name = "COMPGrade";
            this.COMPGrade.Size = new System.Drawing.Size(56, 21);
            this.COMPGrade.TabIndex = 3;
            this.COMPGrade.SelectedValueChanged += new System.EventHandler(this.COMPGrade_SelectedValueChanged);
            // 
            // PROGGrade
            // 
            this.PROGGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PROGGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PROGGrade.Location = new System.Drawing.Point(216, 125);
            this.PROGGrade.Name = "PROGGrade";
            this.PROGGrade.Size = new System.Drawing.Size(56, 21);
            this.PROGGrade.TabIndex = 4;
            this.PROGGrade.SelectedValueChanged += new System.EventHandler(this.PROGGrade_SelectedValueChanged);
            // 
            // ISLGrade
            // 
            this.ISLGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISLGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ISLGrade.Location = new System.Drawing.Point(216, 152);
            this.ISLGrade.Name = "ISLGrade";
            this.ISLGrade.Size = new System.Drawing.Size(56, 21);
            this.ISLGrade.TabIndex = 5;
            this.ISLGrade.SelectedValueChanged += new System.EventHandler(this.ISLGrade_SelectedValueChanged);
            // 
            // COMPLABGrade
            // 
            this.COMPLABGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPLABGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.COMPLABGrade.Location = new System.Drawing.Point(216, 179);
            this.COMPLABGrade.Name = "COMPLABGrade";
            this.COMPLABGrade.Size = new System.Drawing.Size(56, 21);
            this.COMPLABGrade.TabIndex = 6;
            this.COMPLABGrade.SelectedValueChanged += new System.EventHandler(this.COMPLABGrade_SelectedValueChanged);
            // 
            // PROGLABGrade
            // 
            this.PROGLABGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PROGLABGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PROGLABGrade.Location = new System.Drawing.Point(216, 206);
            this.PROGLABGrade.Name = "PROGLABGrade";
            this.PROGLABGrade.Size = new System.Drawing.Size(56, 21);
            this.PROGLABGrade.TabIndex = 7;
            this.PROGLABGrade.SelectedValueChanged += new System.EventHandler(this.PROGLABGrade_SelectedValueChanged);
            // 
            // APLABGrade
            // 
            this.APLABGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APLABGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.APLABGrade.Location = new System.Drawing.Point(216, 233);
            this.APLABGrade.Name = "APLABGrade";
            this.APLABGrade.Size = new System.Drawing.Size(56, 21);
            this.APLABGrade.TabIndex = 8;
            this.APLABGrade.SelectedValueChanged += new System.EventHandler(this.APLABGrade_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Applied Physics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Calculus-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "English-1 (Comprehension)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Intro to Computing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Intro to Computer Programming";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Islamic Studies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Intro to Computing LAB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Intro to Compturer Programming LAB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Applied Physics LAB";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(35, 281);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(172, 34);
            this.CalculateButton.TabIndex = 18;
            this.CalculateButton.Text = "Calculate SGPA";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.PaleGreen;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(216, 281);
            this.ResultBox.Multiline = false;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ResultBox.Size = new System.Drawing.Size(51, 34);
            this.ResultBox.TabIndex = 19;
            this.ResultBox.Text = "0.0";
            this.ResultBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 342);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APLABGrade);
            this.Controls.Add(this.PROGLABGrade);
            this.Controls.Add(this.COMPLABGrade);
            this.Controls.Add(this.ISLGrade);
            this.Controls.Add(this.PROGGrade);
            this.Controls.Add(this.COMPGrade);
            this.Controls.Add(this.ENGGrade);
            this.Controls.Add(this.CALCGrade);
            this.Controls.Add(this.APGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SGPA Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox APGrade;
        private System.Windows.Forms.ComboBox CALCGrade;
        private System.Windows.Forms.ComboBox ENGGrade;
        private System.Windows.Forms.ComboBox COMPGrade;
        private System.Windows.Forms.ComboBox PROGGrade;
        private System.Windows.Forms.ComboBox ISLGrade;
        private System.Windows.Forms.ComboBox COMPLABGrade;
        private System.Windows.Forms.ComboBox PROGLABGrade;
        private System.Windows.Forms.ComboBox APLABGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.RichTextBox ResultBox;
    }
}

