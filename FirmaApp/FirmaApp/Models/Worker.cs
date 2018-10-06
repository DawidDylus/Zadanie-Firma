﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FirmaApp.Models 
{
    class Worker : INotifyPropertyChanged
    {

        public Worker(string _firstName, string _lastName, string _contract = "Staż")
        {
            FirstName = _firstName;
            LastName = _lastName;
            Contract = _contract;
        }

        private string firstName;        
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }       //Getter,Setter for firstName variable

        private string lastName;        
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");                    
                }
            }
        }
        
        private string contract;        
        public string Contract
        {
            get
            {
                return contract;
            }
            set
            {
                if (contract != value)
                {
                    contract = value;
                    RaisePropertyChanged("Contract");
                }
            }
        }





        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;





    }
}