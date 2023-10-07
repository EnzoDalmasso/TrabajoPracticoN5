using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField]
    PerfilJugador perfilJugador;

    private ObjectCollector collector;

    private void Start()
    {
        collector = GetComponent<ObjectCollector>();
    }

    public void ModificarVida(float puntos)
    {
        perfilJugador.Vida += puntos;
        Debug.Log(EstasVivo());
    }


    private bool EstasVivo()
    {
        return perfilJugador.Vida > 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Meta") && collector.CollectedCount<3) { return; }

        Debug.Log("GANASTE");
    }
}