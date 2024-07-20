using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : Item
{

    //When the plant is healthy and doing fine. Stage 0 of the simulation
    public GameObject plant_stage1; //plant of next stage
    public GameObject plant_stage2; //plant of previous stage/next two stages

    public GameObject button; //button to start the simulation


    public int stage; //current stage of simulation


    
    void ChangePlant() {

        //stage = button.GetComponent<Simulation>().stage;
        if (stage == 0) {
            plant_stage1.SetActive(false);
            plant_stage2.SetActive(false);
        }
        else if (stage == 1) {
            plant_stage1.SetActive(true);
            plant_stage2.SetActive(false);
            item.SetActive(false);
        }
        else if (stage == 2) {
            plant_stage1.SetActive(false);
            plant_stage2.SetActive(true);
            item.SetActive(false);
        }
        else {
            Debug.Log("Keine Bedingung ist erfüllt"); //if stage is not 0, 1 or 2, do nothing
        }
    }
    
}
