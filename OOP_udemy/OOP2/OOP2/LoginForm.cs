using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP2.MemberFactory;

namespace OOP2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExecutionRadioButton_Click(object sender, EventArgs e)
        {
            // シルバー 0
            // ゴールド 20%
            // プラチナ 40%

            MemberKind memberKind = MemberKind.Silver;
            if (GoldRadioButton.Checked)
            {
                memberKind = MemberKind.Gold;
            }
            else if(PlatinumRadioButton.Checked)
            {
                memberKind = MemberKind.Platinum;
            }

            LoginInfo.Member = MemberFactory.Create(memberKind);

            using(var f = new Form1())
            {
                f.ShowDialog();
            }

        }
    }
}
