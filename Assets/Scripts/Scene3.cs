using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    [SerializeField] private int card;
    [SerializeField] private int star;
    [SerializeField] private GameObject[] tabBright;
    private int selected;

    public void Card_Name(int id)
    {
        card = id;
        if (selected == card)
        {
            selected = 0;
            tabBright[card - 1].SetActive(false);
        }
        else if (selected == 0)
        {
            selected = card;
            tabBright[card - 1].SetActive(true);
        }
        else
        {
            tabBright[selected - 1].SetActive(false);
            selected = card;
            tabBright[card - 1].SetActive(true);
        }       
    }

    public void Cassiope_Star()
    {
        star = 1;
        //setActive(true) la surbrillance
    }
    public void Cephee_Star()
    {
        star = 2;
        //setActive(true) la surbrillance
    }
    public void Cancer_Star()
    {
        star = 3;
        //setActive(true) la surbrillance
    }
    public void PetiteOurs_Star()
    {
        star = 4;
        //setActive(true) la surbrillance
    }
    public void GrandeOurs_Star()
    {
        star = 5;
        //setActive(true) la surbrillance
    }
    public void Orion_Star()
    {
        star = 6;
        //setActive(true) la surbrillance
    }
    public void Boussole_Star()
    {
        star = 7;
        //setActive(true) la surbrillance
    }
    public void Persee_Star()
    {
        star = 8;
        //setActive(true) la surbrillance
    }
    public void Gemeaux_Star()
    {
        star = 9;
        //setActive(true) la surbrillance
    }
    public void Triangle_Star()
    {
        star = 10;
        //setActive(true) la surbrillance
    }
    public void Girafe_Star()
    {
        star = 11;
        //setActive(true) la surbrillance
    }
    public void CouronneBoreale_Star()
    {
        star = 12;
        //setActive(true) la surbrillance
    }
    public void Lion_Star()
    {
        star = 13;
        //setActive(true) la surbrillance
    }
    public void Dragon_Star()
    {
        star = 14;
        //setActive(true) la surbrillance
    }
    public void Serpent_Star()
    {
        star = 15;
        //setActive(true) la surbrillance
    }
    public void Hydre_Star()
    {
        star = 16;
        //setActive(true) la surbrillance
    }
    public void Vierge_Star()
    {
        star = 17;
        //setActive(true) la surbrillance
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
