﻿using CarListingApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListingApp.Helpers
{
    public static class MenuBuilder
    {
        public static void BuildMenu()
        {
            Shell.Current.Items.Clear();
            Shell.Current.FlyoutHeader = new FlyOutHeader();

            var role = App.UserInfo.Role;

            if(role.Equals("Administrator"))
            {
                var flyOutItem = new FlyoutItem()
                {
                    Title = "Admin Car Management",
                    Route = nameof(MainPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                    {
                        new ShellContent
                        {
                            Icon = "dotnet_bot.svg",
                            Title = "Admin Page 1",
                            ContentTemplate = new DataTemplate(typeof(MainPage))
                        },
                         new ShellContent
                        {
                            Icon = "dotnet_bot.svg",
                            Title = "Admin Page 2",
                            ContentTemplate = new DataTemplate(typeof(MainPage))
                        },
                          new ShellContent
                        {
                            Icon = "dotnet_bot.svg",
                            Title = "Admin Page 3",
                            ContentTemplate = new DataTemplate(typeof(MainPage))
                        }
                    }
                };

                if(!Shell.Current.Items.Contains(flyOutItem))
                {
                    Shell.Current.Items.Add(flyOutItem);
                }
            }
            else if(role.Equals("User"))
            {
                var flyOutItem = new FlyoutItem()
                {
                    Title = "User Car Management",
                    Route = nameof(MainPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                    {
                        new ShellContent
                        {
                            Icon = "dotnet_bot.svg",
                            Title = "User Page 1",
                            ContentTemplate = new DataTemplate(typeof(MainPage))
                        },
                         new ShellContent
                        {
                            Icon = "dotnet_bot.svg",
                            Title = "User Page 2",
                            ContentTemplate = new DataTemplate(typeof(MainPage))
                        },
                          new ShellContent
                        {
                            Icon = "dotnet_bot.svg",
                            Title = "User Page 3",
                            ContentTemplate = new DataTemplate(typeof(MainPage))
                        }
                    }
                };

                if (!Shell.Current.Items.Contains(flyOutItem))
                {
                    Shell.Current.Items.Add(flyOutItem);
                }
            }
        }
    }
}
