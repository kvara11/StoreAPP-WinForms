using Store.Repository;
using System;
using Xunit;

namespace Store.Tests
{
    public abstract class BaseRepositoryTest<TDomain, TRepository> : BaseTest
        where TDomain : class
        where TRepository : BaseRepository<TDomain>, new()
    {
        protected readonly TRepository _repository;

        public BaseRepositoryTest()
        {
            _repository = new TRepository();
        }

        public abstract void InsertTest();
    }
}
