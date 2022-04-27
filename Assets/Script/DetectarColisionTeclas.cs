using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColisionTeclas : MonoBehaviour
{
    public Animator animSprite, animPlayer;
    public string nombreBotonEnColider;
    public bool hayObjetoEnColider;
    public KeyCode arriba, derecha, abajo, izquierda;
    public string nombreBotonApretado;
    public string nombreBotonArriba, nombreBotonDerecha, nombreBotonAbajo, nombreBotonIzquierda;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("botones"))
        {
            hayObjetoEnColider = true;
           nombreBotonEnColider = collision.gameObject.name;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("botones"))
        {
            hayObjetoEnColider = false;
            nombreBotonEnColider= null;
        }
    }


    private void Update()
    {
        DetectarBotones();



    }


    void ChequearBotonApretado()
    {
        if(nombreBotonApretado == nombreBotonEnColider)
        {
            animSprite.Play("golpe");
        }
        else
        {
            animPlayer.Play("error");
        }
    }

    void DetectarBotones()
    {
        if (Input.GetKeyDown(arriba))
        {
            nombreBotonApretado = nombreBotonArriba;
            ChequearBotonApretado();
        }
        if (Input.GetKeyDown(derecha))
        {
            nombreBotonApretado = nombreBotonDerecha;
            ChequearBotonApretado();
        }
        if (Input.GetKeyDown(abajo))
        {
            nombreBotonApretado = nombreBotonAbajo;
            ChequearBotonApretado();
        }
        if (Input.GetKeyDown(izquierda))
        {
            nombreBotonApretado = nombreBotonIzquierda;
            ChequearBotonApretado();
        }
    }


    public void Daño()
    {

    }
}
