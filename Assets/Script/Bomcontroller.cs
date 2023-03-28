using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomcontroller : MainMonobahvour
{
    
    public GameObject bombPrefab;
    public KeyCode inputKey = KeyCode.Space;
    public float boombFuseTime = 3f;
    public int bomAmount = 1;
    private int bombsRemaining;
    Vector2 position;
    Vector2 BoomPos;
    private void OnEnable() {
        bombsRemaining = bomAmount;
    }

    void Update()
    {
        if (bombsRemaining > 0 && Input.GetKeyDown(inputKey))
            StartCoroutine(PlaceBoomb());
       
    }

    private IEnumerator PlaceBoomb(){
        position = PlayerController.instance.playerModel.transform.position;
        // position.x = Mathf.Round(position.x);
        // position.y = Mathf.Round(position.y);

        GameObject bomb = Instantiate(bombPrefab, position, Quaternion.identity);
        bombsRemaining--;
        BoomPos = bomb.transform.position;
        yield return new WaitForSeconds(boombFuseTime);
        Destroy(bomb);
        bombsRemaining++;
    }

    // protected virtual void BoomBurn()
    // {  
    //     StartCoroutine(PlaceBoomb());
        
    //     GameObject burn = Instantiate(burnfrefaps,BoomPos,Quaternion.identity);
    // } 
    
}
