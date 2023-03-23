using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using JamesTest.Core.State;
using System;

namespace JamesTest.Forms.Local.ViewModels
{
        public partial class MainContentViewModel : ObservableBase, IViewLoadable
        {
                [ObservableProperty]
                private string data;
                private readonly ScreenState _screenState;
                public MainContentViewModel(ScreenState screenState)
                {
                        this._screenState = screenState;
                }
                public void OnLoaded(IViewable smartWindow)
                {
                }

                [RelayCommand]
                private void Count()
                {
                        this._screenState.count++;
                        this.Data = $"현재 값은 {this._screenState.count}";
                }
        }
}
