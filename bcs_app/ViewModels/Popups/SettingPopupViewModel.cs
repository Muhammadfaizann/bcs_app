﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Bilateral_Corneal_Symmetry_3D_Analyzer.ViewModels;

[INotifyPropertyChanged]
public partial class SettingPopupViewModel
{
    public SettingPopupViewModel(Action hideAction)
    {
        _hideAction = hideAction;
    }

    [RelayCommand]
    void Cancel() => _hideAction?.Invoke();

    private readonly Action _hideAction;
}