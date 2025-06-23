using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Cars
    {
        private string registNumber;
        public string RegistNumber
        {
            get { return registNumber; }
            set { registNumber = value; }
        }
        private string mark;
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Cars(string registNumber, string mark, string model, double price, int year)
        {
            RegistNumber = registNumber;
            Mark = mark;
            Model = model;
            Price = price;
            Year = year;
        }
       
    }
}
