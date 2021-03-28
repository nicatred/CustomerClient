
namespace CustomerClient
{
    partial class AdoClient
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtGetCustomerById = new System.Windows.Forms.TextBox();
            this.btnGetCustomerById = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetAllCustomer = new System.Windows.Forms.Button();
            this.txtSureName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(354, 163);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 26;
            this.btn_Create.Text = "Yarat";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 341);
            this.dataGridView1.TabIndex = 25;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(89, 111);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(101, 20);
            this.txtDelete.TabIndex = 24;
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.Location = new System.Drawing.Point(260, 108);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(271, 20);
            this.dateTimeBirthday.TabIndex = 23;
            // 
            // txtGetCustomerById
            // 
            this.txtGetCustomerById.Location = new System.Drawing.Point(89, 29);
            this.txtGetCustomerById.Name = "txtGetCustomerById";
            this.txtGetCustomerById.Size = new System.Drawing.Size(101, 20);
            this.txtGetCustomerById.TabIndex = 22;
            // 
            // btnGetCustomerById
            // 
            this.btnGetCustomerById.Location = new System.Drawing.Point(89, 55);
            this.btnGetCustomerById.Name = "btnGetCustomerById";
            this.btnGetCustomerById.Size = new System.Drawing.Size(75, 23);
            this.btnGetCustomerById.TabIndex = 21;
            this.btnGetCustomerById.Text = "Get ID";
            this.btnGetCustomerById.UseVisualStyleBackColor = true;
            this.btnGetCustomerById.Click += new System.EventHandler(this.btnGetCustomerById_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Yenilə";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGetAllCustomer
            // 
            this.btnGetAllCustomer.Location = new System.Drawing.Point(435, 163);
            this.btnGetAllCustomer.Name = "btnGetAllCustomer";
            this.btnGetAllCustomer.Size = new System.Drawing.Size(146, 23);
            this.btnGetAllCustomer.TabIndex = 18;
            this.btnGetAllCustomer.Text = "Bütün Müştərilər";
            this.btnGetAllCustomer.UseVisualStyleBackColor = true;
            this.btnGetAllCustomer.Click += new System.EventHandler(this.btnGetAllCustomer_Click);
            // 
            // txtSureName
            // 
            this.txtSureName.Location = new System.Drawing.Point(260, 82);
            this.txtSureName.Name = "txtSureName";
            this.txtSureName.Size = new System.Drawing.Size(271, 20);
            this.txtSureName.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(260, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(260, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(271, 20);
            this.txtId.TabIndex = 15;
            // 
            // AdoClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.dateTimeBirthday);
            this.Controls.Add(this.txtGetCustomerById);
            this.Controls.Add(this.btnGetCustomerById);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGetAllCustomer);
            this.Controls.Add(this.txtSureName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "AdoClient";
            this.Text = "AdoClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.DateTimePicker dateTimeBirthday;
        private System.Windows.Forms.TextBox txtGetCustomerById;
        private System.Windows.Forms.Button btnGetCustomerById;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGetAllCustomer;
        private System.Windows.Forms.TextBox txtSureName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
    }
}