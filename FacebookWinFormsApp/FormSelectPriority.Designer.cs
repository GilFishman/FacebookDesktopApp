using System.Windows.Forms;
namespace DesktopFacebookUI
{
    partial class FormSelectPriority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectPriority));
            this.m_RadioButtonPriority1 = new System.Windows.Forms.RadioButton();
            this.m_RadioButtonPriority2 = new System.Windows.Forms.RadioButton();
            this.m_RadioButtonPriority3 = new System.Windows.Forms.RadioButton();
            this.m_labelSelect = new System.Windows.Forms.Label();
            this.m_buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_RadioButtonPriority1
            // 
            this.m_RadioButtonPriority1.Location = new System.Drawing.Point(12, 55);
            this.m_RadioButtonPriority1.Name = "m_RadioButtonPriority1";
            this.m_RadioButtonPriority1.Size = new System.Drawing.Size(191, 35);
            this.m_RadioButtonPriority1.TabIndex = 0;
            this.m_RadioButtonPriority1.Text = "Priority1";
            this.m_RadioButtonPriority1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // m_RadioButtonPriority2
            // 
            this.m_RadioButtonPriority2.Location = new System.Drawing.Point(12, 96);
            this.m_RadioButtonPriority2.Name = "m_RadioButtonPriority2";
            this.m_RadioButtonPriority2.Size = new System.Drawing.Size(176, 35);
            this.m_RadioButtonPriority2.TabIndex = 1;
            this.m_RadioButtonPriority2.Text = "Priority2";
            // 
            // m_RadioButtonPriority3
            // 
            this.m_RadioButtonPriority3.Location = new System.Drawing.Point(12, 137);
            this.m_RadioButtonPriority3.Name = "m_RadioButtonPriority3";
            this.m_RadioButtonPriority3.Size = new System.Drawing.Size(160, 28);
            this.m_RadioButtonPriority3.TabIndex = 2;
            this.m_RadioButtonPriority3.Text = "Priority3";
            // 
            // m_labelSelect
            // 
            this.m_labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_labelSelect.Location = new System.Drawing.Point(74, 9);
            this.m_labelSelect.Name = "m_labelSelect";
            this.m_labelSelect.Size = new System.Drawing.Size(200, 29);
            this.m_labelSelect.TabIndex = 3;
            this.m_labelSelect.Text = "Please select priority:";
            // 
            // m_buttonOK
            // 
            this.m_buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_buttonOK.Location = new System.Drawing.Point(345, 173);
            this.m_buttonOK.Name = "m_buttonOK";
            this.m_buttonOK.Size = new System.Drawing.Size(70, 35);
            this.m_buttonOK.TabIndex = 4;
            this.m_buttonOK.Text = "OK";
            this.m_buttonOK.Click += new System.EventHandler(this.m_buttonOK_Click);
            // 
            // FormSelectPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 220);
            this.Controls.Add(this.m_RadioButtonPriority1);
            this.Controls.Add(this.m_RadioButtonPriority2);
            this.Controls.Add(this.m_RadioButtonPriority3);
            this.Controls.Add(this.m_labelSelect);
            this.Controls.Add(this.m_buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelectPriority";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectPriority";
            this.ResumeLayout(false);

        }
        #endregion
        private RadioButton m_RadioButtonPriority1;
        private RadioButton m_RadioButtonPriority2;
        private RadioButton m_RadioButtonPriority3;
        private Label m_labelSelect;
        private Button m_buttonOK;
    }
}