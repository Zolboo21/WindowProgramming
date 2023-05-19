﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp4.ViewModel
{
    class Car
    {
        public String Company { get; set; }
        public String Model { get; set; }
        public String Year { get; set; }
        public Color color { get; set; }

        public override string ToString()
        {
            return Company + " " + Model + " " + Year + " " + color;
        }
    }
        class MainWindowViewModel
        {
            List<Car> _cars;

            public List<Car> Cars
            {
                get
                {
                    return _cars;
                }
            }

            public MainWindowViewModel()
            {
                _cars = new List<Car>();

                _cars.Add(new Car() { Company = "Benz", Model = "Gle", Year = "1996", color = Colors.Aqua });
                _cars.Add(new Car() { Company = "Bmw", Model = "x5", Year = "2011", color = Colors.Blue });
                _cars.Add(new Car() { Company = "Hyundae", Model = "Sonata", Year = "2011", color = Colors.Gold });
            }
        }
}
