using System;
using System.Collections.Generic;

namespace MinimumRefill
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxDist = 400;
            var distanceTraveledSoFar = 0;
            var endpoint = 1155;

            //assuming gasStations are in ascending order 
            var gasStations = new int[] {200, 375, 550, 750};
            List<int> stationsWhereRefill = new List<int>();

            //cant reach first station
            if (gasStations[0] > maxDist)
            {
                throw new ApplicationException("Cant reach!");
            }

            for (int i = 1; i < gasStations.Length; i++)
            {
                if (gasStations[i] > maxDist + distanceTraveledSoFar)
                {
                    //refill at previous here
                    stationsWhereRefill.Add(gasStations[i-1]);
                    distanceTraveledSoFar = gasStations[i-1];

                    if (distanceTraveledSoFar + maxDist >= endpoint)
                    {
                        break;
                    }
                }

                //very last
                if (i == gasStations.Length - 1)
                {
                    stationsWhereRefill.Add(gasStations[i]);
                    distanceTraveledSoFar = gasStations[i];
                }
            }

            if (distanceTraveledSoFar + maxDist < endpoint)
            {
                throw new ApplicationException($"Cant reach! max distance travelled so far { distanceTraveledSoFar} and can reach upto {distanceTraveledSoFar + maxDist}");
            }


            Console.WriteLine("Refill at following kms");
            foreach (var gasStation in stationsWhereRefill)
            {   
                Console.WriteLine(gasStation);
            }
        }
    }
}
