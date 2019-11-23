using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] protected float speed;
    private float startX;
    private float startY;
    
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
    }
    
    
    protected virtual void Update()
    {
        
        Move();
    }
    protected virtual void Move()
    {
        if (transform.position.x <= -(startX - 2))
        {
            transform.position = new Vector2(startX, startY);
        }
        transform.Translate(transform.right * speed);
    }

}
