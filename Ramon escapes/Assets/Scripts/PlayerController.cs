using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Titulo del modulo de configuraciones en unity
    [Header("Configuraciones")]
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float gravedad = 20f;
    //Permite cambiar la variable de velocidad en Unity
    //[SerializeField] private float velocidad = 20.0f;
    //[SerializeField] private float velocidadGiro = 1f;

    //[SerializeField] private float InpHorizontal;
    // Start is called before the first frame update
    private BoxController boxController;
    private float posicionVertical;
    private int carrilActual;
    private Vector3 direccionDeseada;

    private void Awake(){
        boxController = GetComponent<BoxController>();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalcularMovimientoVertical();
        MoverPersonaje();
    }

    private void MoverPersonaje(){
        //Mover el carro hacia el frente
    //transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
    //Modificar el giro
    //transform.Rotate(Vector3.up, velocidadGiro * InpHorizontal * Time.deltaTime);
        Vector3 nuevaPos = new Vector3(0f, posicionVertical, velocidadMovimiento);
        boxController.Move(nuevaPos * Time.deltaTime);
    }

    private void CalcularMovimientoVertical(){
        if(boxController.isGrounded){
            posicionVertical = 0f;
        }
        posicionVertical -= gravedad * Time.deltaTime;
    }

}
