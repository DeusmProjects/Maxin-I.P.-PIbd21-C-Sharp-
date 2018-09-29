namespace Lab1
{
    partial class ShipForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.bottonCreateWar = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateCruiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShip.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(766, 424);
            this.pictureBoxShip.TabIndex = 0;
            this.pictureBoxShip.TabStop = false;
            // 
            // bottonCreateWar
            // 
            this.bottonCreateWar.Location = new System.Drawing.Point(12, 12);
            this.bottonCreateWar.Name = "bottonCreateWar";
            this.bottonCreateWar.Size = new System.Drawing.Size(83, 23);
            this.bottonCreateWar.TabIndex = 1;
            this.bottonCreateWar.Text = "CreateWar";
            this.bottonCreateWar.UseVisualStyleBackColor = true;
            this.bottonCreateWar.Click += new System.EventHandler(this.bottonCreateWar_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.Location = new System.Drawing.Point(668, 326);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.Location = new System.Drawing.Point(622, 372);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.Location = new System.Drawing.Point(714, 372);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.Location = new System.Drawing.Point(668, 372);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 40);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateCruiser
            // 
            this.buttonCreateCruiser.Location = new System.Drawing.Point(116, 12);
            this.buttonCreateCruiser.Name = "buttonCreateCruiser";
            this.buttonCreateCruiser.Size = new System.Drawing.Size(83, 23);
            this.buttonCreateCruiser.TabIndex = 6;
            this.buttonCreateCruiser.Text = "CreateCruiser";
            this.buttonCreateCruiser.UseVisualStyleBackColor = true;
            this.buttonCreateCruiser.Click += new System.EventHandler(this.buttonCreateCruiser_Click);
            // 
            // ShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 424);
            this.Controls.Add(this.buttonCreateCruiser);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.bottonCreateWar);
            this.Controls.Add(this.pictureBoxShip);
            this.Name = "ShipForm";
            this.Text = "Ship";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Button bottonCreateWar;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateCruiser;
    }
}

