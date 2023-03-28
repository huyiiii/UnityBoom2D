using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MainMonobahvour
{
    public static PlayerController instance;
    public Transform playerModel;
    public Animator animator;
    public Rigidbody2D rigidbody2d;
    PlayerMovement playerMovement;
    protected override void Awake()
    {
        base.Awake();
        if(PlayerController.instance != null)   Debug.LogError("Only 1 PlayerController allow");
        PlayerController.instance = this;
    }
    protected virtual void Update()
    {
        LoadComponents();
    }
    
    protected override void LoadComponents()
    {
        this.LoadChar();
    }

    protected virtual void LoadChar()
    {
        if(this.playerModel != null) return;
        this.playerModel = transform.Find("HeroWhite");
        this.animator = this.playerModel.GetComponent<Animator>();
        this.rigidbody2d = this.playerModel.GetComponent<Rigidbody2D>();
        this.playerMovement = this.playerMovement.GetComponent<PlayerMovement>();
    }
}
