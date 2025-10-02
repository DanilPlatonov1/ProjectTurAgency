using System;
using System.Windows.Forms;
using Unity;
using ProjectTurAgency.Forms;

namespace ProjectTurAgency
{
    public partial class FormAgency : Form
    {
        private readonly IUnityContainer _container;

        public FormAgency(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormClients>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке клиентов",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormContracts>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке контрактов",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiscountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDiscounts>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке скидок",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormRoutes>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке маршрутов",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormTours>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке туров",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContractSigningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormContractSignings>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке подписаний контрактов",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TourCompilationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormTourCompilations>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке подборок туров",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAgency_Load(object sender, EventArgs e)
        {

        }
    }
}
