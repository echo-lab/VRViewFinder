using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task2SphereFoundCount : MonoBehaviour
{
    public Text task2_sphere_found_count;
    void Start()
    {
        task2_sphere_found_count = GetComponent<Text>() as Text;
    }
    void Update()
    {
        task2_sphere_found_count.text = "Count: " + Task2RayCastDetection.task2_sphere_found_count.ToString("00");
    }
}
