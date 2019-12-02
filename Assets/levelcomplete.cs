using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class levelcomplete : MonoBehaviour
{
    [SerializeField] Transform spawnpoint;
    public string levelCompleteScene;
    public int requiredCoins;
    GameObject[] coins;

    private void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("coins");
        requiredCoins = coins.Length;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player") && scorecounter.coinAmount == requiredCoins)
        {
            SoundManagerScript.PlaySound("levelcomplete");
            Thread.Sleep(1000);
            Application.LoadLevel(levelCompleteScene);
        }
    }
}