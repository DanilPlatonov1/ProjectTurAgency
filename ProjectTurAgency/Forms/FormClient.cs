using ProjectTurAgency.Entity;
using ProjectTurAgency.Entity.Enums;
using ProjectTurAgency.Repositories;

namespace ProjectTurAgency.Forms
{
    public partial class FormClient : Form
    {
        private readonly IClientRepository _clientRepository;
        private int? _clientId;

        public int Id
        {
            set
            {
                try
                {
                    var client = _clientRepository.ReadClientById(value);
                    if (client == null)
                        throw new InvalidDataException(nameof(client));

                    textBoxFullName.Text = client.FullName;
                    comboBoxSex.SelectedItem = client.ClientSex;
                    textBoxPhone.Text = client.Phone;
                    textBoxEmail.Text = client.Email;
                    _clientId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormClient(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));

            comboBoxSex.DataSource = Enum.GetValues(typeof(ClientSex));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPhone.Text))
                    throw new Exception("Имеются незаполненные поля");

                if (_clientId.HasValue)
                    _clientRepository.UpdateClient(CreateClient(_clientId.Value));
                else
                    _clientRepository.CreateClient(CreateClient(0));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Client CreateClient(int id) => Client.CreateEntity(id,
                textBoxFullName.Text,
                (ClientSex)comboBoxSex.SelectedItem,
                textBoxPhone.Text,
                textBoxEmail.Text
            );

        private void FormClient_Load(object sender, EventArgs e)
        {

        }
    }
}
