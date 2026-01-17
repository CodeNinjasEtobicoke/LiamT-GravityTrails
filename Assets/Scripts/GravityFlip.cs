using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;
    public GameObject avatarSpriteImage;

    private float currentYScale = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRigidbody.gravityScale *= -1;
            Vector3 newDirection = transform.localScale;
            newDirection.y *= -1;

            currentYScale *= -1;
            avatarSpriteImage.transform.localScale = new Vector3(1, currentYScale, 1);

        }
        
    }
}
