using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    public GameObject[] equipements;
    private bool _epeeDetruite = false;
    private bool _bouclierDetruit = false;
    private bool _casqueDetruit = false;
    private bool _plastronDetruit = false;
    private int _piécesPlacées = 0;

    
    //  NOTE :  Element 0 = Plastron  | Element 1 = Casque  | Element 2 = Epee  |  Element 3 = Bouclier  
    private void OnEnable()
    {
        Bouclier.ShieldWasTaken += BouclierDetruit;
        Casque.HelmetWasTaken += CasqueDetruit;
        Epee.SwordWasTaken += EpeeDetruite;
        Plastron.BreastPlateWasTaken += PlastronDetruit;
    }

    private void Update()
    {
        StatueComplete();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlacementBouclier();
            PlacementCasque();
            PlacementEpee();
            PlacementPlastron();
        }
    }

    private void PlacementBouclier()
    {
        if (_bouclierDetruit==true)
        {
            _piécesPlacées++;
            equipements[3].SetActive(true);
        }
    }
    private void PlacementEpee()
    {
        if (_epeeDetruite==true)
        {
            _piécesPlacées++;
            equipements[2].SetActive(true);
        }
    }
    private void PlacementPlastron()
    {
        if (_plastronDetruit==true)
        {
            _piécesPlacées++;
            equipements[0].SetActive(true);
        }
    }
    private void PlacementCasque()
    {
        if (_casqueDetruit==true)
        {
            _piécesPlacées++;
            equipements[1].SetActive(true);
        }
    }
    
    private void BouclierDetruit()
    {
        _bouclierDetruit = true;
    }
    private void EpeeDetruite()
    {
        _epeeDetruite = true;
    }
    private void PlastronDetruit()
    {
        _plastronDetruit = true;
    }
    private void CasqueDetruit()
    {
        _casqueDetruit = true;
    }

    private void StatueComplete()
    {
        if (_piécesPlacées>=4)
        {
            print("baboushka");
        }
    }
    private void OnDisable()
    {
        Bouclier.ShieldWasTaken -= BouclierDetruit;
        Casque.HelmetWasTaken -= CasqueDetruit;
        Epee.SwordWasTaken -= EpeeDetruite;
        Plastron.BreastPlateWasTaken -= PlastronDetruit;
    }
}
