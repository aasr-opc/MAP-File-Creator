using System.Text;

namespace MapFileCreator;

public class MapSaver
{
    public void SaveMap(string filePath, List<MapItem> mapItems)
    {
        var lines = new StringBuilder();
        lines.AppendLine("3");
        foreach (var mapItem in mapItems)
        {
            lines.AppendLine(MapItemToLine(mapItem));
        }

        File.WriteAllText(filePath, lines.ToString());
    }

    private string MapItemToLine(MapItem mapItem)
    {
        return $"{(mapItem.IsInCity ? "+" : "-")}{mapItem.Type}: {mapItem.X} {mapItem.Y} {mapItem.Facet} {mapItem.Label}";
    }
}