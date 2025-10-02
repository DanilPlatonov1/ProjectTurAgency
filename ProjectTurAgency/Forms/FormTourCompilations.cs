using ProjectTurAgency.Repositories;
using Unity;
using System;
using System.Windows.Forms;

namespace ProjectTurAgency.Forms
{
    public partial class FormTourCompilations : Form
    {
        private readonly IUnityContainer _container;
        private readonly ITourCompilationRepository _tourCompilationRepository;

        public FormTourCompilations(IUnityContainer container, ITourCompilationRepository repo)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _tourCompilationRepository = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        private void FormTourCompilations_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() =>
            dataGridViewData.DataSource = _tourCompilationRepository.ReadTourCompilations();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormTourCompilation>().ShowDialog();
            LoadList();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out var id)) return;
            var form = _container.Resolve<FormTourCompilation>();
            form.Id = id;
            form.ShowDialog();
            LoadList();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out var id)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            _tourCompilationRepository.DeleteTourCompilation(id);
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

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
