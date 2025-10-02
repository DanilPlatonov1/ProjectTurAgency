using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectTurAgency.Forms
{
    public partial class FormTour : Form
    {
        private readonly ITourRepository _tourRepository;
        private readonly IRouteRepository _routeRepository;
        private int? _tourId;

        public int Id
        {
            set
            {
                try
                {
                    var tour = _tourRepository.ReadTourById(value);
                    if (tour == null)
                        throw new InvalidDataException(nameof(tour));

                    textBoxName.Text = tour.Name;
                    numericUpDownPrice.Value = (decimal)tour.Price;
                    comboBoxRoute.SelectedValue = tour.RouteId;

                    _tourId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormTour(ITourRepository tourRepository, IRouteRepository routeRepository)
        {
            InitializeComponent();
            _tourRepository = tourRepository ?? throw new ArgumentNullException(nameof(tourRepository));
            _routeRepository = routeRepository ?? throw new ArgumentNullException(nameof(routeRepository));
        }

        private void FormTour_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxRoute.DataSource = _routeRepository.ReadRoutes();
                comboBoxRoute.DisplayMember = "EndPoint";
                comboBoxRoute.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке маршрутов",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var tour = Tour.CreateEntity(
                    _tourId ?? 0,
                    textBoxName.Text.Trim(),
                    (double)numericUpDownPrice.Value,
                    (int)comboBoxRoute.SelectedValue
                );

                if (_tourId.HasValue)
                    _tourRepository.UpdateTour(tour);
                else
                    _tourRepository.CreateTour(tour);

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
