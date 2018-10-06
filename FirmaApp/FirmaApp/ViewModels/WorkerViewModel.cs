﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using FirmaApp.Models;

namespace FirmaApp.ViewModels
{
    class WorkerViewModel
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
            ObservableCollection<Worker> workers = new ObservableCollection<Worker>();

            workers.Add(new Worker("Dawid", "Dylus"));
            workers.Add(new Worker("Patryk", "Kowalski", "Etat"));
            workers.Add(new Worker("Janusz", "Chrobry"));

            Workers = workers;
        }




    }
}