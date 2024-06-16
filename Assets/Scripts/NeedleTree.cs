using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleTree : MonoBehaviour, IInventoryItem
{
    GameObject ObjectNeedle;

    public string Name 
    { 
        get
        {
            return "NeedleTree";
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
        ObjectNeedle.SetActive(true);
    }

    GameObject UserInv;

    void Start()
    {
        UserInv = GameObject.Find("UserInventory");
        UserInv.GetComponent<UserInventory>().AddToInventory(this);

        ObjectNeedle = GameObject.Find("NeedleTree");
    }

}
