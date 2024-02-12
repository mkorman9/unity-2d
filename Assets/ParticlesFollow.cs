using UnityEngine;

public class ParticlesFollow : MonoBehaviour
{
    public GameObject target;
    
    void Update()
    {
        transform.position = target.transform.position;
    }
}
