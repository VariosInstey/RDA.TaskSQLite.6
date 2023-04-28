using Microsoft.EntityFrameworkCore.Infrastructure;
using RDA.TaskSQLite._6.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RDA.TaskSQLite._6;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        DatabaseFacade facade = new DatabaseFacade(new ModelContext());
        facade.EnsureCreated();
    }
}
