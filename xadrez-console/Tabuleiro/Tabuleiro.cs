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
        public Peca GetPeca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }
        public void InsertPeca(Peca peca, Posicao pos) 
        {
            if (ExistPeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }

            Pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;
        }
        public bool ExistPeca(Posicao posicao) 
        {
            ValidatePosition(posicao);
            return GetPeca(posicao) != null;
        }
        public bool IsValidPosition(Posicao pos)
        {
            if (pos == null) return false;

            if (pos.Linha > Linhas || pos.Linha < 0) { return false; }

            if (pos.Coluna > Colunas|| pos.Coluna< 0) { return false; }

            return true;
        }

        public void ValidatePosition(Posicao pos)
        {
            if(!IsValidPosition(pos)) throw new TabuleiroException("posição invalida!");
        }
    }
}
