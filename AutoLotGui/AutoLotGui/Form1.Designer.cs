namespace AutoLotGui
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
            this.lvMain = new System.Windows.Forms.ListView();
            this.btnGetTable = new System.Windows.Forms.Button();
            this.btnOpenCon = new System.Windows.Forms.Button();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.btnCloseCon = new System.Windows.Forms.Button();
            this.btnConState = new System.Windows.Forms.Button();
            this.txtInsertMake = new System.Windows.Forms.TextBox();
            this.txtInsertColor = new System.Windows.Forms.TextBox();
            this.lbInsertMake = new System.Windows.Forms.Label();
            this.lbInsertColor = new System.Windows.Forms.Label();
            this.lbInsertPetName = new System.Windows.Forms.Label();
            this.txtInsertPetName = new System.Windows.Forms.TextBox();
            this.btnInsertAuto = new System.Windows.Forms.Button();
            this.numRemoveId = new System.Windows.Forms.NumericUpDown();
            this.lbRemoveId = new System.Windows.Forms.Label();
            this.btnRemoveAuto = new System.Windows.Forms.Button();
            this.txtUpdPetId = new System.Windows.Forms.TextBox();
            this.lbUpdPetNew = new System.Windows.Forms.Label();
            this.lbUpdPetId = new System.Windows.Forms.Label();
            this.numUpdPetId = new System.Windows.Forms.NumericUpDown();
            this.btnUpdPet = new System.Windows.Forms.Button();
            this.numShowPetId = new System.Windows.Forms.NumericUpDown();
            this.lbShowPetId = new System.Windows.Forms.Label();
            this.txtShowPetPName = new System.Windows.Forms.TextBox();
            this.btnShowPetName = new System.Windows.Forms.Button();
            this.lbShowPetPName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdPetId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShowPetId)).BeginInit();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.Location = new System.Drawing.Point(12, 12);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(279, 426);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            // 
            // btnGetTable
            // 
            this.btnGetTable.Location = new System.Drawing.Point(297, 83);
            this.btnGetTable.Name = "btnGetTable";
            this.btnGetTable.Size = new System.Drawing.Size(121, 23);
            this.btnGetTable.TabIndex = 1;
            this.btnGetTable.Text = "Get table";
            this.btnGetTable.UseVisualStyleBackColor = true;
            this.btnGetTable.Click += new System.EventHandler(this.btnGetInventory_Click);
            // 
            // btnOpenCon
            // 
            this.btnOpenCon.Location = new System.Drawing.Point(663, 384);
            this.btnOpenCon.Name = "btnOpenCon";
            this.btnOpenCon.Size = new System.Drawing.Size(125, 23);
            this.btnOpenCon.TabIndex = 2;
            this.btnOpenCon.Text = "Connect";
            this.btnOpenCon.UseVisualStyleBackColor = true;
            this.btnOpenCon.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(297, 12);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(121, 21);
            this.cbTables.TabIndex = 3;
            // 
            // btnCloseCon
            // 
            this.btnCloseCon.Location = new System.Drawing.Point(663, 415);
            this.btnCloseCon.Name = "btnCloseCon";
            this.btnCloseCon.Size = new System.Drawing.Size(125, 23);
            this.btnCloseCon.TabIndex = 4;
            this.btnCloseCon.Text = "Close connection";
            this.btnCloseCon.UseVisualStyleBackColor = true;
            this.btnCloseCon.Click += new System.EventHandler(this.btnCloseCon_Click);
            // 
            // btnConState
            // 
            this.btnConState.Location = new System.Drawing.Point(663, 355);
            this.btnConState.Name = "btnConState";
            this.btnConState.Size = new System.Drawing.Size(125, 23);
            this.btnConState.TabIndex = 5;
            this.btnConState.Text = "Connection state";
            this.btnConState.UseVisualStyleBackColor = true;
            this.btnConState.Click += new System.EventHandler(this.btnConState_Click);
            // 
            // txtInsertMake
            // 
            this.txtInsertMake.Location = new System.Drawing.Point(502, 13);
            this.txtInsertMake.Name = "txtInsertMake";
            this.txtInsertMake.Size = new System.Drawing.Size(100, 20);
            this.txtInsertMake.TabIndex = 6;
            this.txtInsertMake.TextChanged += new System.EventHandler(this.txtInsert_TextChanged);
            this.txtInsertMake.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsert_KeyPress);
            // 
            // txtInsertColor
            // 
            this.txtInsertColor.Location = new System.Drawing.Point(502, 35);
            this.txtInsertColor.Name = "txtInsertColor";
            this.txtInsertColor.Size = new System.Drawing.Size(100, 20);
            this.txtInsertColor.TabIndex = 7;
            this.txtInsertColor.TextChanged += new System.EventHandler(this.txtInsert_TextChanged);
            this.txtInsertColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsert_KeyPress);
            // 
            // lbInsertMake
            // 
            this.lbInsertMake.AutoSize = true;
            this.lbInsertMake.Location = new System.Drawing.Point(459, 16);
            this.lbInsertMake.Name = "lbInsertMake";
            this.lbInsertMake.Size = new System.Drawing.Size(37, 13);
            this.lbInsertMake.TabIndex = 8;
            this.lbInsertMake.Text = "Make:";
            // 
            // lbInsertColor
            // 
            this.lbInsertColor.AutoSize = true;
            this.lbInsertColor.Location = new System.Drawing.Point(462, 38);
            this.lbInsertColor.Name = "lbInsertColor";
            this.lbInsertColor.Size = new System.Drawing.Size(34, 13);
            this.lbInsertColor.TabIndex = 9;
            this.lbInsertColor.Text = "Color:";
            // 
            // lbInsertPetName
            // 
            this.lbInsertPetName.AutoSize = true;
            this.lbInsertPetName.Location = new System.Drawing.Point(442, 60);
            this.lbInsertPetName.Name = "lbInsertPetName";
            this.lbInsertPetName.Size = new System.Drawing.Size(54, 13);
            this.lbInsertPetName.TabIndex = 10;
            this.lbInsertPetName.Text = "PetName:";
            // 
            // txtInsertPetName
            // 
            this.txtInsertPetName.Location = new System.Drawing.Point(502, 57);
            this.txtInsertPetName.Name = "txtInsertPetName";
            this.txtInsertPetName.Size = new System.Drawing.Size(100, 20);
            this.txtInsertPetName.TabIndex = 11;
            this.txtInsertPetName.TextChanged += new System.EventHandler(this.txtInsert_TextChanged);
            this.txtInsertPetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsert_KeyPress);
            // 
            // btnInsertAuto
            // 
            this.btnInsertAuto.Enabled = false;
            this.btnInsertAuto.Location = new System.Drawing.Point(445, 83);
            this.btnInsertAuto.Name = "btnInsertAuto";
            this.btnInsertAuto.Size = new System.Drawing.Size(157, 23);
            this.btnInsertAuto.TabIndex = 12;
            this.btnInsertAuto.Text = "Insert new auto";
            this.btnInsertAuto.UseVisualStyleBackColor = true;
            this.btnInsertAuto.Click += new System.EventHandler(this.btnInsertAuto_Click);
            // 
            // numRemoveId
            // 
            this.numRemoveId.Location = new System.Drawing.Point(663, 16);
            this.numRemoveId.Name = "numRemoveId";
            this.numRemoveId.Size = new System.Drawing.Size(120, 20);
            this.numRemoveId.TabIndex = 13;
            // 
            // lbRemoveId
            // 
            this.lbRemoveId.AutoSize = true;
            this.lbRemoveId.Location = new System.Drawing.Point(622, 18);
            this.lbRemoveId.Name = "lbRemoveId";
            this.lbRemoveId.Size = new System.Drawing.Size(37, 13);
            this.lbRemoveId.TabIndex = 14;
            this.lbRemoveId.Text = "CarID:";
            // 
            // btnRemoveAuto
            // 
            this.btnRemoveAuto.Location = new System.Drawing.Point(625, 83);
            this.btnRemoveAuto.Name = "btnRemoveAuto";
            this.btnRemoveAuto.Size = new System.Drawing.Size(158, 23);
            this.btnRemoveAuto.TabIndex = 15;
            this.btnRemoveAuto.Text = "Remove auto";
            this.btnRemoveAuto.UseVisualStyleBackColor = true;
            this.btnRemoveAuto.Click += new System.EventHandler(this.btnRemoveAuto_Click);
            // 
            // txtUpdPetId
            // 
            this.txtUpdPetId.Location = new System.Drawing.Point(298, 176);
            this.txtUpdPetId.Name = "txtUpdPetId";
            this.txtUpdPetId.Size = new System.Drawing.Size(100, 20);
            this.txtUpdPetId.TabIndex = 17;
            this.txtUpdPetId.TextChanged += new System.EventHandler(this.txtUpdPetId_TextChanged);
            // 
            // lbUpdPetNew
            // 
            this.lbUpdPetNew.AutoSize = true;
            this.lbUpdPetNew.Location = new System.Drawing.Point(297, 160);
            this.lbUpdPetNew.Name = "lbUpdPetNew";
            this.lbUpdPetNew.Size = new System.Drawing.Size(79, 13);
            this.lbUpdPetNew.TabIndex = 19;
            this.lbUpdPetNew.Text = "New PetName:";
            // 
            // lbUpdPetId
            // 
            this.lbUpdPetId.AutoSize = true;
            this.lbUpdPetId.Location = new System.Drawing.Point(297, 118);
            this.lbUpdPetId.Name = "lbUpdPetId";
            this.lbUpdPetId.Size = new System.Drawing.Size(37, 13);
            this.lbUpdPetId.TabIndex = 18;
            this.lbUpdPetId.Text = "CarID:";
            // 
            // numUpdPetId
            // 
            this.numUpdPetId.Location = new System.Drawing.Point(298, 134);
            this.numUpdPetId.Name = "numUpdPetId";
            this.numUpdPetId.Size = new System.Drawing.Size(120, 20);
            this.numUpdPetId.TabIndex = 20;
            // 
            // btnUpdPet
            // 
            this.btnUpdPet.Location = new System.Drawing.Point(297, 202);
            this.btnUpdPet.Name = "btnUpdPet";
            this.btnUpdPet.Size = new System.Drawing.Size(121, 23);
            this.btnUpdPet.TabIndex = 21;
            this.btnUpdPet.Text = "Update";
            this.btnUpdPet.UseVisualStyleBackColor = true;
            this.btnUpdPet.Click += new System.EventHandler(this.btnUpdPet_Click);
            // 
            // numShowPetId
            // 
            this.numShowPetId.Location = new System.Drawing.Point(445, 134);
            this.numShowPetId.Name = "numShowPetId";
            this.numShowPetId.Size = new System.Drawing.Size(157, 20);
            this.numShowPetId.TabIndex = 23;
            // 
            // lbShowPetId
            // 
            this.lbShowPetId.AutoSize = true;
            this.lbShowPetId.Location = new System.Drawing.Point(442, 118);
            this.lbShowPetId.Name = "lbShowPetId";
            this.lbShowPetId.Size = new System.Drawing.Size(37, 13);
            this.lbShowPetId.TabIndex = 22;
            this.lbShowPetId.Text = "CarID:";
            // 
            // txtShowPetPName
            // 
            this.txtShowPetPName.Location = new System.Drawing.Point(445, 176);
            this.txtShowPetPName.Name = "txtShowPetPName";
            this.txtShowPetPName.ReadOnly = true;
            this.txtShowPetPName.Size = new System.Drawing.Size(157, 20);
            this.txtShowPetPName.TabIndex = 24;
            // 
            // btnShowPetName
            // 
            this.btnShowPetName.Location = new System.Drawing.Point(445, 202);
            this.btnShowPetName.Name = "btnShowPetName";
            this.btnShowPetName.Size = new System.Drawing.Size(157, 23);
            this.btnShowPetName.TabIndex = 25;
            this.btnShowPetName.Text = "Show Pet Name";
            this.btnShowPetName.UseVisualStyleBackColor = true;
            this.btnShowPetName.Click += new System.EventHandler(this.btnShowPetName_Click);
            // 
            // lbShowPetPName
            // 
            this.lbShowPetPName.AutoSize = true;
            this.lbShowPetPName.Location = new System.Drawing.Point(442, 160);
            this.lbShowPetPName.Name = "lbShowPetPName";
            this.lbShowPetPName.Size = new System.Drawing.Size(79, 13);
            this.lbShowPetPName.TabIndex = 26;
            this.lbShowPetPName.Text = "New PetName:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbShowPetPName);
            this.Controls.Add(this.btnShowPetName);
            this.Controls.Add(this.txtShowPetPName);
            this.Controls.Add(this.numShowPetId);
            this.Controls.Add(this.lbShowPetId);
            this.Controls.Add(this.btnUpdPet);
            this.Controls.Add(this.numUpdPetId);
            this.Controls.Add(this.lbUpdPetNew);
            this.Controls.Add(this.lbUpdPetId);
            this.Controls.Add(this.txtUpdPetId);
            this.Controls.Add(this.btnRemoveAuto);
            this.Controls.Add(this.lbRemoveId);
            this.Controls.Add(this.numRemoveId);
            this.Controls.Add(this.btnInsertAuto);
            this.Controls.Add(this.txtInsertPetName);
            this.Controls.Add(this.lbInsertPetName);
            this.Controls.Add(this.lbInsertColor);
            this.Controls.Add(this.lbInsertMake);
            this.Controls.Add(this.txtInsertColor);
            this.Controls.Add(this.txtInsertMake);
            this.Controls.Add(this.btnConState);
            this.Controls.Add(this.btnCloseCon);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.btnOpenCon);
            this.Controls.Add(this.btnGetTable);
            this.Controls.Add(this.lvMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numRemoveId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdPetId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShowPetId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.Button btnGetTable;
        private System.Windows.Forms.Button btnOpenCon;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Button btnCloseCon;
        private System.Windows.Forms.Button btnConState;
        private System.Windows.Forms.TextBox txtInsertMake;
        private System.Windows.Forms.TextBox txtInsertColor;
        private System.Windows.Forms.Label lbInsertMake;
        private System.Windows.Forms.Label lbInsertColor;
        private System.Windows.Forms.Label lbInsertPetName;
        private System.Windows.Forms.TextBox txtInsertPetName;
        private System.Windows.Forms.Button btnInsertAuto;
        private System.Windows.Forms.NumericUpDown numRemoveId;
        private System.Windows.Forms.Label lbRemoveId;
        private System.Windows.Forms.Button btnRemoveAuto;
        private System.Windows.Forms.TextBox txtUpdPetId;
        private System.Windows.Forms.Label lbUpdPetNew;
        private System.Windows.Forms.Label lbUpdPetId;
        private System.Windows.Forms.NumericUpDown numUpdPetId;
        private System.Windows.Forms.Button btnUpdPet;
        private System.Windows.Forms.NumericUpDown numShowPetId;
        private System.Windows.Forms.Label lbShowPetId;
        private System.Windows.Forms.TextBox txtShowPetPName;
        private System.Windows.Forms.Button btnShowPetName;
        private System.Windows.Forms.Label lbShowPetPName;
    }
}

