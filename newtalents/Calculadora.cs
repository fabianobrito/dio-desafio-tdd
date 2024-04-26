namespace newtalents
{
    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }

        public int Soma(int val1, int val2)
        {
            var result = val1 + val2;
            historico.Insert(0, $"val1 + val2 = {result}");
            return result;
        }

        public int Subtracao(int val1, int val2)
        {
            var result = val1 - val2;
            historico.Insert(0, $"val1 - val2 = {result}");
            return result;
        }

        public int Divisao(int val1, int val2)
        {
            var result = val1 / val2;
            historico.Insert(0, $"val1 / val2 = {result}");
            return result;
        }

        public int Multiplicacao(int val1, int val2)
        {
            var result = val1 * val2;
            historico.Insert(0, $"val1 * val2 = {result}");
            return result;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}