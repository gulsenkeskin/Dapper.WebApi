namespace DapperRepositoryPattern.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
