using System.ComponentModel;
using System.Windows.Input;
using System.Windows;

namespace UBYS_App
{
    public class MainWindowViewModel : INotifyPropertyChanged {
        public ICommand OpenStudentWindowCommand { get; }
        public ICommand OpenTeacherWindowCommand { get; }
        public ICommand OpenAdminWindowCommand { get; }

        public int Github;

        public MainWindowViewModel() {
            OpenStudentWindowCommand = new RelayCommand(OpenStudentWindow);
            OpenTeacherWindowCommand = new RelayCommand(OpenTeacherWindow);
            OpenAdminWindowCommand = new RelayCommand(OpenAdminWindow);
        }

        private void OpenStudentWindow() {
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.Show();
            Application.Current.MainWindow.Close();
        }

        private void OpenTeacherWindow() {
            TeacherWindow teacherWindow = new TeacherWindow();
            teacherWindow.Show();
            Application.Current.MainWindow.Close();
        }

        private void OpenAdminWindow() {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            Application.Current.MainWindow.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
