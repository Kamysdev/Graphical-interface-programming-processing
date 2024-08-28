using ReactiveUI;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Geometric_figures.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
