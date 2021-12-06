using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBoxes : MonoBehaviour
{
    private int total;
    public Boxes rott;
    public Dice numberBox;
    int repotition;
    public int punto;
    bool movimie;

    void Start()
    {
        total = 0;
    }

    void Update()
    {
        if (!movimie)
        {
            punto = numberBox.currentNumber;

            total = punto;

            if (repotition + punto < rott.box.Count)
            {
                StartCoroutine(Move());
            }
            else
            {
                Debug.Log("Resultado");
            }
        }
    }

    IEnumerator Move()
    {
        if (movimie)
        {
            yield break;
        }

        movimie = true;

        while (punto > 0)
        {
            Vector3 nextPos = rott.box[repotition + 0].position;

            while (MoveToNextNode(nextPos))
            {
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);
            punto--;
            repotition++;
        }
        movimie = false;
    }

    bool MoveToNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
    }
}
