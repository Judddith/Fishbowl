using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantWorm : MonoBehaviour, IInventoryItem
{
    GameObject ObjectWorm;

    public string Name 
    { 
        get
        {
            return "GiantWorm";
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPlacement()
    {
        Debug.Log("Badischer Riesenregenwurm");
        ObjectWorm.SetActive(true);
    }

    GameObject UserInv;

    void Start()
    {
        UserInv = GameObject.Find("UserInventory");
        UserInv.GetComponent<UserInventory>().AddToInventory(this);

        ObjectWorm = GameObject.Find("GiantWorm");
    }

}
