using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScript bird;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.layer == 3 && bird.birdIsAlive){
            logic.addScore(1);
        }
    }
}
