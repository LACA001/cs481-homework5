    using System;
using System.Diagnostics;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;

namespace Homework5.ViewModels
{
    public class TabContainerViewModel : BindableBase, INavigationAware
    {
        private string _title;
        
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public TabContainerViewModel()
        {
            Title = "Tab Container";
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(TabContainerViewModel)}:  ctor");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedFrom)}");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatingTo)}");

        }
    }
}
