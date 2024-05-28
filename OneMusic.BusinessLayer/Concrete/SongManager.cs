using OneMusic.BusinessLayer.Abstract;
using OneMusic.DataAccessLayer.Abstract;
using OneMusic.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Concrete
{
	public class SongManager : ISongService
	{
		private readonly ISongDal _songDal;

		public SongManager(ISongDal songDal)
		{
			_songDal = songDal;
		}

		public void TCreate(Song t)
		{
			_songDal.Create(t);
		}

		public void TDelete(int id)
		{
			_songDal.Delete(id);
		}

		public Song TGetById(int id)
		{
			return _songDal.GetById(id);	
		}

		public List<Song> TGetList()
		{
			return _songDal.GetList();
		}

        public List<Song> TGetSongByArtist(int id)
        {
            return _songDal.GetSongByArtist(id);
        }

        public List<Song> TGetSongWithAlbum()
        {
            return _songDal.GetSongWithAlbum();
        }

        public void TUpdate(Song t)
		{
			_songDal.Update(t);
		}
	}
}
