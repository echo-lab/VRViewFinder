using UnityEngine;
using UnityEngine.UI;

public class SphereFoundCount : MonoBehaviour
{
    public Text sphere_found_count;

    void Start()
    {
        sphere_found_count = GetComponent<Text>() as Text;
    }
    void Update()
    {
        sphere_found_count.text ="Count: " + RayCastDetection.sphere_found_count.ToString("00");
    }
}
