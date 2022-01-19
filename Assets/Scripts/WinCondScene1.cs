using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class WinCondScene1 : MonoBehaviour
{
    private bool[] tags = new bool[100]; // tableau des tags de remplissage ou nn des bonnes drops
    private bool[] tagsR = new bool[100]; // tableau des tags de remplissages dou nn des mauvaises drop
    private Component[] tmp = new Component[50]; // tableau recepteur avant le tri
    public short length; // nombre bonnes drops dans la constellation
    private GameObject winpanel;

    // Start is called before the first frame update
    void Start()
    {
        winpanel = GameObject.FindGameObjectWithTag("winscene1");
        winpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int count_filled = 0, count_n_filled = 0; // init de compteurs

        //recup des dropzones
        tmp = GetComponentsInChildren<dropscript>();
        foreach (dropscript k in tmp)
        {
            if (k.right == true && k.filed == true)
            {
                count_filled ++;
            }

            if (k.right == false && k.filed == true)
            {
                count_n_filled ++;
            }
        }
        print(count_filled);
        print(count_n_filled);


        // separation en fonction de leur etat dans les tableau tags et tagsR
        /*foreach (dropscript k in tmp)
        {
            if (k.right == true)
            {
                tags[a] = k.filed;
                a++;
            }

            if (k.right == false)
            {
                tagsR[b] = k.filed;
                b++;
            }
        }
        // Ã©tude des dropzones
        foreach (bool j in tags)
        {
            if (j == true)
            count_filled++;
        }
        foreach (bool j in tagsR)
        {
            count_n_filled++;
        }*/
        //condition de victoire
        if (count_filled == length && count_n_filled == 0)
            winpanel.SetActive(true);
        else
            winpanel.SetActive(false);

    }
}