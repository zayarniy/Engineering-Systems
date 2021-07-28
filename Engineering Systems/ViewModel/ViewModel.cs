using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engineering_Systems.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        Database database = new Database();

        public List<Data> Boilers { get; set; }

        public List<int> Stages { get; set; } = new List<int>() { 0, 1, 2, 3 };

        Data _boiler;
        int _stage;

        public int Stage { get 
            {
                return _stage;
            }
            set
            {
                System.Diagnostics.Debug.WriteLine("Stage set");
                if (value != _stage)
                    _stage = Convert.ToInt32(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Stage"));
                GetResult();

            }
        }

        int _result;

        public Data SelectedBoiler { 
            get
            {
                return _boiler;
            }
            set
            {
                if (value != _boiler)
                    _boiler = value;
                System.Diagnostics.Debug.WriteLine("SelectedBoiler set");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedBoiler"));
                GetResult();    
            }
        
        }

        void GetResult()
        {
            Result = _boiler.Value*_stage;
        }
        public ViewModel()
        {
            Boilers = database.Boilers;
            SelectedBoiler = Boilers[0];
        }

        public int Result
        {
            get
            {
                return _result;
            }
            set
            {
                if (_result!=value)
                {
                    _result = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));
                }
            }
        }

        






















        /*
        Data selectedItem;
        public Data SelectedElement
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (value != selectedItem)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedElement"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));
                    System.Diagnostics.Debug.WriteLine("SelectedItem sets");
                }
            }
        }
            
        public List<Data> Datas { get; set; } = new List<Data>() { new Data("Нет", 0), new Data("Газовый", 100), new Data("Электрический", 200), new Data("Каскад", 300) };

        public ViewModel()
        {
            selectedItem = Datas[0];
        }


        int result;

        public int Result 
        { 
            get
            {
                return SelectedElement.Value;
            }
            set
            {
                result = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));
            }
        
        }
        public event PropertyChangedEventHandler PropertyChanged;
        */

    }
}
