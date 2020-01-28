using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorPick : MonoBehaviour
{
    public GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = controller.transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        
    }
}
