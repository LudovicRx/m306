﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCreerPartie : MonoBehaviour
{
    public GameObject camera;
    public GameObject pageConfig;
    public GameObject fondPageConfig;

    private string texte;
    private int nbJoueurs;
    public GameObject jeu;

    // Start is called before the first frame update
    void Start()
    {
         pageConfig.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, 70);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnMouseDown()
   {
        
       camera.GetComponent<Transform>().position = new Vector3(fondPageConfig.transform.position.x, fondPageConfig.transform.position.y,60);
   }

    public void CreerPartie()
    {
        nbJoueurs = jeu.GetComponent<Jeu>().ObtientNbJoueur();

        List<Joueur> joueursProvisoirs = new List<Joueur>();

        //Pré-fabriquer des personnage aux races et noms aléatoires, au nombre des joueurs
        for (int i = 0; i < nbJoueurs; i++)
        {
            joueursProvisoirs.Add(new Joueur());
            joueursProvisoirs[i].DetermineEspeceDefaut();
            joueursProvisoirs[i].DetermineNomDefaut();
        }

        jeu.GetComponent<Jeu>().DetermineJoueurs(joueursProvisoirs);
    }
}
