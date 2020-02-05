<Query Kind="Program">
  <Connection>
    <ID>62b8fffe-44f5-471f-8f76-a465a14b2169</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

void Main()
{
	//Create a query showing the track song name, the length of the song in milliseconds
	// and whether the song is longer, shorter, or the average length of all songs
	
	//tip: you may at times need to do multiple queries to get your final answer.
	
	//concern: you need to know the average length of all songs BEFORE
	//	 you can test an individual song against all songs
	
	var resultavg = Tracks.Average(x => x.Milliseconds);
	var resultreport = from x in Tracks
						select new
						{
							song = x.Name,
							length = x.Milliseconds,
							LongShortAvg = x.Milliseconds > resultavg ? "Long" :
											x.Milliseconds < resultavg ? "Short" :
											"Average"
						};
	resultreport.Dump();
	
	
}

// Define other methods and classes here
