using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Model
    {
        private static double T = 0;
        public static double Time { get { return T; } }
        
        private static List<Agent> agents = new List<Agent>();
        static Restoraunt restoraunt;
        static ClientCustom clientCustom;
        static Agent activeAgent;
        public static int people = 0;

        public static int operators;

        public static void Run()
        {
            
            
            do
            {

                double tmin = double.MaxValue;
                activeAgent = null;
                foreach (Agent a in agents)
                {
                    double ta = a.getNextEventTime();
                    if (ta < tmin)
                    {
                        tmin = ta;
                        activeAgent = a;
                    }
                }
                T = tmin;
                if (activeAgent != null) 
                    activeAgent.ProccessEvent();
                people++;
            } while (!stopCondirion(T, activeAgent));

        }

        public static void GO() 
        {
            restoraunt = new Restoraunt();
            clientCustom = new ClientCustom(restoraunt);
            agents.Add(restoraunt);
            agents.Add(clientCustom);
        }

        public static int queueCount()
        {
            return restoraunt.getQueueSize();
        }
        public static int getBusyOperatorsCount()
        {
            return restoraunt.getBusyOperatorsCount();
        }

        private static bool stopCondirion(double t, Agent activeAgent)
        {
            return (t < 100) || (activeAgent == null);
        }
    
    }
}
