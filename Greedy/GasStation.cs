/*
There are n gas stations along a circular route, where the amount of gas at the ith station is gas[i].

You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from the ith station to its next (i + 1)th station. You begin the journey with an empty tank at one of the gas stations.

Given two integer arrays gas and cost, return the starting gas station's index if you can travel around the circuit once in the clockwise direction, otherwise return -1. If there exists a solution, it is guaranteed to be unique.
*/

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Length;
        int start = 0;
        int totalCountOfGas = 0;
        int totalCountOfCost = 0;
        int sum = 0;

        for(int i = 0; i < n; i++)
        {
            totalCountOfGas += gas[i];
            totalCountOfCost += cost[i];
        
            sum += gas[i]-cost[i];
            if(sum < 0)
            {
                sum = 0;
                start = i+1;
            }
        }

        if(totalCountOfGas < totalCountOfCost) 
            return -1;

        return start;
    }
}