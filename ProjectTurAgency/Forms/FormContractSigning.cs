using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;
using ProjectTurAgency.Repositories.Implementations;

namespace ProjectTurAgency.Forms
{
    public partial class FormContractSigning : Form
    {
        private readonly IContractSigningRepository _contractSigningRepository;
        private readonly IContractRepository _contractRepository;
        private readonly IClientRepository _clientRepository;
        private readonly ITourRepository _tourRepository;

        private int? _contractSigningId;

        public int Id
        {
            set
            {
                try
                {
                    var signing = _contractSigningRepository
                        .ReadContractSignings(null, null)
                        .FirstOrDefault(x => x.Id == value);

                    if (signing == null)
                        throw new InvalidDataException(nameof(signing));

                    comboBoxContracts.SelectedValue = signing.ContractId;

                    dateTimePickerSigningDate.Value = signing.SigningDate;
                    _contractSigningId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormContractSigning(
        IContractSigningRepository contractSigningRepository,
        IContractRepository contractRepository,
        IClientRepository clientRepository,
        ITourRepository tourRepository)
        {
            InitializeComponent();
            _contractSigningRepository = contractSigningRepository ?? throw new ArgumentNullException(nameof(contractSigningRepository));
            _contractRepository = contractRepository ?? throw new ArgumentNullException(nameof(contractRepository));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _tourRepository = tourRepository ?? throw new ArgumentNullException(nameof(tourRepository));
        }

        private void FormContractSigning_Load(object sender, EventArgs e)
        {
            var contracts = _contractRepository.ReadContracts().ToList();
            var clients = _clientRepository.ReadClients().ToDictionary(c => c.Id, c => c.FullName);
            var tours = _tourRepository.ReadTours().ToDictionary(t => t.Id, t => t.Name);

            var comboData = contracts.Select(c => new
            {
                c.Id,
                DisplayInfo = $"ID: {c.Id} | Клиент: {clients.GetValueOrDefault(c.ClientId, "Неизвестен")} | Тур: {tours.GetValueOrDefault(c.TourId, "Неизвестен")}"
            }).ToList();

            comboBoxContracts.DataSource = comboData;
            comboBoxContracts.DisplayMember = "DisplayInfo";
            comboBoxContracts.ValueMember = "Id";
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedContractId = (int)comboBoxContracts.SelectedValue;

                var entity = ContractSigning.CreateOperation(
                    _contractSigningId ?? 0,
                    selectedContractId
                );

                _contractSigningRepository.CreateContractSigning(entity);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}
