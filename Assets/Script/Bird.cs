using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rigid;

    public GameObject GameOver;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid.velocity = Vector2.up * speed;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            rigid.velocity = Vector2.up * speed;
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }

}
