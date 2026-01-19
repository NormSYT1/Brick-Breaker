using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bricks : MonoBehaviour
{
    public Sprite[] brick_sprite;//Tuðlalarýn görünümü için gerekli dizi(sprite dizisi) deðiþkeni
    private int max_collision;//Maksimum çarpma sayýsý deðiþkeni
    private int collision_counter = 0;//Çarpýþma sayýsý deðiþkeni
    public static int total_brick = 0;//Toplam tuðla sayýsý
    public GameObject breaking_effect;//Tuðla kýrýlma efekti deðiþkeni
    public AudioClip sound1, sound2;//Ses deðiþkenleri
    public int temp_brick = 0;//Geçici deðiþken
    void Start()
    {       
        max_collision = brick_sprite.Length + 1;
        total_brick++;//Tuðla sayýsýný arttýr
    }
    public void Reset()//Özel fonksiyon
    {
        total_brick = temp_brick;//Statik deðiþkeni sýfýrla
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")//Tuðla "Ball" isimli nesneye(topa) çarparsa
        {
            collision_counter++;//Çarpma sayýsýný 1 arttýr          
            if (collision_counter >= max_collision) //Çarpýþma sayýsý maksimum çarpma sayýsýna ulaþýrsa
            {
                total_brick--;//Tuðlalar kýrýldýkça tuðla sayýsýný azalt
                if (total_brick <= 0)//Tuðla sayýsý 0 olursa
                {
                    GameObject.FindObjectOfType<Game_Control>().GetComponent<Game_Control>().Next_Scene();//Bir sonraki sahneye geç
                }
                Vector3 position1 = collision.contacts[0].point;//Çarpma efekti için gerekli deðiþken
                GameObject go1 = Instantiate(breaking_effect, position1, Quaternion.identity) as GameObject;//Nesne yok olunca kýrýlma efektini oluþtur
                /*Color brick_color =GetComponent<SpriteRenderer>().color;//Sprine nesnesinden tuðlanýn rengini bul
                go1.GetComponent<ParticleSystemRenderer>().material.color = brick_color;//Kýrýlma efektinin rengini tuðlanýn rengine göre yap*/
                Destroy(go1, 0.8f);//Kýrýlma efektini yok et
                AudioSource.PlayClipAtPoint(sound2,transform.position);//Sesi çalar
                Destroy(this.gameObject);//Nesneyi(tuðlayý) yok et
            }
            else
            {
                AudioSource.PlayClipAtPoint(sound1, transform.position);//Sesi çalar
                GetComponent<SpriteRenderer>().sprite = brick_sprite[collision_counter - 1];
            }
        }
    }
}
