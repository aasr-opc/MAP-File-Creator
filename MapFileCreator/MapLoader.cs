namespace MapFileCreator;

public class MapLoader
{
    public List<MapItem> LoadMap(string filePath)
    {
        var result = new List<MapItem>();
        var mapFileContent = File.ReadAllLines(filePath);
        var lines = mapFileContent.Skip(1);

        foreach (var line in lines)
        {
            if (line == "3")
            {
                continue;
            }

            var lineSegments = line.Split(' ');

            var mapItem = new MapItem
            {
                IsInCity = lineSegments[0].Substring(0, 1) == "+",
                Type = lineSegments[0].Substring(1).TrimEnd(':'),
                X = int.Parse(lineSegments[1]),
                Y = int.Parse(lineSegments[2]),
                Facet = int.Parse(lineSegments[3]),
                Label = string.Join(" ", lineSegments.Skip(4))
            };
            result.Add(mapItem);
        }

        return result;
    }
}
