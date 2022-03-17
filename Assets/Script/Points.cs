using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public Reiniciar controller;

    void Start()
    {
        controller = FindObjectOfType<Reiniciar>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
    }
}
