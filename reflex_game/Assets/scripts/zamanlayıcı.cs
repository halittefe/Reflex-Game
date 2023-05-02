using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zamanlayıcı : MonoBehaviour
{

    public float ilkBekleme = 3.0f;
    public float ikinciBekleme;
    public float toplamBekleme;
    public float oyunIcindeGecenSure;
    public float baslangicZamani=0;
    public bool oyunBasladi = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        oyunIcindeGecenSure = Time.time;
        
        if(oyunBasladi)
        {
            if((oyunIcindeGecenSure- baslangicZamani) > toplamBekleme)
            {
                //print("butona bas");


                GameObject.Find("yeşil küp").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("şimdi").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("kırmızı küp").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("bekle").GetComponent<MeshRenderer>().enabled = false;

                GameObject.Find("scriptler").GetComponent<klavye_kontolleri>().tumButonlarBasılabilir = true;



            }
        }

    }

    public void zamanBelirle()
    {
        ikinciBekleme = Random.Range(3.0f, 10.0f);
        toplamBekleme = (ilkBekleme + ikinciBekleme);
    }


}

