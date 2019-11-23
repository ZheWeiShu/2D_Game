using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField]
    private int score;
    [SerializeField]
    private int scoreHight;
    [SerializeField, Header("水管")]
    private GameObject pipe;
    [SerializeField,Header("間隔時間")]
    private float interval;
    [SerializeField,Header("生成點")]
    private Transform pos;
    private bool startgame;
    void Start()
    {
       
            InvokeRepeating("SpawnPipe", 0, interval);
      
    }
    
    
    void Update()
    {
        
    }
    

    private void SpawnPipe()
    {
        float y = Random.Range(1.5f, 4.3f);
        Instantiate(pipe,new Vector2(pos.position.x,y),pos.rotation);
    }

    private void AddScore()
    {
        
    }
   
        
}
