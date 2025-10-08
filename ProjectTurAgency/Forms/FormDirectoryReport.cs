using ProjectTurAgency.Reports;
using Unity;

namespace ProjectTurAgency.Forms
{
    public partial class FormDirectoryReport : Form
    {
        private readonly IUnityContainer _container;

        public FormDirectoryReport(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void ButtonBuild_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBoxClient.Checked && !checkBoxRoute.Checked && !checkBoxTour.Checked)
                {
                    throw new Exception("Не выбран ни один справочник для выгрузки!");
                }

                var sfd = new SaveFileDialog()
                {
                    Filter = "Документ Word (*.docx)|*.docx"
                };

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("Не выбран файл для отчета");
                }

                var docReport = _container.Resolve<DocReport>();

                bool result = docReport.CreateDoc(
                    sfd.FileName,
                    includeClients: checkBoxClient.Checked,
                    includeRoutes: checkBoxRoute.Checked,
                    includeTours: checkBoxTour.Checked
                );

                if (result)
                {
                    MessageBox.Show("Документ успешно сформирован!", "Формирование отчёта",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Возникли ошибки при формировании документа. Подробности в логах.", "Формирование отчёта",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, "Ошибка при создании отчёта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
