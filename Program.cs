
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano"),
    new Eruption("Zardarbunga", 2022, "New York City", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");

// Execute Assignment Tasks here!


// Use LINQ to find the first eruption that is in Chile and print the result.
string firstEruptionInChile = eruptions.First( c => c.Location == "Chile" ).ToString();
Console.WriteLine( "First Eruption In Chile: " + firstEruptionInChile );


// Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
try
{
    Eruption Hawaii = eruptions.Where( c => c.Location == "Hawaiian Is" ).First();
    Console.WriteLine( "First Eruption in Hawaii: " + Hawaii);
}
catch
{
    Console.WriteLine("No Hawaiian eruption is found");
}

// Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
string firstEruptionInNewZealand = eruptions.First( c => c.Location == "New Zealand" && c.Year > 1900 ).ToString();
Console.WriteLine( "First Eruption after the year 1900 AND in New Zealand: " + firstEruptionInNewZealand );


// Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> elevationOver2000 = eruptions.Where( c => c.ElevationInMeters > 2000 );
PrintEach( elevationOver2000, "Eruptions where the volcano's elevation is over 2000m" );


// Find all eruptions where the volcano's name starts with "Z" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> startsWithZ = eruptions.Where( c => c.Volcano.ToLower().StartsWith( "z" ) );
PrintEach( startsWithZ, "Volcano eruption's that start with Z" );
Console.WriteLine( "Number of volcano eruptions that start with Z: " + startsWithZ.Count() );


// Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElevation = eruptions.Max( c => c.ElevationInMeters );
Console.WriteLine( "Highest Elevation: " + highestElevation );


// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
IEnumerable<Eruption> highestElevationVolcano = eruptions.Where( c => c.ElevationInMeters == highestElevation );
PrintEach( highestElevationVolcano, "Volcano eruption with the highest elevation" );


// Print all Volcano names alphabetically.
IEnumerable<Eruption> alphabetical = eruptions.OrderBy( c => c.Volcano );
PrintEach( alphabetical, "Volcanos in alphabetical order" );


// Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> before1000CE = eruptions.OrderBy( c => c.Volcano ).Where( c => c.Year < 1000 );
PrintEach( before1000CE, "Eruptions before 1000 CE" );


// BONUS: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
Console.WriteLine( "Bonus: " );
List<Eruption> before1000CENames = eruptions.OrderBy( c => c.Volcano ).Where( c => c.Year < 1000 ).ToList();
foreach( Eruption name in before1000CENames )
{
    Console.WriteLine( name.Volcano );
}




// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
