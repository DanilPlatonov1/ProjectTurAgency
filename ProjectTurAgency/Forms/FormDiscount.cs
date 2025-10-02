using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectTurAgency.Forms
{
    public partial class FormDiscount : Form
    {
        private readonly IDiscountRepository _discountRepository;
        private int? _discountId;

        public int Id
        {
            set
            {
                try
                {
                    var discount = _discountRepository.ReadDiscountById(value);
                    if (discount == null)
                        throw new InvalidDataException(nameof(discount));

                    textBoxDescription.Text = discount.Description;
                    numericUpDownPercent.Value = (decimal)discount.Percent;

                    _discountId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormDiscount(IDiscountRepository discountRepository)
        {
            InitializeComponent();
            _discountRepository = discountRepository ?? throw new ArgumentNullException(nameof(discountRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var discount = Discount.CreateEntity(
                    _discountId ?? 0,
                    textBoxDescription.Text.Trim(),
                    (double)numericUpDownPercent.Value
                );

                if (_discountId.HasValue)
                    _discountRepository.UpdateDiscount(discount);
                else
                    _discountRepository.CreateDiscount(discount);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}
