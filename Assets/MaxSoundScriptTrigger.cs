using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSoundScriptTrigger : MonoBehaviour {
    private ExampleOSCMessageSender osc;
    // Use this for initialization
    void Start () {
        osc = GameObject.FindWithTag("OSCMessageSender").GetComponent<ExampleOSCMessageSender>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(SoundTrigger());
        Debug.Log("cllide");
    }

    IEnumerator SoundTrigger()
    {
        //if (obj.gameObject.name == "VROrigin")
        //{
        List<object> message = new List<object>();

        string address = "/FElefante.wav";
        message.Add(1); // this would be the X Position Value
        osc.AppendMessage(address, message);

        Debug.Log("Message send!!!!!!!");

        //}

        yield return new WaitForSecondsRealtime(2);
    }
}
