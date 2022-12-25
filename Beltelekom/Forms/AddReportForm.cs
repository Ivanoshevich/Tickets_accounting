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

namespace Beltelekom.Forms
{
    public partial class AddReportForm : Form
    {
        private string description;
        public AddReportForm()
        {
            InitializeComponent();
            LoadFIOPerformer();
            this.comboFIOPerformer.SelectedIndexChanged += new System.EventHandler(this.comboFIOPerformer_SelectedIndexChanged);
        }
        public void LoadFIOPerformer()
        {
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                List<string> data = new HashSet<string>(db.Ticket.Select(t => t.FIOPerformer).ToList()).ToList();
                data.Add("Все");
                comboFIOPerformer.DataSource = data;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                try
                {
                    Report report = new Report();
                    report.DateStart = dateStart.Value;
                    report.DateEnd = dateEnd.Value;
                    report.Description = description;
                    report.Sum = Convert.ToDouble(textSum.Text);
                    db.Report.Add(report);
                    db.SaveChanges();
                    MessageBox.Show("Отчет успешно добавлен", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка добавления отчета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }

        private void comboFIOPerformer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fioPerformer = comboFIOPerformer.Items[comboFIOPerformer.SelectedIndex].ToString();
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                List<double> pays = new List<double>();
                if (fioPerformer.Equals("Все"))
                {
                    pays = db.Ticket.Where(c => c.Date >= dateStart.Value &&
                    c.Date <= dateEnd.Value).Select(c => c.Sum).ToList();
                    description = "Итоговая сумма по всем иcполнителям";
                }
                else
                {
                    pays = db.Ticket.Where(c => c.Date >= dateStart.Value &&
                    c.Date <= dateEnd.Value && c.FIOPerformer.Equals(fioPerformer)).Select(c => c.Sum).ToList();
                    description = "Итоговая сумма по иcполнителю " + fioPerformer;
                }
                textSum.Text = pays.Sum().ToString();
            }
        }
    }
}
