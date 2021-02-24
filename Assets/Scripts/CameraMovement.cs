using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    public string mouse_x_axis; // type "Mouse X" on the Scene
    public string mouse_y_axis; // type "Mouse Y" on the Scene, reference from the Input Manager

    public float mouse_sensitivity = 220;
    public float movement_sensitivity = 10;

    void Start()
    {
        Cursor.visible = false; // make cursor invisible during the game play.
    }

    void Update()
    {
        float x_axis = Input.GetAxis(mouse_x_axis); // read the mouse x axis value 
        float y_axis = Input.GetAxis(mouse_y_axis); // read the mouse y axis value

        // change the camera rotation
        transform.eulerAngles += new Vector3(-y_axis * Time.deltaTime * mouse_sensitivity, x_axis * Time.deltaTime * mouse_sensitivity, 0);

        // WASD movement
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, movement_sensitivity * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -movement_sensitivity * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-movement_sensitivity * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(movement_sensitivity * Time.deltaTime, 0, 0);
        }
    }
}
