using System;
namespace tabuleiro
{
    internal class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string message) : base(message) { }
    }
}
