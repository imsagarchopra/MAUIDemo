﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models;

namespace Tasker.ViewModels
{
    public class NewTaskViewModel
    {
        public string Task { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }
        public ObservableCollection<Category> Categories { get; set; }

    }
}
