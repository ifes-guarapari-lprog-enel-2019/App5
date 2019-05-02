using System;
using System.Collections.Generic;
using System.Text;

namespace App5.Modelos
{
    class Aluno
    {

        // lista de matriculas
        public List<Matricula> Matriculas = new List<Matricula>();

        // atributo nome
        private String nome;

        public String Nome {

            get
            {
                return this.nome;
            }

        }

        // construtor da classe
        public Aluno(String nome)
        {
            this.nome = nome;
        }

        // método cursar (estabelece uma dependência da classe com Matricula e Curso)
        public Matricula Cursar(Curso curso)
        {
            // criar nova matrícula
            Matricula matricula = new Matricula(this, curso);
            // adicionar na lista
            Matriculas.Add(matricula);
            // retornar nova matrícula
            return matricula;
        }


    }
}
