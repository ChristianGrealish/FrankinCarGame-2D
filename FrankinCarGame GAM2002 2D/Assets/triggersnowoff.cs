﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggersnowoff : MonoBehaviour
{

    public ParticleSystem snow;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "vehicle")

        {
            var em = snow.emission;
            em.enabled = false;
            print("snow off");
        }

    }


    

}




