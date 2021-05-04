using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * x + transform.forward * -z;

        controller.Move(move * speed * Time.deltaTime);

    }
}
