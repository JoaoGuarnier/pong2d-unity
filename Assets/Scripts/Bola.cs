using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public float velocidadeDaBola;

    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;
    public Rigidbody2D oRigidbody2D;
    public AudioSource somDaBola;

    // Start is called before the first frame update
    void Start()
    {
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoverBola() {

        oRigidbody2D.velocity = new Vector2(velocidadeDaBola, velocidadeDaBola);

    }

    public void OnCollisionEnter2D(Collision2D collisionInfo) {
        somDaBola.Play();
        oRigidbody2D.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
    }

}
