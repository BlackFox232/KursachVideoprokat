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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void uchetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uchetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videostoreDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "videostoreDataSet.Uchet". При необходимости она может быть перемещена или удалена.
            this.uchetTableAdapter.Fill(this.videostoreDataSet.Uchet);

        }
    }
}
