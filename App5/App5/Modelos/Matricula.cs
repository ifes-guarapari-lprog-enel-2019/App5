using System;
using System.Collections.Generic;
using System.Text;

namespace App5.Modelos
{
    class Matricula
    {

        // lista de históricos
        public List<Historico> Historicos = new List<Historico>();

        // atributo aluno
        private Aluno aluno;

        public Aluno Aluno
        {
            get
            {
                return this.aluno;
            }
            set
            {
                this.aluno = value;
            }
        }

        // atributo curso
        private Curso curso;

        public Curso Curso
        {
            get
            {
                return this.curso;
            }
            set
            {
                this.curso = value;
            }
        }

        // atributo ano
        private int ano;

        public int Ano
        {
            get
            {
                return this.ano;
            }
            set
            {
                this.ano = value;
            }
        }

        // atributo semestre
        private int semestre;

        public int Semestre
        {
            get
            {
                return this.semestre;
            }
            set
            {
                this.semestre = value;
            }
        }

        // atributo codigo
        private String codigo;

        public String Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        // construtor da classe
        public Matricula()
        {
        }

        // construtor da classe
        public Matricula(Aluno aluno, Curso curso)
        {
            this.aluno = aluno;
            this.curso = curso;
            // pegar data atual
            DateTime date = DateTime.Now;
            this.ano = date.Year;
            this.semestre = date.Month % 6;
            this.codigo = date.Millisecond.ToString();
        }

        public Historico Matricular(Turma turma)
        {

        }

    }
}
