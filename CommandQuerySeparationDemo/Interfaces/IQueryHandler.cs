namespace CommandQuerySeparationDemo.Interfaces
{
    public interface IQueryHandler<TResult>
    {
    }

    public interface IQueryHandler<TResult, TQuery> where TQuery: IQueryHandler<TResult>
    {
        TResult Handle(TQuery query);
    }
}
