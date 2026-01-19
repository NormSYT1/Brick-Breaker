using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{
    private GameObject pedal;//Pedal nesnesi de�i�keni
    private bool game = false;//Oyunun ba�lay�p ba�lamad���n� kontrol eden de�i�ken
    private float time = 0;//S�re de�i�keni
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal_Move>().gameObject;//Pedal nesnesine eri�im       
    }
    void Update()
    {
        if (time < 4)
        {
            time += Time.deltaTime;//S�reyi artt�r
        }
        if (!game)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, pedal.transform.position.z);//Topun konumunu pedal�n konumuna ayarla
        }
        if (Input.GetMouseButtonDown(0) && !game && time >= 3.5f)//Farenin sol tu�una bas�l�rsa ve oyun ba�lamad�ysa ve s�re 3.5 saniyeden b�y�kse
        {
            game = true;//Oyunu ba�lat      
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0f, 7f);//Topa kuvvet uygular                  
        }
    }
}
