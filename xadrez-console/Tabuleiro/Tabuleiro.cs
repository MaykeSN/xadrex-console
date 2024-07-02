namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
        public Peca GetPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        public void InsertPeca(Peca peca, Posicao pos) 
        {
            Pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;
        }
    }
}
