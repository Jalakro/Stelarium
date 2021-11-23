using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class WinCondScene1 : MonoBehaviour
{
    private short count_filled = 0; // compteur nombr ede bonnes drops remplies
    private short count_n_filled = 0; // compteur nombre de mauvaises drops remplies 
    private Component[] tags = new Component[1]; // tableau des tags de remplissage ou nn des bonnes drops
    private Component[] tagsR = new Component[1]; // tableau des tags de remplissages dou nn des mauvaises drop
    private Component[] tmp = new Component[50]; // tableau recepteur avant le tri
    public short length; // nombre bonnes drops dans la constellation

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int a = 0,b = 0; // init de compteurs

        //recup des dropzones
        tmp = GetComponentsInChildren<dropscript>();
        print("sale pute");
        // separation en fonction de leur etat dans les tableau tags et tagsR
        foreach(dropscript k in tmp)
        {
            if(k.right == true)
                Array.Resize(ref tags, a);
                tags[a] = k;
                a++;

            if(k.right == false)
                Array.Resize(ref tagsR, b);
                tagsR[b] = k;
                b++;
        }

        // étude des dropzones
        foreach(dropscript j in tags)
        {
            if (j.filed == true)
                count_filled++;
        }

        foreach (dropscript j in tagsR)
        {
            if (j.filed == true)
                count_n_filled++;
        }

        //condition de victoire
        if (count_filled == length && count_n_filled == 0)
            print("Victoire");

        Array.Resize(ref tags, 1);
        Array.Resize(ref tagsR, 1);
    }
}
