using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{    
    public List<Material> rocksColors;
    public ColorRocks rocas;
    int permutationCode = 0;
        
    void Start()
    {
       
    }

    void Update()
    {
        rocas.rocasMaterial = rocksColors[0];
        StartCoroutine(NextColor());
    }    
    
    IEnumerator NextColor()
    {
        yield return new WaitForSeconds(0.05f);
        int piedrasIndex = permutationCode % rocksColors.Count;
                
        rocas.rocasMaterial = rocksColors[piedrasIndex];
        rocas.ColorRockNow();
        permutationCode++;       
        StartCoroutine(NextColor());
    }
}