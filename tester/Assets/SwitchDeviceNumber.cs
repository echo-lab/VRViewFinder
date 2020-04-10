using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SwitchDeviceNumber : MonoBehaviour
{
    private int index = 5;
    private SteamVR_TrackedObject tracker;
    // Start is called before the first frame update
    void Start()
    {
        tracker = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            index--;
            if (System.Enum.IsDefined(typeof(SteamVR_TrackedObject.EIndex), index))
                tracker.index = (SteamVR_TrackedObject.EIndex)index;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            index++;
            if (System.Enum.IsDefined(typeof(SteamVR_TrackedObject.EIndex), index))
                tracker.index = (SteamVR_TrackedObject.EIndex)index;
        }
    }
}
