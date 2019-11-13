
using UnityEngine;

public class Button3 : MonoBehaviour
{
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
        Application.LoadLevel("Controls");
    }

}
