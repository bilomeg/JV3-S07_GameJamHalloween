using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Pour créer le scriptable object joueur
[CreateAssetMenu(fileName="InfosJoueurs", menuName ="SO/NouveauJoueur")]
public class InfosJoueurs : ScriptableObject
{
    //Variable du scriptable object joueur

    public float _nbPoints;
   

    [SerializeField] public string _tempsDuJoueur;
}
