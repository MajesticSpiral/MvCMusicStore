﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace MvcMusicStore.Models
{
	public class Album
	{
		[Key]
		public int AlbumId { get; set; }
		public int GenreId { get; set; }
		public int ArtistId { get; set; }
		public string Title { get; set; }
		public decimal Price { get; set; }
		public string AlbumArtUrl { get; set; }
		public Genre Genre { get; set; }
		public Artist Artist { get; set; }
		public List<Album> Albums { get; set; }
	}
}