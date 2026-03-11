namespace OOP_Midterm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstDisplay = new ListBox();
            btnAddVehicle = new Button();
            btnRemoveVehicle = new Button();
            btnChargeBattery = new Button();
            SuspendLayout();
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.Location = new Point(24, 22);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(462, 204);
            lstDisplay.TabIndex = 0;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Location = new Point(36, 258);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(114, 71);
            btnAddVehicle.TabIndex = 1;
            btnAddVehicle.Text = "Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // btnRemoveVehicle
            // 
            btnRemoveVehicle.Location = new Point(194, 258);
            btnRemoveVehicle.Name = "btnRemoveVehicle";
            btnRemoveVehicle.Size = new Size(114, 71);
            btnRemoveVehicle.TabIndex = 2;
            btnRemoveVehicle.Text = "Remove Vehicle";
            btnRemoveVehicle.UseVisualStyleBackColor = true;
            btnRemoveVehicle.Click += btnRemoveVehicle_Click;
            // 
            // btnChargeBattery
            // 
            btnChargeBattery.Location = new Point(352, 258);
            btnChargeBattery.Name = "btnChargeBattery";
            btnChargeBattery.Size = new Size(114, 71);
            btnChargeBattery.TabIndex = 3;
            btnChargeBattery.Text = "Charge Battery";
            btnChargeBattery.UseVisualStyleBackColor = true;
            btnChargeBattery.Click += btnChargeBattery_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAddVehicle;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 366);
            Controls.Add(btnChargeBattery);
            Controls.Add(btnRemoveVehicle);
            Controls.Add(btnAddVehicle);
            Controls.Add(lstDisplay);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Midterm by ________";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstDisplay;
        private Button btnAddVehicle;
        private Button btnRemoveVehicle;
        private Button btnChargeBattery;
    }
}
