﻿namespace Microsoft.NetConf2021.Maui.Pages;

public partial class CategoryPage : ContentPage
{
    CategoryViewModel vm => BindingContext as CategoryViewModel;
    public CategoryPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await vm.InitializeAsync();
    }
}
