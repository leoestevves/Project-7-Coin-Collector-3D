using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{    
    Rigidbody ballRigidbody;
    [SerializeField] float speed;

    int score = 0;
    [SerializeField] int winScore;
    [SerializeField] GameObject winText;

    float xInput;
    float zInput;    

    void Awake()
    {
        ballRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical"); // Y seria para cima e para baixo, como um pulo

        ballRigidbody.AddForce(xInput * speed, 0, zInput * speed);        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            score++;

            if(score >= winScore)
            {
                winText.SetActive(true);
            }
        } 
        
    }
}
