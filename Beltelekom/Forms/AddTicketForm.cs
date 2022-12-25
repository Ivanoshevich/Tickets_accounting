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
    public partial class AddTicketForm : Form
    {
        private bool op;
        private int id;

        public void LoadService()
        {
            using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
            {
                comboService.DataSource = db.Service.Select(t => t.Name).ToList();
            }
        }
        public AddTicketForm(bool op, int id)
        {
            InitializeComponent();
            LoadService();
            this.op = op;
            this.id = id;
            if (op)
            {
                buttonAdd.Text = "Сохранить изменения";
                Text = "Редактирование заявки";
                using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
                {
                    Ticket ticket = db.Ticket.Where(p => p.Id == id).FirstOrDefault();
                    textContract.Text = ticket.Contract;
                    textAddress.Text = ticket.Address;
                    textFIOClient.Text = ticket.FIOClient;
                    textFIOPerformer.Text = ticket.FIOPerformer;
                    textPhone.Text = ticket.Phone;
                    textSum.Text = Convert.ToString(ticket.Sum);
                    dateService.Value = ticket.Date;
                    comboService.SelectedIndex = ticket.ServiceId - 1;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (op)
            {
                using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
                {
                    try
                    {
                        Ticket ticket = db.Ticket.Where(p => p.Id == id).FirstOrDefault();
                        ticket.Contract = textContract.Text;
                        ticket.Address = textAddress.Text;
                        ticket.Date = dateService.Value;
                        ticket.FIOPerformer = textFIOPerformer.Text;
                        ticket.FIOClient = textFIOClient.Text;
                        ticket.Phone = textPhone.Text;
                        ticket.ServiceId = comboService.SelectedIndex + 1;
                        ticket.Sum = Convert.ToDouble(textSum.Text);
                        db.SaveChanges();
                        MessageBox.Show("Данные успешно изменены.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                using (BeltelekomDatabaseEntities db = new BeltelekomDatabaseEntities())
                {
                    try
                    {
                        Ticket ticket = new Ticket();
                        ticket.Contract = textContract.Text;
                        ticket.Address = textAddress.Text;
                        ticket.Date = dateService.Value;
                        ticket.FIOPerformer = textFIOPerformer.Text;
                        ticket.FIOClient = textFIOClient.Text;
                        ticket.Phone = textPhone.Text;
                        ticket.ServiceId = comboService.SelectedIndex + 1;
                        ticket.Sum = Convert.ToDouble(textSum.Text);
                        db.Ticket.Add(ticket);
                        db.SaveChanges();
                        MessageBox.Show("Данные успешно добавлены.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Close();
        }
    }
}
