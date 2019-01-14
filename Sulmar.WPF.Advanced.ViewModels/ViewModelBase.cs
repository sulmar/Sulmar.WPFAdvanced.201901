using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
