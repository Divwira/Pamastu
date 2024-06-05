using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareEnemy : MonoBehaviour
{
    public GameObject enemy;  
    public float disappearTime = 2.0f;  

    private bool hasAppeared = false; 

    void Start()
    {
       
        enemy.SetActive(false);
        Debug.Log("Musuh diset ke tidak aktif pada awal.");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasAppeared)
        {
            
            Debug.Log("Pemain memasuki area trigger.");
            enemy.SetActive(true);
            Debug.Log("Musuh muncul.");
            hasAppeared = true;
            StartCoroutine(DisappearAfterTime(disappearTime));
        }
    }

    System.Collections.IEnumerator DisappearAfterTime(float time)
    {
        
        yield return new WaitForSeconds(time);
        enemy.SetActive(false);
        Debug.Log("Musuh menghilang.");
    }
}