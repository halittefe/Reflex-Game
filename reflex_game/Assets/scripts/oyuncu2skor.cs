using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class oyuncu2skor : MonoBehaviour
{
    public int skor2=0;

    public void Skor2Guncelle()
    {
    GetComponent<TMP_Text>().text=skor2.ToString();
    }
}
