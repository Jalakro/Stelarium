using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    [SerializeField] private int card; //variable correspondant a l'id de la derniere carte select -> 0 rien et apres de 1 à 17
    [SerializeField] private int star; //variable pareil que card pour les constellation
    private int selectedCard; //variable contenant l'id de la carte précedemment selected pour gerer l'affichage du bright sur la bonne carte
    private int selectedStar; //pareil que celle au dessus pour les constellations 
    private int finished; //compteur pour la verif de victoire en comptant les couples carte et constellation trouvés
    [SerializeField] private GameObject[] tabNameBright; //tab des bright des cartes pour les SetActive quand selected
    [SerializeField] private GameObject[] tabStarBright; //tab des bright des constellations
    [SerializeField] private bool[] tabFinished = new bool[17]; //tab de bools avec un bool pour chaque couple verif si complété
    [SerializeField] private GameObject winpanel; //panel affichant la victoire

    public void Card_Name(int id)
    {
        card = id;
        if (selectedCard == card)
        {
            selectedCard = 0;
            tabNameBright[card - 1].SetActive(false);
        }
        else if (selectedCard == 0)
        {
            selectedCard = card;
            tabNameBright[card - 1].SetActive(true);
        }
        else
        {
            tabNameBright[selectedCard - 1].SetActive(false);
            selectedCard = card;
            tabNameBright[card - 1].SetActive(true);
        }       
    }

    public void Stars(int id)
    {
        star = id;
        if (selectedStar == star)
        {
            selectedStar = 0;
            tabStarBright[star - 1].SetActive(false);
        }
        else if (selectedStar == 0)
        {
            selectedStar = star;
            tabStarBright[star - 1].SetActive(true);
        }
        else
        {
            tabStarBright[selectedStar - 1].SetActive(false);
            selectedStar = star;
            tabStarBright[star - 1].SetActive(true);
        }       
    }


    // Start is called before the first frame update
    void Start()
    {
        card = 0;
        star = 0;
        selectedCard = 0;
        selectedStar = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(star == card)
        {
            tabFinished[card - 1] = true;

            //morceau pour en cas de bonne paire tout allumer puis tout éteindre sauf le rempli
            for(int i = 0 ; i < 17 ; i++)
            {
                if(i != selectedCard)
                {
                    tabNameBright[i].SetActive(true);
                }                    
            }
                        
            for(int i = 0 ; i < 17 ; i++)
            {
                tabNameBright[i].SetActive(false);
            }
            tabNameBright[selectedCard].SetActive(true);
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

        for(int i = 0 ; i < 17 ; i++)
        {
            if(tabFinished[i] == true)
            {
                tabNameBright[i].SetActive(true);
                tabStarBright[i].SetActive(true);
            }
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
