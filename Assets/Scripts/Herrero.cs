using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Herrero : MonoBehaviour
{
    public PlayerMovement jugador;
    public GameObject panelHerrero;
    public GameObject panelMejora;
    public bool jugadorCerca;
    public bool aceptarMejora;
    public GameObject botonFinMejora;
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        panelHerrero.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X) && aceptarMejora == false)
        {
            
        }
        
    }
}
