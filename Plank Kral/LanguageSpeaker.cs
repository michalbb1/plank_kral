using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Plank_Kral
{
    public abstract class LanguageSpeaker
    {
        protected static int MAX_COUNTDOWN = 10;

        protected SoundPlayer[] countdown;
        protected SoundPlayer[] m_sndNormal;
        protected SoundPlayer m_sndGo;
        protected SoundPlayer m_sndStart;
        protected SoundPlayer m_sndFinish;
        protected SoundPlayer m_sndSeconds;
        protected SoundPlayer m_sndMinute;
        protected SoundPlayer m_sndMinutes;

        public LanguageSpeaker(String languageDir)
        {
            countdown = new SoundPlayer[MAX_COUNTDOWN+1];
            m_sndNormal = new SoundPlayer[101];
            for(int i = 0; i < MAX_COUNTDOWN; i++)
            {
                int j = MAX_COUNTDOWN - i;
                string sPath = languageDir + j.ToString() + "cnt.wav";
                countdown[j] = new SoundPlayer(sPath);
            }
            m_sndGo = new SoundPlayer(languageDir + "go.wav");
            m_sndFinish = new SoundPlayer(languageDir + "finish.wav");

            for(int i = 0; i < 101; i++)
            {
                String filename = languageDir + i.ToString() + ".wav";
                if(File.Exists(filename))
                    m_sndNormal[i] = new SoundPlayer(languageDir + i.ToString() + ".wav");
            }

            m_sndStart = new SoundPlayer(languageDir + "start.wav");
            m_sndSeconds = new SoundPlayer(languageDir + "seconds.wav");
            m_sndMinute = new SoundPlayer(languageDir + "minute.wav");
            m_sndMinutes = new SoundPlayer(languageDir + "minutes.wav");

        }

        public void SayCountdown(int sec)
        {
            SoundsQueuePlayer.AddSound(countdown[sec]);
        }

        public abstract void SayTime(int sec);

        public void SayStart()
        {
            m_sndStart.PlaySync();
        }

        public void SayGo()
        {
            SoundsQueuePlayer.AddSound(m_sndGo);
        }

        public void SayFinish()
        {
            SoundsQueuePlayer.AddSound(m_sndFinish);
        }
    }
}
