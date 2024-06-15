using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarVisibility : MonoBehaviour
{
    CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

    }

    void dropdown() 
    {
        if (!canvasGroup.interactable) 
        {
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1;
        }
    }
}
