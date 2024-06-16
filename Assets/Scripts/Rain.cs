using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour, IInventoryItem
{
    GameObject ObjectRain;

    public string Name 
    { 
        get
        {
            return "Rain";
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
        ObjectRain.SetActive(true);
    }

    GameObject UserInv;

    void Start()
    {
        UserInv = GameObject.Find("UserInventory");
        UserInv.GetComponent<UserInventory>().AddToInventory(this);

        ObjectRain = GameObject.Find("Rain");
    }

}
