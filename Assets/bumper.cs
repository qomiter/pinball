using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CircleCollider2D circle = GetComponent<CircleCollider2D>();
        AudioSource bumperHit = GetComponent<AudioSource>();

        if (collision != null)
        {
           
            circle.transform.localScale += new Vector3(0.05f, 0.05f, 0f);
            transform.localScale += new Vector3(0.05f, 0.05f, 0f);
            bumperHit.Play();
            scoretracker.gameScore += 10;
            StartCoroutine(shrink());
        }
        IEnumerator shrink()
        {
            yield return new WaitForSeconds(0.1f);
            circle.transform.localScale = new Vector3(0.5f, 0.5f, 0f);
            transform.localScale = new Vector3(0.5f, 0.5f, 0);
        }
        
            
        
    }
}
