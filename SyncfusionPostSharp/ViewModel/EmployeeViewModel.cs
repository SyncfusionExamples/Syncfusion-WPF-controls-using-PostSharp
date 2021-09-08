using PostSharp.Patterns.Model;
using PostSharp.Patterns.Xaml;
using Syncfusion.UI.Xaml.Grid;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace SyncfusionPostSharp
{
    [NotifyPropertyChanged]
    public class EmployeeViewModel
    {
        private ObservableCollection<Employee> employees;

        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public string EmployeeEventDetail { get; set; }

        public EmployeeViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee("Mark", 10000, 1000));
            Employees.Add(new Employee("Adam", 20000, 2000));
            Employees.Add(new Employee("Michael", 30000, 3000));
            Employees.Add(new Employee("Johnson", 40000, 4000));
            Employees.Add(new Employee("Gayle", 50000, 5000));
            Employees.Add(new Employee("Peter", 60000, 6000));
            Employees.Add(new Employee("William", 70000, 1000));
            Employees.Add(new Employee("Rob", 80000, 2000));
            Employees.Add(new Employee("Oliver", 30000, 3000));
            Employees.Add(new Employee("Jennifer", 40000, 4000));
            Employees.Add(new Employee("Dave", 50000, 5000));
            Employees.Add(new Employee("Erica", 60000, 6000)); 
            Employees.Add(new Employee("William", 20000, 1000));
            Employees.Add(new Employee("Glenn", 70000, 2000));
            Employees.Add(new Employee("Helen", 80000, 3000));
            Employees.Add(new Employee("Randy", 40000, 4000));
            Employees.Add(new Employee("Kelly", 50000, 5000));
            Employees.Add(new Employee("Wndy", 60000, 6000));
        }

        [Command(ExecuteMethod = nameof(ExecuteCellTapped), CanExecuteMethod = nameof(CanExecuteCellTapped))]
        public ICommand CellTappedCommand { get; set; }

        private bool CanExecuteCellTapped()
        {
            return true;
        }

        private void ExecuteCellTapped(GridCellTappedEventArgs args)
        {
           EmployeeEventDetail = (args.Record as Employee).FirstName + " row cell has been tapped";
        }

    }
}
