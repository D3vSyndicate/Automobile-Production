namespace Automobile_Production
{
    partial class CoolRides
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
            this.components = new System.ComponentModel.Container();
            this.rbBlackCar = new System.Windows.Forms.RadioButton();
            this.rbWhiteCar = new System.Windows.Forms.RadioButton();
            this.rbBlackMinibus = new System.Windows.Forms.RadioButton();
            this.rbWhiteMinibus = new System.Windows.Forms.RadioButton();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblMinibus = new System.Windows.Forms.Label();
            this.lblCarTitle = new System.Windows.Forms.Label();
            this.lblMinibusTitle = new System.Windows.Forms.Label();
            this.lblSpraybooth = new System.Windows.Forms.Label();
            this.lblCarQueue = new System.Windows.Forms.Label();
            this.lblMinibusQueue = new System.Windows.Forms.Label();
            this.lblCarAssemblyLine = new System.Windows.Forms.Label();
            this.lblMinibusAssemblyLine = new System.Windows.Forms.Label();
            this.lblSprayboothStatus = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rbBlackCar
            // 
            this.rbBlackCar.AutoSize = true;
            this.rbBlackCar.Location = new System.Drawing.Point(26, 34);
            this.rbBlackCar.Name = "rbBlackCar";
            this.rbBlackCar.Size = new System.Drawing.Size(118, 20);
            this.rbBlackCar.TabIndex = 0;
            this.rbBlackCar.TabStop = true;
            this.rbBlackCar.Text = "Black LUX1000";
            this.rbBlackCar.UseVisualStyleBackColor = true;
            // 
            // rbWhiteCar
            // 
            this.rbWhiteCar.AutoSize = true;
            this.rbWhiteCar.Location = new System.Drawing.Point(26, 90);
            this.rbWhiteCar.Name = "rbWhiteCar";
            this.rbWhiteCar.Size = new System.Drawing.Size(118, 20);
            this.rbWhiteCar.TabIndex = 1;
            this.rbWhiteCar.TabStop = true;
            this.rbWhiteCar.Text = "White LUX1000";
            this.rbWhiteCar.UseVisualStyleBackColor = true;
            // 
            // rbBlackMinibus
            // 
            this.rbBlackMinibus.AutoSize = true;
            this.rbBlackMinibus.Location = new System.Drawing.Point(26, 139);
            this.rbBlackMinibus.Name = "rbBlackMinibus";
            this.rbBlackMinibus.Size = new System.Drawing.Size(106, 20);
            this.rbBlackMinibus.TabIndex = 2;
            this.rbBlackMinibus.TabStop = true;
            this.rbBlackMinibus.Text = "Black MV500";
            this.rbBlackMinibus.UseVisualStyleBackColor = true;
            // 
            // rbWhiteMinibus
            // 
            this.rbWhiteMinibus.AutoSize = true;
            this.rbWhiteMinibus.Location = new System.Drawing.Point(26, 195);
            this.rbWhiteMinibus.Name = "rbWhiteMinibus";
            this.rbWhiteMinibus.Size = new System.Drawing.Size(106, 20);
            this.rbWhiteMinibus.TabIndex = 3;
            this.rbWhiteMinibus.TabStop = true;
            this.rbWhiteMinibus.Text = "White MV500";
            this.rbWhiteMinibus.UseVisualStyleBackColor = true;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(251, 34);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(202, 39);
            this.lblCar.TabIndex = 4;
            this.lblCar.Text = "Car Queue:";
            // 
            // lblMinibus
            // 
            this.lblMinibus.AutoSize = true;
            this.lblMinibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinibus.Location = new System.Drawing.Point(1319, 34);
            this.lblMinibus.Name = "lblMinibus";
            this.lblMinibus.Size = new System.Drawing.Size(269, 39);
            this.lblMinibus.TabIndex = 5;
            this.lblMinibus.Text = "Minibus Queue:";
            // 
            // lblCarTitle
            // 
            this.lblCarTitle.AutoSize = true;
            this.lblCarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarTitle.Location = new System.Drawing.Point(779, 153);
            this.lblCarTitle.Name = "lblCarTitle";
            this.lblCarTitle.Size = new System.Drawing.Size(330, 39);
            this.lblCarTitle.TabIndex = 6;
            this.lblCarTitle.Text = "Car Assembly Line:";
            // 
            // lblMinibusTitle
            // 
            this.lblMinibusTitle.AutoSize = true;
            this.lblMinibusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinibusTitle.Location = new System.Drawing.Point(731, 321);
            this.lblMinibusTitle.Name = "lblMinibusTitle";
            this.lblMinibusTitle.Size = new System.Drawing.Size(397, 39);
            this.lblMinibusTitle.TabIndex = 7;
            this.lblMinibusTitle.Text = "Minibus Assembly Line:";
            // 
            // lblSpraybooth
            // 
            this.lblSpraybooth.AutoSize = true;
            this.lblSpraybooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpraybooth.Location = new System.Drawing.Point(809, 514);
            this.lblSpraybooth.Name = "lblSpraybooth";
            this.lblSpraybooth.Size = new System.Drawing.Size(201, 39);
            this.lblSpraybooth.TabIndex = 8;
            this.lblSpraybooth.Text = "Spraybooth";
            // 
            // lblCarQueue
            // 
            this.lblCarQueue.AutoSize = true;
            this.lblCarQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarQueue.Location = new System.Drawing.Point(294, 90);
            this.lblCarQueue.Name = "lblCarQueue";
            this.lblCarQueue.Size = new System.Drawing.Size(0, 32);
            this.lblCarQueue.TabIndex = 9;
            // 
            // lblMinibusQueue
            // 
            this.lblMinibusQueue.AutoSize = true;
            this.lblMinibusQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinibusQueue.Location = new System.Drawing.Point(1394, 101);
            this.lblMinibusQueue.Name = "lblMinibusQueue";
            this.lblMinibusQueue.Size = new System.Drawing.Size(0, 32);
            this.lblMinibusQueue.TabIndex = 10;
            // 
            // lblCarAssemblyLine
            // 
            this.lblCarAssemblyLine.AutoSize = true;
            this.lblCarAssemblyLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarAssemblyLine.Location = new System.Drawing.Point(810, 224);
            this.lblCarAssemblyLine.Name = "lblCarAssemblyLine";
            this.lblCarAssemblyLine.Size = new System.Drawing.Size(60, 32);
            this.lblCarAssemblyLine.TabIndex = 11;
            this.lblCarAssemblyLine.Text = "Idle";
            // 
            // lblMinibusAssemblyLine
            // 
            this.lblMinibusAssemblyLine.AutoSize = true;
            this.lblMinibusAssemblyLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinibusAssemblyLine.Location = new System.Drawing.Point(810, 398);
            this.lblMinibusAssemblyLine.Name = "lblMinibusAssemblyLine";
            this.lblMinibusAssemblyLine.Size = new System.Drawing.Size(60, 32);
            this.lblMinibusAssemblyLine.TabIndex = 12;
            this.lblMinibusAssemblyLine.Text = "Idle";
            // 
            // lblSprayboothStatus
            // 
            this.lblSprayboothStatus.AutoSize = true;
            this.lblSprayboothStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprayboothStatus.Location = new System.Drawing.Point(855, 583);
            this.lblSprayboothStatus.Name = "lblSprayboothStatus";
            this.lblSprayboothStatus.Size = new System.Drawing.Size(60, 32);
            this.lblSprayboothStatus.TabIndex = 13;
            this.lblSprayboothStatus.Text = "Idle";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(26, 250);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(138, 94);
            this.btnOrder.TabIndex = 14;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CoolRides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1779, 718);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblSprayboothStatus);
            this.Controls.Add(this.lblMinibusAssemblyLine);
            this.Controls.Add(this.lblCarAssemblyLine);
            this.Controls.Add(this.lblMinibusQueue);
            this.Controls.Add(this.lblCarQueue);
            this.Controls.Add(this.lblSpraybooth);
            this.Controls.Add(this.lblMinibusTitle);
            this.Controls.Add(this.lblCarTitle);
            this.Controls.Add(this.lblMinibus);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.rbWhiteMinibus);
            this.Controls.Add(this.rbBlackMinibus);
            this.Controls.Add(this.rbWhiteCar);
            this.Controls.Add(this.rbBlackCar);
            this.Name = "CoolRides";
            this.Text = "Cool Rides";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBlackCar;
        private System.Windows.Forms.RadioButton rbWhiteCar;
        private System.Windows.Forms.RadioButton rbBlackMinibus;
        private System.Windows.Forms.RadioButton rbWhiteMinibus;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblMinibus;
        private System.Windows.Forms.Label lblCarTitle;
        private System.Windows.Forms.Label lblMinibusTitle;
        private System.Windows.Forms.Label lblSpraybooth;
        private System.Windows.Forms.Label lblCarQueue;
        private System.Windows.Forms.Label lblMinibusQueue;
        private System.Windows.Forms.Label lblCarAssemblyLine;
        private System.Windows.Forms.Label lblMinibusAssemblyLine;
        private System.Windows.Forms.Label lblSprayboothStatus;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Timer timer1;
    }
}

