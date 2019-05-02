using System;
using System.Collections.Generic;
using System.Text;

namespace App5.Modelos
{
    class Curso
    {
        // lista de disciplinas
        public List<Disciplina> Disciplinas = new List<Disciplina>();

        // atributo nome
        private String nome;

        public String Nome
        {

            get
            {
                return this.nome;
            }

        }

        // construtor da classe
        public Curso(String nome)
        {
            this.nome = nome;
        }

    }
}
