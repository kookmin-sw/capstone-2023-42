using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SimpleRandomWalkParameters_", menuName = "PCG/SimpleRandomWalkData", order = 0)]
public class SimpleRandomWalkSO : ScriptableObject 
{
    public int iterations = 10, walkLength = 10;
    public bool startRandomlyEachIteration = true;
}