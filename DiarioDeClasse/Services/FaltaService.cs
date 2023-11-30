using DiarioDeClasse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeClasse.Services
{
    public class FaltaService
    {
        List<FaltaModel> listFaltas;
        public FaltaService() 
        {   
            listFaltas = new List<FaltaModel>();
        }

        public List<FaltaModel> ReturnFaltas()
        {
            return listFaltas;
        }

        public void Adicionar(DisciplinaModel disciplina, AlunoModel aluno, DayOfWeek dia)
        {

            FaltaModel novaFalta = new FaltaModel { aluno = aluno, disciplina = disciplina, dia = dia};

            listFaltas.Add(novaFalta);
        }

        public bool RemoveFalta(string nome)
        {
            FaltaModel faltaModel = listFaltas.Find(a => a.aluno.Nome == nome);

            if (faltaModel != null)
            {
                listFaltas.Remove(faltaModel);

                return true;
            }
            else return false;
        }
    }
}
