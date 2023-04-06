using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateforme : MonoBehaviour
{
    public Transform limiteA, limiteB;
    public int speed;
    Vector3 cible;

    // Start is called before the first frame update
    void Start()
    {
        cible= limiteB.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, limiteA.position)<.1f) cible= limiteB.position;

        if (Vector3.Distance(transform.position, limiteB.position)<.1f) cible= limiteA.position;

        transform.position= Vector3.MoveTowards(transform.position, cible, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform);
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
}
