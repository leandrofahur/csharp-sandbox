
namespace UserRegistration
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
            this.userListBox = new System.Windows.Forms.ListBox();
            this.ioGroupBox = new System.Windows.Forms.GroupBox();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.loadUsersButton = new System.Windows.Forms.Button();
            this.saveUsersButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.insertUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.methodsGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.sortByIdButton = new System.Windows.Forms.Button();
            this.showHeaderButton = new System.Windows.Forms.Button();
            this.chooseRandomUserButton = new System.Windows.Forms.Button();
            this.saveModButton = new System.Windows.Forms.Button();
            this.saveAddedButton = new System.Windows.Forms.Button();
            this.ioGroupBox.SuspendLayout();
            this.actionsGroupBox.SuspendLayout();
            this.methodsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 19;
            this.userListBox.Location = new System.Drawing.Point(12, 12);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(776, 137);
            this.userListBox.TabIndex = 0;
            // 
            // ioGroupBox
            // 
            this.ioGroupBox.Controls.Add(this.saveUsersButton);
            this.ioGroupBox.Controls.Add(this.loadUsersButton);
            this.ioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ioGroupBox.Location = new System.Drawing.Point(12, 155);
            this.ioGroupBox.Name = "ioGroupBox";
            this.ioGroupBox.Size = new System.Drawing.Size(200, 168);
            this.ioGroupBox.TabIndex = 1;
            this.ioGroupBox.TabStop = false;
            this.ioGroupBox.Text = "IO Controls";
            // 
            // actionsGroupBox
            // 
            this.actionsGroupBox.Controls.Add(this.deleteUserButton);
            this.actionsGroupBox.Controls.Add(this.insertUserButton);
            this.actionsGroupBox.Controls.Add(this.updateUserButton);
            this.actionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsGroupBox.Location = new System.Drawing.Point(231, 155);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(200, 168);
            this.actionsGroupBox.TabIndex = 2;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Actions";
            // 
            // loadUsersButton
            // 
            this.loadUsersButton.Location = new System.Drawing.Point(22, 41);
            this.loadUsersButton.Name = "loadUsersButton";
            this.loadUsersButton.Size = new System.Drawing.Size(157, 50);
            this.loadUsersButton.TabIndex = 0;
            this.loadUsersButton.Text = "Load Users";
            this.loadUsersButton.UseVisualStyleBackColor = true;
            // 
            // saveUsersButton
            // 
            this.saveUsersButton.Location = new System.Drawing.Point(22, 97);
            this.saveUsersButton.Name = "saveUsersButton";
            this.saveUsersButton.Size = new System.Drawing.Size(157, 50);
            this.saveUsersButton.TabIndex = 1;
            this.saveUsersButton.Text = "Save Users";
            this.saveUsersButton.UseVisualStyleBackColor = true;
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(35, 25);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(135, 38);
            this.updateUserButton.TabIndex = 2;
            this.updateUserButton.Text = "Update User";
            this.updateUserButton.UseVisualStyleBackColor = true;
            // 
            // insertUserButton
            // 
            this.insertUserButton.Location = new System.Drawing.Point(35, 69);
            this.insertUserButton.Name = "insertUserButton";
            this.insertUserButton.Size = new System.Drawing.Size(135, 38);
            this.insertUserButton.TabIndex = 3;
            this.insertUserButton.Text = "Insert User";
            this.insertUserButton.UseVisualStyleBackColor = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(35, 113);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(135, 38);
            this.deleteUserButton.TabIndex = 4;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(12, 336);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(776, 64);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // methodsGroupBox
            // 
            this.methodsGroupBox.Controls.Add(this.saveAddedButton);
            this.methodsGroupBox.Controls.Add(this.saveModButton);
            this.methodsGroupBox.Controls.Add(this.chooseRandomUserButton);
            this.methodsGroupBox.Controls.Add(this.showHeaderButton);
            this.methodsGroupBox.Controls.Add(this.exitButton);
            this.methodsGroupBox.Controls.Add(this.sortByIdButton);
            this.methodsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodsGroupBox.Location = new System.Drawing.Point(450, 155);
            this.methodsGroupBox.Name = "methodsGroupBox";
            this.methodsGroupBox.Size = new System.Drawing.Size(338, 168);
            this.methodsGroupBox.TabIndex = 5;
            this.methodsGroupBox.TabStop = false;
            this.methodsGroupBox.Text = "Methods";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(185, 113);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 38);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // sortByIdButton
            // 
            this.sortByIdButton.Location = new System.Drawing.Point(35, 25);
            this.sortByIdButton.Name = "sortByIdButton";
            this.sortByIdButton.Size = new System.Drawing.Size(135, 38);
            this.sortByIdButton.TabIndex = 2;
            this.sortByIdButton.Text = "Sort";
            this.sortByIdButton.UseVisualStyleBackColor = true;
            // 
            // showHeaderButton
            // 
            this.showHeaderButton.Location = new System.Drawing.Point(35, 69);
            this.showHeaderButton.Name = "showHeaderButton";
            this.showHeaderButton.Size = new System.Drawing.Size(135, 38);
            this.showHeaderButton.TabIndex = 4;
            this.showHeaderButton.Text = "Show Header";
            this.showHeaderButton.UseVisualStyleBackColor = true;
            // 
            // chooseRandomUserButton
            // 
            this.chooseRandomUserButton.Location = new System.Drawing.Point(35, 113);
            this.chooseRandomUserButton.Name = "chooseRandomUserButton";
            this.chooseRandomUserButton.Size = new System.Drawing.Size(135, 38);
            this.chooseRandomUserButton.TabIndex = 5;
            this.chooseRandomUserButton.Text = "Random";
            this.chooseRandomUserButton.UseVisualStyleBackColor = true;
            // 
            // saveModButton
            // 
            this.saveModButton.Location = new System.Drawing.Point(185, 69);
            this.saveModButton.Name = "saveModButton";
            this.saveModButton.Size = new System.Drawing.Size(135, 38);
            this.saveModButton.TabIndex = 6;
            this.saveModButton.Text = "Save Mod.";
            this.saveModButton.UseVisualStyleBackColor = true;
            // 
            // saveAddedButton
            // 
            this.saveAddedButton.Location = new System.Drawing.Point(185, 25);
            this.saveAddedButton.Name = "saveAddedButton";
            this.saveAddedButton.Size = new System.Drawing.Size(135, 38);
            this.saveAddedButton.TabIndex = 7;
            this.saveAddedButton.Text = "Save Added";
            this.saveAddedButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.methodsGroupBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.actionsGroupBox);
            this.Controls.Add(this.ioGroupBox);
            this.Controls.Add(this.userListBox);
            this.Name = "Form1";
            this.Text = "User Register App";
            this.ioGroupBox.ResumeLayout(false);
            this.actionsGroupBox.ResumeLayout(false);
            this.methodsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.GroupBox ioGroupBox;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.Button saveUsersButton;
        private System.Windows.Forms.Button loadUsersButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button insertUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox methodsGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button sortByIdButton;
        private System.Windows.Forms.Button saveAddedButton;
        private System.Windows.Forms.Button saveModButton;
        private System.Windows.Forms.Button chooseRandomUserButton;
        private System.Windows.Forms.Button showHeaderButton;
    }
}

