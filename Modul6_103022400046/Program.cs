using System;
public class SayaMusicUser
{
    private int id;
    public string Username;
    private List<SayaMusicTrack> uploadedTracks;

    public SayaMusicUser(string Username)
    {
        this.Username = Username;
        this.uploadedTracks = new List<SayaMusicTrack>();
    }

    public int GetTotalPlayCount()
    {
        return uploadedTracks.Count;
    }

    public void AddTrack(SayaMusicTrack track)
    {
        uploadedTracks.Add(track);
    }

    public void PrintAllTracks()
    {
        int number = 1;
        foreach (var item in uploadedTracks)
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Track: {number++} : {item.title}");
        }
    }
}

public class SayaMusicTrack
{
    private int id;
    public string title;
    private int playCount;

    public SayaMusicTrack(string title)
    {
        this.title = title;
        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID Lagu: {this.id}");
        Console.WriteLine($"Judul Lagu: {this.title}");
        Console.WriteLine($"Total Play: {this.playCount}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        SayaMusicUser user1 = new SayaMusicUser("Dhiyaul");

        SayaMusicTrack track1 = new SayaMusicTrack("Kembali Pulang");
        SayaMusicTrack track2 = new SayaMusicTrack("Mantan Terindah");
        SayaMusicTrack track3 = new SayaMusicTrack("Risk it all");
        SayaMusicTrack track4 = new SayaMusicTrack("New Jeans");
        SayaMusicTrack track5 = new SayaMusicTrack("Likey");
        SayaMusicTrack track6 = new SayaMusicTrack("Malu Malu");
        SayaMusicTrack track7 = new SayaMusicTrack("Kasih tau mama");
        SayaMusicTrack track8 = new SayaMusicTrack("Hujan");
        SayaMusicTrack track9 = new SayaMusicTrack("Akad");
        SayaMusicTrack track10 = new SayaMusicTrack("Dan ");

        track1.IncreasePlayCount(10);
        track2.IncreasePlayCount(20);
        track3.IncreasePlayCount(30);
        track4.IncreasePlayCount(40);
        track5.IncreasePlayCount(50);
        track6.IncreasePlayCount(60);
        track7.IncreasePlayCount(70);
        track8.IncreasePlayCount(80);
        track9.IncreasePlayCount(90);
        track10.IncreasePlayCount(100);


        user1.AddTrack(track1);
        user1.AddTrack(track2);
        user1.AddTrack(track3);
        user1.AddTrack(track4);
        user1.AddTrack(track5);
        user1.AddTrack(track6);
        user1.AddTrack(track7);
        user1.AddTrack(track8);
        user1.AddTrack(track9);
        user1.AddTrack(track10);

        user1.PrintAllTracks();

        Console.WriteLine("Total Play Count: " + user1.GetTotalPlayCount());
    }
}