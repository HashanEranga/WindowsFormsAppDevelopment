using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempAgencyApplication
{

    public class Employee
    {
        private string empLastName;
        private string empFirstName;
        private int noOfDependents;
        private int noOfHours;

        private const double RATE = 150.0;
        private const double FEDERAL_TAX = 0.25;
        private const double SOCIAL_SECURITY_RATE = 0.0785;
        private const double DEPENDENT_ALLOWANCE = 0.0575;
        private const double AGENCY_CHARGE = 0.13;


        public string EmpLastName { get => empLastName; set => empLastName = value; }
        public string EmpFirstName { get => empFirstName; set => empFirstName = value; }
        public int NoOfDependents { get => noOfDependents; set => noOfDependents = value; }
        public int NoOfHours { get => noOfHours; set => noOfHours = value; }

        public Employee(string fname, string lname, int dependents, int hours)
        {
            EmpLastName = lname;
            EmpFirstName = fname;  
            NoOfDependents = dependents;
            NoOfHours = hours;
        }

        public double DetermineGross()
        {
            return NoOfHours * RATE;

        }
        public double DetermineAgencyFee()
        {
            return DetermineGross()*AGENCY_CHARGE;
        }
        public double DetermineFederalTax()
        {
            return (DetermineGross()-DetermineGross()*DEPENDENT_ALLOWANCE*NoOfDependents)*FEDERAL_TAX;
        }
        public double DetermineSocialSecurity()
        {
            return DetermineGross()*SOCIAL_SECURITY_RATE;
        }
        public double DetermineNet()
        {
            return DetermineGross() - DetermineSocialSecurity() - DetermineAgencyFee() - DetermineFederalTax();
        }
    }

}
