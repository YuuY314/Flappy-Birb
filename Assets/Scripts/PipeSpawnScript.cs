using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate;
    private float timer = 0;
    public float heightOffSet = 10;
    public LogicScript logic;
    public PipeMoveScript pipeMove;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();   
        pipeMove = pipe.GetComponent<PipeMoveScript>();
        spawnPipe();
    }

    void Update()
    {
        if(timer < spawnRate){
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }

        if(logic.playerScore == 10){
            spawnRate = 3;
        } else if(logic.playerScore == 20){
            pipeMove.moveSpeed = 6;
        } else if(logic.playerScore == 30){
            pipeMove.moveSpeed = 7;
        } else if(logic.playerScore == 40){
            heightOffSet = 8;
        } else if(logic.playerScore == 50){
            pipeMove.moveSpeed = 8;
        }
    }

    void spawnPipe(){
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
