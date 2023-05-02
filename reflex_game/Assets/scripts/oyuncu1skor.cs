using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class oyuncu1skor : MonoBehaviour
{
    public int skor1=0;

    public void Skor1Guncelle()
    {
    GetComponent<TMP_Text>().text=skor1.ToString();
    }
}
