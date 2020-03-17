using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Class_Creater
{
    public enum Parm_Type { String = 0, Int = 1, Double = 2, Decimal = 3 }

    public class Param : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private Parm_Type _ParamType = Parm_Type.String;
        [Display(Name = "ParamType", Description = "參數型態")]
        public Parm_Type ParamType
        {
            get { return _ParamType; }
            set
            {
                _ParamType = value;
                this.NotifyPropertyChanged("ParamType");
            }
        }

        private string _ParamName = string.Empty;
        [Display(Name = "ParamName", Description = "參數名稱")]
        public string ParamName
        {
            get { return _ParamName; }
            set
            {
                _ParamName = value;
                this.NotifyPropertyChanged("ParamName");
            }
        }

        public Param()
        {
            _ParamType = Parm_Type.String;
            _ParamName = string.Empty;
        }
        
        public static Dictionary<string, string> Get_Prop_Display()
        {
            Dictionary<string, string> _Infos = new Dictionary<string, string>();
            try
            {
                PropertyInfo[] propInfos = default(PropertyInfo[]);
                propInfos = typeof(Param).GetProperties();
                propInfos.ToList().ForEach(x =>
                {
                    IList<CustomAttributeData> cad = (x as System.Reflection.MemberInfo).GetCustomAttributesData();
                    _Infos.Add(x.Name, cad[0].NamedArguments[1].TypedValue.Value.ToString());
                });

                return _Infos;
            }
            catch (Exception ex)
            {
                return _Infos;
            }
        }
    }
}
