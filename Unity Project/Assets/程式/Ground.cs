using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float speed;
    private float startX;
    private float startY;
    void Start()
    {
        startX = transform.position.x;
        startY = transform.position.y;
    }

    
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (transform.position.x <= -(startX - 2))
        {
            transform.position = new Vector2(startX, startY);
        }
        transform.Translate(transform.right * speed);
    }

}
