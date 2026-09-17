using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector2.zero;
       
        // one fourth if the wasd 
        if (Keyboard.current.wKey.isPressed);
        {
           direction += (Vector2.up * speed);
        }
        if (Keyboard.current.sKey.isPressed);
        {
           direction += (Vector2.down * speed );
        }
       if (Keyboard.current.aKey.isPressed);
        {
           direction += (Vector2.left * speed );
        }
        if (Keyboard.current.dKey.isPressed);
        {
           direction += (Vector2.right * speed );
        }

        transform.Translate(direction);

      float rot = 0f;
      if ( Keyboard.current.qKey.isPressed);
     {
        rot += 1f;
     }
     if ( Keyboard.current.eKey.isPressed)
     {
        rot -= 1f;
     }

     transform.Rotate(new Vector3 (0,0,rot));
    }
}