using System.Windows;
using AppKinalAlumnos.ModelViews;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
namespace AppKinalAlumnos.Views
{
    public partial class AlumnoView : MetroWindow
    {
        private AlumnoViewModel model;
        public AlumnoView()
        {
            InitializeComponent();
            model = new AlumnoViewModel(DialogCoordinator.Instance);
            this.DataContext = model;
        }
    }
}