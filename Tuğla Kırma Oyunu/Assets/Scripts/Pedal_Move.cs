using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal_Move : MonoBehaviour
{
    void Update()
    {
        if (Time.timeScale == 1f) //Oyun devam ediyorsa 
        {
            Vector3 mouse_position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));//Farenin hareketine göre pedalý hareket ettir
            transform.position = new Vector3(Mathf.Clamp(mouse_position.x, -4.1f, 4.1f), transform.position.y, transform.position.z);//Fare hareket edince kamera da ona baðlý haraket etsin              
        }      
    }
}
