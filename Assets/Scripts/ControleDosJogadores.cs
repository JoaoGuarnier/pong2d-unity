using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDosJogadores : MonoBehaviour
{

    public float velocidadeDoJogador;
    public float yMinimo;
    public float yMaximo;

    public bool jogador1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador1) {
            MoverJogador1();
        } else {
            MoverJogador2();
        }
        

    }


    private void MoverJogador1() {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y ,yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }

    }

        private void MoverJogador2() {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y ,yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }

    }


}
