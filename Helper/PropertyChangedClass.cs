using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataOfLibrary.Helper
{
    public class PropertyChangedClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
