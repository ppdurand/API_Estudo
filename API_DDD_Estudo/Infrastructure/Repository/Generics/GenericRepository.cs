using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Generics
{
    public class GenericRepository<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ContextBase> _dbContextOptions;
        public GenericRepository() 
        {
            _dbContextOptions= new DbContextOptions<ContextBase>();
        }
        public async Task Add(T entity)
        {
            using (var data = new ContextBase(_dbContextOptions))
            {
                await data.Set<T>
            }
        }

        public async Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> List()
        {
            throw new NotImplementedException();
        }

        public async Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        //IDisposable

        bool _disposedValue = false;

       
        SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);
        
        public void Dispose(int x)
        {
            //Coloquei esse paramentro e essa linha abaixo pra resolver um bug
            //Os dois são gambiarras e não tem função nenhuma no código
            x = 0;
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing) 
        {
            if(_disposedValue)
            {
                return;
            }
            if(disposing) 
            { 
                _safeHandle.Dispose();

            }
            _disposedValue = true;
        }

        
    }
}
