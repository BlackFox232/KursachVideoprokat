using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachVideoprokat
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void blacklistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.blacklistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videostoreDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videostoreDataSet.Blacklist". При необходимости она может быть перемещена или удалена.
            this.blacklistTableAdapter.Fill(this.videostoreDataSet.Blacklist);

        }
    }
}
