using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programmers
{
    class Bridge
    {
        private static Bridge m_instance;
        public static Bridge Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Bridge();
                }
                return m_instance;
            }
        }
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int time = 0;
            Queue<Truck> WaitTruck = new Queue<Truck>();
            Truck[] Trucks = new Truck[truck_weights.Length];
            for (int i=0;i< truck_weights.Length; i++)
            {
                WaitTruck.Enqueue(new Truck(truck_weights[i]));
            }
            int CurrentPoint = 0;
            int weighLeft = weight;
            Queue<Truck> onBridge = new Queue<Truck>();
            while (!(onBridge.Count == 0 && WaitTruck.Count == 0))
            {
                time++;
                if (onBridge.Count > 0)
                    if(onBridge.First().length >= bridge_length)
                    {
                        weighLeft += onBridge.First().weigh;
                        onBridge.Dequeue();
                    }
                if(WaitTruck.Count > 0)
                    if(WaitTruck.First().weigh <= weighLeft)
                    {
                        weighLeft -= WaitTruck.First().weigh;
                        onBridge.Enqueue(WaitTruck.Dequeue());
                    }
                if (onBridge.Count > 0)
                    foreach (Truck t in onBridge)
                    {
                        t.length++;
                    }
                Thread.Sleep(100);
                Console.WriteLine(time + ":::::::" + weighLeft);
            }
            return time;
        }
        class Truck
        {
            public int weigh;
            public int length;
            public bool done;
            public Truck(int w)
            {
                weigh = w;
                length = 0;
                done = false;
            }
        }
    }
}
