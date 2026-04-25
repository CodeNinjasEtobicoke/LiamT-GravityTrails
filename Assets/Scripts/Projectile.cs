using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;


    private Vector3 MoveDirection; 


    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        MoveDirection = direction.offset;

        Invoke("DestroyThrowable", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += MoveDirection * Time.deltaTime * speed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Teleport Tea = GameObject.Find("Teleporter").GetComponent<Teleport>();
            Tea.enemyCount -= 1;
            Destroy (collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
