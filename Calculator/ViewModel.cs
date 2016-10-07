using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Calculator
{
    public class ViewModel :  DependencyObject
    {


        public int Result
        {
            get { return (int)GetValue(ResultProperty); }
            set { SetValue(ResultProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Result.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ResultProperty =
            DependencyProperty.Register("Result", typeof(int), typeof(ViewModel), new PropertyMetadata(0));



        private ICommand calculate;
        private int result;

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public ICommand Calculate
        {
            get
            {
                return calculate ?? (calculate = new RelayCommand(() => 
                {
                    Result = FirstNumber + SecondNumber;
                }));
            }

            set
            {
                calculate = value;
            }
        }


        //public int Result
        //{
        //    get
        //    {
        //        return result;
        //    }

        //    set
        //    {
        //        result = value;
        //        RaisePropertyChanged(() => Result);
        //    }
        //}


    }
}
