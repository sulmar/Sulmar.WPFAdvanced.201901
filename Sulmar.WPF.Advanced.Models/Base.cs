using System;
using System.ComponentModel;

namespace Sulmar.WPF.Advanced.Models
{
    public class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
