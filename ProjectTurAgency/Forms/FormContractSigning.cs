using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectTurAgency.Forms
{
    public partial class FormContractSigning : Form
    {
        private readonly IContractSigningRepository _contractSigningRepository;
        private int? _contractSigningId;

        public int Id
        {
            set
            {
                try
                {
                    var signing = _contractSigningRepository
                        .ReadContractSignings(null, null, null, null)
                        .FirstOrDefault(x => x.Id == value);

                    if (signing == null)
                        throw new InvalidDataException(nameof(signing));

                    numericUpDownClientId.Value = signing.ClientId;
                    numericUpDownTourId.Value = signing.TourId;
                    numericUpDownDiscountId.Value = signing.DiscountId ?? 0;
                    dateTimePickerSigningDate.Value = signing.SigningDate;
                    numericUpDownFinalPrice.Value = (decimal)signing.FinalPrice;

                    _contractSigningId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormContractSigning(IContractSigningRepository contractSigningRepository)
        {
            InitializeComponent();
            _contractSigningRepository = contractSigningRepository ?? throw new ArgumentNullException(nameof(contractSigningRepository));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var entity = ContractSigning.CreateOperation(
                    _contractSigningId ?? 0,
                    (int)numericUpDownClientId.Value,
                    (int)numericUpDownTourId.Value,
                    numericUpDownDiscountId.Value == 0 ? null : (int?)numericUpDownDiscountId.Value,
                    (double)numericUpDownFinalPrice.Value
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

        private void FormContractSigning_Load(object sender, EventArgs e)
        {

        }
    }
}
