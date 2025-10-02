using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectTurAgency.Forms
{
    public partial class FormTourCompilation : Form
    {
        private readonly ITourCompilationRepository _tourCompilationRepository;
        private int? _tourCompilationId;

        public int Id
        {
            set
            {
                try
                {
                    var compilation = _tourCompilationRepository.ReadTourCompilations(null, null, null)
                        .FirstOrDefault(x => x.Id == value);

                    if (compilation == null)
                        throw new InvalidDataException(nameof(compilation));

                    numericUpDownTourId.Value = compilation.TourId;
                    dateTimePickerCompilationDate.Value = compilation.CompilationDate;

                    _tourCompilationId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormTourCompilation(ITourCompilationRepository repo)
        {
            InitializeComponent();
            _tourCompilationRepository = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var entity = TourCompilation.CreateOperation(
                    _tourCompilationId ?? 0,
                    (int)numericUpDownTourId.Value,
                    []
                );

                _tourCompilationRepository.CreateTourCompilation(entity);
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
