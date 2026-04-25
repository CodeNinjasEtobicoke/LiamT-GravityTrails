using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public TextMeshProUGUI collectableCounterText;
        
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(1, 0, 0);
        offset = transform.localScale.x * new Vector3(1, 0, 0);
        Vector3 throwablePosition = transform.position + offset;

        if (Input.GetButtonDown("Fire1") && throwableCounter>0) 
        {
            
            Instantiate(objectThrown, throwablePosition, transform.rotation);
            throwableCounter -= 1;
            collectableCounterText.text = throwableCounter.ToString();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable") {

            Debug.Log("collide");
            Destroy(collision.gameObject);
            throwableCounter = throwableCounter + 1;
            collectableCounterText.text = throwableCounter.ToString();

        }
    }
}
