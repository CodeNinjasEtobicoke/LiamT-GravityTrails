using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher1: MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if  (transform.position.x <= -8 || transform.position.x >= 8)
        {
            speed *= -1;
        }
        float newXposition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYposition = transform.position.y;
        Vector2 newPosition = new Vector2(newXposition, newYposition);
        transform.position = newPosition;
    }
}
