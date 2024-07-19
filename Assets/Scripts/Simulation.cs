using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Simulation : MonoBehaviour
{

    public GameObject button;
    public GameObject bowl;
    public int simulationPoints;
    public int stage;
    public bool addedNewAsset;
    public bool failedOnce;
    public int amountOfAssets = 10; // Placeholder, should be calculated based on the number of placeable assets.
    public int assetsToUnlock = 9; //Needs to be changed according to the number of unlockable assets.

    public List<GameObject> ListOfItems;

    void Start() {
        stage = 0;

        button = this.gameObject;
        ListOfItems = bowl.GetComponent<ItemsInBowl>().ItemsSpawned;

        
    }


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

    //Checks wether or not the next stage is reached
    public void CheckStage()
    {
        if (simulationPoints == 0 && failedOnce == true)
        {
            stage = 2;
            simulationPoints = 0;
        }
        else if (simulationPoints <= amountOfAssets/2 && failedOnce == false)
        {
            stage = 1;
            failedOnce = true;
            simulationPoints = 0;
        }
        else 
        {
            stage = 0;
            simulationPoints = 0;
            failedOnce = false;
        }
    }


    //Unlocks New Assets when criteria are met 
    public void UnlockNewAsset() {

        //Hier kommt der Code rein, um neue Assets freizuschalten
        assetsToUnlock -= 1;


    }

/// <summary>
/// TO-DO: CalculatePoints needs to be added to the Start Button
/// </summary>

    //Calculates Points for all items in the Bowl
    public void CalculatePoints() {

        //Loop through List of Items and add 1 point to simulationPoints for each item
        foreach (var item in ListOfItems) {
            AddPoints(1);
        }

        //If the player didn't use all assets points will be subtracted so the player can't win without using all assets
        if (amountOfAssets > ListOfItems.Count){
            RemovePoints(ListOfItems.Count - amountOfAssets);
            if (simulationPoints < 0) {
                simulationPoints = 0;
            }
        }
        

        //If new asset was added failure will be reseted to give player a chance to try again
        //Needs to be set true by adding a new asset to the ListOfItems
        if (addedNewAsset) {
            failedOnce = false;
        }

        CheckStage();

        //If the player failed once a new Asset will be unlocked
        if (failedOnce && assetsToUnlock > 0 && addedNewAsset == false) {
            UnlockNewAsset();
        }


    }
   
}
