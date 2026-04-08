namespace ProjetoEscola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();
            A.Nome = "João";
            A.Matricula = "M12344";
            A.Idade = 20;

            Professor P1 = new Professor();
            P1.Nome = "Maria";
            P1.Idade = 35;
            P1.Titulacao = "Doutorado";

            Funcionario F1 = new Funcionario();
            F1.Nome = "Carlos";
            F1.Idade = 40; 
            F1.SalarioMensal = 2000;

            FuncionarioNoturno FN = new FuncionarioNoturno();
            FN.Nome = "Ana";
            FN.Idade = 30;
            FN.SalarioMensal = 2500;
            FN.AdicionalNoturno = 500;

            Console.WriteLine(A.MostrarAluno());
            Console.WriteLine(P1.MostrarProfessor());
            Console.WriteLine(F1.MostrarFuncionario());
            Console.WriteLine(FN.MostrarFuncionarioNoturno());
            Console.ReadKey();
        }
    }
}