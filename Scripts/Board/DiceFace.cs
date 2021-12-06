using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceFace : MonoBehaviour
{
    public int number;
    public bool onFloor;
    void Start()
    {
        number = int.Parse(GetComponent<TextMesh>().text);
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Suelo")
        {
            onFloor = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        onFloor = false;
    }
}
