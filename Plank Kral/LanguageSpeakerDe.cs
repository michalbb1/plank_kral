using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Media;

namespace Plank_Kral
{
    class LanguageSpeakerDe : LanguageSpeaker
    {
        SoundPlayer m_sndUnd;
        public LanguageSpeakerDe(string languageDir) : base(languageDir)
        {
            m_sndUnd = new SoundPlayer(languageDir + "und.wav");

        }

        public override void SayTime(int sec)
        {
            int minutes = sec / 60;
            int seconds = sec % 60;
            if (minutes > 0)
            {
                SoundsQueuePlayer.AddSound(m_sndNormal[minutes]);
                SoundsQueuePlayer.AddSound(minutes == 1 ? m_sndMinute : m_sndMinutes);
            }
            if (seconds > 0)
            {
                if (seconds <= 19)
                    SoundsQueuePlayer.AddSound(m_sndNormal[seconds]);
                else
                {
                    int restSec = seconds % 10;
                    if (restSec > 0)
                    {
                        SoundsQueuePlayer.AddSound(m_sndNormal[restSec]);
                        SoundsQueuePlayer.AddSound(m_sndUnd);
                    }
                    int mulTen = (seconds / 10) * 10;
                    SoundsQueuePlayer.AddSound(m_sndNormal[mulTen]);

                }
                SoundsQueuePlayer.AddSound(m_sndSeconds);
            }
        }
    }
}
