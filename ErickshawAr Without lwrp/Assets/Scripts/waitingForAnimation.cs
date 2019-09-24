using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitingForAnimation : MonoBehaviour
{
    Animator anim;

    void Start()
    {

        /*yield WaitForSeconds(5);*/
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        
    }
}
