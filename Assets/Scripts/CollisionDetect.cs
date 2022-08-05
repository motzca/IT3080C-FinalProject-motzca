using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    void Start()
    {}
    void Update()
    {}

    private void OnTriggerEvent(Collider other){
        Debug.Log("Testing");
    }
}
