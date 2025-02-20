using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class don : MonoBehaviour
{
    [SerializeField]
    float donmeHizi;

    float donhiz;

  
    void Update()
    {
        donhiz = donmeHizi * (PlayerPrefs.GetInt("level") * 1.05f);
        if(donhiz > 170)
        {
            donhiz = 170;
        }
        transform.Rotate(0, 0,200  * Time.deltaTime);
        
    }
}
