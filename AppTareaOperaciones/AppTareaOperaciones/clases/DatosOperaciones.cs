using System;
using System.Collections.Generic;
using System.Text;

namespace AppTareaOperaciones.clases
{
    
    class DatosOperaciones
    {
        public double numero1;
        public double numero2;
      
        public DatosOperaciones() { }
        public DatosOperaciones(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
           
        }

 
        public void setNumero1(double _numero1)
        {
            
            this.numero1 = _numero1;
            
        }
        public void setNumero2(double _numero2)
        {
            this.numero2 = _numero2;
        }

     
        public double getNumero1()
        {
            return numero1;
        }
        public double getNumero2()
        {
            return numero2;
        }

       

    }
}
