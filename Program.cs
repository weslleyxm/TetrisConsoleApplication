using Tetris;
using System.Runtime.InteropServices;

//  __          __         .__        
//_/  |_  _____/  |________|__| ______
//\   __\/ __ \   __\_  __ \  |/  ___/
// |  | \  ___/|  |  |  | \/  |\___ \ 
// |__|  \___  >__|  |__|  |__/____  >
//           \/                    \/ 


 //┌, ┐, └, ┘
 // ─
 //│
 //├, ┤, ┬, ┴, ┼

Time.Initialize();
Board.Initialize();

Console.CursorVisible = false;

while (true)
{
    Console.SetCursorPosition(0, 1);

    //Console.WriteLine($"Score: {Score.Current}");
    //Console.WriteLine($"Time: {Time.GetTime()}");

    Board.Update();
    Board.DrawBoard();
    Board.Clear();

    Thread.Sleep(200);

    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
        Console.BufferHeight = 200;
        Console.BufferWidth = 200;
    } 
}



