namespace OOP_Midterm
{
    partial class AddVehicle
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
            radElectric = new RadioButton();
            radGas = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            btnAddVehicle = new Button();
            SuspendLayout();
            // 
            // radElectric
            // 
            radElectric.AutoSize = true;
            radElectric.Location = new Point(29, 45);
            radElectric.Name = "radElectric";
            radElectric.Size = new Size(78, 24);
            radElectric.TabIndex = 0;
            radElectric.TabStop = true;
            radElectric.Text = "Electric";
            radElectric.UseVisualStyleBackColor = true;
            radElectric.CheckedChanged += radElectric_CheckedChanged;
            // 
            // radGas
            // 
            radGas.AutoSize = true;
            radGas.Location = new Point(247, 45);
            radGas.Name = "radGas";
            radGas.Size = new Size(54, 24);
            radGas.TabIndex = 1;
            radGas.TabStop = true;
            radGas.Text = "Gas";
            radGas.UseVisualStyleBackColor = true;
            radGas.CheckedChanged += radGas_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 110);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 2;
            label1.Text = "Make:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 146);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 183);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Year:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(107, 107);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(194, 27);
            txtMake.TabIndex = 5;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(107, 140);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(194, 27);
            txtModel.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(107, 176);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(194, 27);
            txtYear.TabIndex = 7;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Location = new Point(29, 263);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(272, 77);
            btnAddVehicle.TabIndex = 8;
            btnAddVehicle.Text = "Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // AddVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 367);
            Controls.Add(btnAddVehicle);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radGas);
            Controls.Add(radElectric);
            Name = "AddVehicle";
            Text = "AddVehicle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radElectric;
        private RadioButton radGas;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private Button btnAddVehicle;
    }
}