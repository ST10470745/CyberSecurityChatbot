using System.Media;

namespace CyberSecurityChat
{
    class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("audio/greeting.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Voice greeting could not be played.");
            }
        }
    }
}