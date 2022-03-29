using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    public GameObject[] emplacements;
    private bool _epeeDetruite = false;
    private bool _bouclierDetruit = false;
    private bool _casqueDetruit = false;
    private bool _plastronDetruit = false;

    private void OnEnable()
    {
        Bouclier.ShieldWasTaken += BouclierDetruit;
        Casque.HelmetWasTaken += CasqueDetruit;
        Epee.SwordWasTaken += EpeeDetruite;
        Plastron.BreastPlateWasTaken += PlastronDetruit;
    }

    private void PlacementBouclier()
    {
        
    }
    private void PlacementEpee()
    {
        
    }
    private void PlacementPlastron()
    {
        
    }
    private void PlacementCasque()
    {
        
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
    
    private void OnDisable()
    {
        Bouclier.ShieldWasTaken -= BouclierDetruit;
        Casque.HelmetWasTaken -= CasqueDetruit;
        Epee.SwordWasTaken -= EpeeDetruite;
        Plastron.BreastPlateWasTaken -= PlastronDetruit;
    }
}
