using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_CS.Clases
{
    public class Persona
    {
        protected string _nombre;
        protected string _apPaterno;
        protected string _apMaterno;
        protected DateTime? _fechaNacimiento;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string APPaterno
        {
            get
            {
                return _apPaterno;
            }
            set
            {
                _apPaterno = value;
            }
        }
        public string APMaterno
        {
            get
            {
                return _apMaterno;
            }
            set
            {
                _apMaterno = value;
            }
        }

        public DateTime? FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }
        public Int16 Edad
        {
            get
            {
                int _edad;
                try
                {
                    _edad = (DateTime.Now.Year - FechaNacimiento.Value.Year);
                    return (short)_edad;
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }
        public Persona()
        {
            _nombre = string.Empty;
            FechaNacimiento = null;
        }
        public Persona(string _nombre, DateTime? _fechaNacimiento)
        {
            this._nombre = _nombre;
            this._fechaNacimiento = _fechaNacimiento;
        }
        public override string ToString()
        {
            return _nombre.ToUpper() + " " + Edad;
        }
    }

}
