using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Leer los valores de los ejes de entrada
        float move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float strafe = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Si hay movimiento horizontal, desactivar el movimiento vertical
        if (move != 0)
        {
            transform.Translate(move, 0, 0); // Mover solo en el eje X (horizontal)
        }
        else if (strafe != 0)
        {
            transform.Translate(0, strafe, 0); // Mover solo en el eje Y (vertical)
        }
    }
}