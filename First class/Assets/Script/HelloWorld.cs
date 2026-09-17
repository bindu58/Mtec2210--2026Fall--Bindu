using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    public float speed;
    public float health = 5;
    public float score = 0;
    public float timer = 0;
    public GameObject coin;
    // Start is called once before the first execution of Updatre after this script gets loaded into your game scene
    void Start ()
    {
        playerSprite.color = Color.white;
       
    }

    void Update ()
    {
        if (health <= 0)
        {
            playerSprite.color = Color.red;

            timer += Time.deltaTime;
            if (timer > 3f)
            {
                Vector2 pos; 
                pos.x = Random.Range (-5,5);
                pos.y = Random.Range( -5,5);
                Instantiate(coin, pos, Quaternion.identity);
                timer = 0; 
            }
        }
    }
    void OnCollisonEnter2D (Collision2D collison)
    {
        Debug.Log ("hit the object");
        if (collison.gameObject.tag == "hazard")
        {
            health--;
        }
        if (collison.gameObject.tag == " collectible")
        {
            score++;
            Destroy(collison.gameObject);
        }
    }

  //thid rins when the gameObkect anters trigger

  void OnTriggerEnter2D(Collider2D collison)
  {
    if (collison.gameObject.tag == "collectible")
    {
        score++;
        Destroy (collison.gameObject);
    }

  }
}