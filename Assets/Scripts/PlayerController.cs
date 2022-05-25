using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //PROPIEDADES
    //[HideInInspector] //para propiedades publicas
    [Range(0, 20)]
    [SerializeField]
    [Tooltip("Velocidad lineal maxima del coche")]
    private float speed = 5f;

    //[HideInInspector] //para propiedades publicas
    [Range(0, 90)]
    [SerializeField]
    [Tooltip("Velocidad de giro maxima del coche")]
    private float turnSpeed = 45f;

    private float horizontalInput, verticalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");
        
        // S = s0 + V*t * direccion
        transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput); //0, 0, 1

        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
}
