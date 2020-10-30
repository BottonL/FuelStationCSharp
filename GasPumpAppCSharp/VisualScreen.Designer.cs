namespace GasPumpAppCSharp
{
    partial class VisualScreen
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
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.removeCardPanel = new System.Windows.Forms.Panel();
            this.removeCardLabel = new System.Windows.Forms.Label();
            this.insertCardPanel = new System.Windows.Forms.Panel();
            this.insertCardLabel = new System.Windows.Forms.Label();
            this.tapPinCodePanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancelPinCodeBtn = new System.Windows.Forms.Button();
            this.validatePinCodeBtn = new System.Windows.Forms.Button();
            this.tapPinCodeLabel = new System.Windows.Forms.Label();
            this.fuelPanel = new System.Windows.Forms.Panel();
            this.sansPlomb98Btn = new System.Windows.Forms.Button();
            this.gplBtn = new System.Windows.Forms.Button();
            this.sansPlomb95E10Btn = new System.Windows.Forms.Button();
            this.gazoleBtn = new System.Windows.Forms.Button();
            this.sansPlomb95Btn = new System.Windows.Forms.Button();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.noTicketBtn = new System.Windows.Forms.Button();
            this.ticketDuplicataBtn = new System.Windows.Forms.Button();
            this.ticketBtn = new System.Windows.Forms.Button();
            this.usePanel = new System.Windows.Forms.Panel();
            this.useLabel = new System.Windows.Forms.Label();
            this.deliveryPanel = new System.Windows.Forms.Panel();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.thanksPanel = new System.Windows.Forms.Panel();
            this.thanksLabel = new System.Windows.Forms.Label();
            this.screenLabel = new System.Windows.Forms.Label();
            this.pumpNozzleWithoutFuelChoicePanel = new System.Windows.Forms.Panel();
            this.pumpNozzleWithoutFuelChoiceLabel = new System.Windows.Forms.Label();
            this.falseCodePinCardLabel = new System.Windows.Forms.Label();
            this.takeTicketPanel = new System.Windows.Forms.Panel();
            this.takeTicketLabel = new System.Windows.Forms.Label();
            this.boardPinCode1 = new GasPumpAppCSharp.boardPinCode();
            this.welcomePanel.SuspendLayout();
            this.removeCardPanel.SuspendLayout();
            this.insertCardPanel.SuspendLayout();
            this.tapPinCodePanel.SuspendLayout();
            this.fuelPanel.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            this.usePanel.SuspendLayout();
            this.deliveryPanel.SuspendLayout();
            this.thanksPanel.SuspendLayout();
            this.pumpNozzleWithoutFuelChoicePanel.SuspendLayout();
            this.takeTicketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.welcomePanel.Controls.Add(this.welcomeLabel);
            this.welcomePanel.Location = new System.Drawing.Point(5, 4);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(18, 18);
            this.welcomePanel.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(232, 133);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(61, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Bienvenue ";
            // 
            // removeCardPanel
            // 
            this.removeCardPanel.Controls.Add(this.removeCardLabel);
            this.removeCardPanel.Location = new System.Drawing.Point(27, 4);
            this.removeCardPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeCardPanel.Name = "removeCardPanel";
            this.removeCardPanel.Size = new System.Drawing.Size(19, 20);
            this.removeCardPanel.TabIndex = 3;
            // 
            // removeCardLabel
            // 
            this.removeCardLabel.AutoSize = true;
            this.removeCardLabel.Location = new System.Drawing.Point(289, 97);
            this.removeCardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.removeCardLabel.Name = "removeCardLabel";
            this.removeCardLabel.Size = new System.Drawing.Size(126, 13);
            this.removeCardLabel.TabIndex = 0;
            this.removeCardLabel.Text = "Veuillez retirer votre carte";
            // 
            // insertCardPanel
            // 
            this.insertCardPanel.Controls.Add(this.insertCardLabel);
            this.insertCardPanel.Location = new System.Drawing.Point(49, 4);
            this.insertCardPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertCardPanel.Name = "insertCardPanel";
            this.insertCardPanel.Size = new System.Drawing.Size(19, 18);
            this.insertCardPanel.TabIndex = 1;
            // 
            // insertCardLabel
            // 
            this.insertCardLabel.AutoSize = true;
            this.insertCardLabel.Location = new System.Drawing.Point(242, 120);
            this.insertCardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insertCardLabel.Name = "insertCardLabel";
            this.insertCardLabel.Size = new System.Drawing.Size(93, 13);
            this.insertCardLabel.TabIndex = 0;
            this.insertCardLabel.Text = "Insérer votre carte";
            // 
            // tapPinCodePanel
            // 
            this.tapPinCodePanel.Controls.Add(this.falseCodePinCardLabel);
            this.tapPinCodePanel.Controls.Add(this.textBox1);
            this.tapPinCodePanel.Controls.Add(this.boardPinCode1);
            this.tapPinCodePanel.Controls.Add(this.cancelPinCodeBtn);
            this.tapPinCodePanel.Controls.Add(this.validatePinCodeBtn);
            this.tapPinCodePanel.Controls.Add(this.tapPinCodeLabel);
            this.tapPinCodePanel.Location = new System.Drawing.Point(27, 28);
            this.tapPinCodePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tapPinCodePanel.Name = "tapPinCodePanel";
            this.tapPinCodePanel.Size = new System.Drawing.Size(464, 277);
            this.tapPinCodePanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(322, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 5;
            // 
            // cancelPinCodeBtn
            // 
            this.cancelPinCodeBtn.Location = new System.Drawing.Point(234, 213);
            this.cancelPinCodeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelPinCodeBtn.Name = "cancelPinCodeBtn";
            this.cancelPinCodeBtn.Size = new System.Drawing.Size(50, 30);
            this.cancelPinCodeBtn.TabIndex = 2;
            this.cancelPinCodeBtn.Text = "Annuler";
            this.cancelPinCodeBtn.UseVisualStyleBackColor = true;
            this.cancelPinCodeBtn.Click += new System.EventHandler(this.CancelPinCodeBtn_Click);
            // 
            // validatePinCodeBtn
            // 
            this.validatePinCodeBtn.Location = new System.Drawing.Point(323, 213);
            this.validatePinCodeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.validatePinCodeBtn.Name = "validatePinCodeBtn";
            this.validatePinCodeBtn.Size = new System.Drawing.Size(66, 30);
            this.validatePinCodeBtn.TabIndex = 1;
            this.validatePinCodeBtn.Text = "Confirmer";
            this.validatePinCodeBtn.UseVisualStyleBackColor = true;
            this.validatePinCodeBtn.Click += new System.EventHandler(this.ValidatePinCodeBtn_Click);
            // 
            // tapPinCodeLabel
            // 
            this.tapPinCodeLabel.AutoSize = true;
            this.tapPinCodeLabel.Location = new System.Drawing.Point(196, 32);
            this.tapPinCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tapPinCodeLabel.Name = "tapPinCodeLabel";
            this.tapPinCodeLabel.Size = new System.Drawing.Size(92, 13);
            this.tapPinCodeLabel.TabIndex = 0;
            this.tapPinCodeLabel.Text = "Taper votre code ";
            // 
            // fuelPanel
            // 
            this.fuelPanel.Controls.Add(this.sansPlomb98Btn);
            this.fuelPanel.Controls.Add(this.gplBtn);
            this.fuelPanel.Controls.Add(this.sansPlomb95E10Btn);
            this.fuelPanel.Controls.Add(this.gazoleBtn);
            this.fuelPanel.Controls.Add(this.sansPlomb95Btn);
            this.fuelPanel.Location = new System.Drawing.Point(72, 4);
            this.fuelPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fuelPanel.Name = "fuelPanel";
            this.fuelPanel.Size = new System.Drawing.Size(19, 18);
            this.fuelPanel.TabIndex = 4;
            // 
            // sansPlomb98Btn
            // 
            this.sansPlomb98Btn.Location = new System.Drawing.Point(323, 14);
            this.sansPlomb98Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sansPlomb98Btn.Name = "sansPlomb98Btn";
            this.sansPlomb98Btn.Size = new System.Drawing.Size(83, 38);
            this.sansPlomb98Btn.TabIndex = 4;
            this.sansPlomb98Btn.Text = "SP 98";
            this.sansPlomb98Btn.UseVisualStyleBackColor = true;
            this.sansPlomb98Btn.Click += new System.EventHandler(this.ButtonChoiceFuel_Click);
            // 
            // gplBtn
            // 
            this.gplBtn.Location = new System.Drawing.Point(178, 79);
            this.gplBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gplBtn.Name = "gplBtn";
            this.gplBtn.Size = new System.Drawing.Size(83, 38);
            this.gplBtn.TabIndex = 3;
            this.gplBtn.Text = "GPL";
            this.gplBtn.UseVisualStyleBackColor = true;
            this.gplBtn.Click += new System.EventHandler(this.ButtonChoiceFuel_Click);
            // 
            // sansPlomb95E10Btn
            // 
            this.sansPlomb95E10Btn.Location = new System.Drawing.Point(178, 14);
            this.sansPlomb95E10Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sansPlomb95E10Btn.Name = "sansPlomb95E10Btn";
            this.sansPlomb95E10Btn.Size = new System.Drawing.Size(83, 38);
            this.sansPlomb95E10Btn.TabIndex = 2;
            this.sansPlomb95E10Btn.Text = "SP 95-E10";
            this.sansPlomb95E10Btn.UseVisualStyleBackColor = true;
            this.sansPlomb95E10Btn.Click += new System.EventHandler(this.ButtonChoiceFuel_Click);
            // 
            // gazoleBtn
            // 
            this.gazoleBtn.Location = new System.Drawing.Point(34, 77);
            this.gazoleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gazoleBtn.Name = "gazoleBtn";
            this.gazoleBtn.Size = new System.Drawing.Size(83, 38);
            this.gazoleBtn.TabIndex = 1;
            this.gazoleBtn.Text = "Gazole";
            this.gazoleBtn.UseVisualStyleBackColor = true;
            this.gazoleBtn.Click += new System.EventHandler(this.ButtonChoiceFuel_Click);
            // 
            // sansPlomb95Btn
            // 
            this.sansPlomb95Btn.Location = new System.Drawing.Point(34, 14);
            this.sansPlomb95Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sansPlomb95Btn.Name = "sansPlomb95Btn";
            this.sansPlomb95Btn.Size = new System.Drawing.Size(83, 38);
            this.sansPlomb95Btn.TabIndex = 0;
            this.sansPlomb95Btn.Text = "SP 95";
            this.sansPlomb95Btn.UseVisualStyleBackColor = true;
            this.sansPlomb95Btn.Click += new System.EventHandler(this.ButtonChoiceFuel_Click);
            // 
            // ticketPanel
            // 
            this.ticketPanel.Controls.Add(this.noTicketBtn);
            this.ticketPanel.Controls.Add(this.ticketDuplicataBtn);
            this.ticketPanel.Controls.Add(this.ticketBtn);
            this.ticketPanel.Location = new System.Drawing.Point(99, 4);
            this.ticketPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(19, 20);
            this.ticketPanel.TabIndex = 5;
            // 
            // noTicketBtn
            // 
            this.noTicketBtn.Location = new System.Drawing.Point(143, 182);
            this.noTicketBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noTicketBtn.Name = "noTicketBtn";
            this.noTicketBtn.Size = new System.Drawing.Size(218, 79);
            this.noTicketBtn.TabIndex = 2;
            this.noTicketBtn.Text = "Pas de ticket";
            this.noTicketBtn.UseVisualStyleBackColor = true;
            this.noTicketBtn.Click += new System.EventHandler(this.TicketOption_Click);
            // 
            // ticketDuplicataBtn
            // 
            this.ticketDuplicataBtn.Location = new System.Drawing.Point(145, 99);
            this.ticketDuplicataBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketDuplicataBtn.Name = "ticketDuplicataBtn";
            this.ticketDuplicataBtn.Size = new System.Drawing.Size(218, 79);
            this.ticketDuplicataBtn.TabIndex = 1;
            this.ticketDuplicataBtn.Text = "Ticket et duplicata";
            this.ticketDuplicataBtn.UseVisualStyleBackColor = true;
            this.ticketDuplicataBtn.Click += new System.EventHandler(this.TicketOption_Click);
            // 
            // ticketBtn
            // 
            this.ticketBtn.Location = new System.Drawing.Point(150, 14);
            this.ticketBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketBtn.Name = "ticketBtn";
            this.ticketBtn.Size = new System.Drawing.Size(218, 79);
            this.ticketBtn.TabIndex = 0;
            this.ticketBtn.Text = "Ticket";
            this.ticketBtn.UseVisualStyleBackColor = true;
            this.ticketBtn.Click += new System.EventHandler(this.TicketOption_Click);
            // 
            // usePanel
            // 
            this.usePanel.Controls.Add(this.useLabel);
            this.usePanel.Location = new System.Drawing.Point(122, 4);
            this.usePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usePanel.Name = "usePanel";
            this.usePanel.Size = new System.Drawing.Size(22, 18);
            this.usePanel.TabIndex = 3;
            // 
            // useLabel
            // 
            this.useLabel.AutoSize = true;
            this.useLabel.Location = new System.Drawing.Point(186, 90);
            this.useLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.useLabel.Name = "useLabel";
            this.useLabel.Size = new System.Drawing.Size(72, 13);
            this.useLabel.TabIndex = 0;
            this.useLabel.Text = "Servez-vous !";
            // 
            // deliveryPanel
            // 
            this.deliveryPanel.Controls.Add(this.deliveryLabel);
            this.deliveryPanel.Location = new System.Drawing.Point(5, 26);
            this.deliveryPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deliveryPanel.Name = "deliveryPanel";
            this.deliveryPanel.Size = new System.Drawing.Size(14, 18);
            this.deliveryPanel.TabIndex = 1;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(175, 92);
            this.deliveryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(103, 13);
            this.deliveryLabel.TabIndex = 0;
            this.deliveryLabel.Text = "Distribution en cours";
            // 
            // thanksPanel
            // 
            this.thanksPanel.Controls.Add(this.thanksLabel);
            this.thanksPanel.Location = new System.Drawing.Point(148, 4);
            this.thanksPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thanksPanel.Name = "thanksPanel";
            this.thanksPanel.Size = new System.Drawing.Size(23, 20);
            this.thanksPanel.TabIndex = 1;
            // 
            // thanksLabel
            // 
            this.thanksLabel.AutoSize = true;
            this.thanksLabel.Location = new System.Drawing.Point(209, 77);
            this.thanksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thanksLabel.Name = "thanksLabel";
            this.thanksLabel.Size = new System.Drawing.Size(102, 13);
            this.thanksLabel.TabIndex = 0;
            this.thanksLabel.Text = "Merci de votre visite";
            // 
            // screenLabel
            // 
            this.screenLabel.AutoSize = true;
            this.screenLabel.Location = new System.Drawing.Point(169, 94);
            this.screenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(201, 13);
            this.screenLabel.TabIndex = 2;
            this.screenLabel.Text = "Pour commencer, veuillez toucher l\'écran";
            // 
            // pumpNozzleWithoutFuelChoicePanel
            // 
            this.pumpNozzleWithoutFuelChoicePanel.Controls.Add(this.pumpNozzleWithoutFuelChoiceLabel);
            this.pumpNozzleWithoutFuelChoicePanel.Location = new System.Drawing.Point(327, 14);
            this.pumpNozzleWithoutFuelChoicePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pumpNozzleWithoutFuelChoicePanel.Name = "pumpNozzleWithoutFuelChoicePanel";
            this.pumpNozzleWithoutFuelChoicePanel.Size = new System.Drawing.Size(203, 244);
            this.pumpNozzleWithoutFuelChoicePanel.TabIndex = 6;
            // 
            // pumpNozzleWithoutFuelChoiceLabel
            // 
            this.pumpNozzleWithoutFuelChoiceLabel.AutoSize = true;
            this.pumpNozzleWithoutFuelChoiceLabel.Location = new System.Drawing.Point(15, 82);
            this.pumpNozzleWithoutFuelChoiceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pumpNozzleWithoutFuelChoiceLabel.Name = "pumpNozzleWithoutFuelChoiceLabel";
            this.pumpNozzleWithoutFuelChoiceLabel.Size = new System.Drawing.Size(184, 13);
            this.pumpNozzleWithoutFuelChoiceLabel.TabIndex = 0;
            this.pumpNozzleWithoutFuelChoiceLabel.Text = "Veuillez d\'abord choisir votre essence";
            // 
            // falseCodePinCardLabel
            // 
            this.falseCodePinCardLabel.AutoSize = true;
            this.falseCodePinCardLabel.Location = new System.Drawing.Point(210, 143);
            this.falseCodePinCardLabel.Name = "falseCodePinCardLabel";
            this.falseCodePinCardLabel.Size = new System.Drawing.Size(58, 13);
            this.falseCodePinCardLabel.TabIndex = 6;
            this.falseCodePinCardLabel.Text = "Code faux.";
            // 
            // takeTicketPanel
            // 
            this.takeTicketPanel.Controls.Add(this.takeTicketLabel);
            this.takeTicketPanel.Location = new System.Drawing.Point(177, 4);
            this.takeTicketPanel.Name = "takeTicketPanel";
            this.takeTicketPanel.Size = new System.Drawing.Size(265, 217);
            this.takeTicketPanel.TabIndex = 7;
            // 
            // takeTicketLabel
            // 
            this.takeTicketLabel.AutoSize = true;
            this.takeTicketLabel.Location = new System.Drawing.Point(35, 79);
            this.takeTicketLabel.Name = "takeTicketLabel";
            this.takeTicketLabel.Size = new System.Drawing.Size(149, 13);
            this.takeTicketLabel.TabIndex = 0;
            this.takeTicketLabel.Text = "Merci de prendre votre ticket !";
            // 
            // boardPinCode1
            // 
            this.boardPinCode1.Location = new System.Drawing.Point(19, 23);
            this.boardPinCode1.Margin = new System.Windows.Forms.Padding(1);
            this.boardPinCode1.Name = "boardPinCode1";
            this.boardPinCode1.Size = new System.Drawing.Size(173, 220);
            this.boardPinCode1.TabIndex = 3;
            // 
            // VisualScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.takeTicketPanel);
            this.Controls.Add(this.pumpNozzleWithoutFuelChoicePanel);
            this.Controls.Add(this.thanksPanel);
            this.Controls.Add(this.tapPinCodePanel);
            this.Controls.Add(this.deliveryPanel);
            this.Controls.Add(this.usePanel);
            this.Controls.Add(this.fuelPanel);
            this.Controls.Add(this.insertCardPanel);
            this.Controls.Add(this.screenLabel);
            this.Controls.Add(this.removeCardPanel);
            this.Controls.Add(this.welcomePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VisualScreen";
            this.Text = "Screen";
            this.Load += new System.EventHandler(this.VisualScreen_Load);
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.removeCardPanel.ResumeLayout(false);
            this.removeCardPanel.PerformLayout();
            this.insertCardPanel.ResumeLayout(false);
            this.insertCardPanel.PerformLayout();
            this.tapPinCodePanel.ResumeLayout(false);
            this.tapPinCodePanel.PerformLayout();
            this.fuelPanel.ResumeLayout(false);
            this.ticketPanel.ResumeLayout(false);
            this.usePanel.ResumeLayout(false);
            this.usePanel.PerformLayout();
            this.deliveryPanel.ResumeLayout(false);
            this.deliveryPanel.PerformLayout();
            this.thanksPanel.ResumeLayout(false);
            this.thanksPanel.PerformLayout();
            this.pumpNozzleWithoutFuelChoicePanel.ResumeLayout(false);
            this.pumpNozzleWithoutFuelChoicePanel.PerformLayout();
            this.takeTicketPanel.ResumeLayout(false);
            this.takeTicketPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel insertCardPanel;
        private System.Windows.Forms.Label insertCardLabel;
        private System.Windows.Forms.Panel tapPinCodePanel;
        private System.Windows.Forms.Button cancelPinCodeBtn;
        private System.Windows.Forms.Button validatePinCodeBtn;
        private System.Windows.Forms.Label tapPinCodeLabel;
        private boardPinCode boardPinCode1;
        private System.Windows.Forms.Panel fuelPanel;
        private System.Windows.Forms.Panel ticketPanel;
        private System.Windows.Forms.Button noTicketBtn;
        private System.Windows.Forms.Button ticketDuplicataBtn;
        private System.Windows.Forms.Button ticketBtn;
        private System.Windows.Forms.Button sansPlomb98Btn;
        private System.Windows.Forms.Button gplBtn;
        private System.Windows.Forms.Button sansPlomb95E10Btn;
        private System.Windows.Forms.Button gazoleBtn;
        private System.Windows.Forms.Button sansPlomb95Btn;
        private System.Windows.Forms.Panel usePanel;
        private System.Windows.Forms.Panel deliveryPanel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Label useLabel;
        private System.Windows.Forms.Panel thanksPanel;
        private System.Windows.Forms.Label thanksLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.Panel removeCardPanel;
        private System.Windows.Forms.Label removeCardLabel;
        private System.Windows.Forms.Panel pumpNozzleWithoutFuelChoicePanel;
        private System.Windows.Forms.Label pumpNozzleWithoutFuelChoiceLabel;
        private System.Windows.Forms.Label falseCodePinCardLabel;
        private System.Windows.Forms.Panel takeTicketPanel;
        private System.Windows.Forms.Label takeTicketLabel;
    }
}