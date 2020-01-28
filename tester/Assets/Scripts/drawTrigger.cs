using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class drawTrigger : MonoBehaviour
{
    public SteamVR_Input_Sources rightHand;
    public SteamVR_Action_Single squeezeAction;
    public GameObject Line;

    draw activeLine;
    GameObject temp;
    private bool key = false;

    public List<GameObject> strokes;

    // Start is called before the first frame update
    void Start()
    {
        SteamVR_Actions.default_righttrigger.AddOnStateDownListener(TriggerPressed, rightHand);
        SteamVR_Actions.default_righttrigger.AddOnStateUpListener(TriggerUp, rightHand);
        strokes = new List<GameObject>();
    }

    private void TriggerPressed(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("click");
        temp = Instantiate(Line);
        activeLine = temp.GetComponent<draw>();
        key = true;
        //UpdateLine(transform.position);

    }
    private void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("up");
        activeLine = null;
        key = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeLine != null && key == true)
        {
            activeLine.UpdateLine(transform.position);
        }
        float triggerV = squeezeAction.GetAxis(rightHand);
        if (triggerV > 0.01f)
        {
            Debug.Log("trigger");
            //currLine.positionCount = numClicks + 1;
            //currLine.SetPosition(0, transform.position);
            //numClicks++;
            
        }


    }
}
