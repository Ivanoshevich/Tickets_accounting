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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
            comboSearch.SelectedIndex = 0;
        }
        public void LoadData()
        {
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                gridTicket.DataSource = (from ticket in db.Ticket
                                         join service in db.Service on ticket.ServiceId equals service.Id
                                           select new
                                           {
                                               Id = ticket.Id,
                                               Contract = ticket.Contract,
                                               Date = ticket.Date,
                                               FIOClient = ticket.FIOClient,
                                               FIOPerformer = ticket.FIOPerformer,
                                               Address = ticket.Address,
                                               Phone = ticket.Phone,
                                               Sum = ticket.Sum,
                                               ServiceName = service.Name
                                           }).ToList();
            }
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTicketForm form = new AddTicketForm(false, 0);
            form.ShowDialog();
            LoadData();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(gridTicket.SelectedRows[0].Cells[0].Value);
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                try
                {
                    Ticket ticket = db.Ticket.Where(w => w.Id == Id).FirstOrDefault();
                    db.Ticket.Remove(ticket);
                    db.SaveChanges();
                    MessageBox.Show("Заявка успешно удалена.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка удаления заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(gridTicket.SelectedRows[0].Cells[0].Value);
            AddTicketForm form = new AddTicketForm(true, Id);
            form.ShowDialog();
            LoadData();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboSearch.SelectedIndex == 0)
            {
                using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
                {
                    gridTicket.DataSource = (from ticket in db.Ticket
                                             join service in db.Service on ticket.ServiceId equals service.Id
                                             where ticket.Contract.Contains(textSearch.Text)
                                             select new
                                             {
                                                 Id = ticket.Id,
                                                 Contract = ticket.Contract,
                                                 Date = ticket.Date,
                                                 FIOClient = ticket.FIOClient,
                                                 FIOPerformer = ticket.FIOPerformer,
                                                 Address = ticket.Address,
                                                 Phone = ticket.Phone,
                                                 Sum = ticket.Sum,
                                                 ServiceName = service.Name
                                             }).ToList();
                }
            }
            else
            {
                using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
                {
                    gridTicket.DataSource = (from ticket in db.Ticket
                                             join service in db.Service on ticket.ServiceId equals service.Id
                                             where ticket.FIOClient.Contains(textSearch.Text)
                                             select new
                                             {
                                                 Id = ticket.Id,
                                                 Contract = ticket.Contract,
                                                 Date = ticket.Date,
                                                 FIOClient = ticket.FIOClient,
                                                 FIOPerformer = ticket.FIOPerformer,
                                                 Address = ticket.Address,
                                                 Phone = ticket.Phone,
                                                 Sum = ticket.Sum,
                                                 ServiceName = service.Name
                                             }).ToList();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
