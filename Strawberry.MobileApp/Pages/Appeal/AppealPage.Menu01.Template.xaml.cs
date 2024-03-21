﻿using Strawberry.MobileApp.DataModels;
using Strawberry.MobileApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Strawberry.MobileApp.Pages.Appeal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppealPage_Menu01_Template : DataTemplate
    {
        public LockDataModel LockData { get; set; }

        public AppealPage_Menu01_Template()
        {
            InitializeComponent();
            this.LockData = new LockDataModel();
        }

        private async void Item_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IDeviceHelper>().Vibrate();

            lock (this.LockData)
            {
                if (this.LockData.IsLocked)
                    return;
                this.LockData.IsLocked = true;
            }

            try
            {
                var element = sender as Element;
                var data = element.BindingContext as AppealPage_Menu01_Data;

                var page = new AppealDetailPage();
                await page.ShowAsync(data.Id);
            }
            catch (Exception ex)
            {
                await App.Instance.MainPage.DisplayToastAsync(ex.Message);
            }
            finally
            {
                this.LockData.IsLocked = false;
            }
        }
    }
}