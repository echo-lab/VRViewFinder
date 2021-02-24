using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticesGenerator : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;

    public GameObject point;
    public GameObject object_drawing;
 
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;

        
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = transform.TransformPoint(vertices[i]);
            point = Instantiate(point, vertices[i], Quaternion.identity); //Instantiate the cylinder
            point.name = "Point" + i; //Name with index 
        }

        object_drawing.SetActive(false);
    }

    void Update()
    {
        


    }
}
