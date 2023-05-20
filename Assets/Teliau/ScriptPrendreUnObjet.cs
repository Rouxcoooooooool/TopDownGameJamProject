using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPrendreUnObjet : MonoBehaviour
{
    public GameObject itemHeld;
    private GameObject displayer;

    // Start is called before the first frame update
    void Start()
    {
        
        print("Hello");
    }


    
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D truc) 
    { if(itemHeld == null && truc.tag == "Item"){
            itemHeld = truc.gameObject;
            print("J'ai" + truc.name);
            print("Get Destroyed");
    }

    }
    
    void Update()
    {
    
    }
}
