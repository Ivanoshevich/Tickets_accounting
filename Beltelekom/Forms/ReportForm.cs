using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beltelekom.DBEntity;
using Beltelekom.Forms;

namespace Beltelekom.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                gridReport.DataSource = db.Report.ToList();
            }
        }
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(gridReport.SelectedRows[0].Cells[0].Value);
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                try
                {
                    Report report = db.Report.Where(p => p.Id == Id).FirstOrDefault();
                    db.Report.Remove(report);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно удалены.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReportForm form = new AddReportForm();
            form.ShowDialog();
            LoadData();
        }
    }
}
