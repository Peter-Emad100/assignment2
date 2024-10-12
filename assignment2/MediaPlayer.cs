using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class MediaPlayer
    {
        public void run(IPlayable i)
        {

        }
    }
    internal interface IPlayable:IStoppable
    {
        public void play();

    }
    internal interface IStoppable
    {
        public void stop();
    }
    internal class Audio : IPlayable
    {
        public void play()
        {

        }
        public void stop()
        {

        }
    }
    internal class Video : IPlayable
    {
        public void play()
        {

        }
        public void stop()
        {

        }
    }
}
