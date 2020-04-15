using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsulinUtilSimple
{
    public partial class theForm : Form
    {
        int slap;
        int spanToReserveDate;
        int[] perPen = new int[3] { 0, 0, 0 };
        DateTime today;

        private ComboBox[] cmbInsulinArray = new ComboBox[3];
        private TextBox[] edtHowToTakeArray = new TextBox[3];
        private TextBox[] edtUseArray = new TextBox[3];
        private TextBox[] edtUseRemArray = new TextBox[3];
        private Label[] lblInsulinArray = new Label[3];

        public theForm()
        {
            InitializeComponent();
        }

        private void ShowControls(int index, bool isVisible)
        {
            lblInsulinArray[index].Visible = isVisible;
            cmbInsulinArray[index].Visible = isVisible;
            edtUseArray[index].Visible = isVisible;
            edtUseRemArray[index].Visible = isVisible;
            edtHowToTakeArray[index].Visible = isVisible;
        }
        private void SetDate()
        {
            if (spanToReserveDate <= 0) spanToReserveDate = 1;
            DateTime reserveDate = today.AddDays(spanToReserveDate);
            edtReserveDate.Text = reserveDate.ToString("M月d日（ddd）");
            int week = spanToReserveDate / 7;
            int remain = spanToReserveDate % 7;
            if (remain == 0){
                edtWeeksToNext.Text = week.ToString() + "週後";
                edtAdditionalDays.Text = "";
            }else{
                edtWeeksToNext.Text = week.ToString() + "週＋";
                edtAdditionalDays.Text = remain.ToString() + "日後";
            }
        }
        private void SetSlap()
        {
            if (slap <= 0) slap = 0;
            if (slap >= 9) slap = 9;
            edtSlaps.Text = slap.ToString() + "単位";
        }
        private void Calc()
        {
            if (edtHowToTakeArray[0].Text != ""){
                ShowControls(1, true);
                if (edtHowToTakeArray[1].Text != ""){
                    ShowControls(2, true);
                } else {
                    ShowControls(2, false);
                }
            } else {
                ShowControls(1, false);
                ShowControls(2, false);
            }
            int timeTotal = 0;
            for (int i = 0; i < 3; ++i){
                int numTimes = 0, use = 0;
                string s = edtHowToTakeArray[i].Text;
                if (s != ""){
//                    ShowControls(i, true);
                    string[] splited = s.Split('-');
                    numTimes = splited.Length;
                    for (int j = 0; j < numTimes; ++j){
                        int n;
                        int.TryParse(splited[j],out n);
                        if (n == 0) { use = 0; numTimes = 0; break; } // 数値を含まない、または""の場合
                        use += n + slap;
                    }
                }
//                else{
//                    if (i != 0) ShowControls(i, false);
//                }

                timeTotal += numTimes;
                use *= spanToReserveDate;
                if (perPen[i] == 0) { edtUseArray[i].Text = "div by 0"; continue; }
                int necessary = use / perPen[i];
                if ((use % perPen[i]) == 0){
                    edtUseArray[i].Text = necessary.ToString() + "本";
                    edtUseRemArray[i].Text = "";
                }else{
                    int diff = use - necessary * perPen[i];
                    edtUseRemArray[i].Text = "（" + necessary.ToString() + "本 + " + diff + "単位）";
                    ++necessary;
                    edtUseArray[i].Text = necessary.ToString() + "本";
                }

                edtTimeTotal.Text = "計 " + timeTotal.ToString() + "回打ち";
                int useNeedleTotal = timeTotal * spanToReserveDate;
                int necessNeedle = useNeedleTotal / 14;
                if ((useNeedleTotal % 14) == 0){
                    edtUseNeedle.Text = necessNeedle.ToString() + "袋";
                    edtUseNeedleRem.Text = "";
                }else{
                    int diff = useNeedleTotal - necessNeedle * 14;
                    edtUseNeedleRem.Text = "（" + necessNeedle.ToString() + "袋 + " + diff + "本）";
                    ++necessNeedle;
                    edtUseNeedle.Text = necessNeedle.ToString() + "袋";
                }
            }
        }

        private void theForm_Load(object sender, EventArgs e)
        {
            this.Text = "インスリンと針　必要数";

            // コントロールを配列で管理
            cmbInsulinArray[0] = cmbInsulin0; cmbInsulinArray[1] = cmbInsulin1; cmbInsulinArray[2] = cmbInsulin2;
            edtHowToTakeArray[0] = edtHowToTake0; edtHowToTakeArray[1] = edtHowToTake1; edtHowToTakeArray[2] = edtHowToTake2;
            edtUseArray[0] = edtUse0; edtUseArray[1] = edtUse1; edtUseArray[2] = edtUse2;
            edtUseRemArray[0] = edtuseRem0; edtUseRemArray[1] = edtUseRem1; edtUseRemArray[2] = edtUseRem2;
            lblInsulinArray[0] = lblInsulin0; lblInsulinArray[1] = lblInsulin1; lblInsulinArray[2] = lblInsulin2;

            // コンボボックスの設定
            for (int i = 0; i < 3; ++i){
                cmbInsulinArray[i].SelectedIndex = 0;
                perPen[i] = int.Parse(cmbInsulinArray[i].SelectedItem.ToString());
            }

            // 空打ち:初期値は2
            slap = 2; SetSlap();

            // 次回予約日までの日数：初期値は28
            spanToReserveDate = 28;
            today = DateTime.Today;
            SetDate();

            this.ActiveControl = this.edtHowToTake0;

            Calc();
        }

        // 日付の変更
        private void btnDateUp_Click(object sender, EventArgs e)
        {
            ++spanToReserveDate; SetDate();
            Calc();
        }
        private void btnDateDn_Click(object sender, EventArgs e)
        {
            ++spanToReserveDate; SetDate();
            Calc();
        }
        private void btnWeekUp_Click(object sender, EventArgs e)
        {
            spanToReserveDate += 7; SetDate();
            Calc();
        }
        private void btnWeekDn_Click(object sender, EventArgs e)
        {
            spanToReserveDate -= 7; SetDate();
            Calc();
        }

        // 空打ちの変更
        private void btnSlapUp_Click(object sender, EventArgs e)
        {
            ++slap; SetSlap();
        }
        private void btnSlapDn_Click(object sender, EventArgs e)
        {
            --slap; SetSlap();
        }

        // １本あたりインスリン量の変更
        private void cmbInsulin0_SelectedIndexChanged(object sender, EventArgs e)
        {
            perPen[0] = int.Parse(cmbInsulinArray[0].SelectedItem.ToString());
            Calc();
        }
        private void cmbInsulin1_SelectedIndexChanged(object sender, EventArgs e)
        {
            perPen[1] = int.Parse(cmbInsulinArray[1].SelectedItem.ToString());
            Calc();
        }
        private void cmbInsulin2_SelectedIndexChanged(object sender, EventArgs e)
        {
            perPen[2] = int.Parse(cmbInsulinArray[2].SelectedItem.ToString());
            Calc();
        }

        // 使用方法変更
        private void edtHowToTake0_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }
        private void edtHowToTake1_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }
        private void edtHowToTake2_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}
