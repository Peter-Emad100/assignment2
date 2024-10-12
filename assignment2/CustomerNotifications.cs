using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class CustomerNotifications
    {
        public void sendNotification(ISendable i)
        {

        }
    }
    public interface ISendable
    {
        void sendConfig();
    }
    public class Email : ISendable
    {
        public void sendConfig() { }
    }
    public class SMS : ISendable
    {
        public void sendConfig() { }
    }
    public class PushcNotification: ISendable
    {
        public void sendConfig() { }
    }
}
