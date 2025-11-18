using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDebug : MonoBehaviour
{
    private bool flag;
private void Start() {
    flag=false;
}

    private void Update() {
        if(GameManager.Instance.canGrab&&!flag){
            GetComponent<BoxCollider>().enabled=true;
            GetComponent<Rigidbody>().useGravity=true;
            flag=true;
        }
    }
}
