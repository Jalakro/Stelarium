using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    [SerializeField] private int card;
    [SerializeField] private int star;


    public void Cassiope_Name()
    {
        card = 1;
        //setActive(true) la surbrillance
    }
    public void Cephee_Name()
    {
        card = 2;
        //setActive(true) la surbrillance
    }
    public void Cancer_Name()
    {
        card = 3;
        //setActive(true) la surbrillance
    }
    public void PetiteOurs_Name()
    {
        card = 4;
        //setActive(true) la surbrillance
    }
    public void GrandeOurs_Name()
    {
        card = 5;
        //setActive(true) la surbrillance
    }
    public void Orion_Name()
    {
        card = 6;
        //setActive(true) la surbrillance
    }
    public void Boussole_Name()
    {
        card = 7;
        //setActive(true) la surbrillance
    }
    public void Persee_Name()
    {
        card = 8;
        //setActive(true) la surbrillance
    }
    public void Gemeaux_Name()
    {
        card = 9;
        //setActive(true) la surbrillance
    }
    public void Triangle_Name()
    {
        card = 10;
        //setActive(true) la surbrillance
    }
    public void Girafe_Name()
    {
        card = 11;
        //setActive(true) la surbrillance
    }
    public void CouronneBoreale_Name()
    {
        card = 12;
        //setActive(true) la surbrillance
    }
    public void Lion_Name()
    {
        card = 13;
        //setActive(true) la surbrillance
    }
    public void Dragon_Name()
    {
        card = 14;
        //setActive(true) la surbrillance
    }
    public void Serpent_Name()
    {
        card = 15;
        //setActive(true) la surbrillance
    }
    public void Hydre_Name()
    {
        card = 16;
        //setActive(true) la surbrillance
    }
    public void Vierge_Name()
    {
        card = 17;
        //setActive(true) la surbrillance
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
