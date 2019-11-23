
public class Pipe : Ground
{
    
    void Start()
    {
        Destroy(gameObject, 3);
    }

   
   

    protected override void Move()
    {
        transform.Translate(transform.right * speed);

    }
}
