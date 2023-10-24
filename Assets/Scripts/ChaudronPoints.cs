using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ChaudronPoints : MonoBehaviour
{
    // Points
    [SerializeField] private TMP_Text _texteNbPoints;
    
    //Référence au scriptable object 
    [SerializeField] private InfosJoueurs _infosJoueurs;
     [SerializeField]private int _nbPoints;
    private void OnTriggerEnter(Collider other){

      // Debug.Log("Test collision");

        if(other.gameObject.tag == "Objets"){
           // Debug.Log("Test objet");

        //Si le nombre de points est suppérieur à 0 on incrémente les points quand le joueur entre en collision avec un objet 

       
           //Debug.Log(_texteNbPoints.text);
            _infosJoueurs._nbPoints += _nbPoints;
           Destroy(other.gameObject);
         
            
           
        }         
     }
    }


