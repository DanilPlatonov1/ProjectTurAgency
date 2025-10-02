using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectTurAgency.Forms
{
    public partial class FormRoute : Form
    {
        private readonly IRouteRepository _routeRepository;
        private int? _routeId;

        public int Id
        {
            set
            {
                try
                {
                    var route = _routeRepository.ReadRouteById(value);
                    if (route == null)
                        throw new InvalidDataException(nameof(route));

                    textBoxStart.Text = route.StartPoint;
                    textBoxEnd.Text = route.EndPoint;
                    numericUpDownDuration.Value = route.DurationDays;

                    _routeId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormRoute(IRouteRepository routeRepository)
        {
            InitializeComponent();
            _routeRepository = routeRepository ?? throw new ArgumentNullException(nameof(routeRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var route = Route.CreateEntity(
                    _routeId ?? 0,
                    textBoxStart.Text.Trim(),
                    textBoxEnd.Text.Trim(),
                    (int)numericUpDownDuration.Value
                );

                if (_routeId.HasValue)
                    _routeRepository.UpdateRoute(route);
                else
                    _routeRepository.CreateRoute(route);

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
