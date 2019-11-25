using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class levelcomplete : MonoBehaviour
{
    [SerializeField] Transform spawnpoint;
    public string levelCompleteScene;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            SoundManagerScript.PlaySound("levelcomplete");
            Thread.Sleep(1000);
            Application.LoadLevel(levelCompleteScene);
        }
    }
}