using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;

namespace ProjectTurAgency.Forms
{
    public partial class FormContract : Form
    {
        private readonly IContractRepository _contractRepository;
        private readonly IClientRepository _clientRepository;
        private readonly ITourRepository _tourRepository;
        private readonly IDiscountRepository _discountRepository;

        private int? _contractId;

        public int Id
        {
            set
            {
                try
                {
                    var contract = _contractRepository.ReadContractById(value);
                    if (contract == null)
                        throw new InvalidDataException(nameof(contract));

                    comboBoxClient.SelectedValue = contract.ClientId;
                    comboBoxTour.SelectedValue = contract.TourId;
                    comboBoxDiscount.SelectedValue = contract.DiscountId ?? 0;
                    dateTimePickerDate.Value = contract.Date;

                    _contractId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormContract(IContractRepository contractRepository,
            IClientRepository clientRepository,
            ITourRepository tourRepository,
            IDiscountRepository discountRepository)
        {
            InitializeComponent();

            _contractRepository = contractRepository ?? throw new ArgumentNullException(nameof(contractRepository));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _tourRepository = tourRepository ?? throw new ArgumentNullException(nameof(tourRepository));
            _discountRepository = discountRepository ?? throw new ArgumentNullException(nameof(discountRepository));

            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            comboBoxClient.DataSource = _clientRepository.ReadClients();
            comboBoxClient.DisplayMember = "FullName";
            comboBoxClient.ValueMember = "Id";

            comboBoxTour.DataSource = _tourRepository.ReadTours();
            comboBoxTour.DisplayMember = "Name";
            comboBoxTour.ValueMember = "Id";

            var discounts = _discountRepository.ReadDiscounts().ToList();
            discounts.Insert(0, Discount.CreateEntity(0, "Без скидки", 0));
            comboBoxDiscount.DataSource = discounts;
            comboBoxDiscount.DisplayMember = "Description";
            comboBoxDiscount.ValueMember = "Id";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var discountId = (int)comboBoxDiscount.SelectedValue;
                int? nullableDiscount = discountId == 0 ? null : discountId;

                var contract = Contract.CreateEntity(
                    _contractId ?? 0,
                    (int)comboBoxClient.SelectedValue,
                    (int)comboBoxTour.SelectedValue,
                    nullableDiscount,
                    dateTimePickerDate.Value
                );

                if (_contractId.HasValue)
                    _contractRepository.UpdateContract(contract);
                else
                    _contractRepository.CreateContract(contract);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private void FormContract_Load(object sender, EventArgs e)
        {

        }
    }
}
