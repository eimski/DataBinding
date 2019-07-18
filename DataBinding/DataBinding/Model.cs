using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{

    public class Model
    {
        string name
        {
            get;
            set;
        }

        int id
        {
            get;
            set;
        }
        string dept
        { 
            get; 
            set; 
        }

        ObservableCollection<EmployeeData> data = new ObservableCollection<EmployeeData>();

        public ObservableCollection<EmployeeData> Data
        {
            get { return data; }
        }

        public struct EmployeeData
        {
            public string name { get; set; }
            public int id { get; set; }
            public string dept { get; set; }
        }
        EmployeeData detail = new EmployeeData();

        public EmployeeData AddDataBase()
        {

            detail.name = name;
            detail.id = id;
            detail.dept = dept;

            data.Add(detail);
            return detail;
        }

    }
    public static class Department
    {
        private static List<string> department = new List<string> { "Finance", "Procurment", "Logistic" };

        public static List<string> dept
        {
            get { return department; }
        }

        
    }
}
