using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_stage2 : Item
{

    //When the plant is almost dead. Stage 2 of the simulation
    public GameObject plant_stage0; 
    public GameObject plant_stage1; 

    public GameObject button; //button to start the simulation


    public int stage; //current stage of simulation


    void Start() {
        stage = GameObject.Find("StartButton").GetComponent<Simulation>().stage;
        button.AddEventListener("click", ChangePlant);
        item.SetActive(false);
    }
    void Update() {
        /*stage = GameObject.Find("StartButton").GetComponent<Simulation>().stage;
        if(stage!= GameObject.Find("StartButton").GetComponent<Simulation>().stage) {
            ChangePlant();
            stage = GameObject.Find("StartButton").GetComponent<Simulation>().stage;
        }*/
    }
    
    void ChangePlant() {

        //stage = button.GetComponent<Simulation>().stage;
        if (GameObject.Find("StartButton").GetComponent<Simulation>().stage == 0) {
            plant_stage0.SetActive(true);
            plant_stage1.SetActive(false);
            item.SetActive(false);
        }
        else if (GameObject.Find("StartButton").GetComponent<Simulation>().stage == 1) {
            plant_stage0.SetActive(false);
            plant_stage1.SetActive(true);
            item.SetActive(false);
        }
        else if (GameObject.Find("StartButton").GetComponent<Simulation>().stage == 2) {
            plant_stage0.SetActive(false);
            plant_stage1.SetActive(false);
        }
        else {
            Debug.Log("Keine Bedingung ist erfüllt"); //if stage is not 0, 1 or 2, do nothing
        }
    }
    
}
