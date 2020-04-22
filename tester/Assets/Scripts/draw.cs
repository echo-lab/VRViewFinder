using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class draw : MonoBehaviour
{
    public SteamVR_Input_Sources rightHand;
    public SteamVR_Action_Single squeezeAction;

    public LineRenderer currLine;
    List<Vector3> points;

    public Material color;

    // Start is called before the first frame update
    void Start()
    {

    }
    



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            currLine = GetComponent<LineRenderer>();
            SetMaterial(color);
        }


    }

    public void UpdateLine(Vector3 pos)
    {
        if (points == null)
        {
            currLine = GetComponent<LineRenderer>();
            currLine.startWidth = 0.03f;
            currLine.endWidth = 0.03f;
            points = new List<Vector3>();
            SetPoint(pos);
            return;
        }
        else if (Vector3.Distance(points[points.Count - 1], pos) > 0.005f)
        {
            SetPoint(pos);
            Debug.Log("line");
        }
    }

    void SetPoint(Vector3 point)
    {
        points.Add(point);

        currLine.positionCount = points.Count;
        currLine.SetPosition(points.Count - 1, point);
    }

    public void SetMaterial(Material m)
    {
        currLine.GetComponent<Renderer>().material = m;
    }
}
