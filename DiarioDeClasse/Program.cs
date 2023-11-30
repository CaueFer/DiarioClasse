
using DiarioDeClasse.Services;
using DiarioDeClasse.Views;
using System;

namespace DiarioDeClasse
{
    public class Program
    {
        static void Main(string[] args)
        {
            AlunoService alunoService = new AlunoService();
            DisciplinaService DisciplinaService = new DisciplinaService();
            ProfessorService ProfessorService = new ProfessorService();
            TurmaService TurmaService = new TurmaService();
            FaltaService faltaService = new FaltaService();

            Application.Run(new HUDlogin(TurmaService, DisciplinaService, ProfessorService, alunoService, faltaService));
        }
    }
}
