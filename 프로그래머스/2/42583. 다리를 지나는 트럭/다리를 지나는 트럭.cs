using System;
using System.Collections.Generic;

public class Solution
{
    public class Truck
    {
        public int weight;
        public int pos;

        public Truck(int weight, int pos)
        {
            this.weight = weight;
            this.pos = pos;
        }
    }

    public class Bridge
    {
        public List<Truck> trucks = new List<Truck>();
        public int length;
        public int remainWeight;

        public Bridge(int length, int weight)
        {
            this.length = length;
            this.remainWeight = weight;
        }

        public void AddTruck(int weight)
        {
            if (remainWeight - weight < 0)
                return;

            trucks.Add(new Truck(weight, 0));
            remainWeight -= weight;
        }

        public int MoveTrucks(int length)
        {
            if (trucks.Count == 0)
                return 0;

            for(int i = trucks.Count - 1; i >= 0 ; i--)
            {
                trucks[i].pos += length;
                
                if (trucks[i].pos >= this.length)
                {
                    remainWeight += trucks[i].weight;
                    trucks.RemoveAt(i);
                }
            }

            return length;
        }
    }

    public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        int answer = 1;
        int i = 0;

        Bridge bridge = new Bridge(bridge_length, weight);

        while(i < truck_weights.Length || bridge.trucks.Count > 0)
        {
            if(i < truck_weights.Length)
            {
                if (bridge.remainWeight >= truck_weights[i])
                {
                    bridge.AddTruck(truck_weights[i]);
                    i++;
                    answer += bridge.MoveTrucks(1);
                    continue;
                }
            }

            answer += bridge.MoveTrucks(bridge.length - bridge.trucks[0].pos);
        }

        return answer;
    }
}