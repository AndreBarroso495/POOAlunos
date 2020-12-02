namespace POOAlunos.classes
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public string rg;
        public int idade;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public float verMediaAluno(){
            return this.mediaFinal;
        }
        public float verMensalidade(bool bolsista){
            float valor;
            if (bolsista == true)
            {
                valor = this.valorMensalidade * 0.5f;
            }else{
                valor = this.valorMensalidade;
            }


            return valor;
        }
        
    }
}