using System;

namespace FrogKnightMonoGL
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class RunGame
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new FrogKnight())
                game.Run();
        }
    }
#endif
}
