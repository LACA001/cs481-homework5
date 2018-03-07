using System;
using System.Diagnostics;
using Prism;
using Prism.Mvvm;

namespace Homework5.ViewModels
{
    public class TabBViewModel : BindableBase, IActiveAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public TabBViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(TabBViewModel)}:  ctor");
            Title = "Tab B";
            IsActiveChanged += OnIsActiveChanged;
        }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                SetProperty(ref _isActive, value);
                IsActiveChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        void OnIsActiveChanged(object sender, EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnIsActiveChanged)}: {IsActive}");
        }
    }
}
