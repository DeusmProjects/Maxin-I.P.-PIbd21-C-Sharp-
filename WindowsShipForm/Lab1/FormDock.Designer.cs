namespace Lab1
{
    partial class FormDock
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
            this.pictureBoxDock = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDocks = new System.Windows.Forms.ListBox();
            this.labelDocks = new System.Windows.Forms.Label();
            this.buttonChooseShip = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBoxDock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxDock.Location = new System.Drawing.Point(12, 80);
            this.pictureBoxDock.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(820, 742);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxShip);
            this.groupBox.Controls.Add(this.buttonTake);
            this.groupBox.Controls.Add(this.labelPlace);
            this.groupBox.Controls.Add(this.maskedTextBoxPlace);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox.Location = new System.Drawing.Point(936, 478);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Size = new System.Drawing.Size(284, 345);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Location = new System.Drawing.Point(0, 192);
            this.pictureBoxShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(276, 145);
            this.pictureBoxShip.TabIndex = 4;
            this.pictureBoxShip.TabStop = false;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(93, 135);
            this.buttonTake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(100, 28);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(72, 92);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(49, 17);
            this.labelPlace.TabIndex = 2;
            this.labelPlace.Text = "Место";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(160, 89);
            this.maskedTextBoxPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(49, 22);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забрать корабль";
            // 
            // listBoxDocks
            // 
            this.listBoxDocks.FormattingEnabled = true;
            this.listBoxDocks.ItemHeight = 16;
            this.listBoxDocks.Location = new System.Drawing.Point(987, 126);
            this.listBoxDocks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxDocks.Name = "listBoxDocks";
            this.listBoxDocks.Size = new System.Drawing.Size(159, 116);
            this.listBoxDocks.TabIndex = 5;
            this.listBoxDocks.SelectedIndexChanged += new System.EventHandler(this.listBoxDocks_SelectedIndexChanged);
            // 
            // labelDocks
            // 
            this.labelDocks.AutoSize = true;
            this.labelDocks.Location = new System.Drawing.Point(1023, 98);
            this.labelDocks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDocks.Name = "labelDocks";
            this.labelDocks.Size = new System.Drawing.Size(42, 17);
            this.labelDocks.TabIndex = 6;
            this.labelDocks.Text = "Доки";
            // 
            // buttonChooseShip
            // 
            this.buttonChooseShip.Location = new System.Drawing.Point(953, 277);
            this.buttonChooseShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChooseShip.Name = "buttonChooseShip";
            this.buttonChooseShip.Size = new System.Drawing.Size(244, 97);
            this.buttonChooseShip.TabIndex = 7;
            this.buttonChooseShip.Text = "Выбрать корабль";
            this.buttonChooseShip.UseVisualStyleBackColor = true;
            this.buttonChooseShip.Click += new System.EventHandler(this.buttonChooseShip_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1236, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(953, 397);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(244, 97);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 833);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonChooseShip);
            this.Controls.Add(this.labelDocks);
            this.Controls.Add(this.listBoxDocks);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxDock);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDock";
            this.Text = "FormDock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDocks;
        private System.Windows.Forms.Label labelDocks;
        private System.Windows.Forms.Button buttonChooseShip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}