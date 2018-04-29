﻿namespace DroneApp
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStabe = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnGuid = new System.Windows.Forms.Button();
            this.btnLand = new System.Windows.Forms.Button();
            this.btnArm = new System.Windows.Forms.Button();
            this.btnGpsUpdate = new System.Windows.Forms.Button();
            this.btnGetArm = new System.Windows.Forms.Button();
            this.btnTakeOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(320, 554);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(326, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 1;
            this.map.MinZoom = 18;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(462, 530);
            this.map.TabIndex = 1;
            this.map.Zoom = 1D;
            // 
            // txtLat
            // 
            this.txtLat.Enabled = false;
            this.txtLat.Location = new System.Drawing.Point(13, 35);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(88, 20);
            this.txtLat.TabIndex = 2;
            this.txtLat.TextChanged += new System.EventHandler(this.txtLat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Long";
            // 
            // txtLong
            // 
            this.txtLong.Enabled = false;
            this.txtLong.Location = new System.Drawing.Point(118, 35);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(88, 20);
            this.txtLong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zoom";
            // 
            // txtZoom
            // 
            this.txtZoom.Location = new System.Drawing.Point(57, 94);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(100, 20);
            this.txtZoom.TabIndex = 7;
            this.txtZoom.Text = "15";
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(12, 268);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.ReadOnly = true;
            this.txtTerminal.Size = new System.Drawing.Size(202, 209);
            this.txtTerminal.TabIndex = 9;
            // 
            // btnTerminal
            // 
            this.btnTerminal.Location = new System.Drawing.Point(12, 519);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(75, 23);
            this.btnTerminal.TabIndex = 10;
            this.btnTerminal.Text = "Send";
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(70, 239);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(13, 484);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(201, 20);
            this.txtCommand.TabIndex = 14;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            // 
            // comboPorts
            // 
            this.comboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(12, 212);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(99, 21);
            this.comboPorts.TabIndex = 15;
            // 
            // comboBaud
            // 
            this.comboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Items.AddRange(new object[] {
            "9600"});
            this.comboBaud.Location = new System.Drawing.Point(118, 212);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(96, 21);
            this.comboBaud.TabIndex = 16;
            this.comboBaud.SelectedIndexChanged += new System.EventHandler(this.comboBaud_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Com Port";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Baud Rate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStabe
            // 
            this.btnStabe.Location = new System.Drawing.Point(230, 61);
            this.btnStabe.Name = "btnStabe";
            this.btnStabe.Size = new System.Drawing.Size(75, 23);
            this.btnStabe.TabIndex = 20;
            this.btnStabe.Text = "Stabilize";
            this.btnStabe.UseVisualStyleBackColor = true;
            this.btnStabe.Click += new System.EventHandler(this.btnStabe_Click);
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(230, 32);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(75, 23);
            this.btnMode.TabIndex = 21;
            this.btnMode.Text = "Get Mode";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnGuid
            // 
            this.btnGuid.Location = new System.Drawing.Point(230, 90);
            this.btnGuid.Name = "btnGuid";
            this.btnGuid.Size = new System.Drawing.Size(75, 23);
            this.btnGuid.TabIndex = 22;
            this.btnGuid.Text = "Guided";
            this.btnGuid.UseVisualStyleBackColor = true;
            this.btnGuid.Click += new System.EventHandler(this.btnGuid_Click);
            // 
            // btnLand
            // 
            this.btnLand.Location = new System.Drawing.Point(230, 119);
            this.btnLand.Name = "btnLand";
            this.btnLand.Size = new System.Drawing.Size(75, 23);
            this.btnLand.TabIndex = 23;
            this.btnLand.Text = "Land";
            this.btnLand.UseVisualStyleBackColor = true;
            this.btnLand.Click += new System.EventHandler(this.btnLand_Click);
            // 
            // btnArm
            // 
            this.btnArm.Location = new System.Drawing.Point(230, 227);
            this.btnArm.Name = "btnArm";
            this.btnArm.Size = new System.Drawing.Size(75, 23);
            this.btnArm.TabIndex = 24;
            this.btnArm.Text = "Arm";
            this.btnArm.UseVisualStyleBackColor = true;
            this.btnArm.Click += new System.EventHandler(this.btnArm_Click);
            // 
            // btnGpsUpdate
            // 
            this.btnGpsUpdate.Location = new System.Drawing.Point(230, 313);
            this.btnGpsUpdate.Name = "btnGpsUpdate";
            this.btnGpsUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnGpsUpdate.TabIndex = 25;
            this.btnGpsUpdate.Text = "GPS Update";
            this.btnGpsUpdate.UseVisualStyleBackColor = true;
            this.btnGpsUpdate.Click += new System.EventHandler(this.btnGpsUpdate_Click);
            // 
            // btnGetArm
            // 
            this.btnGetArm.Location = new System.Drawing.Point(230, 266);
            this.btnGetArm.Name = "btnGetArm";
            this.btnGetArm.Size = new System.Drawing.Size(75, 23);
            this.btnGetArm.TabIndex = 26;
            this.btnGetArm.Text = "Get Armed";
            this.btnGetArm.UseVisualStyleBackColor = true;
            this.btnGetArm.Click += new System.EventHandler(this.btnGetArm_Click);
            // 
            // btnTakeOff
            // 
            this.btnTakeOff.Location = new System.Drawing.Point(230, 171);
            this.btnTakeOff.Name = "btnTakeOff";
            this.btnTakeOff.Size = new System.Drawing.Size(75, 23);
            this.btnTakeOff.TabIndex = 27;
            this.btnTakeOff.Text = "Takeoff";
            this.btnTakeOff.UseVisualStyleBackColor = true;
            this.btnTakeOff.Click += new System.EventHandler(this.btnTakeOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.btnTakeOff);
            this.Controls.Add(this.btnGetArm);
            this.Controls.Add(this.btnGpsUpdate);
            this.Controls.Add(this.btnArm);
            this.Controls.Add(this.btnLand);
            this.Controls.Add(this.btnGuid);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnStabe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBaud);
            this.Controls.Add(this.comboPorts);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnTerminal);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtZoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZoom;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStabe;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnGuid;
        private System.Windows.Forms.Button btnLand;
        private System.Windows.Forms.Button btnArm;
        private System.Windows.Forms.Button btnGpsUpdate;
        private System.Windows.Forms.Button btnGetArm;
        private System.Windows.Forms.Button btnTakeOff;
    }
}

