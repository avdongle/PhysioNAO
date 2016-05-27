﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace PhysioNAO.Model
{
    public class Patient : GalaSoft.MvvmLight.ObservableObject
    {
        #region Fields
        string _name;
        ExerciseSet _exerciseset;

        public Patient()
        {
        }

        public Patient(string s)
        {
            _name = s;
        }
        #endregion //Fields

        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        #endregion //properties
    }
}
