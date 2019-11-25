using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class KillPlayer : MonoBehaviour{
    [SerializeField] Transform spawnpoint;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");

        if (col.transform.CompareTag("Player"))
        {
            Debug.Log("Was player");
            SoundManagerScript.PlaySound("stab");
            Thread.Sleep(200);
            SoundManagerScript.PlaySound("dead");
            Thread.Sleep(1300);
             Application.LoadLevel("death scene");
        }
    }
}