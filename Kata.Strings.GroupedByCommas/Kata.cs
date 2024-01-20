namespace Kata.Strings.GroupedByCommas;

using System.Linq;

public static class Kata
{
    public static string GroupByCommas(int n)
    {
        var values = n.ToString();
        int lenght = values.Length;
        int groupBy = 3;
        int remainder = lenght % groupBy;
        int divide = lenght / groupBy;
        string chunks = string.Empty;

        string chunk = GetChunk(values, 0, remainder);

        chunks += !string.IsNullOrEmpty(chunk) && divide > 0 ? chunk + "," : chunk;

        remainder++;

        for (int i = remainder; i < lenght; i = i + groupBy)
        {
            chunks += GetChunk(values, remainder - 1, groupBy);
            chunks += (remainder + groupBy - 1 != lenght) ? "," : string.Empty;
            remainder = remainder + groupBy;
        }

        return chunks;
    }

    private static string GetChunk(string values, int from, int distance)
    {
        return values.Substring(from, distance);
    }
}