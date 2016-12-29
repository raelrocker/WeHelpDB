using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeHelpDB.Context;

namespace WeHelpDB.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        #region Properties
        private WeHelpContext weHelpContext;
        #endregion

        #region Repositories
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
