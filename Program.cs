using Pv;

using (PvRecorder recorder = PvRecorder.Create(0, frameLength: 1024))
{
    Console.WriteLine($"Using device: {recorder.SelectedDevice}");
    Console.Write($"Listening...\n");
    recorder.Start();

    while (true)
    {
        short[] pcm = recorder.Read();

        Console.WriteLine($"Read {pcm.Length} bytes");

        Thread.Yield();
    }
}