using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    [SerializeField] private int card;
    [SerializeField] private int star;
    private int selected;
    private int finished;
    [SerializeField] private GameObject[] tabNameBright;
    [SerializeField] private GameObject[] tabStarBright;
    [SerializeField] private bool[] tabFinished = new bool[17];
    [SerializeField] private GameObject winpanel;

    public void Card_Name(int id)
    {
        card = id;
        if (selected == card)
        {
            selected = 0;
            tabNameBright[card - 1].SetActive(false);
        }
        else if (selected == 0)
        {
            selected = card;
            tabNameBright[card - 1].SetActive(true);
        }
        else
        {
            tabNameBright[selected - 1].SetActive(false);
            selected = card;
            tabNameBright[card - 1].SetActive(true);
        }       
    }

    public void Stars(int id)
    {
        star = id;
        if (selected == star)
        {
            selected = 0;
            tabStarBright[star - 1].SetActive(false);
        }
        else if (selected == 0)
        {
            selected = star;
            tabStarBright[star - 1].SetActive(true);
        }
        else
        {
            tabStarBright[selected - 1].SetActive(false);
            selected = star;
            tabStarBright[star - 1].SetActive(true);
        }       
    }


    // Start is called before the first frame update
    void Start()
    {
        card = 0;
        star = 0;
        selected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(star == card)
        {
            tabFinished[card] = true;

            //morceau pour en cas de bonne paire tout allumer puis tout éteindre sauf le rempli
            for(int i = 0 ; i < 17 ; i++)
            {
                if(i != selected)
                {
                    tabNameBright[i].SetActive(true);
                }                    
            }
                        
            for(int i = 0 ; i < 17 ; i++)
            {
                tabNameBright[i].SetActive(false);
            }
            tabNameBright[selected].SetActive(true);
            //TODO//afficher les infos sur la constellation recup grace au num
        }
        else
        {
            //TODO//affichage de l'erreur
            //setActive(false) surbrillance carte
            //setActive(false) surbrillance stars
            star =0;
            card = 0;
        }

        //laisser allumer les bright des couples trouvés
        for(int i = 0 ; i<17 ; i++)
        {
            if(tabFinished[i] == true)
            {
                tabNameBright[i].SetActive(true);
                tabStarBright[i].SetActive(true);
            }  
        }

        //décompte des finis pour savoir si victoire complète
        finished = 0;
        for(int i = 0 ; i<17 ; i++)
        {
            if(tabFinished[i] == true)
                finished++;
        }
        if(finished == 17)
        {
            winpanel.SetActive(true);
        }
    }
}
