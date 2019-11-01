namespace TestMahAppsNumericBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ViewModel : INotifyPropertyChanged
    {
        static double _default = 5;

        private double _testValue;

        public double TestValue
        {
            get => _testValue;
            set
            {
                _testValue = value;
                OnPropertyChanged2(null);// This updates all Properties
            }
        }

        public double? NullableTestValue
        {
            get => _testValue;
            set
            {
                _testValue = value ?? _default;
                OnPropertyChanged2(null); // This updates all Properties
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        // OnPropertyChanged with option to call for more than one property
        protected virtual void OnPropertyChanged2(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
