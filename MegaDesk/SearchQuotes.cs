using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            MegaDesk viewMegaDeskForm = (MegaDesk)Tag;
            viewMegaDeskForm.Show();
            base.OnFormClosed(e);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MegaDesk viewMegaDeskForm = (MegaDesk)Tag;
            viewMegaDeskForm.Show();
            this.Close();
        }
    }
}
