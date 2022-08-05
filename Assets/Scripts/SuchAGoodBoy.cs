using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuchAGoodBoy : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {}

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            anim.SetTrigger("friendly");
        }
    }
    
}
