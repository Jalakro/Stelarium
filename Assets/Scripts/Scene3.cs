using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    [SerializeField] private int card;
    [SerializeField] private int star;
    [SerializeField] private GameObject[] tabNameBright;
    [SerializeField] private GameObject[] tabStarBright;
    private int selected;

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
            tabStarBright[card - 1].SetActive(false);
        }
        else if (selected == 0)
        {
            selected = card;
            tabStarBright[card - 1].SetActive(true);
        }
        else
        {
            tabBright[selected - 1].SetActive(false);
            selected = card;
            tabStarBright[card - 1].SetActive(true);
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
            //afficher les infos sur la constellation recup grace au num
        }
        else
        {
            //affichage de l'erreur
            //setActive(false) surbrillance carte
            //setActive(false) surbrillance stars
            star =0;
            card = 0;
        }
    }
}
