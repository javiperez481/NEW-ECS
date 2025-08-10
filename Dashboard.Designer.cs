namespace ECS_Equipment_Checkout_System
{
    partial class formDashboard
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
            lstOverdueEquipment = new ListBox();
            btnAdminPage = new Button();
            btnEquipmentCheckoutPage = new Button();
            btnOverdueEquipmentPage = new Button();
            btnReturnEquipment = new Button();
            SuspendLayout();
            // 
            // lstOverdueEquipment
            // 
            lstOverdueEquipment.FormattingEnabled = true;
            lstOverdueEquipment.ItemHeight = 15;
            lstOverdueEquipment.Location = new Point(410, 51);
            lstOverdueEquipment.Name = "lstOverdueEquipment";
            lstOverdueEquipment.ScrollAlwaysVisible = true;
            lstOverdueEquipment.Size = new Size(270, 334);
            lstOverdueEquipment.Sorted = true;
            lstOverdueEquipment.TabIndex = 0;
            // 
            // btnAdminPage
            // 
            btnAdminPage.Location = new Point(217, 101);
            btnAdminPage.Name = "btnAdminPage";
            btnAdminPage.Size = new Size(75, 23);
            btnAdminPage.TabIndex = 1;
            btnAdminPage.Text = "Admin";
            btnAdminPage.UseVisualStyleBackColor = true;
            // 
            // btnEquipmentCheckoutPage
            // 
            btnEquipmentCheckoutPage.Location = new Point(217, 159);
            btnEquipmentCheckoutPage.Name = "btnEquipmentCheckoutPage";
            btnEquipmentCheckoutPage.Size = new Size(75, 39);
            btnEquipmentCheckoutPage.TabIndex = 2;
            btnEquipmentCheckoutPage.Text = "Equipment Checkout";
            btnEquipmentCheckoutPage.UseVisualStyleBackColor = true;
            // 
            // btnOverdueEquipmentPage
            // 
            btnOverdueEquipmentPage.Location = new Point(217, 234);
            btnOverdueEquipmentPage.Name = "btnOverdueEquipmentPage";
            btnOverdueEquipmentPage.Size = new Size(75, 39);
            btnOverdueEquipmentPage.TabIndex = 3;
            btnOverdueEquipmentPage.Text = "Overdue Equipment";
            btnOverdueEquipmentPage.UseVisualStyleBackColor = true;
            // 
            // btnReturnEquipment
            // 
            btnReturnEquipment.Location = new Point(217, 312);
            btnReturnEquipment.Name = "btnReturnEquipment";
            btnReturnEquipment.Size = new Size(75, 38);
            btnReturnEquipment.TabIndex = 4;
            btnReturnEquipment.Text = "Return Equipment";
            btnReturnEquipment.UseVisualStyleBackColor = true;
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturnEquipment);
            Controls.Add(btnOverdueEquipmentPage);
            Controls.Add(btnEquipmentCheckoutPage);
            Controls.Add(btnAdminPage);
            Controls.Add(lstOverdueEquipment);
            Name = "formDashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOverdueEquipment;
        private Button btnAdminPage;
        private Button btnEquipmentCheckoutPage;
        private Button btnOverdueEquipmentPage;
        private Button btnReturnEquipment;
    }
}