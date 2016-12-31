using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeHelpDB.Context;
using WeHelpDB.Repositories.Classes;

namespace WeHelpDB.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        #region Properties
        private WeHelpContext weHelpContext;
        private UserRepository userRepository;
        private CategoryRepository categoryRepository;
        private EventRepository eventRepository;
        #endregion

        #region Repositories
        public UserRepository UserRepository {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(this.weHelpContext);
                }
                return userRepository;
            }
        }

        public CategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(this.weHelpContext);
                }
                return categoryRepository;
            }
        }

        public EventRepository EventRepository
        {
            get
            {
                if (eventRepository == null)
                {
                    eventRepository = new EventRepository(this.weHelpContext);
                }
                return eventRepository;
            }
        }
        #endregion

        #region Construtor
        public UnitOfWork(WeHelpContext weHelpContext)
        {
            this.weHelpContext = weHelpContext;
        }
        #endregion

        #region Methods
        public int Save()
        {
            return weHelpContext.SaveChanges();
        }
        #endregion

        #region IDisposable
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    weHelpContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


    }
}
