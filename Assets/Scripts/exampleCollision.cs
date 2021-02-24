using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exampleCollision : MonoBehaviour {
    private ExampleOSCMessageSender osc;
    public string mes;
    private bool played = false;
    // Use this for initialization
    void Start () {
        osc = GameObject.FindWithTag("OSCMessageSender").GetComponent<ExampleOSCMessageSender>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider obj)
    {
        if (played == false)
        {
            if (obj.gameObject.tag == "Player")
            {
                StartCoroutine(SoundTrigger(obj));
                played = true;
            }
        }
    }

    IEnumerator SoundTrigger(Collider obj)
    {
        //if (obj.gameObject.name == "VROrigin")
        //{
            List<object> message = new List<object>();

            message.Add(1); // this would be the X Position Value
            osc.AppendMessage(mes, message);

            Debug.Log("Message send!!!!!!!");

        //}

        yield return new WaitForSecondsRealtime(2);
    }
}
