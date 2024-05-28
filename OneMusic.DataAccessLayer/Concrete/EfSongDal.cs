using Microsoft.EntityFrameworkCore;
using OneMusic.DataAccessLayer.Abstract;
using OneMusic.DataAccessLayer.Context;
using OneMusic.DataAccessLayer.Repositories;
using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.DataAccessLayer.Concrete
{
    public class EfSongDal : GenericRepository<Song>, ISongDal
    {
      private readonly OneMusicContext _context;

        public EfSongDal(OneMusicContext context) : base(context)
        {
            _context = context;
        }

        public List<Song> GetSongByArtist(int id)
        {
            return _context.Songs.Include(x => x.Album)
                                 .ThenInclude(y => y.AppUser)
                                 .Where(x => x.Album.AppUser.Id == id)
                                 .ToList();
        }

        List<Song> ISongDal.GetSongWithAlbum()
        {
            return _context.Songs.Include(x => x.Album).ToList();
        }
    }
}
