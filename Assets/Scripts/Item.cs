using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Standardaufbau aller vom Nutzer platzierbaren Objekte
public class Item : MonoBehaviour
{

    public string name;
    public Vector3 Position;
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;

    

    void Animate()
    {
        //Animationen hier hinzufuegen
    }

    void Start()
    {
        name = Stage1.name;
        Stage2 = GameObject.Find(name + "2");
        Debug.Log(Stage2);
        Position = Stage1.transform.position;
        Debug.Log(name + ";" + Position + ";" + Stage1);
        Stage1.SetActive(false); //deactivates asset in bowl
    }

    void Change()
    {

    }
}


