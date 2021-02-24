using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2RayCastDetection : MonoBehaviour
{
    public float task2_ray_distance = 4; // by changing the range, conduct task 1 and task 2.
    public static bool task2_sphere_found_status = false;

    public GameObject task2_sphere;

    int task2_sphere_position_index = 0;
    public static int task2_sphere_found_count = 0;

    //float scale_position = 1; // to reduce or enlarge the respawning range of the sphere. Multiply at the position vector if it is needed.

    // range ([-8 : 8], [0.5 : 4.5], [-12 : 3]), total 20 positions.
    Vector3[] task2_sphere_position = new[] { new Vector3(-1.5f*2f, 2f, -3f), new Vector3(1.5f*2f, 2f, 2f), new Vector3(-0.5f*2f, 2f, -2f),
        new Vector3(0.5f*2f, 2f, 0f), new Vector3(-1.5f*2f, 2f, 3f), new Vector3(0f*2f, 2f, 3f), new Vector3(1.5f*2f, 2f, -4f),
    new Vector3(2f*2f, 2f, -2f), new Vector3(-2f*2f, 2f, -2f), new Vector3(2f*2f, 2f, 0f), new Vector3(-2f*2f, 2f, 3f),
    new Vector3(-2f*2f, 2f, -4f), new Vector3(1f*2f, 2f, 2f), new Vector3(-0.5f*2f, 2f, 1f), new Vector3(-0.5f*2f, 2f, -3f),
    new Vector3(0f*2f, 2f, 2f), new Vector3(1.0f*2f, 2f, 3f), new Vector3(0f*2f, 2f, -1f), new Vector3(0f*2f, 2f, -4f),
    new Vector3(2f*2f, 2f, 1f), new Vector3(-2f*2f, 2f, -1f) };

void Update()
    {
        RaycastHit hit; // variable for the raycast interaction objects.

        if (Physics.Raycast(transform.position, transform.transform.forward, out hit, task2_ray_distance))
        {
            // if the ray hit with the sphere,
            if (hit.transform.name == "Sphere")
            {
                Debug.Log(hit.transform.name);
                task2_sphere_found_status = true; // change static variable to reference at SphereRespawn class.

                Destroy(task2_sphere); //Destroy the sphere

                //Instantiate the obejct with original object. By doing this, clones can be destroyed.
                task2_sphere = Instantiate(task2_sphere, task2_sphere_position[task2_sphere_position_index], Quaternion.identity);
                task2_sphere.name = "Sphere"; // Name the clone as "Sphere" to be detected by if statement.

                task2_sphere.GetComponent<SphereMoving>().enabled = true; // Re-Enable th SphereMoving script, that script is disabled after destroyed.

                task2_sphere_position_index++; //Increase the sphere position index.
                task2_sphere_found_count++; //Increase the count.

                if (task2_sphere_position_index == 20) // if the index out of range, set to 0 for repition.
                {
                    task2_sphere_position_index = 0;
                }
            }
        }




    }

}
