namespace Converter
{
    partial class Conversion
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
            this.Temperature_Label = new System.Windows.Forms.Label();
            this.Mass_Label = new System.Windows.Forms.Label();
            this.Presure_Label = new System.Windows.Forms.Label();
            this.Temperature_TextBox = new System.Windows.Forms.TextBox();
            this.Mass_TextBox = new System.Windows.Forms.TextBox();
            this.Pressure_TextBox = new System.Windows.Forms.TextBox();
            this.Pressure_ComboBox = new System.Windows.Forms.ComboBox();
            this.Mass_ComboBox = new System.Windows.Forms.ComboBox();
            this.Temperature_ComboBox = new System.Windows.Forms.ComboBox();
            this.Convert_Btn = new System.Windows.Forms.Button();
            this.Temperature_Convertion_View = new System.Windows.Forms.TextBox();
            this.Mass_Convertion_View = new System.Windows.Forms.TextBox();
            this.Pressure_Convertion_View = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Temperature_Label
            // 
            this.Temperature_Label.AutoSize = true;
            this.Temperature_Label.Location = new System.Drawing.Point(40, 26);
            this.Temperature_Label.Name = "Temperature_Label";
            this.Temperature_Label.Size = new System.Drawing.Size(90, 17);
            this.Temperature_Label.TabIndex = 0;
            this.Temperature_Label.Text = "Temperatura";
            // 
            // Mass_Label
            // 
            this.Mass_Label.AutoSize = true;
            this.Mass_Label.Location = new System.Drawing.Point(363, 26);
            this.Mass_Label.Name = "Mass_Label";
            this.Mass_Label.Size = new System.Drawing.Size(42, 17);
            this.Mass_Label.TabIndex = 1;
            this.Mass_Label.Text = "Masa";
            // 
            // Presure_Label
            // 
            this.Presure_Label.AutoSize = true;
            this.Presure_Label.Location = new System.Drawing.Point(575, 26);
            this.Presure_Label.Name = "Presure_Label";
            this.Presure_Label.Size = new System.Drawing.Size(56, 17);
            this.Presure_Label.TabIndex = 2;
            this.Presure_Label.Text = "Presión";
            // 
            // Temperature_TextBox
            // 
            this.Temperature_TextBox.Location = new System.Drawing.Point(12, 76);
            this.Temperature_TextBox.Name = "Temperature_TextBox";
            this.Temperature_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Temperature_TextBox.TabIndex = 3;
            // 
            // Mass_TextBox
            // 
            this.Mass_TextBox.Location = new System.Drawing.Point(286, 76);
            this.Mass_TextBox.Name = "Mass_TextBox";
            this.Mass_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Mass_TextBox.TabIndex = 4;
            // 
            // Pressure_TextBox
            // 
            this.Pressure_TextBox.Location = new System.Drawing.Point(551, 76);
            this.Pressure_TextBox.Name = "Pressure_TextBox";
            this.Pressure_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Pressure_TextBox.TabIndex = 5;
            // 
            // Pressure_ComboBox
            // 
            this.Pressure_ComboBox.FormattingEnabled = true;
            this.Pressure_ComboBox.Items.AddRange(new object[] {
            "kg/(cm^2)",
            "PSI",
            "KPa"});
            this.Pressure_ComboBox.Location = new System.Drawing.Point(667, 74);
            this.Pressure_ComboBox.Name = "Pressure_ComboBox";
            this.Pressure_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Pressure_ComboBox.TabIndex = 6;
            // 
            // Mass_ComboBox
            // 
            this.Mass_ComboBox.FormattingEnabled = true;
            this.Mass_ComboBox.Items.AddRange(new object[] {
            "cm^3",
            "m^3",
            "ft"});
            this.Mass_ComboBox.Location = new System.Drawing.Point(392, 74);
            this.Mass_ComboBox.Name = "Mass_ComboBox";
            this.Mass_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Mass_ComboBox.TabIndex = 7;
            // 
            // Temperature_ComboBox
            // 
            this.Temperature_ComboBox.FormattingEnabled = true;
            this.Temperature_ComboBox.Items.AddRange(new object[] {
            "Celsio",
            "Farenhiet",
            "Kelvin"});
            this.Temperature_ComboBox.Location = new System.Drawing.Point(118, 74);
            this.Temperature_ComboBox.Name = "Temperature_ComboBox";
            this.Temperature_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Temperature_ComboBox.TabIndex = 8;
            // 
            // Convert_Btn
            // 
            this.Convert_Btn.Location = new System.Drawing.Point(12, 396);
            this.Convert_Btn.Name = "Convert_Btn";
            this.Convert_Btn.Size = new System.Drawing.Size(126, 23);
            this.Convert_Btn.TabIndex = 9;
            this.Convert_Btn.Text = "Convertir";
            this.Convert_Btn.UseVisualStyleBackColor = true;
            this.Convert_Btn.Click += new System.EventHandler(this.Convert_Btn_Click);
            // 
            // Temperature_Convertion_View
            // 
            this.Temperature_Convertion_View.Enabled = false;
            this.Temperature_Convertion_View.Location = new System.Drawing.Point(12, 143);
            this.Temperature_Convertion_View.Multiline = true;
            this.Temperature_Convertion_View.Name = "Temperature_Convertion_View";
            this.Temperature_Convertion_View.Size = new System.Drawing.Size(227, 193);
            this.Temperature_Convertion_View.TabIndex = 10;
            // 
            // Mass_Convertion_View
            // 
            this.Mass_Convertion_View.Enabled = false;
            this.Mass_Convertion_View.Location = new System.Drawing.Point(286, 143);
            this.Mass_Convertion_View.Multiline = true;
            this.Mass_Convertion_View.Name = "Mass_Convertion_View";
            this.Mass_Convertion_View.Size = new System.Drawing.Size(227, 193);
            this.Mass_Convertion_View.TabIndex = 11;
            // 
            // Pressure_Convertion_View
            // 
            this.Pressure_Convertion_View.Enabled = false;
            this.Pressure_Convertion_View.Location = new System.Drawing.Point(551, 143);
            this.Pressure_Convertion_View.Multiline = true;
            this.Pressure_Convertion_View.Name = "Pressure_Convertion_View";
            this.Pressure_Convertion_View.Size = new System.Drawing.Size(237, 193);
            this.Pressure_Convertion_View.TabIndex = 12;
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pressure_Convertion_View);
            this.Controls.Add(this.Mass_Convertion_View);
            this.Controls.Add(this.Temperature_Convertion_View);
            this.Controls.Add(this.Convert_Btn);
            this.Controls.Add(this.Temperature_ComboBox);
            this.Controls.Add(this.Mass_ComboBox);
            this.Controls.Add(this.Pressure_ComboBox);
            this.Controls.Add(this.Pressure_TextBox);
            this.Controls.Add(this.Mass_TextBox);
            this.Controls.Add(this.Temperature_TextBox);
            this.Controls.Add(this.Presure_Label);
            this.Controls.Add(this.Mass_Label);
            this.Controls.Add(this.Temperature_Label);
            this.Name = "Conversion";
            this.Text = "Convertidor de Unidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temperature_Label;
        private System.Windows.Forms.Label Mass_Label;
        private System.Windows.Forms.Label Presure_Label;
        private System.Windows.Forms.TextBox Temperature_TextBox;
        private System.Windows.Forms.TextBox Mass_TextBox;
        private System.Windows.Forms.TextBox Pressure_TextBox;
        private System.Windows.Forms.ComboBox Pressure_ComboBox;
        private System.Windows.Forms.ComboBox Mass_ComboBox;
        private System.Windows.Forms.ComboBox Temperature_ComboBox;
        private System.Windows.Forms.Button Convert_Btn;
        private System.Windows.Forms.TextBox Temperature_Convertion_View;
        private System.Windows.Forms.TextBox Mass_Convertion_View;
        private System.Windows.Forms.TextBox Pressure_Convertion_View;
    }
}

