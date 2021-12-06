using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    Transform[] place;
    public List<Transform> box = new List<Transform>();

    void Update()
    {
        box.Clear();
        place = GetComponentsInChildren<Transform>();

        foreach (Transform child in place)
        {
            if (child != this.transform)
            {
                box.Add(child);
            }
        }
    }
}
