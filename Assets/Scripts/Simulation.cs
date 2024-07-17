using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{


    public int simulationPoints;
    public int stage;
    public bool addedNewAsset;
    public bool failedOnce;

    ItemsSpawned itemsSpawned;


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

    public void checkStage()
    {
        if(simulationPoints = 0 && failedOnce)
        {
            stage = 2;
        }
        else if(simulationPoints <= 5 && failedOnce == false)
        {
            stage = 1;
        }
        else 
        {
            stage = 0;
        }
    }

    void Start()
    {
        itemsSpawned = FindObejctOfType<ItemsInBowl>();

        if (itemsSpawned != null)
        {
            public List<Item> items = itemsSpawned.ItemsSpawned;
            Debug.Log("Access successfull")
        }
    }

    public void checkList() 
    {
        foreach(Item item in items)
        {
            Debug.Log(item.Name);
        }
    }

}
