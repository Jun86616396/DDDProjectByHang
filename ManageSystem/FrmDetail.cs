using System.Windows.Forms;

namespace ManageSystem
{
    public partial class FrmDetail : Form
    {

       
        public FrmDetail(string info ,object bindSourceList)
        {
            InitializeComponent();

            this.lbInfo.Text = info;

            this.dgvDetail.DataSource = bindSourceList;

        }

    }
}
