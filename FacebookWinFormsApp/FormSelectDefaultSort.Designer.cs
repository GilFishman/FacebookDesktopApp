using System.Windows.Forms;
namespace DesktopFacebookUI
{
    partial class FormSelectDefaultSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectDefaultSort));
            this.m_RadioButtonNeedToComment = new System.Windows.Forms.RadioButton();
            this.m_RadioButtonNeedToLike = new System.Windows.Forms.RadioButton();
            this.m_RadioButtonSendToFriend = new System.Windows.Forms.RadioButton();
            this.m_labelSelect = new System.Windows.Forms.Label();
            this.m_buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_RadioButtonNeedToComment
            // 
            this.m_RadioButtonNeedToComment.Location = new System.Drawing.Point(12, 55);
            this.m_RadioButtonNeedToComment.Name = "m_RadioButtonNeedToComment";
            this.m_RadioButtonNeedToComment.Size = new System.Drawing.Size(191, 35);
            this.m_RadioButtonNeedToComment.TabIndex = 0;
            this.m_RadioButtonNeedToComment.Text = "Need To Comment";
            this.m_RadioButtonNeedToComment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // m_RadioButtonNeedToLike
            // 
            this.m_RadioButtonNeedToLike.Location = new System.Drawing.Point(12, 96);
            this.m_RadioButtonNeedToLike.Name = "m_RadioButtonNeedToLike";
            this.m_RadioButtonNeedToLike.Size = new System.Drawing.Size(176, 35);
            this.m_RadioButtonNeedToLike.TabIndex = 1;
            this.m_RadioButtonNeedToLike.Text = "Need To Like";
            // 
            // m_RadioButtonSendToFriend
            // 
            this.m_RadioButtonSendToFriend.Location = new System.Drawing.Point(12, 137);
            this.m_RadioButtonSendToFriend.Name = "m_RadioButtonSendToFriend";
            this.m_RadioButtonSendToFriend.Size = new System.Drawing.Size(210, 33);
            this.m_RadioButtonSendToFriend.TabIndex = 2;
            this.m_RadioButtonSendToFriend.Text = "Send To A Friend";
            // 
            // m_labelSelect
            // 
            this.m_labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_labelSelect.Location = new System.Drawing.Point(74, 9);
            this.m_labelSelect.Name = "m_labelSelect";
            this.m_labelSelect.Size = new System.Drawing.Size(239, 43);
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
            // FormSelectDefaultSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 219);
            this.Controls.Add(this.m_RadioButtonNeedToComment);
            this.Controls.Add(this.m_RadioButtonNeedToLike);
            this.Controls.Add(this.m_RadioButtonSendToFriend);
            this.Controls.Add(this.m_labelSelect);
            this.Controls.Add(this.m_buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelectDefaultSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectDefaultSort";
            this.ResumeLayout(false);

        }
        #endregion
        private RadioButton m_RadioButtonNeedToComment;
        private RadioButton m_RadioButtonNeedToLike;
        private RadioButton m_RadioButtonSendToFriend;
        private Label m_labelSelect;
        private Button m_buttonOK;
    }
}