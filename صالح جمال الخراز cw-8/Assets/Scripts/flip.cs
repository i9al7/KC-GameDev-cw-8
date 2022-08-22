using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{

    SpriteRenderer sprite;
    bool faceRigth = true;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipPlayer();
    }

    void FlipPlayer()
    {
        if(Input.GetKeyDown(KeyCode.D) && faceRigth ==  false)
        {
            sprite.flipX = false;
            faceRigth = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && faceRigth == true)
        {
            sprite.flipX = true;
            faceRigth = false;
        }
    }
}
