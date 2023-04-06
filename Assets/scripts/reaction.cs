using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reaction : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnTriggerEnter(Collider other)
    {
        _animator.Play(stateName:"Waving");
    }
    private void OnTriggerStay(Collider other)
    {
        transform.LookAt(other.transform);
    }
}
