using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{

    public string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonInteract()
    {
        Debug.Log("Our button was clicked");
        Application.LoadLevel(levelToLoad);
    }

}

