using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkazanma : MonoBehaviour {

public int oyunSkorUstLimit = 3;

    

    // Update is called once per frame
    void Update() 
    {
      if (GameObject.Find("oyuncu1skor").GetComponent<oyuncu1skor>().skor1 > oyunSkorUstLimit)  
    
        {
        GameObject.Find("oyuncu1 kazandı").GetComponent<MeshRenderer>().enabled=true;
        }
    if (GameObject.Find("oyuncu2skor").GetComponent<oyuncu2skor>().skor2 > oyunSkorUstLimit)  
    {
    
        GameObject.Find("oyuncu2 kazandı").GetComponent<MeshRenderer>().enabled=true;
    }
}
}