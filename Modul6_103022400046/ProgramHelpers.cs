internal static class ProgramHelpers
{
    public static void Main(string[] args)
    {
        SayaMusicUser user1 = new SayaMusicUser("ilhamrmdhn");

        SayaMusicTrack track1 = new SayaMusicTrack("Payung Teduh");
        SayaMusicTrack track2 = new SayaMusicTrack("Mati-Matian");
        SayaMusicTrack track3 = new SayaMusicTrack("Lagu Sunday");
        SayaMusicTrack track4 = new SayaMusicTrack("Lagu Monday");
        SayaMusicTrack track5 = new SayaMusicTrack("Lagu Tuesday");
        SayaMusicTrack track6 = new SayaMusicTrack("Lagu Wednesday");
        SayaMusicTrack track7 = new SayaMusicTrack("Lagu Thursday");
        SayaMusicTrack track8 = new SayaMusicTrack("Lagu Friday");
        SayaMusicTrack track9 = new SayaMusicTrack("Lagu Laguan");
        SayaMusicTrack track10 = new SayaMusicTrack("Kereta Malam");

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