using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncerHIt : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource hit = GetComponent<AudioSource>();
        hit.Play();
    }
}
