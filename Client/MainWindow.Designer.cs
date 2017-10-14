namespace Client
{
    partial class MainWindow
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
            this.fbidInput = new System.Windows.Forms.TextBox();
            this.fbtokenInput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.injectDataGrid = new System.Windows.Forms.DataGridView();
            this.injectSearchInput = new System.Windows.Forms.TextBox();
            this.injectButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.summonButton = new System.Windows.Forms.Button();
            this.unitSearchInput = new System.Windows.Forms.TextBox();
            this.unitDataGrid = new System.Windows.Forms.DataGridView();
            this.donateButton = new System.Windows.Forms.Button();
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injectDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fbidInput
            // 
            this.fbidInput.Location = new System.Drawing.Point(13, 250);
            this.fbidInput.Name = "fbidInput";
            this.fbidInput.Size = new System.Drawing.Size(100, 20);
            this.fbidInput.TabIndex = 0;
            this.fbidInput.Text = "fb id";
            // 
            // fbtokenInput
            // 
            this.fbtokenInput.Location = new System.Drawing.Point(120, 250);
            this.fbtokenInput.Name = "fbtokenInput";
            this.fbtokenInput.Size = new System.Drawing.Size(100, 20);
            this.fbtokenInput.TabIndex = 1;
            this.fbtokenInput.Text = "fb token";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 231);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.injectDataGrid);
            this.tabPage1.Controls.Add(this.injectSearchInput);
            this.tabPage1.Controls.Add(this.injectButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Injection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // injectDataGrid
            // 
            this.injectDataGrid.AllowUserToAddRows = false;
            this.injectDataGrid.AllowUserToDeleteRows = false;
            this.injectDataGrid.AllowUserToResizeRows = false;
            this.injectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.injectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.injectDataGrid.Location = new System.Drawing.Point(3, 6);
            this.injectDataGrid.Name = "injectDataGrid";
            this.injectDataGrid.RowHeadersVisible = false;
            this.injectDataGrid.Size = new System.Drawing.Size(377, 165);
            this.injectDataGrid.TabIndex = 3;
            // 
            // injectSearchInput
            // 
            this.injectSearchInput.Location = new System.Drawing.Point(6, 178);
            this.injectSearchInput.Name = "injectSearchInput";
            this.injectSearchInput.Size = new System.Drawing.Size(100, 20);
            this.injectSearchInput.TabIndex = 2;
            this.injectSearchInput.Text = "search";
            this.injectSearchInput.TextChanged += new System.EventHandler(this.InjectSearchInput_TextChanged);
            // 
            // injectButton
            // 
            this.injectButton.Location = new System.Drawing.Point(296, 176);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(75, 23);
            this.injectButton.TabIndex = 1;
            this.injectButton.Text = "inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.summonButton);
            this.tabPage2.Controls.Add(this.unitSearchInput);
            this.tabPage2.Controls.Add(this.unitDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unit Hunter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // summonButton
            // 
            this.summonButton.Location = new System.Drawing.Point(250, 177);
            this.summonButton.Name = "summonButton";
            this.summonButton.Size = new System.Drawing.Size(127, 23);
            this.summonButton.TabIndex = 2;
            this.summonButton.Text = "summon highlighted";
            this.summonButton.UseVisualStyleBackColor = true;
            this.summonButton.Click += new System.EventHandler(this.SummonButton_Click);
            // 
            // unitSearchInput
            // 
            this.unitSearchInput.Location = new System.Drawing.Point(7, 179);
            this.unitSearchInput.Name = "unitSearchInput";
            this.unitSearchInput.Size = new System.Drawing.Size(100, 20);
            this.unitSearchInput.TabIndex = 1;
            this.unitSearchInput.Text = "search";
            this.unitSearchInput.TextChanged += new System.EventHandler(this.UnitSearchInput_TextChanged);
            // 
            // unitDataGrid
            // 
            this.unitDataGrid.AllowUserToAddRows = false;
            this.unitDataGrid.AllowUserToDeleteRows = false;
            this.unitDataGrid.AllowUserToResizeRows = false;
            this.unitDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unitDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitDataGrid.Location = new System.Drawing.Point(7, 7);
            this.unitDataGrid.Name = "unitDataGrid";
            this.unitDataGrid.RowHeadersVisible = false;
            this.unitDataGrid.Size = new System.Drawing.Size(370, 166);
            this.unitDataGrid.TabIndex = 0;
            // 
            // donateButton
            // 
            this.donateButton.Location = new System.Drawing.Point(325, 250);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(75, 23);
            this.donateButton.TabIndex = 3;
            this.donateButton.Text = "donate";
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // consoleLog
            // 
            this.consoleLog.Location = new System.Drawing.Point(13, 281);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ReadOnly = true;
            this.consoleLog.Size = new System.Drawing.Size(387, 245);
            this.consoleLog.TabIndex = 3;
            this.consoleLog.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 279);
            this.Controls.Add(this.consoleLog);
            this.Controls.Add(this.donateButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fbtokenInput);
            this.Controls.Add(this.fbidInput);
            this.Name = "MainWindow";
            this.Text = "Shalzuth\'s Brave Haxvius";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injectDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fbidInput;
        private System.Windows.Forms.TextBox fbtokenInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView injectDataGrid;
        private System.Windows.Forms.TextBox injectSearchInput;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button donateButton;
        private System.Windows.Forms.DataGridView unitDataGrid;
        private System.Windows.Forms.Button summonButton;
        private System.Windows.Forms.TextBox unitSearchInput;
        private System.Windows.Forms.RichTextBox consoleLog;
    }
}

