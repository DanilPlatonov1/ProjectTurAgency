using ProjectTurAgency.Entity;
using ProjectTurAgency.Entity.Enums;
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

                    checkedListBoxAttractions.Items.Clear();
                    foreach (RouteAttractions attraction in Enum.GetValues(typeof(RouteAttractions)))
                    {
                        if (attraction == RouteAttractions.None) continue;
                        int index = checkedListBoxAttractions.Items.Add(attraction);
                        checkedListBoxAttractions.SetItemChecked(index, route.Attractions.HasFlag(attraction));
                    }

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

            foreach (RouteAttractions attraction in Enum.GetValues(typeof(RouteAttractions)))
            {
                if (attraction == RouteAttractions.None) continue;
                checkedListBoxAttractions.Items.Add(attraction);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                RouteAttractions selectedAttractions = RouteAttractions.None;
                foreach (var item in checkedListBoxAttractions.CheckedItems)
                {
                    selectedAttractions |= (RouteAttractions)item;
                }

                var route = Route.CreateEntity(
                    _routeId ?? 0,
                    textBoxStart.Text.Trim(),
                    textBoxEnd.Text.Trim(),
                    (int)numericUpDownDuration.Value,
                    selectedAttractions
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
        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }

}
