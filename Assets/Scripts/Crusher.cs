using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Crusher : MonoBehaviour
{
    public float speed;
    public float leftWall;
    public float rightWall;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if (transform.position.x <= leftWall || transform.position.x >= rightWall)
        {
            speed *= -1;
        }
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }

}


