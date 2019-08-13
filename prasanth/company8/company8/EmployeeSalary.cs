using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company8
{
    class EmployeeSalary
    {
        int EmpId;
        String employeename;
        int salary;
        int basic;
        int travelallowance;
        int HRallowance;
        public EmployeeSalary(int basic0, int tr, int hr)
        {
            basic= basic0;
            travelallowance = tr;
            HRallowance = hr;

        }
        

        public int getEmpId1()
        {
            return EmpId;
        }
        public void setEmpId(int id)
        {
            EmpId = id;
        }
        
             public String getNAME()
        {
            return employeename;
        }
        public void setNAME(String employee)
        {
            employeename = employee;
        }
    }
       
        
        }
   
