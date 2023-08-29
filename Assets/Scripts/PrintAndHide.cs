using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;

    public Renderer rend;

    int rando = 0;

    // Start is called before the first frame update
    void Start()
    {
        rando = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.tag == "Red")
        { 
            if(i == 100) gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue")
        {
            if (i == rando) rend.enabled = false;
        }
    }
}
