namespace DesktopFacebookUI
{
    partial class FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.pictureBoxPictureProfile = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.lableName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.lableFriends = new System.Windows.Forms.Label();
            this.lableAlbums = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelPics = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBoxPictureCover = new System.Windows.Forms.PictureBox();
            this.listBoxRed = new System.Windows.Forms.ListBox();
            this.labelPostDefualt = new System.Windows.Forms.Label();
            this.listBoxYellow = new System.Windows.Forms.ListBox();
            this.listBoxGreen = new System.Windows.Forms.ListBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxYellow = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxPriority3 = new System.Windows.Forms.TextBox();
            this.textBoxPriority2 = new System.Windows.Forms.TextBox();
            this.textBoxPriority1 = new System.Windows.Forms.TextBox();
            this.listBoxPriority3 = new System.Windows.Forms.ListBox();
            this.listBoxPriority2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPriority1 = new System.Windows.Forms.ListBox();
            this.buttonDisableButtons = new System.Windows.Forms.Button();
            this.buttonenableButtons = new System.Windows.Forms.Button();
            this.buttonLogout = new ButtonObserver();
            this.buttonLinkedin = new ButtonObserver(); 
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPictureProfile
            // 
            this.pictureBoxPictureProfile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBoxPictureProfile.Location = new System.Drawing.Point(12, 206);
            this.pictureBoxPictureProfile.Name = "pictureBoxPictureProfile";
            this.pictureBoxPictureProfile.Size = new System.Drawing.Size(197, 222);
            this.pictureBoxPictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPictureProfile.TabIndex = 2;
            this.pictureBoxPictureProfile.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.Thistle;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(24, 499);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(188, 304);
            this.listBoxFriends.TabIndex = 3;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.Color.Thistle;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(241, 499);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(193, 304);
            this.listBoxAlbums.TabIndex = 4;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.Color.Thistle;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(457, 499);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(188, 304);
            this.listBoxPosts.TabIndex = 52;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Location = new System.Drawing.Point(222, 216);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(55, 20);
            this.lableName.TabIndex = 6;
            this.lableName.Text = "Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(308, 216);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(126, 26);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(308, 312);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.ReadOnly = true;
            this.textBoxBirthday.Size = new System.Drawing.Size(126, 26);
            this.textBoxBirthday.TabIndex = 16;
            // 
            // lableFriends
            // 
            this.lableFriends.AutoSize = true;
            this.lableFriends.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lableFriends.ForeColor = System.Drawing.Color.BlueViolet;
            this.lableFriends.Location = new System.Drawing.Point(39, 456);
            this.lableFriends.Name = "lableFriends";
            this.lableFriends.Size = new System.Drawing.Size(142, 29);
            this.lableFriends.TabIndex = 17;
            this.lableFriends.Text = "My Friends";
            // 
            // lableAlbums
            // 
            this.lableAlbums.AutoSize = true;
            this.lableAlbums.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lableAlbums.ForeColor = System.Drawing.Color.BlueViolet;
            this.lableAlbums.Location = new System.Drawing.Point(265, 456);
            this.lableAlbums.Name = "lableAlbums";
            this.lableAlbums.Size = new System.Drawing.Size(143, 29);
            this.lableAlbums.TabIndex = 18;
            this.lableAlbums.Text = "My Albums";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelPosts.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelPosts.Location = new System.Drawing.Point(493, 456);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(120, 29);
            this.labelPosts.TabIndex = 19;
            this.labelPosts.Text = "My Posts";
            // 
            // labelPics
            // 
            this.labelPics.Location = new System.Drawing.Point(0, 0);
            this.labelPics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPics.Name = "labelPics";
            this.labelPics.Size = new System.Drawing.Size(150, 35);
            this.labelPics.TabIndex = 44;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(219, 315);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(67, 20);
            this.labelBirthday.TabIndex = 15;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelError.Location = new System.Drawing.Point(770, 545);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 29);
            this.labelError.TabIndex = 43;
            // 
            // pictureBoxPictureCover
            // 
            this.pictureBoxPictureCover.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBoxPictureCover.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPictureCover.Name = "pictureBoxPictureCover";
            this.pictureBoxPictureCover.Size = new System.Drawing.Size(1052, 178);
            this.pictureBoxPictureCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPictureCover.TabIndex = 45;
            this.pictureBoxPictureCover.TabStop = false;
            // 
            // listBoxRed
            // 
            this.listBoxRed.BackColor = System.Drawing.Color.Crimson;
            this.listBoxRed.FormattingEnabled = true;
            this.listBoxRed.ItemHeight = 20;
            this.listBoxRed.Location = new System.Drawing.Point(676, 499);
            this.listBoxRed.Name = "listBoxRed";
            this.listBoxRed.Size = new System.Drawing.Size(175, 124);
            this.listBoxRed.TabIndex = 47;
            // 
            // labelPostDefualt
            // 
            this.labelPostDefualt.AutoSize = true;
            this.labelPostDefualt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelPostDefualt.ForeColor = System.Drawing.Color.Black;
            this.labelPostDefualt.Location = new System.Drawing.Point(876, 416);
            this.labelPostDefualt.Name = "labelPostDefualt";
            this.labelPostDefualt.Size = new System.Drawing.Size(208, 29);
            this.labelPostDefualt.TabIndex = 48;
            this.labelPostDefualt.Text = "Posts by Default";
            // 
            // listBoxYellow
            // 
            this.listBoxYellow.BackColor = System.Drawing.Color.Orange;
            this.listBoxYellow.FormattingEnabled = true;
            this.listBoxYellow.ItemHeight = 20;
            this.listBoxYellow.Location = new System.Drawing.Point(873, 499);
            this.listBoxYellow.Name = "listBoxYellow";
            this.listBoxYellow.Size = new System.Drawing.Size(191, 124);
            this.listBoxYellow.TabIndex = 50;
            // 
            // listBoxGreen
            // 
            this.listBoxGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.listBoxGreen.FormattingEnabled = true;
            this.listBoxGreen.ItemHeight = 20;
            this.listBoxGreen.Location = new System.Drawing.Point(1093, 499);
            this.listBoxGreen.Name = "listBoxGreen";
            this.listBoxGreen.Size = new System.Drawing.Size(189, 124);
            this.listBoxGreen.TabIndex = 51;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(688, 465);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(135, 26);
            this.textBoxRed.TabIndex = 53;
            this.textBoxRed.Text = "Need to comment";
            this.textBoxRed.Leave += new System.EventHandler(this.textBoxRed_Leave);
            // 
            // textBoxYellow
            // 
            this.textBoxYellow.Location = new System.Drawing.Point(917, 465);
            this.textBoxYellow.Name = "textBoxYellow";
            this.textBoxYellow.Size = new System.Drawing.Size(92, 26);
            this.textBoxYellow.TabIndex = 54;
            this.textBoxYellow.Text = "Need to like";
            this.textBoxYellow.Leave += new System.EventHandler(this.textBoxYellow_Leave);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(1117, 464);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(122, 26);
            this.textBoxGreen.TabIndex = 55;
            this.textBoxGreen.Text = "Send to friend";
            this.textBoxGreen.Leave += new System.EventHandler(this.textBoxGreen_Leave);
            // 
            // textBoxPriority3
            // 
            this.textBoxPriority3.Location = new System.Drawing.Point(1117, 674);
            this.textBoxPriority3.Name = "textBoxPriority3";
            this.textBoxPriority3.Size = new System.Drawing.Size(122, 26);
            this.textBoxPriority3.TabIndex = 62;
            this.textBoxPriority3.Text = "Prioirty 3";
            // 
            // textBoxPriority2
            // 
            this.textBoxPriority2.Location = new System.Drawing.Point(917, 675);
            this.textBoxPriority2.Name = "textBoxPriority2";
            this.textBoxPriority2.Size = new System.Drawing.Size(92, 26);
            this.textBoxPriority2.TabIndex = 61;
            this.textBoxPriority2.Text = "Priority 2";
            // 
            // textBoxPriority1
            // 
            this.textBoxPriority1.Location = new System.Drawing.Point(688, 675);
            this.textBoxPriority1.Name = "textBoxPriority1";
            this.textBoxPriority1.Size = new System.Drawing.Size(135, 26);
            this.textBoxPriority1.TabIndex = 60;
            this.textBoxPriority1.Text = "Priority 1";
            // 
            // listBoxPriority3
            // 
            this.listBoxPriority3.BackColor = System.Drawing.Color.LimeGreen;
            this.listBoxPriority3.FormattingEnabled = true;
            this.listBoxPriority3.ItemHeight = 20;
            this.listBoxPriority3.Location = new System.Drawing.Point(1093, 709);
            this.listBoxPriority3.Name = "listBoxPriority3";
            this.listBoxPriority3.Size = new System.Drawing.Size(189, 124);
            this.listBoxPriority3.TabIndex = 59;
            // 
            // listBoxPriority2
            // 
            this.listBoxPriority2.BackColor = System.Drawing.Color.Orange;
            this.listBoxPriority2.FormattingEnabled = true;
            this.listBoxPriority2.ItemHeight = 20;
            this.listBoxPriority2.Location = new System.Drawing.Point(873, 709);
            this.listBoxPriority2.Name = "listBoxPriority2";
            this.listBoxPriority2.Size = new System.Drawing.Size(191, 124);
            this.listBoxPriority2.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(876, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 57;
            this.label1.Text = "Posts by priority";
            // 
            // listBoxPriority1
            // 
            this.listBoxPriority1.BackColor = System.Drawing.Color.Crimson;
            this.listBoxPriority1.FormattingEnabled = true;
            this.listBoxPriority1.ItemHeight = 20;
            this.listBoxPriority1.Location = new System.Drawing.Point(676, 709);
            this.listBoxPriority1.Name = "listBoxPriority1";
            this.listBoxPriority1.Size = new System.Drawing.Size(175, 124);
            this.listBoxPriority1.TabIndex = 56;
            // 
            // buttonDisableButtons
            // 
            this.buttonDisableButtons.Location = new System.Drawing.Point(1117, 91);
            this.buttonDisableButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDisableButtons.Name = "buttonDisableButtons";
            this.buttonDisableButtons.Size = new System.Drawing.Size(142, 49);
            this.buttonDisableButtons.TabIndex = 63;
            this.buttonDisableButtons.Text = "Disable Buttons";
            this.buttonDisableButtons.UseVisualStyleBackColor = true;
            this.buttonDisableButtons.Click += new System.EventHandler(this.buttonDisableButtons_Click);
            // 
            // buttonLinkedin
            // 
            this.buttonLinkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLinkedin.Location = new System.Drawing.Point(498, 216);
            this.buttonLinkedin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLinkedin.Name = "buttonLinkedin";
            this.buttonLinkedin.Size = new System.Drawing.Size(246, 73);
            this.buttonLinkedin.TabIndex = 46;
            this.buttonLinkedin.Text = "Create Linkedin Profile";
            this.buttonLinkedin.UseVisualStyleBackColor = true;
            this.buttonLinkedin.Click += new System.EventHandler(this.buttonLinkedin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1117, 14);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(142, 49);
            this.buttonLogout.TabIndex = 26;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonenableButtons
            // 
            this.buttonenableButtons.Location = new System.Drawing.Point(1117, 162);
            this.buttonenableButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonenableButtons.Name = "buttonenableButtons";
            this.buttonenableButtons.Size = new System.Drawing.Size(142, 49);
            this.buttonenableButtons.TabIndex = 64;
            this.buttonenableButtons.Text = "Enable Buttons";
            this.buttonenableButtons.UseVisualStyleBackColor = true;
            this.buttonenableButtons.Click += new System.EventHandler(this.buttonEnableButtons_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 833);
            this.Controls.Add(this.buttonLinkedin);
            this.Controls.Add(this.buttonLogout); 
            this.Controls.Add(this.buttonenableButtons);
            this.Controls.Add(this.buttonDisableButtons);
            this.Controls.Add(this.textBoxPriority3);
            this.Controls.Add(this.textBoxPriority2);
            this.Controls.Add(this.textBoxPriority1);
            this.Controls.Add(this.listBoxPriority3);
            this.Controls.Add(this.listBoxPriority2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPriority1);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxYellow);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.listBoxGreen);
            this.Controls.Add(this.listBoxYellow);
            this.Controls.Add(this.labelPostDefualt);
            this.Controls.Add(this.listBoxRed);
            this.Controls.Add(this.pictureBoxPictureCover);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelPics);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.lableAlbums);
            this.Controls.Add(this.lableFriends);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lableName);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.pictureBoxPictureProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Profile App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictureCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPictureProfile;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.Label lableFriends;
        private System.Windows.Forms.Label lableAlbums;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelPics;
        private ButtonObserver buttonLogout;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBoxPictureCover;
        private ButtonObserver buttonLinkedin;
        private System.Windows.Forms.ListBox listBoxRed;
        private System.Windows.Forms.Label labelPostDefualt;
        private System.Windows.Forms.ListBox listBoxYellow;
        private System.Windows.Forms.ListBox listBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxYellow;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxPriority3;
        private System.Windows.Forms.TextBox textBoxPriority2;
        private System.Windows.Forms.TextBox textBoxPriority1;
        private System.Windows.Forms.ListBox listBoxPriority3;
        private System.Windows.Forms.ListBox listBoxPriority2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPriority1;
        private System.Windows.Forms.Button buttonDisableButtons;
        private System.Windows.Forms.Button buttonenableButtons;
    }
}