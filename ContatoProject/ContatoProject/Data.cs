using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatoProject
{
    public class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public int getDia()
        {
            return this.dia;
        }

        public void setDia(int dia)
        {
            this.dia = dia;
        }

        public int getMes()
        {
            return this.mes;
        }

        public void setMes(int mes)
        {
            this.mes = mes;
        }

        public int getAno()
        {
            return this.ano;
        }

        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public override string ToString()
        {
            return $"{this.dia:00}/{this.mes:00}/{this.ano:0000}";
        }
    }
}
