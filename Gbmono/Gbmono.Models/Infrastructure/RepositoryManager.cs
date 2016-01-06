
using Gbmono.Models.DataContext;
using Gbmono.EF;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Gbmono.Models.Models;

namespace Gbmono.Models.Infrastructure
{
    public class RepositoryManager<T> where T : class
    {
        // db context
        public DbContext Context { get; private set; }

        #region ctors
        // default constructor
        public RepositoryManager()
        {
            Context = new GbmonoSqlContext(); // create new instance of sql context with default settings
        }

        // constructor with extra settings
        public RepositoryManager(int commandTimeout, bool enableAutoDetectChanges, bool enableValidateOnSave)
        {
            Context = new GbmonoSqlContext();

            Context.Configuration.AutoDetectChangesEnabled = enableAutoDetectChanges;
            Context.Configuration.ValidateOnSaveEnabled = enableValidateOnSave;

            // command timeout
            var objectContext = ((IObjectContextAdapter)Context).ObjectContext;

            objectContext.CommandTimeout = commandTimeout; // value in seconds
        }

        #endregion

        // entity repositories
        private IRepository<Category> _categoryRepository;

        // public accessors
        public IRepository<Category> CategoryRepository
        {
            get { return _categoryRepository ?? (_categoryRepository = new Repository<Category>(Context)); }
        }


        //Generica Repository
        private IRepository<T> _Repository;

        // public accessors
        public IRepository<T> Repository
        {
            get { return _Repository ?? (_Repository = new Repository<T>(Context)); }
        }
    }
}
