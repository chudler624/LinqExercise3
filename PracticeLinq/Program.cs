var videoGameNames= new List<string>()
{ "Madden 22",
  "Fifa World Cup", 
  "Call of Duty",
  "Roblox", 
  "Clash of Clans", 
  "CSR Racing", 
  "Archero" };

videoGameNames.OrderBy(x => x).ToList();

foreach (var item in videoGameNames)
    Console.WriteLine();