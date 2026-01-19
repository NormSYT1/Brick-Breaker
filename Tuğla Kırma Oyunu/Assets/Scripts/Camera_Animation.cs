using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Animation : MonoBehaviour
{
    public Vector3 first_position;
    void Start()
    {
        first_position = transform.position;
        transform.position = new Vector3(first_position.x, first_position.y - 6, first_position.z);//Kameranýn konumunu 6 birim aþaðýya indir  
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, first_position, 1.5f * Time.deltaTime);
    }
}
