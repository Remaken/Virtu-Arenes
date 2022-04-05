using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Statue : MonoBehaviour
{
    public GameObject[] equipements;
    private bool _epeeDetruite = false;
    private bool _bouclierDetruit = false;
    private bool _casqueDetruit = false;
    private bool _plastronDetruit = false;
    private int _piecesPlaces = 0;
    public bool statueComplete = false;

    
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

    private void  PlacementBouclier()
    {
        if (_bouclierDetruit==true)
        {
            _bouclierDetruit = false;
            equipements[3].SetActive(true);
            
            if (_bouclierDetruit==false)
            {
                _piecesPlaces++;
            }
        }
    }
    private void  PlacementEpee()
    {
        if (_epeeDetruite==true)
        {
            _epeeDetruite = false;
            equipements[2].SetActive(true);
            
            if (_epeeDetruite==false)
            {
                _piecesPlaces++;
            }
        }
    }
    private void PlacementPlastron()
    {
        if (_plastronDetruit==true)
        {
            _plastronDetruit = false;
            equipements[0].SetActive(true);
            
            if (_plastronDetruit==false)
            {
                _piecesPlaces++;
            }
        }
    }
    private void  PlacementCasque()
    {
        if (_casqueDetruit==true)
        {
            _casqueDetruit = false;
            equipements[1].SetActive(true);
            if (_casqueDetruit==false)
            {
                _piecesPlaces++;
            }
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
        if (_piecesPlaces>=4)
        {
            statueComplete = true;
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
