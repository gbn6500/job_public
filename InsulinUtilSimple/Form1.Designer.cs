namespace InsulinUtilSimple
{
    partial class theForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReserveTitle = new System.Windows.Forms.Label();
            this.btnDateUp = new System.Windows.Forms.Button();
            this.btnDateDn = new System.Windows.Forms.Button();
            this.btnWeekUp = new System.Windows.Forms.Button();
            this.btnWeekDn = new System.Windows.Forms.Button();
            this.edtReserveDate = new System.Windows.Forms.TextBox();
            this.edtWeeksToNext = new System.Windows.Forms.TextBox();
            this.edtAdditionalDays = new System.Windows.Forms.TextBox();
            this.lblSlap = new System.Windows.Forms.Label();
            this.btnSlapUp = new System.Windows.Forms.Button();
            this.btnSlapDn = new System.Windows.Forms.Button();
            this.edtSlaps = new System.Windows.Forms.TextBox();
            this.cmbInsulin0 = new System.Windows.Forms.ComboBox();
            this.cmbInsulin1 = new System.Windows.Forms.ComboBox();
            this.cmbInsulin2 = new System.Windows.Forms.ComboBox();
            this.edtHowToTake0 = new System.Windows.Forms.TextBox();
            this.edtHowToTake1 = new System.Windows.Forms.TextBox();
            this.edtHowToTake2 = new System.Windows.Forms.TextBox();
            this.lblNumUse = new System.Windows.Forms.Label();
            this.edtUse0 = new System.Windows.Forms.TextBox();
            this.edtUse1 = new System.Windows.Forms.TextBox();
            this.edtUse2 = new System.Windows.Forms.TextBox();
            this.edtuseRem0 = new System.Windows.Forms.TextBox();
            this.edtUseRem1 = new System.Windows.Forms.TextBox();
            this.edtUseRem2 = new System.Windows.Forms.TextBox();
            this.edtTimeTotal = new System.Windows.Forms.TextBox();
            this.edtUseNeedle = new System.Windows.Forms.TextBox();
            this.edtUseNeedleRem = new System.Windows.Forms.TextBox();
            this.lblUnitPerPen = new System.Windows.Forms.Label();
            this.lblInsulin0 = new System.Windows.Forms.Label();
            this.lblInsulin1 = new System.Windows.Forms.Label();
            this.lblInsulin2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReserveTitle
            // 
            this.lblReserveTitle.AutoSize = true;
            this.lblReserveTitle.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblReserveTitle.Location = new System.Drawing.Point(30, 30);
            this.lblReserveTitle.Name = "lblReserveTitle";
            this.lblReserveTitle.Size = new System.Drawing.Size(120, 21);
            this.lblReserveTitle.TabIndex = 0;
            this.lblReserveTitle.Text = "次回受診日";
            // 
            // btnDateUp
            // 
            this.btnDateUp.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDateUp.Location = new System.Drawing.Point(105, 81);
            this.btnDateUp.Name = "btnDateUp";
            this.btnDateUp.Size = new System.Drawing.Size(60, 25);
            this.btnDateUp.TabIndex = 1;
            this.btnDateUp.Text = "▲";
            this.btnDateUp.UseVisualStyleBackColor = true;
            this.btnDateUp.Click += new System.EventHandler(this.btnDateUp_Click);
            // 
            // btnDateDn
            // 
            this.btnDateDn.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDateDn.Location = new System.Drawing.Point(105, 157);
            this.btnDateDn.Name = "btnDateDn";
            this.btnDateDn.Size = new System.Drawing.Size(60, 25);
            this.btnDateDn.TabIndex = 2;
            this.btnDateDn.Text = "▼";
            this.btnDateDn.UseVisualStyleBackColor = true;
            this.btnDateDn.Click += new System.EventHandler(this.btnDateDn_Click);
            // 
            // btnWeekUp
            // 
            this.btnWeekUp.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWeekUp.Location = new System.Drawing.Point(245, 81);
            this.btnWeekUp.Name = "btnWeekUp";
            this.btnWeekUp.Size = new System.Drawing.Size(60, 25);
            this.btnWeekUp.TabIndex = 3;
            this.btnWeekUp.Text = "▲";
            this.btnWeekUp.UseVisualStyleBackColor = true;
            this.btnWeekUp.Click += new System.EventHandler(this.btnWeekUp_Click);
            // 
            // btnWeekDn
            // 
            this.btnWeekDn.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWeekDn.Location = new System.Drawing.Point(245, 157);
            this.btnWeekDn.Name = "btnWeekDn";
            this.btnWeekDn.Size = new System.Drawing.Size(60, 25);
            this.btnWeekDn.TabIndex = 4;
            this.btnWeekDn.Text = "▼";
            this.btnWeekDn.UseVisualStyleBackColor = true;
            this.btnWeekDn.Click += new System.EventHandler(this.btnWeekDn_Click);
            // 
            // edtReserveDate
            // 
            this.edtReserveDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtReserveDate.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtReserveDate.Location = new System.Drawing.Point(60, 121);
            this.edtReserveDate.Name = "edtReserveDate";
            this.edtReserveDate.ReadOnly = true;
            this.edtReserveDate.Size = new System.Drawing.Size(150, 21);
            this.edtReserveDate.TabIndex = 5;
            this.edtReserveDate.TabStop = false;
            this.edtReserveDate.Text = "12月23日（月）";
            this.edtReserveDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edtWeeksToNext
            // 
            this.edtWeeksToNext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtWeeksToNext.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtWeeksToNext.Location = new System.Drawing.Point(240, 121);
            this.edtWeeksToNext.Name = "edtWeeksToNext";
            this.edtWeeksToNext.ReadOnly = true;
            this.edtWeeksToNext.Size = new System.Drawing.Size(70, 21);
            this.edtWeeksToNext.TabIndex = 6;
            this.edtWeeksToNext.TabStop = false;
            this.edtWeeksToNext.Text = "12週後";
            this.edtWeeksToNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtAdditionalDays
            // 
            this.edtAdditionalDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtAdditionalDays.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtAdditionalDays.Location = new System.Drawing.Point(310, 121);
            this.edtAdditionalDays.Name = "edtAdditionalDays";
            this.edtAdditionalDays.ReadOnly = true;
            this.edtAdditionalDays.Size = new System.Drawing.Size(60, 21);
            this.edtAdditionalDays.TabIndex = 7;
            this.edtAdditionalDays.TabStop = false;
            this.edtAdditionalDays.Text = "6日後";
            // 
            // lblSlap
            // 
            this.lblSlap.AutoSize = true;
            this.lblSlap.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSlap.Location = new System.Drawing.Point(545, 56);
            this.lblSlap.Name = "lblSlap";
            this.lblSlap.Size = new System.Drawing.Size(73, 21);
            this.lblSlap.TabIndex = 8;
            this.lblSlap.Text = "空打ち";
            // 
            // btnSlapUp
            // 
            this.btnSlapUp.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSlapUp.Location = new System.Drawing.Point(504, 81);
            this.btnSlapUp.Name = "btnSlapUp";
            this.btnSlapUp.Size = new System.Drawing.Size(32, 25);
            this.btnSlapUp.TabIndex = 9;
            this.btnSlapUp.Text = "▲";
            this.btnSlapUp.UseVisualStyleBackColor = true;
            this.btnSlapUp.Click += new System.EventHandler(this.btnSlapUp_Click);
            // 
            // btnSlapDn
            // 
            this.btnSlapDn.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSlapDn.Location = new System.Drawing.Point(466, 81);
            this.btnSlapDn.Name = "btnSlapDn";
            this.btnSlapDn.Size = new System.Drawing.Size(32, 25);
            this.btnSlapDn.TabIndex = 10;
            this.btnSlapDn.Text = "▼";
            this.btnSlapDn.UseVisualStyleBackColor = true;
            this.btnSlapDn.Click += new System.EventHandler(this.btnSlapDn_Click);
            // 
            // edtSlaps
            // 
            this.edtSlaps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtSlaps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtSlaps.Location = new System.Drawing.Point(556, 83);
            this.edtSlaps.Name = "edtSlaps";
            this.edtSlaps.ReadOnly = true;
            this.edtSlaps.Size = new System.Drawing.Size(60, 21);
            this.edtSlaps.TabIndex = 11;
            this.edtSlaps.TabStop = false;
            this.edtSlaps.Text = "2単位";
            // 
            // cmbInsulin0
            // 
            this.cmbInsulin0.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbInsulin0.FormattingEnabled = true;
            this.cmbInsulin0.Items.AddRange(new object[] {
            "300",
            "450",
            "600"});
            this.cmbInsulin0.Location = new System.Drawing.Point(192, 263);
            this.cmbInsulin0.Name = "cmbInsulin0";
            this.cmbInsulin0.Size = new System.Drawing.Size(60, 29);
            this.cmbInsulin0.TabIndex = 12;
            this.cmbInsulin0.SelectedIndexChanged += new System.EventHandler(this.cmbInsulin0_SelectedIndexChanged);
            // 
            // cmbInsulin1
            // 
            this.cmbInsulin1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbInsulin1.FormattingEnabled = true;
            this.cmbInsulin1.Items.AddRange(new object[] {
            "300",
            "450",
            "600"});
            this.cmbInsulin1.Location = new System.Drawing.Point(192, 307);
            this.cmbInsulin1.Name = "cmbInsulin1";
            this.cmbInsulin1.Size = new System.Drawing.Size(60, 29);
            this.cmbInsulin1.TabIndex = 13;
            this.cmbInsulin1.SelectedIndexChanged += new System.EventHandler(this.cmbInsulin1_SelectedIndexChanged);
            // 
            // cmbInsulin2
            // 
            this.cmbInsulin2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbInsulin2.FormattingEnabled = true;
            this.cmbInsulin2.Items.AddRange(new object[] {
            "300",
            "450",
            "600"});
            this.cmbInsulin2.Location = new System.Drawing.Point(192, 351);
            this.cmbInsulin2.Name = "cmbInsulin2";
            this.cmbInsulin2.Size = new System.Drawing.Size(60, 29);
            this.cmbInsulin2.TabIndex = 14;
            this.cmbInsulin2.SelectedIndexChanged += new System.EventHandler(this.cmbInsulin2_SelectedIndexChanged);
            // 
            // edtHowToTake0
            // 
            this.edtHowToTake0.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtHowToTake0.Location = new System.Drawing.Point(267, 263);
            this.edtHowToTake0.Name = "edtHowToTake0";
            this.edtHowToTake0.Size = new System.Drawing.Size(106, 28);
            this.edtHowToTake0.TabIndex = 15;
            this.edtHowToTake0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtHowToTake0.TextChanged += new System.EventHandler(this.edtHowToTake0_TextChanged);
            // 
            // edtHowToTake1
            // 
            this.edtHowToTake1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtHowToTake1.Location = new System.Drawing.Point(267, 307);
            this.edtHowToTake1.Name = "edtHowToTake1";
            this.edtHowToTake1.Size = new System.Drawing.Size(106, 28);
            this.edtHowToTake1.TabIndex = 16;
            this.edtHowToTake1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtHowToTake1.TextChanged += new System.EventHandler(this.edtHowToTake1_TextChanged);
            // 
            // edtHowToTake2
            // 
            this.edtHowToTake2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtHowToTake2.Location = new System.Drawing.Point(267, 351);
            this.edtHowToTake2.Name = "edtHowToTake2";
            this.edtHowToTake2.Size = new System.Drawing.Size(106, 28);
            this.edtHowToTake2.TabIndex = 17;
            this.edtHowToTake2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtHowToTake2.TextChanged += new System.EventHandler(this.edtHowToTake2_TextChanged);
            // 
            // lblNumUse
            // 
            this.lblNumUse.AutoSize = true;
            this.lblNumUse.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNumUse.Location = new System.Drawing.Point(340, 227);
            this.lblNumUse.Name = "lblNumUse";
            this.lblNumUse.Size = new System.Drawing.Size(76, 21);
            this.lblNumUse.TabIndex = 18;
            this.lblNumUse.Text = "必要量";
            // 
            // edtUse0
            // 
            this.edtUse0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtUse0.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtUse0.Location = new System.Drawing.Point(403, 267);
            this.edtUse0.Name = "edtUse0";
            this.edtUse0.ReadOnly = true;
            this.edtUse0.Size = new System.Drawing.Size(60, 21);
            this.edtUse0.TabIndex = 19;
            this.edtUse0.TabStop = false;
            this.edtUse0.Text = "24 本";
            this.edtUse0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtUse1
            // 
            this.edtUse1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtUse1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtUse1.Location = new System.Drawing.Point(403, 311);
            this.edtUse1.Name = "edtUse1";
            this.edtUse1.ReadOnly = true;
            this.edtUse1.Size = new System.Drawing.Size(60, 21);
            this.edtUse1.TabIndex = 20;
            this.edtUse1.TabStop = false;
            this.edtUse1.Text = "本";
            this.edtUse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtUse2
            // 
            this.edtUse2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtUse2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtUse2.Location = new System.Drawing.Point(403, 355);
            this.edtUse2.Name = "edtUse2";
            this.edtUse2.ReadOnly = true;
            this.edtUse2.Size = new System.Drawing.Size(60, 21);
            this.edtUse2.TabIndex = 21;
            this.edtUse2.TabStop = false;
            this.edtUse2.Text = "本";
            this.edtUse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtuseRem0
            // 
            this.edtuseRem0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtuseRem0.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtuseRem0.Location = new System.Drawing.Point(478, 269);
            this.edtuseRem0.Name = "edtuseRem0";
            this.edtuseRem0.ReadOnly = true;
            this.edtuseRem0.Size = new System.Drawing.Size(140, 16);
            this.edtuseRem0.TabIndex = 22;
            this.edtuseRem0.TabStop = false;
            this.edtuseRem0.Text = "（2本 + 222単位）";
            // 
            // edtUseRem1
            // 
            this.edtUseRem1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtUseRem1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtUseRem1.Location = new System.Drawing.Point(478, 313);
            this.edtUseRem1.Name = "edtUseRem1";
            this.edtUseRem1.ReadOnly = true;
            this.edtUseRem1.Size = new System.Drawing.Size(140, 16);
            this.edtUseRem1.TabIndex = 23;
            this.edtUseRem1.TabStop = false;
            this.edtUseRem1.Text = "単位";
            // 
            // edtUseRem2
            // 
            this.edtUseRem2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtUseRem2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtUseRem2.Location = new System.Drawing.Point(478, 357);
            this.edtUseRem2.Name = "edtUseRem2";
            this.edtUseRem2.ReadOnly = true;
            this.edtUseRem2.Size = new System.Drawing.Size(140, 16);
            this.edtUseRem2.TabIndex = 24;
            this.edtUseRem2.TabStop = false;
            this.edtUseRem2.Text = "単位";
            // 
            // edtTimeTotal
            // 
            this.edtTimeTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtTimeTotal.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtTimeTotal.Location = new System.Drawing.Point(261, 395);
            this.edtTimeTotal.Name = "edtTimeTotal";
            this.edtTimeTotal.ReadOnly = true;
            this.edtTimeTotal.Size = new System.Drawing.Size(112, 21);
            this.edtTimeTotal.TabIndex = 25;
            this.edtTimeTotal.TabStop = false;
            this.edtTimeTotal.Text = "計 4回打ち";
            this.edtTimeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtUseNeedle
            // 
            this.edtUseNeedle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtUseNeedle.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtUseNeedle.Location = new System.Drawing.Point(403, 395);
            this.edtUseNeedle.Name = "edtUseNeedle";
            this.edtUseNeedle.ReadOnly = true;
            this.edtUseNeedle.Size = new System.Drawing.Size(60, 21);
            this.edtUseNeedle.TabIndex = 26;
            this.edtUseNeedle.TabStop = false;
            this.edtUseNeedle.Text = "23袋";
            this.edtUseNeedle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtUseNeedleRem
            // 
            this.edtUseNeedleRem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edtUseNeedleRem.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.edtUseNeedleRem.Location = new System.Drawing.Point(478, 397);
            this.edtUseNeedleRem.Name = "edtUseNeedleRem";
            this.edtUseNeedleRem.ReadOnly = true;
            this.edtUseNeedleRem.Size = new System.Drawing.Size(140, 16);
            this.edtUseNeedleRem.TabIndex = 27;
            this.edtUseNeedleRem.TabStop = false;
            this.edtUseNeedleRem.Text = "本";
            // 
            // lblUnitPerPen
            // 
            this.lblUnitPerPen.AutoSize = true;
            this.lblUnitPerPen.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUnitPerPen.Location = new System.Drawing.Point(173, 227);
            this.lblUnitPerPen.Name = "lblUnitPerPen";
            this.lblUnitPerPen.Size = new System.Drawing.Size(98, 21);
            this.lblUnitPerPen.TabIndex = 28;
            this.lblUnitPerPen.Text = "単位／本";
            // 
            // lblInsulin0
            // 
            this.lblInsulin0.AutoSize = true;
            this.lblInsulin0.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInsulin0.Location = new System.Drawing.Point(60, 267);
            this.lblInsulin0.Name = "lblInsulin0";
            this.lblInsulin0.Size = new System.Drawing.Size(117, 21);
            this.lblInsulin0.TabIndex = 29;
            this.lblInsulin0.Text = "インスリン１";
            // 
            // lblInsulin1
            // 
            this.lblInsulin1.AutoSize = true;
            this.lblInsulin1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInsulin1.Location = new System.Drawing.Point(60, 311);
            this.lblInsulin1.Name = "lblInsulin1";
            this.lblInsulin1.Size = new System.Drawing.Size(117, 21);
            this.lblInsulin1.TabIndex = 30;
            this.lblInsulin1.Text = "インスリン２";
            // 
            // lblInsulin2
            // 
            this.lblInsulin2.AutoSize = true;
            this.lblInsulin2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInsulin2.Location = new System.Drawing.Point(60, 355);
            this.lblInsulin2.Name = "lblInsulin2";
            this.lblInsulin2.Size = new System.Drawing.Size(117, 21);
            this.lblInsulin2.TabIndex = 31;
            this.lblInsulin2.Text = "インスリン３";
            // 
            // theForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 446);
            this.Controls.Add(this.lblInsulin2);
            this.Controls.Add(this.lblInsulin1);
            this.Controls.Add(this.lblInsulin0);
            this.Controls.Add(this.lblUnitPerPen);
            this.Controls.Add(this.edtUseNeedleRem);
            this.Controls.Add(this.edtUseNeedle);
            this.Controls.Add(this.edtTimeTotal);
            this.Controls.Add(this.edtUseRem2);
            this.Controls.Add(this.edtUseRem1);
            this.Controls.Add(this.edtuseRem0);
            this.Controls.Add(this.edtUse2);
            this.Controls.Add(this.edtUse1);
            this.Controls.Add(this.edtUse0);
            this.Controls.Add(this.lblNumUse);
            this.Controls.Add(this.edtHowToTake2);
            this.Controls.Add(this.edtHowToTake1);
            this.Controls.Add(this.edtHowToTake0);
            this.Controls.Add(this.cmbInsulin2);
            this.Controls.Add(this.cmbInsulin1);
            this.Controls.Add(this.cmbInsulin0);
            this.Controls.Add(this.edtSlaps);
            this.Controls.Add(this.btnSlapDn);
            this.Controls.Add(this.btnSlapUp);
            this.Controls.Add(this.lblSlap);
            this.Controls.Add(this.edtAdditionalDays);
            this.Controls.Add(this.edtWeeksToNext);
            this.Controls.Add(this.edtReserveDate);
            this.Controls.Add(this.btnWeekDn);
            this.Controls.Add(this.btnWeekUp);
            this.Controls.Add(this.btnDateDn);
            this.Controls.Add(this.btnDateUp);
            this.Controls.Add(this.lblReserveTitle);
            this.Name = "theForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.theForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReserveTitle;
        private System.Windows.Forms.Button btnDateUp;
        private System.Windows.Forms.Button btnDateDn;
        private System.Windows.Forms.Button btnWeekUp;
        private System.Windows.Forms.Button btnWeekDn;
        private System.Windows.Forms.TextBox edtReserveDate;
        private System.Windows.Forms.TextBox edtWeeksToNext;
        private System.Windows.Forms.TextBox edtAdditionalDays;
        private System.Windows.Forms.Label lblSlap;
        private System.Windows.Forms.Button btnSlapUp;
        private System.Windows.Forms.Button btnSlapDn;
        private System.Windows.Forms.TextBox edtSlaps;
        private System.Windows.Forms.ComboBox cmbInsulin0;
        private System.Windows.Forms.ComboBox cmbInsulin1;
        private System.Windows.Forms.ComboBox cmbInsulin2;
        private System.Windows.Forms.TextBox edtHowToTake0;
        private System.Windows.Forms.TextBox edtHowToTake1;
        private System.Windows.Forms.TextBox edtHowToTake2;
        private System.Windows.Forms.Label lblNumUse;
        private System.Windows.Forms.TextBox edtUse0;
        private System.Windows.Forms.TextBox edtUse1;
        private System.Windows.Forms.TextBox edtUse2;
        private System.Windows.Forms.TextBox edtuseRem0;
        private System.Windows.Forms.TextBox edtUseRem1;
        private System.Windows.Forms.TextBox edtUseRem2;
        private System.Windows.Forms.TextBox edtTimeTotal;
        private System.Windows.Forms.TextBox edtUseNeedle;
        private System.Windows.Forms.TextBox edtUseNeedleRem;
        private System.Windows.Forms.Label lblUnitPerPen;
        private System.Windows.Forms.Label lblInsulin0;
        private System.Windows.Forms.Label lblInsulin1;
        private System.Windows.Forms.Label lblInsulin2;
    }
}

