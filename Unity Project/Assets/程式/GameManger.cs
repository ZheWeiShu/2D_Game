using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
    
    public int score;
    [SerializeField]
    private Text scoreText,bestscoreText;
    [SerializeField]
    private int scoreHight;
    [SerializeField, Header("水管")]
    private GameObject pipe;
    [SerializeField,Header("間隔時間")]
    private float interval;
    [SerializeField,Header("生成點")]
    private Transform pos;
    private bool startgame;
    public GameObject EndWindow;
    public static bool gameover;
    void Start()
    {
       
       
        InvokeRepeating("SpawnPipe", 0, interval);
        scoreHight = PlayerPrefs.GetInt("BestScore");
    }
    
    
    void Update()
    {
        
    }
    

    private void SpawnPipe()
    {
        float y = Random.Range(1.5f, 4.3f);
        GameObject cloen= Instantiate(pipe,new Vector2(pos.position.x,y),pos.rotation);
        
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void GameOver()
    {
        if (score > scoreHight)
        {
            PlayerPrefs.SetInt("BestScore", score);
            bestscoreText.text = score.ToString();
        }
        else
        {
            bestscoreText.text = scoreHight.ToString();
        }
        gameover = true;
        CancelInvoke("SpawnPipe");
        EndWindow.SetActive(true);
        
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
        gameover = false;
    } 
    public void ExitGame()
    {
        Application.Quit();
    }
}
