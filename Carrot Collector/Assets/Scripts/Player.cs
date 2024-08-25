using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed;
    float HInput,VInput;

    int score = 0;

    public GameObject winText;

    public int winScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        HInput = joystick.Horizontal * moveSpeed;
        VInput = joystick.Vertical * moveSpeed;

        transform.Translate(HInput,VInput,0);
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Carrot")
        {
            score++;

            Destroy(collision.gameObject);

            if(score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}
