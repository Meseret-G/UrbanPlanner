using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Models
{
    class Building
    {
        //overloading 
        public Building()
        {

        }
        //Constructor
        public Building (string address)
        {
            _address = address;
            
        }
        public Building(string designer, DateTime dateConstructed, string address, string owner)
        {
            _designer = designer;
            _dateConstructed = dateConstructed;
            _address = address;
            _owner = owner;

        }
        //fields
        private string _designer = "Meseret";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
    
        // properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public  double Volume
        {
            get =>  Width * Depth * (3 * Stories);
                  
            }
       
        //Methods
        public void Construct ()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            _owner = name;
        }
        public void PrintToConsole()
        {
            string output = $@"
{_address } --------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner }
{Volume} cubic meters of space";

Console .WriteLine(output);
        }
        }
    }
