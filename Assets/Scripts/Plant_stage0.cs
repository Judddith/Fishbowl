using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_stage0 : Item
{

    //When the plant is healthy and doing fine. Stage 0 of the simulation
    public GameObject plant_stage1; //plant of next stage
    public GameObject plant_stage2; //plant of previous stage/next two stages

    public GameObject button; //button to start the simulation


    public int stage; //current stage of simulation
  

    void Start() {
        stage = GameObject.Find("StartButton").GetComponent<Simulation>().stage;
        button.AddEventListener("click", ChangePlant);
    }
    void Update() {
        /*if(stage!= GameObject.Find("StartButton").GetComponent<Simulation>().stage) {
            ChangePlant();
            stage = GameObject.Find("StartButton").GetComponent<Simulation>().stage;
        }*/
    }

    
    
    void ChangePlant() {
        Debug.Log($"ChangePlant sagt wir haben {stage}");
        //stage = button.GetComponent<Simulation>().stage;
        if (GameObject.Find("StartButton").GetComponent<Simulation>().stage == 0) {
            plant_stage1.SetActive(false);
            plant_stage2.SetActive(false);
        }
        else if (GameObject.Find("StartButton").GetComponent<Simulation>().stage == 1) {
            plant_stage1.SetActive(true);
            plant_stage2.SetActive(false);
            item.SetActive(false);
        }
        else if (GameObject.Find("StartButton").GetComponent<Simulation>().stage == 2) {
            plant_stage1.SetActive(false);
            plant_stage2.SetActive(true);
            item.SetActive(false);
        }
        else {
            Debug.Log("Keine Bedingung ist erfüllt"); //if stage is not 0, 1 or 2, do nothing
        }
    }
    
}
