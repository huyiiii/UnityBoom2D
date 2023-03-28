using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{ 
    Vector2 input;
    // Update is called once per frame
    void Update()
    {
        this.PlayerInput();
    }

    protected virtual void PlayerInput()
    {
            this.input.x = Input.GetAxisRaw("Horizontal");
            this.input.y = Input.GetAxisRaw("Vertical");
    }
}
