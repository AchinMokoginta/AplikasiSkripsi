using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideObject : MonoBehaviour {

    public GameObject Object;
    private bool showObject = false;

    public void showhideObject()
    {
        if (!showObject)
        {
            Object.SetActive(true);
            showObject = true;
        }
        else
        {
            Object.SetActive(false);
            showObject = false;
        }
    }
}
