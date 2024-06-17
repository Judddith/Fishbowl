using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveTree : MonoBehaviour, IInventoryItem
{
    GameObject ObjectLeaves;

    public string Name 
    { 
        get
        {
            return "LeaveTree";
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
        ObjectLeaves.SetActive(true);
    }

    GameObject UserInv;

    void Start()
    {
        UserInv = GameObject.Find("UserInventory");
        UserInv.GetComponent<UserInventory>().AddToInventory(this);

        ObjectLeaves = GameObject.Find("LeaveTree");
    }

}
