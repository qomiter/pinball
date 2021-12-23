using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CircleCollider2D circle = GetComponent<CircleCollider2D>();

        if (collision != null)
        {
           
            circle.transform.localScale += new Vector3(0.2f, 0.2f, 0f);
            transform.localScale += new Vector3(0.2f, 0.2f, 0f);
            StartCoroutine(shrink());
        }
        IEnumerator shrink()
        {
            yield return new WaitForSeconds(0.1f);
            circle.transform.localScale = new Vector3(2f, 2f, 0f);
            transform.localScale = new Vector3(2f,2f,0);
        }
        
            
        
    }
}
