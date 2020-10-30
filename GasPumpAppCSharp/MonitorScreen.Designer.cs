namespace GasPumpAppCSharp
{
    partial class MonitorScreen
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.touchScreenBtn = new System.Windows.Forms.Button();
            this.insertCardBtn = new System.Windows.Forms.Button();
            this.removeCardBtn = new System.Windows.Forms.Button();
            this.takeGoodPumpNozzleBtn = new System.Windows.Forms.Button();
            this.takeBadPumpNozzleBtn = new System.Windows.Forms.Button();
            this.pushTriggerBtn = new System.Windows.Forms.Button();
            this.releaseTriggerBtn = new System.Windows.Forms.Button();
            this.releasePumpNozzleBtn = new System.Windows.Forms.Button();
            this.takeTicketBtn = new System.Windows.Forms.Button();
            this.takePumpNozzleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // touchScreenBtn
            // 
            this.touchScreenBtn.Location = new System.Drawing.Point(0, 0);
            this.touchScreenBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.touchScreenBtn.Name = "touchScreenBtn";
            this.touchScreenBtn.Size = new System.Drawing.Size(153, 47);
            this.touchScreenBtn.TabIndex = 0;
            this.touchScreenBtn.Text = "Toucher écran";
            this.touchScreenBtn.UseVisualStyleBackColor = true;
            this.touchScreenBtn.Click += new System.EventHandler(this.ButtonMonitor_Click);
            // 
            // insertCardBtn
            // 
            this.insertCardBtn.Location = new System.Drawing.Point(0, 51);
            this.insertCardBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertCardBtn.Name = "insertCardBtn";
            this.insertCardBtn.Size = new System.Drawing.Size(153, 47);
            this.insertCardBtn.TabIndex = 1;
            this.insertCardBtn.Text = "Insérer carte";
            this.insertCardBtn.UseVisualStyleBackColor = true;
            this.insertCardBtn.Click += new System.EventHandler(this.ButtonMonitor_Click);
            // 
            // removeCardBtn
            // 
            this.removeCardBtn.Location = new System.Drawing.Point(0, 152);
            this.removeCardBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeCardBtn.Name = "removeCardBtn";
            this.removeCardBtn.Size = new System.Drawing.Size(153, 47);
            this.removeCardBtn.TabIndex = 3;
            this.removeCardBtn.Text = "Retirer carte";
            this.removeCardBtn.UseVisualStyleBackColor = true;
            this.removeCardBtn.Click += new System.EventHandler(this.ButtonMonitor_Click);
            // 
            // takeGoodPumpNozzleBtn
            // 
            this.takeGoodPumpNozzleBtn.Location = new System.Drawing.Point(0, 210);
            this.takeGoodPumpNozzleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.takeGoodPumpNozzleBtn.Name = "takeGoodPumpNozzleBtn";
            this.takeGoodPumpNozzleBtn.Size = new System.Drawing.Size(153, 47);
            this.takeGoodPumpNozzleBtn.TabIndex = 4;
            this.takeGoodPumpNozzleBtn.Text = "Prendre le bon pistolet";
            this.takeGoodPumpNozzleBtn.UseVisualStyleBackColor = true;
            this.takeGoodPumpNozzleBtn.Click += new System.EventHandler(this.ButtonMonitor_Click);
            // 
            // takeBadPumpNozzleBtn
            // 
            this.takeBadPumpNozzleBtn.Location = new System.Drawing.Point(249, 0);
            this.takeBadPumpNozzleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.takeBadPumpNozzleBtn.Name = "takeBadPumpNozzleBtn";
            this.takeBadPumpNozzleBtn.Size = new System.Drawing.Size(153, 47);
            this.takeBadPumpNozzleBtn.TabIndex = 5;
            this.takeBadPumpNozzleBtn.Text = "Prendre le mauvais pistolet";
            this.takeBadPumpNozzleBtn.UseVisualStyleBackColor = true;
            this.takeBadPumpNozzleBtn.Click += new System.EventHandler(this.ButtonMonitor_Click);
            // 
            // pushTriggerBtn
            // 
            this.pushTriggerBtn.Location = new System.Drawing.Point(239, 62);
            this.pushTriggerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pushTriggerBtn.Name = "pushTriggerBtn";
            this.pushTriggerBtn.Size = new System.Drawing.Size(153, 47);
            this.pushTriggerBtn.TabIndex = 6;
            this.pushTriggerBtn.Text = "Activer la gâchette";
            this.pushTriggerBtn.UseVisualStyleBackColor = true;
            this.pushTriggerBtn.Click += new System.EventHandler(this.ButtonFuel_Click);
            // 
            // releaseTriggerBtn
            // 
            this.releaseTriggerBtn.Location = new System.Drawing.Point(239, 120);
            this.releaseTriggerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.releaseTriggerBtn.Name = "releaseTriggerBtn";
            this.releaseTriggerBtn.Size = new System.Drawing.Size(153, 47);
            this.releaseTriggerBtn.TabIndex = 7;
            this.releaseTriggerBtn.Text = "Relâcher la gâchette";
            this.releaseTriggerBtn.UseVisualStyleBackColor = true;
            this.releaseTriggerBtn.Click += new System.EventHandler(this.ButtonFuel_Click);
            // 
            // releasePumpNozzleBtn
            // 
            this.releasePumpNozzleBtn.Location = new System.Drawing.Point(249, 181);
            this.releasePumpNozzleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.releasePumpNozzleBtn.Name = "releasePumpNozzleBtn";
            this.releasePumpNozzleBtn.Size = new System.Drawing.Size(153, 47);
            this.releasePumpNozzleBtn.TabIndex = 8;
            this.releasePumpNozzleBtn.Text = "Ranger le pistolet";
            this.releasePumpNozzleBtn.UseVisualStyleBackColor = true;
            this.releasePumpNozzleBtn.Click += new System.EventHandler(this.ButtonMonitor_Click);
            // 
            // takeTicketBtn
            // 
            this.takeTicketBtn.Location = new System.Drawing.Point(267, 238);
            this.takeTicketBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.takeTicketBtn.Name = "takeTicketBtn";
            this.takeTicketBtn.Size = new System.Drawing.Size(153, 47);
            this.takeTicketBtn.TabIndex = 9;
            this.takeTicketBtn.Text = "Prendre le ticket et duplicata";
            this.takeTicketBtn.UseVisualStyleBackColor = true;
            this.takeTicketBtn.Click += new System.EventHandler(this.ButtonMonitor_Click);
            // 
            // takePumpNozzleBtn
            // 
            this.takePumpNozzleBtn.Location = new System.Drawing.Point(0, 227);
            this.takePumpNozzleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.takePumpNozzleBtn.Name = "takePumpNozzleBtn";
            this.takePumpNozzleBtn.Size = new System.Drawing.Size(153, 47);
            this.takePumpNozzleBtn.TabIndex = 10;
            this.takePumpNozzleBtn.Text = "Prendre pistolet";
            this.takePumpNozzleBtn.UseVisualStyleBackColor = true;
            this.takePumpNozzleBtn.Click += new System.EventHandler(this.ButtonMonitor_Click);
            // 
            // MonitorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.takePumpNozzleBtn);
            this.Controls.Add(this.takeTicketBtn);
            this.Controls.Add(this.releasePumpNozzleBtn);
            this.Controls.Add(this.releaseTriggerBtn);
            this.Controls.Add(this.pushTriggerBtn);
            this.Controls.Add(this.takeBadPumpNozzleBtn);
            this.Controls.Add(this.takeGoodPumpNozzleBtn);
            this.Controls.Add(this.removeCardBtn);
            this.Controls.Add(this.insertCardBtn);
            this.Controls.Add(this.touchScreenBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MonitorScreen";
            this.Text = "Action";
            this.Load += new System.EventHandler(this.MonitorScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button touchScreenBtn;
        private System.Windows.Forms.Button insertCardBtn;
        private System.Windows.Forms.Button removeCardBtn;
        private System.Windows.Forms.Button takeGoodPumpNozzleBtn;
        private System.Windows.Forms.Button takeBadPumpNozzleBtn;
        private System.Windows.Forms.Button pushTriggerBtn;
        private System.Windows.Forms.Button releaseTriggerBtn;
        private System.Windows.Forms.Button releasePumpNozzleBtn;
        private System.Windows.Forms.Button takeTicketBtn;
        private System.Windows.Forms.Button takePumpNozzleBtn;
    }
}

