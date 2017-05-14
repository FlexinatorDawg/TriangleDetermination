using System;
using System.ComponentModel;
using System.Windows.Input;

namespace TriangleDetermination
{
    public class TriangleDeterminationVM : INotifyPropertyChanged
    {
        private readonly ITriangleDeterminationService _determinationService; 
        private string _triangleStyleResult;

        public event PropertyChangedEventHandler PropertyChanged;             

        public string SideA { get;set; }

        public string SideB { get; set; }

        public string SideC { get; set; }

        public string TriangleStyleResult
        {
            get
            {
                return _triangleStyleResult;
            }
            set
            {
                _triangleStyleResult = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand DetermineCommand { get; }
        public TriangleDeterminationVM()
        {
            ITriangleStyleCalculator calculator = new TriangleStyleCalculator();
            _determinationService = new TriangleDeterminationService(calculator);
            DetermineCommand = new TriangleCommand(DetermineExecute, DetermineCanExecute);
        }

        private void DetermineExecute(object parameter)
        {
            TriangleStyleResult = string.Empty;
            TriangleStyleResult = string.Format("I am a {0} triangle", _determinationService.DetermineTriangle(SideA, SideB, SideC));
        }

        private bool DetermineCanExecute(object parameter)
        {
            return true;
        }

        private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    internal class TriangleCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute _execute;
        private ICommandOnCanExecute _canExecute;

        public TriangleCommand(ICommandOnExecute onExecuteMethod, ICommandOnCanExecute onCanExecuteMethod)
        {
            _execute = onExecuteMethod;
            _canExecute = onCanExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
