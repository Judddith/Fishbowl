using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Standardaufbau aller vom Nutzer platzierbaren Objekte
public class Item : MonoBehaviour
{

    string Name {get;}
    Vector3 Position {get;}
    GameObject Object {get;}
    //GameObject Stage1 = Unity.FindGameObject();
    //ObjectName + Stage

    void animate(){
        //Animationen hier hinzufuegen
    }

    void Start() {
        Debug.Log(Name + ";" + Position + ";" + Object);
    }

    void Change(){

    }
}


