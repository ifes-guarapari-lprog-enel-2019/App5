using System;
using System.Collections.Generic;
using System.Text;

namespace App5.Modelos
{
    class Disciplina
    {

        // atributo nome
        private String nome;

        public String Nome
        {

            get
            {
                return this.nome;
            }

        }

        // atributo horas
        private int horas;

        public int Horas
        {
            get
            {
                return this.horas;
            }
            set
            {
                this.horas = value;
            }
        }

        public Disciplina(String nome)
        {
            this.nome = nome;
        }

    }
}
