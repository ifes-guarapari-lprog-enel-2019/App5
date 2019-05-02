﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App5.Modelos
{
    class Turma
    {

        // atributo disciplina
        private Disciplina disciplina;

        public Disciplina Disciplina
        {
            get
            {
                return this.disciplina;
            }
            set
            {
                this.disciplina = value;
            }
        }

        // lista de professores
        public List<Professor> Professores = new List<Professor>();

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

        // construtor da classe (estabelece uma agregação com as classes Disciplina e Professor)
        public Turma(Disciplina disciplina, Professor professor)
        {
            this.disciplina = disciplina;
            this.Professores.Add(professor);
        }

    }
}
