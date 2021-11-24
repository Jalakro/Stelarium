using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class WinCondScene1 : MonoBehaviour
{
    private short count_filled = 0; // compteur nombr ede bonnes drops remplies
    private short count_n_filled = 0; // compteur nombre de mauvaises drops remplies 
    private bool[] tags = new bool[100]; // tableau des tags de remplissage ou nn des bonnes drops
    private bool[] tagsR = new bool[100]; // tableau des tags de remplissages dou nn des mauvaises drop
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
            print("bougnoule");
            if(k.right == true)
            {
                tags[a] = k.filed;
                a++;
            }

            if(k.right == false)
            {
                tagsR[b] = k.filed;
                print("aled");
                b++;
            }

        }
        print("negre");
        // étude des dropzones
        foreach(bool j in tags)
        {
            if (j == true)
                print("jeanne");
                count_filled++;
        }
        print("puuuute");
        foreach (bool j in tagsR)
        {
            if (j == true)
                print("oskour");
                count_n_filled++;
        }
        print("a l'air de marcher");
        //condition de victoire
        if (count_filled == length && count_n_filled == 0)
            print("Victoire");
    }
}
