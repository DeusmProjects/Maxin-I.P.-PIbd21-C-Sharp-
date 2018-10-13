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
            this.buttonParkingCruiser = new System.Windows.Forms.Button();
            this.buttonParkingWarShip = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxDock)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBoxDock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxDock.Location = new System.Drawing.Point(9, 65);
            this.pictureBoxDock.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(615, 603);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // buttonParkingCruiser
            // 
            this.buttonParkingCruiser.Location = new System.Drawing.Point(754, 54);
            this.buttonParkingCruiser.Name = "buttonParkingCruiser";
            this.buttonParkingCruiser.Size = new System.Drawing.Size(96, 57);
            this.buttonParkingCruiser.TabIndex = 1;
            this.buttonParkingCruiser.Text = "Пришвартовать крейсер";
            this.buttonParkingCruiser.UseVisualStyleBackColor = true;
            this.buttonParkingCruiser.Click += new System.EventHandler(this.buttonParkingCruiser_Click);
            // 
            // buttonParkingWarShip
            // 
            this.buttonParkingWarShip.Location = new System.Drawing.Point(755, 117);
            this.buttonParkingWarShip.Name = "buttonParkingWarShip";
            this.buttonParkingWarShip.Size = new System.Drawing.Size(96, 57);
            this.buttonParkingWarShip.TabIndex = 2;
            this.buttonParkingWarShip.Text = "Пришвартовать военный корабль";
            this.buttonParkingWarShip.UseVisualStyleBackColor = true;
            this.buttonParkingWarShip.Click += new System.EventHandler(this.buttonParkingWarShip_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxShip);
            this.groupBox.Controls.Add(this.buttonTake);
            this.groupBox.Controls.Add(this.labelPlace);
            this.groupBox.Controls.Add(this.maskedTextBoxPlace);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox.Location = new System.Drawing.Point(712, 200);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(213, 280);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Location = new System.Drawing.Point(0, 156);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(207, 118);
            this.pictureBoxShip.TabIndex = 4;
            this.pictureBoxShip.TabStop = false;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(70, 110);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(54, 75);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 2;
            this.labelPlace.Text = "Место";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(120, 72);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забрать корабль";
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 677);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonParkingWarShip);
            this.Controls.Add(this.buttonParkingCruiser);
            this.Controls.Add(this.pictureBoxDock);
            this.Name = "FormDock";
            this.Text = "FormDock";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxDock)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.Button buttonParkingCruiser;
        private System.Windows.Forms.Button buttonParkingWarShip;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label label1;
    }
}