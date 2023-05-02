using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class klavye_kontolleri : MonoBehaviour
    
{
    public bool oyuncu1Kazan = false;
    public bool oyuncu2Kazan = false;
    public bool tumButonlarBasılabilir = false;


    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("yeşil küp").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("şimdi").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("kırmızı küp").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("bekle").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("sarı küp").GetComponent<MeshRenderer>().enabled = true;
        GameObject.Find("hazır").GetComponent<MeshRenderer>().enabled = true;




    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && (oyuncu2Kazan == false) && (oyuncu1Kazan == false) && (tumButonlarBasılabilir==true))
        {
            print("z basıldı");
            GameObject.Find("oyuncu1skor").GetComponent<oyuncu1skor>().skor1 += 1;
            GameObject.Find("oyuncu1skor").GetComponent<oyuncu1skor>().Skor1Guncelle();
            GameObject.Find("oyuncu1 kazandı").GetComponent<MeshRenderer>().enabled = false;
            oyuncu1Kazan = true;
            
        }
        if(Input.GetKeyDown(KeyCode.M) && (oyuncu1Kazan == false) && (oyuncu2Kazan == false) && (tumButonlarBasılabilir) ==true)
        {
            print("m basıldı");
            GameObject.Find("oyuncu2skor").GetComponent<oyuncu2skor>().skor2 += 1;
            GameObject.Find("oyuncu2skor").GetComponent<oyuncu2skor>().Skor2Guncelle();
            GameObject.Find("oyuncu2 kazandı").GetComponent<MeshRenderer>().enabled = false;
            oyuncu2Kazan = true;
            
        }
        if(Input.GetKeyDown(KeyCode.Y)){
            GameObject.Find("oyuncu1skor").GetComponent<oyuncu1skor>().skor1 = 0;
            GameObject.Find("oyuncu1skor").GetComponent<oyuncu1skor>().Skor1Guncelle();
            GameObject.Find("oyuncu2skor").GetComponent<oyuncu2skor>().skor2 = 0;
            GameObject.Find("oyuncu2skor").GetComponent<oyuncu2skor>().Skor2Guncelle();
            GameObject.Find("yeşil küp").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("şimdi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("sarı küp").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("hazır").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("oyuncu1 kazandı").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("oyuncu2 kazandı").GetComponent<MeshRenderer>().enabled = false;

            oyuncu1Kazan = false;
            oyuncu2Kazan = false;

            GetComponent<zamanlayıcı>().baslangicZamani = GetComponent<zamanlayıcı>().oyunIcindeGecenSure;
            tumButonlarBasılabilir=false;
            GetComponent<zamanlayıcı>().oyunBasladi = false;
            
            print("y basıldı");
        }
        if(Input.GetKeyDown(KeyCode.P)){

            GameObject.Find("yeşil küp").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("şimdi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("kırmızı küp").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("bekle").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("sarı küp").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("hazır").GetComponent<MeshRenderer>().enabled = false;

            GameObject.Find("oyuncu1 kazandı").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("oyuncu2 kazandı").GetComponent<MeshRenderer>().enabled = false;

            oyuncu1Kazan = false;
            oyuncu2Kazan = false;

            GetComponent<zamanlayıcı>().ilkBekleme = 3.0f;
            GetComponent<zamanlayıcı>().ikinciBekleme = 0.0f;
            GetComponent<zamanlayıcı>().toplamBekleme = 0.0f;
            

            GetComponent<zamanlayıcı>().zamanBelirle();
            GetComponent<zamanlayıcı>().baslangicZamani = GetComponent<zamanlayıcı>().oyunIcindeGecenSure;

            GetComponent<zamanlayıcı>().oyunBasladi = true;
            tumButonlarBasılabilir=false;
            
            
            print("p basıldı");


        }
    }
}
