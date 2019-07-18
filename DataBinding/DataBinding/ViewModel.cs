using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataBinding
{
    public class ViewModel :INotifyPropertyChanged
    {
        private DataBinding.Model.EmployeeData employeeData;
        private Model mMod;
        public ViewModel()
        {
            var cmd = new MyCommand();
            cmd.Bind(() => AddInfoModel());
            AddEmployeeCommand = cmd;
            mMod = new Model();

        }
        public ICommand AddEmployeeCommand
        {
            get;
            set;
        }
        public List<string> DepartmentLst
        {
            get
            {
                return Department.dept;
            }
            
        }

        public Model Model
        {
            get
            {
                return mMod;
            }
        }
        public DataBinding.Model.EmployeeData EmployeeData
        {
            get { return employeeData; }
        }
        public Model AddInfoModel()
        {
            employeeData = mMod.AddDataBase();
            RaisePropertyChange("EmployeeData");
            return mMod;

        }

        public void RaisePropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
