using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganador : MonoBehaviour
{
    [SerializeField] GameObject ganar;
    [SerializeField] GameObject perder;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Bueno")
        {
            ganar.SetActive(true);
        }
        else if (col.gameObject.tag == "Malo")
        {
            perder.SetActive(true);
        }
    }
}
