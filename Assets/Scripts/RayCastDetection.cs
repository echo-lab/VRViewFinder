using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastDetection : MonoBehaviour
{
    public float ray_distance = 4; // by changing the range, conduct task 1 and task 2.
    public static bool sphere_found_status = false;

    public GameObject sphere;

    int sphere_position_index = 0;
    public static int sphere_found_count = 0;

    //float scale_position = 1; // to reduce or enlarge the respawning range of the sphere. Multiply at the position vector if it is needed.

    // range ([-8 : 8], [0.5 : 4.5], [-12 : 3]), total 20 positions.
    /*Vector3[] sphere_position = new[] { new Vector3(-2f, 2f, 3f), new Vector3( 0f, 2f, 2f), new Vector3( 0f, 2f, -4f),
        new Vector3(1f, 2f, 0f), new Vector3(0f, 2f, 1f), new Vector3( 1f, 2f, 3f),  new Vector3( 2f, 2f, -2f),
        new Vector3( -1f, 2f, -3f), new Vector3( 1f, 2f, -3f), new Vector3( -2f, 2f, -2f),
        new Vector3( -1f, 2f, 0f), new Vector3( 0f, 2f, 1f),   new Vector3( 2f, 2f, 3f), new Vector3( 2f, 2f, -1f),
         new Vector3( 2f, 2f, 4f),  new Vector3( -1f, 2f, 1f), new Vector3( -1f, 2f, 2f), new Vector3( -2f, 2f, -1f)};*/
    Vector3[] sphere_position = new[] { new Vector3(-1.5f*2f, 2f, -3f), new Vector3(1.5f*2f, 2f, 2f), new Vector3(-0.5f*2f, 2f, -2f),
        new Vector3(0.5f*2f, 2f, 0f), new Vector3(-1.5f*2f, 2f, 3f), new Vector3(0f*2f, 2f, 3f), new Vector3(1.5f*2f, 2f, -4f),
    new Vector3(2f*2f, 2f, -2f), new Vector3(-2f*2f, 2f, -2f), new Vector3(2f*2f, 2f, 0f), new Vector3(-2f*2f, 2f, 3f),
    new Vector3(-2f*2f, 2f, -4f), new Vector3(1f*2f, 2f, 2f), new Vector3(-0.5f*2f, 2f, 1f), new Vector3(-0.5f*2f, 2f, -3f),
    new Vector3(0f*2f, 2f, 2f), new Vector3(1.0f*2f, 2f, 3f), new Vector3(0f*2f, 2f, -1f), new Vector3(0f*2f, 2f, -4f),
    new Vector3(2f*2f, 2f, 1f), new Vector3(-2f*2f, 2f, -1f) };


    void Update()
    {
        RaycastHit hit; // variable for the raycast interaction objects.

        if(Physics.Raycast(transform.position, transform.transform.forward, out hit, ray_distance))
        {
            // if the ray hit with the sphere,
            if(hit.transform.name == "Sphere") {
                Debug.Log(hit.transform.name);
                sphere_found_status = true; // change static variable to reference at SphereRespawn class.

                Destroy(sphere); //Destroy the sphere

                //Instantiate the obejct with original object. By doing this, clones can be destroyed.
                sphere = Instantiate(sphere, sphere_position[sphere_position_index], Quaternion.identity);
                sphere.name = "Sphere"; // Name the clone as "Sphere" to be detected by if statement.

                //sphere.GetComponent<SphereMoving>().enabled = true; // Re-Enable th SphereMoving script, that script is disabled after destroyed.

                sphere_position_index++; //Increase the sphere position index.
                sphere_found_count++; //Increase the count.

                if (sphere_position_index == 20) // if the index out of range, set to 0 for repition.
                {
                    sphere_position_index = 0;
                }
            }
        }

        


    }

}
