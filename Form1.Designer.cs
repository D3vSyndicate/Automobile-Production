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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolRides));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbBlackCar
            // 
            this.rbBlackCar.AutoSize = true;
            this.rbBlackCar.Location = new System.Drawing.Point(27, 34);
            this.rbBlackCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.rbWhiteCar.Location = new System.Drawing.Point(27, 90);
            this.rbWhiteCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.rbBlackMinibus.Location = new System.Drawing.Point(27, 139);
            this.rbBlackMinibus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.rbWhiteMinibus.Location = new System.Drawing.Point(27, 194);
            this.rbWhiteMinibus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblCar.Size = new System.Drawing.Size(196, 38);
            this.lblCar.TabIndex = 4;
            this.lblCar.Text = "Car Queue:";
            // 
            // lblMinibus
            // 
            this.lblMinibus.AutoSize = true;
            this.lblMinibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinibus.Location = new System.Drawing.Point(1319, 34);
            this.lblMinibus.Name = "lblMinibus";
            this.lblMinibus.Size = new System.Drawing.Size(259, 38);
            this.lblMinibus.TabIndex = 5;
            this.lblMinibus.Text = "Minibus Queue:";
            // 
            // lblCarTitle
            // 
            this.lblCarTitle.AutoSize = true;
            this.lblCarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarTitle.Location = new System.Drawing.Point(779, 153);
            this.lblCarTitle.Name = "lblCarTitle";
            this.lblCarTitle.Size = new System.Drawing.Size(319, 38);
            this.lblCarTitle.TabIndex = 6;
            this.lblCarTitle.Text = "Car Assembly Line:";
            // 
            // lblMinibusTitle
            // 
            this.lblMinibusTitle.AutoSize = true;
            this.lblMinibusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinibusTitle.Location = new System.Drawing.Point(731, 321);
            this.lblMinibusTitle.Name = "lblMinibusTitle";
            this.lblMinibusTitle.Size = new System.Drawing.Size(382, 38);
            this.lblMinibusTitle.TabIndex = 7;
            this.lblMinibusTitle.Text = "Minibus Assembly Line:";
            // 
            // lblSpraybooth
            // 
            this.lblSpraybooth.AutoSize = true;
            this.lblSpraybooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpraybooth.Location = new System.Drawing.Point(809, 514);
            this.lblSpraybooth.Name = "lblSpraybooth";
            this.lblSpraybooth.Size = new System.Drawing.Size(194, 38);
            this.lblSpraybooth.TabIndex = 8;
            this.lblSpraybooth.Text = "Spraybooth";
            // 
            // lblCarQueue
            // 
            this.lblCarQueue.AutoSize = true;
            this.lblCarQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarQueue.Location = new System.Drawing.Point(293, 90);
            this.lblCarQueue.Name = "lblCarQueue";
            this.lblCarQueue.Size = new System.Drawing.Size(0, 32);
            this.lblCarQueue.TabIndex = 9;
            // 
            // lblMinibusQueue
            // 
            this.lblMinibusQueue.AutoSize = true;
            this.lblMinibusQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinibusQueue.Location = new System.Drawing.Point(1395, 101);
            this.lblMinibusQueue.Name = "lblMinibusQueue";
            this.lblMinibusQueue.Size = new System.Drawing.Size(0, 32);
            this.lblMinibusQueue.TabIndex = 10;
            // 
            // lblCarAssemblyLine
            // 
            this.lblCarAssemblyLine.AutoSize = true;
            this.lblCarAssemblyLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarAssemblyLine.Location = new System.Drawing.Point(811, 224);
            this.lblCarAssemblyLine.Name = "lblCarAssemblyLine";
            this.lblCarAssemblyLine.Size = new System.Drawing.Size(60, 32);
            this.lblCarAssemblyLine.TabIndex = 11;
            this.lblCarAssemblyLine.Text = "Idle";
            // 
            // lblMinibusAssemblyLine
            // 
            this.lblMinibusAssemblyLine.AutoSize = true;
            this.lblMinibusAssemblyLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinibusAssemblyLine.Location = new System.Drawing.Point(811, 398);
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
            this.btnOrder.Location = new System.Drawing.Point(27, 250);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(176, 94);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tinyiko Mkhombo: 229072739";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sibusiso Nxumalo: 224473131";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thapelo Sitoe: 229282822";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Khanyisa Mbonya: 225347865";
            // 
            // CoolRides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1656, 645);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

