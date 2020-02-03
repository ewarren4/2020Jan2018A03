<Query Kind="Statements">
  <Connection>
    <ID>709df223-7662-44a7-a163-cd75e912213c</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Albums
			  where x.Artist.Name.Contains("Deep")
			  select new
			  {
			    AlbumTitle = x.Title,
				Year = x.ReleaseYear,
				ArtistName = x.Artist.Name
			  };
//the method .Dump() is a LinqPad method only
results.Dump();