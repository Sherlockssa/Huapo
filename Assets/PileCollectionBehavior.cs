using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileCollectionBehavior : MonoBehaviour
{
    public GameObject[] piles;
    public static PileCollectionBehavior Instance;
    public int index;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }
    public void SetActiveNextPile(){
        if(index < piles.Length){
            piles[index].SetActive(true);
            index++;
        }
    }
}
