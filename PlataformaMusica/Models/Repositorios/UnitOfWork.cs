using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Models.Repositorios
{
    public class UnitOfWork : IDisposable
    {
        private MusicaContext context = new MusicaContext();

        private GenericRepository<Artista> artistaRepository;
        public GenericRepository<Artista> ArtistaRepository
        {
            get
            {
                if (this.artistaRepository == null)
                {
                    this.artistaRepository = new GenericRepository<Artista>(context);
                }
                return artistaRepository;
            }
        }
        private GenericRepository<Cancion> cancionRepository;
        public GenericRepository<Cancion> CancionRepository
        {
            get
            {
                if (this.cancionRepository == null)
                {
                    this.cancionRepository = new GenericRepository<Cancion>(context);
                }
                return cancionRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
