using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravelPile : MonoBehaviour
{
    public GameObject spawner;
   private void OnTriggerEnter(Collider other) {
         if (other.gameObject.tag == "Player")
         {
              other.transform.position=new Vector3(spawner.transform.position.x,other.transform.position.y,spawner.transform.position.z);
              if(!CompleteCheck.Instance._passed){
                CompleteCheck.Instance.CheckIfPassCP2();
              }
         }
   }
}
