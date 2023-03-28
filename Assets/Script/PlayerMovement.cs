using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed =1 ;
    Vector3 pos;
    public bool isMoving;
    private Vector3 input;


    private  void Update()
    {
        this.input.x = Input.GetAxisRaw("Horizontal");
        this.input.y = Input.GetAxisRaw("Vertical");
        Moving();
        Animation();
    }


    public virtual void Animation()
    {

        PlayerController.instance.animator.SetFloat("moveX",input.x);
        PlayerController.instance.animator.SetFloat("moveY",input.y);  
    }

    public virtual void Moving()
    {
        PlayerController.instance.rigidbody2d.velocity = new Vector2(input.x *moveSpeed,input.y *moveSpeed);

    }
}
