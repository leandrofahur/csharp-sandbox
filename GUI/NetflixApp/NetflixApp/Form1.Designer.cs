
namespace NetflixApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.orderByGroupBox = new System.Windows.Forms.GroupBox();
            this.yearCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.titleCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.idCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.controlGroupBox.SuspendLayout();
            this.orderByGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.controlGroupBox.Controls.Add(this.addButton);
            this.controlGroupBox.Controls.Add(this.deleteButton);
            this.controlGroupBox.Controls.Add(this.orderByGroupBox);
            this.controlGroupBox.Controls.Add(this.saveButton);
            this.controlGroupBox.Controls.Add(this.loadButton);
            this.controlGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlGroupBox.Location = new System.Drawing.Point(10, 2);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(168, 432);
            this.controlGroupBox.TabIndex = 0;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 207);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 40);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Data";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 253);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(144, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Data";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // orderByGroupBox
            // 
            this.orderByGroupBox.Controls.Add(this.yearCheckBox);
            this.orderByGroupBox.Controls.Add(this.dateCheckBox);
            this.orderByGroupBox.Controls.Add(this.titleCheckBox);
            this.orderByGroupBox.Controls.Add(this.typeCheckBox);
            this.orderByGroupBox.Controls.Add(this.idCheckBox);
            this.orderByGroupBox.Location = new System.Drawing.Point(12, 22);
            this.orderByGroupBox.Name = "orderByGroupBox";
            this.orderByGroupBox.Size = new System.Drawing.Size(144, 179);
            this.orderByGroupBox.TabIndex = 2;
            this.orderByGroupBox.TabStop = false;
            this.orderByGroupBox.Text = "Order By";
            // 
            // yearCheckBox
            // 
            this.yearCheckBox.AutoSize = true;
            this.yearCheckBox.Location = new System.Drawing.Point(19, 145);
            this.yearCheckBox.Name = "yearCheckBox";
            this.yearCheckBox.Size = new System.Drawing.Size(62, 24);
            this.yearCheckBox.TabIndex = 5;
            this.yearCheckBox.Text = "Year";
            this.yearCheckBox.UseVisualStyleBackColor = true;
            this.yearCheckBox.CheckedChanged += new System.EventHandler(this.yearCheckBox_CheckedChanged);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(19, 115);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(63, 24);
            this.dateCheckBox.TabIndex = 4;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // titleCheckBox
            // 
            this.titleCheckBox.AutoSize = true;
            this.titleCheckBox.Location = new System.Drawing.Point(19, 85);
            this.titleCheckBox.Name = "titleCheckBox";
            this.titleCheckBox.Size = new System.Drawing.Size(57, 24);
            this.titleCheckBox.TabIndex = 3;
            this.titleCheckBox.Text = "Title";
            this.titleCheckBox.UseVisualStyleBackColor = true;
            this.titleCheckBox.CheckedChanged += new System.EventHandler(this.titleCheckBox_CheckedChanged);
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Location = new System.Drawing.Point(19, 55);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(62, 24);
            this.typeCheckBox.TabIndex = 2;
            this.typeCheckBox.Text = "Type";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            this.typeCheckBox.CheckedChanged += new System.EventHandler(this.typeCheckBox_CheckedChanged);
            // 
            // idCheckBox
            // 
            this.idCheckBox.AutoSize = true;
            this.idCheckBox.Location = new System.Drawing.Point(19, 25);
            this.idCheckBox.Name = "idCheckBox";
            this.idCheckBox.Size = new System.Drawing.Size(42, 24);
            this.idCheckBox.TabIndex = 1;
            this.idCheckBox.Text = "Id";
            this.idCheckBox.UseVisualStyleBackColor = true;
            this.idCheckBox.CheckedChanged += new System.EventHandler(this.idCheckBox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 383);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(144, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Data";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 337);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(144, 40);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // dataListBox
            // 
            this.dataListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.Location = new System.Drawing.Point(186, 14);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(849, 420);
            this.dataListBox.TabIndex = 0;
            this.dataListBox.SelectedIndexChanged += new System.EventHandler(this.dataListBox_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(186, 440);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(849, 23);
            this.progressBar.TabIndex = 1;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(7, 440);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(171, 23);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1047, 474);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.controlGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Netflix App";
            this.controlGroupBox.ResumeLayout(false);
            this.orderByGroupBox.ResumeLayout(false);
            this.orderByGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.GroupBox orderByGroupBox;
        private System.Windows.Forms.CheckBox titleCheckBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox idCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox yearCheckBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

