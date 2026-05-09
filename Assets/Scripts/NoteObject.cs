using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;

    public bool wasPressed = false;

    public KeyCode keyToPress;
    public KeyCode altKeyToPress;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress) || Input.GetKeyDown(altKeyToPress))
        {
            if (canBePressed)
            {
                // gameObject.SetActive(false);

                GameManager.instance.NoteHit();
                wasPressed = true;

                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = false;

            if (!wasPressed)
            {
                GameManager.instance.NoteMissed();
            }
        }
        
    }
}
