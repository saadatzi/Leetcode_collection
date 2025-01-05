using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class ShortestPathInCircle
{
    public static int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        int clockwise = 0;
        int counterClockwise = 0;

        int i = start;
        while( i != destination)
        {
            clockwise += distance[i];
            i = ++i % distance.Length;
        }

        int j = destination;
        while( j != start)
        {
            counterClockwise += distance[j];
            j = ++j % distance.Length;
        }

        if(counterClockwise < clockwise)
        {
            return counterClockwise;
        }

        return clockwise;
    }
}