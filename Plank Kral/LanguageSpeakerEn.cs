using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plank_Kral
{
    class LanguageSpeakerEn : LanguageSpeaker
    {
        public LanguageSpeakerEn(string languageDir) : base(languageDir)
        {

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
                    int mulTen = (seconds / 10) * 10;
                    SoundsQueuePlayer.AddSound(m_sndNormal[mulTen]);
                    int restSec = seconds % 10;
                    if (restSec > 0)
                        SoundsQueuePlayer.AddSound(m_sndNormal[restSec]);
                }
                SoundsQueuePlayer.AddSound(m_sndSeconds);
            }
        }
    }
}
