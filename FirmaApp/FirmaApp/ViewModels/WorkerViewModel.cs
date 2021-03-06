﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using FirmaApp.Models;

namespace FirmaApp.ViewModels
{
    public class WorkerViewModel
    {
        public WorkerViewModel()
        {
            LoadWorkers();           
            
        }

        public ObservableCollection<Worker> Workers
        {
            get;
            set;           
        }
                

        public void LoadWorkers()
        {
            ObservableCollection<Worker> workers = new ObservableCollection<Worker>
            {
                new Worker("Dawid", "Dylus"),
                new Worker("Patryk", "Kowalski"),
                new Worker("Janusz", "Chrobry")
            };

            Workers = workers;
        }

        public int GetWorkerCount()
        {
            return Workers.Count;
        }

       
        

        

    }
}
