using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : Item
{
    public GameObject plant_next; //plant of next stage
    public GameObject plant_pre; //plant of previous stage/next two stages

    public GameObject button; //button to start the simulation


    public int stage; //current stage of simulation


    void Start() {

       
    }

    
    
    void ChangePlant() {

        //stage = button.GetComponent<Simulation>().stage;
        if (stage == 0) {
            plant_next.SetActive(false);
            plant_pre.SetActive(false);
        }
        else if (stage == 1) {
            plant_next.SetActive(true);
            plant_pre.SetActive(false);
            item.SetActive(false);
        }
        else if (stage == 2) {
            plant_next.SetActive(false);
            plant_pre.SetActive(true);
            item.SetActive(false);
        }
        else {
            Debug.Log("Keine Bedingung ist erfüllt"); //if stage is not 0, 1 or 2, do nothing
        }
    }
    
}
