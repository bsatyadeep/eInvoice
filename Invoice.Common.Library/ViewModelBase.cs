using System;
using System.ComponentModel;
using System.Windows;

namespace Invoice.Common.Library
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Property Changed Event
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Property Changed Methods
        protected void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor
                       .FromProperty(prop, typeof(FrameworkElement))
                       .Metadata.DefaultValue;
            }
        }
        #endregion
    }
}
