using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShauryaTechTest.Database
{
    public static class stt_dbContext
    {
        private static DatabaseContext _stt_dbContext;
        private static readonly object _stt_lock = new object();

        public static DatabaseContext _dbContext
        {
            get {
                if (_stt_dbContext == null)
                {
                    lock (_stt_lock)
                    {
                        if (_stt_dbContext == null)
                        {
                            _stt_dbContext = new DatabaseContext();
                        }
                    }
                }
                return _stt_dbContext;
            }
        }
    }
}
