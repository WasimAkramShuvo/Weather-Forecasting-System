namespace Weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.weather = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // cityid
            // 
            this.cityid.Location = new System.Drawing.Point(20, 34);
            this.cityid.Name = "cityid";
            this.cityid.Size = new System.Drawing.Size(147, 20);
            this.cityid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(86, 67);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(0, 13);
            this.temp.TabIndex = 3;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(173, 32);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(49, 23);
            this.go.TabIndex = 4;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // weather
            // 
            this.weather.AutoSize = true;
            this.weather.Location = new System.Drawing.Point(85, 84);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(0, 13);
            this.weather.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weather:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "City";
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(173, 55);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(49, 44);
            this.icon.TabIndex = 9;
            this.icon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Weather.Properties.Resources._3_30555_weather_weather_clipart_transparent_background;
            this.ClientSize = new System.Drawing.Size(230, 118);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weather);
            this.Controls.Add(this.go);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Label weather;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox icon;
    }
}

