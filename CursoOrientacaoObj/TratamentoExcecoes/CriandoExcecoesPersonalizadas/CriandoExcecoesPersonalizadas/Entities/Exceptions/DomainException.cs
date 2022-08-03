namespace CriandoExcecoesPersonalizadas.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string messsage) : base(messsage)
        {
        }
    }
}
