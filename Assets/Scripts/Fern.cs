using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fern : MonoBehaviour, IInventoryItem
{
    GameObject ObjectFern;

     public string Name 
    { 
        get
        {
            return "Fern";
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
        ObjectFern.SetActive(true);
    }

    GameObject UserInv;

    void Start()
    {
        UserInv = GameObject.Find("UserInventory");
        UserInv.GetComponent<UserInventory>().AddToInventory(this);

        ObjectFern = GameObject.Find("Farn.1blend");
    }

}
