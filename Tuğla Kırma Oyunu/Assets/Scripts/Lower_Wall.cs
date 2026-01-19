using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lower_Wall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")//Tetiklenen nesnenin ismi "Ball" ise
        {
            GameObject.FindObjectOfType<Bricks>().GetComponent<Bricks>().Reset();//Statik deðiþkeni sýfýrlayan fonksiyonu çaðýr
            GameObject.FindObjectOfType<Game_Control>().GetComponent<Game_Control>().Current_Scene();//Mevcut sahneyi yükleyen fonksiyonu çaðýr                     
        }
    }
}
