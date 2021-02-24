using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCylinder : MonoBehaviour
{
    public GameObject cylinder_object;

    public int point_index = 1;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (RightHandDrawing.line_end_point_status && RightHandDrawing.line_starting_point_status)
        {
            Vector3 cylinder_position = (RightHandDrawing.line_starting_position + RightHandDrawing.line_end_position) / 2; //Find the middle point between two objects
            Quaternion cylinder_direction = Quaternion.FromToRotation(Vector3.up, RightHandDrawing.line_starting_position - RightHandDrawing.line_end_position); //Find the rotation between two objects
            float distance = Vector3.Distance(RightHandDrawing.line_starting_position, RightHandDrawing.line_end_position); //Find distance between two objects

            cylinder_object = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder_object.transform.position = cylinder_position;
            cylinder_object.transform.rotation = cylinder_direction;

            //cylinder_object = Instantiate(cylinder_object, cylinder_position, cylinder_direction); //Instantiate the cylinder
            cylinder_object.name = "Cylinder" + point_index; //Name with index
            cylinder_object.transform.localScale = new Vector3(0.01f, distance/2, 0.01f); // Transform the object scale
            
            RightHandDrawing.line_starting_point_status = false;
            RightHandDrawing.line_end_point_status = false;
            point_index++;

            
        }

        
    }
}
