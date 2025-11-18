using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneColliderTrigger : MonoBehaviour
{
    public static StoneColliderTrigger Instance;
    public int StoneCount;

    private void Start() {
        Instance=this;
        StoneCount=0;
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag=="Stone"){
            StoneCount++;
            if(StoneCount>=3){
                Continue();
            }
        }
    }

    public void Continue(){ 
        Debug.Log("haha");
        UIManager.Instance.timeline.Resume();
    }
}
