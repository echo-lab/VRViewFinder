using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoving : MonoBehaviour
{
    public float sphere_speed = 0.03f;
    int position_index = 1;

    Vector3[] target_position = new[] { new Vector3(-2f, 2f, 3f), new Vector3( -1f, 2f, 2f), new Vector3(0f, 2f, 1f),
        new Vector3(1f, 2f, 0f), new Vector3( 2f, 2f, -1f), new Vector3( 2f, 2f, -2f), new Vector3( 1f, 2f, -3f),
        new Vector3( 0f, 2f, -4f), new Vector3( -1f, 2f, -3f), new Vector3( -2f, 2f, -2f), new Vector3( -2f, 2f, -1f) ,
        new Vector3( -1f, 2f, 0f), new Vector3( 0f, 2f, 1f), new Vector3( 1f, 2f, 2f), new Vector3( 2f, 2f, 3f),
        new Vector3( 2f, 2f, 4f) , new Vector3( 1f, 2f, 3f), new Vector3( 0f, 2f, 2f), new Vector3( -1f, 2f, 1f),
        new Vector3( -2f, 2f, 0f)};

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target_position[position_index], sphere_speed);

        if (Vector3.Distance(transform.position, target_position[position_index]) < 0.001f)
        {
            //Moving to the next location
            position_index++;
            if(position_index == 20) // if index out of range
            {
                position_index = 0; // make it 0 to start over
            }
        }
    }
}
