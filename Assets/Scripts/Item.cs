using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Standardaufbau aller vom Nutzer platzierbaren Objekte
public class Item : MonoBehaviour
{

    public string name;
    public Vector3 Position;
    public GameObject item;

    

    void Animate()
    {
        //Animationen hier hinzufuegen
    }

    void Start()
    {
        item = this.gameObject;
        name = item.name;
        //Stage2 = GameObject.Find(name + "2");
        //Debug.Log(Stage2);
        Position = item.transform.position;
        Debug.Log(name + ";" + Position + ";" + item);
        item.SetActive(false); //deactivates asset in bowl
    }

}


