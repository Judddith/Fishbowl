using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Simulation : MonoBehaviour
{


    public int simulationPoints;
    public int stage;
    public bool addedNewAsset;
    public bool failedOnce;

    

    
    
    

    public void AddPoints(int points) 
    {
        simulationPoints += points;
    }

    public void RemovePoints(int points)
    {
        simulationPoints -= points;
        if (simulationPoints < 0)
        {
            simulationPoints = 0;
        }
    }

    public void CheckStage()
    {
        if (simulationPoints == 0 && failedOnce == true)
        {
            stage = 2;
        }
        else if (simulationPoints <= 5 && failedOnce == false)
        {
            stage = 1;
        }
        else 
        {
            stage = 0;
        }
    }
   
}
