using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenTrigger : MonoBehaviour
{
    
    private IEnumerator liteBackUp()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<SpriteRenderer>().enabled = true;

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GetComponent<SpriteRenderer>().enabled == true)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(liteBackUp());
        }
       
        
    }


}
