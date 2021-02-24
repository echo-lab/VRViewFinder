using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //buttonOriginPosition = buttonObject.localPosition;
    }
	
	// Update is called once per frame
	void Update () { 
    }

    public GameObject toControl;
    public bool onOff = false;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touched");
        if (onOff == true) {
            toControl.SetActive(false);
            onOff = false;
        }
        else {
            toControl.SetActive(true);
            onOff = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        //buttonObject.localPosition = buttonOriginPosition;
    }
}
