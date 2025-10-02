using ProjectTurAgency.Repositories;
using Unity;
using System;
using System.Windows.Forms;

namespace ProjectTurAgency.Forms
{
    public partial class FormContractSignings : Form
    {
        private readonly IUnityContainer _container;
        private readonly IContractSigningRepository _contractSigningRepository;

        public FormContractSignings(IUnityContainer container, IContractSigningRepository repo)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _contractSigningRepository = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        private void FormContractSignings_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() =>
            dataGridViewData.DataSource = _contractSigningRepository.ReadContractSignings();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormContractSigning>().ShowDialog();
            LoadList();
        }

        private bool TryGetId(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}
