using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;
using ProjectTurAgency.Repositories.Implementations;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectTurAgency.Forms
{
    public partial class FormTour : Form
    {
        private readonly ITourRepository _tourRepository;
        private readonly IRouteRepository _routeRepository;
        private readonly ITourRouteRepository _tourRouteRepository;
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

                    var tourRouteIds = _tourRouteRepository.ReadByTourId(tour.Id).Select(tr => tr.RouteId).ToList();

                    for (int i = 0; i < checkedListBoxRoutes.Items.Count; i++)
                    {
                        var route = (Route)checkedListBoxRoutes.Items[i];
                        checkedListBoxRoutes.SetItemChecked(i, tourRouteIds.Contains(route.Id));
                    }

                    _tourId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormTour(ITourRepository tourRepository, IRouteRepository routeRepository, ITourRouteRepository tourRouteRepository)
        {
            InitializeComponent();
            _tourRepository = tourRepository ?? throw new ArgumentNullException(nameof(tourRepository));
            _routeRepository = routeRepository ?? throw new ArgumentNullException(nameof(routeRepository));
            _tourRouteRepository = tourRouteRepository ?? throw new ArgumentNullException(nameof(tourRouteRepository));

            try
            {
                var routes = _routeRepository.ReadRoutes()
                .OrderBy(r => r.EndPoint)
                .ToList();

                checkedListBoxRoutes.Items.Clear();
                foreach (var route in routes)
                {
                    checkedListBoxRoutes.Items.Add(route);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке маршрутов",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTour_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRouteIds = checkedListBoxRoutes.CheckedItems
                    .Cast<Route>()
                    .Select(r => r.Id)
                    .ToList();

                var tour = Tour.CreateEntity(
                    _tourId ?? 0,
                    textBoxName.Text.Trim(),
                    (double)numericUpDownPrice.Value
                );

                if (_tourId.HasValue)
                    _tourRepository.UpdateTour(tour, selectedRouteIds);
                else
                    _tourRepository.CreateTour(tour, selectedRouteIds);

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
