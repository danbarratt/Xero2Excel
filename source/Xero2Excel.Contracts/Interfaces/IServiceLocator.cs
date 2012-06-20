namespace Xero2Excel.Contracts.Interfaces
{
    public interface IServiceLocator
    {
        TService Get<TService>();
    }
}
