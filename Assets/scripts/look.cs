using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.LookAt(other.transform);
    }
    private void OnTriggerStay(Collider other)
    {
        transform.LookAt(other.transform);
    }
}
