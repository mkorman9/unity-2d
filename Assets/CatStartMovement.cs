using UnityEngine;

public class CatStartMovement : MonoBehaviour
{
    public float velocity = 3;
    
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(velocity, velocity);
    }
}
