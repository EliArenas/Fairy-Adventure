using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public Text texto;
    public DiceFace[] faces;
    public int currentNumber;
    void Start()
    {
        DiceNumber();
    }

    void Update()
    {
        texto.text = "Casillas :" + currentNumber;
    }

    void DiceNumber()
    {
        for (int i = 0; i < faces.Length; i++)
        {
            if (faces[i].onFloor)
            {
                currentNumber = 7 - faces[i].number;
            }
        }

        Invoke("DiceNumber", 0.5f);
    }

    public void ThrowDice()
    {
        float strength = Random.Range(1, 6);
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().AddForce(new Vector3(0, strength * 200, 0));
        GetComponent<Rigidbody>().rotation = Random.rotation;

    }
}
