using System;

public class Playlist
{
    private string[] songs = { "Believer", "Perfect", "Faded" };

    // Indexer by int
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < songs.Length)
                return songs[index];

            return "Index Out of Range";
        }
        set
        {
            if (index >= 0 && index < songs.Length)
                songs[index] = value;
        }
    }

    // Indexer by string
    public string this[string songName]
    {
        get
        {
            foreach (var song in songs)
            {
                if (song.Equals(songName, StringComparison.OrdinalIgnoreCase))
                    return song;
            }

            return "Song Not Found";
        }
    }
}