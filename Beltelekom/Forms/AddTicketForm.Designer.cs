namespace Beltelekom.Forms
{
    partial class AddTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTicketForm));
            this.dateService = new System.Windows.Forms.DateTimePicker();
            this.textFIOPerformer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFIOClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textContract = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateService
            // 
            this.dateService.Location = new System.Drawing.Point(171, 150);
            this.dateService.Name = "dateService";
            this.dateService.Size = new System.Drawing.Size(233, 20);
            this.dateService.TabIndex = 55;
            // 
            // textFIOPerformer
            // 
            this.textFIOPerformer.Location = new System.Drawing.Point(171, 216);
            this.textFIOPerformer.Name = "textFIOPerformer";
            this.textFIOPerformer.Size = new System.Drawing.Size(233, 20);
            this.textFIOPerformer.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "ФИО исполнителя";
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(171, 116);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(233, 21);
            this.comboService.TabIndex = 52;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Brown;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(38, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(366, 23);
            this.buttonAdd.TabIndex = 51;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Вид выполненных работ";
            // 
            // textFIOClient
            // 
            this.textFIOClient.Location = new System.Drawing.Point(171, 55);
            this.textFIOClient.Name = "textFIOClient";
            this.textFIOClient.Size = new System.Drawing.Size(233, 20);
            this.textFIOClient.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "ФИО клиента";
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(171, 250);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(233, 20);
            this.textSum.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Сумма к оплате";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Номер телефона";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(171, 86);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(233, 20);
            this.textPhone.TabIndex = 61;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(171, 183);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(233, 20);
            this.textAddress.TabIndex = 62;
            // 
            // textContract
            // 
            this.textContract.Location = new System.Drawing.Point(171, 21);
            this.textContract.Name = "textContract";
            this.textContract.Size = new System.Drawing.Size(233, 20);
            this.textContract.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Договор";
            // 
            // AddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(437, 328);
            this.Controls.Add(this.textContract);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateService);
            this.Controls.Add(this.textFIOPerformer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboService);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFIOClient);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTicketForm";
            this.Text = "Новая заявка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateService;
        private System.Windows.Forms.TextBox textFIOPerformer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFIOClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textContract;
        private System.Windows.Forms.Label label8;
    }
}