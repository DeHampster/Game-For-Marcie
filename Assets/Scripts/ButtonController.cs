using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer SR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    
    public KeyCode keyToPress;
    public KeyCode altKeyToPress;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        SR = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(keyToPress) || Input.GetKeyDown(altKeyToPress))
        {
            SR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(altKeyToPress))
        {
            SR.sprite = defaultImage;
        }
        
    }
}
