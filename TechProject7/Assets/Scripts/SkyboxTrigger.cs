using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxTrigger : MonoBehaviour
{
    public Material skyboxOne;
    public Material skyboxTwo;

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            RenderSettings.skybox = skyboxTwo;
        }
    }

    void OnTriggerExit (Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            RenderSettings.skybox = skyboxOne;
        }
    }
}
