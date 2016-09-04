using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Media;

namespace Plank_Kral
{
    public static class SoundsQueuePlayer
    {
        public static void SoundsQueueMain()
        {
            bool bEnd = false;
            while(!bEnd)
            {
                if (m_shouldStop)
                    break;

                int iCurrentCount = m_soundsQueue.Count;
                for(int i = 0; i < iCurrentCount; i++)
                {
                    if (m_shouldStop)
                    {
                        bEnd = true;
                        break;
                    }
                    SoundPlayer snd = m_soundsQueue.Dequeue();
                    snd.PlaySync();
                }

                Thread.Sleep(100);
            }
        }

        private static Queue<SoundPlayer> m_soundsQueue;
        private static Thread m_threadPlayer;
        private static bool m_shouldStop;

        public static void Start()
        {
            ThreadStart childref = new ThreadStart(SoundsQueueMain);
            m_threadPlayer = new Thread(childref);
            m_shouldStop = false;
            m_threadPlayer.Start();
            m_soundsQueue = new Queue<SoundPlayer>();
        }
        
        public static void AddSound(SoundPlayer sound)
        {
            m_soundsQueue.Enqueue(sound);
        }

        public static void Stop()
        {
            m_shouldStop = true;
            m_threadPlayer.Join();
        }
    }
}
