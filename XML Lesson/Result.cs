﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Lesson {
	class Result {
		public string WrapperType { get; set; }
		public string Kind { get; set; }
		public long ArtistId { get; set; }
		public long CollectionId { get; set; }
		public long TrackId { get; set; }
		public string ArtistName { get; set; }
		public string CollectionName { get; set; }
		public string TrackName { get; set; }
		public string CollectionCensoredName { get; set; }
		public string TrackCensoredName { get; set; }
		public string ArtistViewUrl { get; set; }
		public string CollectionViewUrl { get; set; }
		public string TrackViewUrl { get; set; }
		public string PreviewUrl { get; set; }
		public string ArtworkUrl30 { get; set; }
		public string ArtworkUrl60 { get; set; }
		public string ArtworkUrl100 { get; set; }
		public double CollectionPrice { get; set; }
		public double TrackPrice { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string CollectionExplicitness { get; set; }
		public string TrackExplicitness { get; set; }
		public int DiscCount { get; set; }
		public int DiscNumber { get; set; }
		public int TrackCount { get; set; }
		public int TrackNumber { get; set; }
		public int TrackTimeMillis { get; set; }
		public string Country { get; set; }
		public string Currency { get; set; }
		public string PrimaryGenreName { get; set; }
		public bool IsStreamable { get; set; }
	}
}