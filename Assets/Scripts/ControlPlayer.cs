using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.position = new Vector3(gameObject.transform.position.x + 10f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        // Otra manera de escribir lo de arriba
        // gameObject.transform.Translate(10f * Time.deltaTime, 0, 0);

        // Controlando el movimiento
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-10f * Time.deltaTime, 0f, 0f);
        } 
        else if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(10f * Time.deltaTime, 0f, 0f);
        }

        ManageJump();
    }

    void ManageJump()
    {
        if (gameObject.transform.position.y <= 0)
        {
            canJump = true;
        }

        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 10)
        {
            gameObject.transform.Translate(0f, 50f * Time.deltaTime, 0f);
        }
        else
        {
            canJump = false;

            if (gameObject.transform.position.y > 0)
            {
                gameObject.transform.Translate(0f, -25f * Time.deltaTime, 0f);
            }
        }
    }
}
