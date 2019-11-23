using UnityEngine;
public class Pipe : Ground
{
    
    void Start()
    {
        
    }

   
   

    protected override void Move()
    {
        transform.Translate(transform.right * speed);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("GM").GetComponent<GameManger>().AddScore();
    }
    private void OnBecameInvisible()//在所有相機都看不見時呼叫。(需有Mesh Renderer)
    {
        
        Destroy(gameObject,1);
    }
    private void OnBecameVisible()//在攝影機畫面內時執行一次
    {
        
    }
}
