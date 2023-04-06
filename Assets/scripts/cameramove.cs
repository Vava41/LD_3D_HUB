using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    float rotationX;
    float mouseSensitivity= 90f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY= Input.GetAxis("Mouse Y")* Time.deltaTime* mouseSensitivity;
        float mouseX= Input.GetAxis("Mouse X")* Time.deltaTime* mouseSensitivity;
        
        rotationX-= mouseY;
        rotationX= Mathf.Clamp(rotationX, -90f, 90f);
        transform.localEulerAngles= new Vector3(rotationX, 0f, 0f);

        player.Rotate(Vector3.up*mouseX);
    }
}
