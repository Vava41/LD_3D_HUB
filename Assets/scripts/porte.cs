using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porte : MonoBehaviour

{
    public float posx= 0;
    public float posy= 0;
    public float posz= 0;
    private void OnCollisionEnter(Collision other)
   {
        other.transform.position= new Vector3(posx, posy, posz);
   }
}
