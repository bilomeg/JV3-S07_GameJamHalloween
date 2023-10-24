using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Référence au texte du timer
    [SerializeField] private TMP_Text _tempsTexte;
    //Variable qui affichera le temps 
    [SerializeField] private float _tempsQuiReste;

   
    [SerializeField] private InfosJoueurs _infosJoueurs;
    
    //Pour déterminer si le temps est écoule 
    private bool _tempsEstEcoule = false;
   
   


    
    void Update()
    {
        //Si le temps n'est pas fini on le calcul sinon on ne le calcul pas 
        if(! _tempsEstEcoule){
           CalculTemps(); 
        }
        
    }
   
   void CalculTemps(){

    _tempsQuiReste -= Time.deltaTime; 
    AfficherTemps(_tempsQuiReste);

  

   }
   
    //Pour afficher le temps du timer qui avance 
    void AfficherTemps(float temps){

    temps +=1;

    float minutes = Mathf.FloorToInt(temps/60);
    float secondes = Mathf.FloorToInt(temps % 60);

    _tempsTexte.text = string.Format("{0:00}:{1:00}",minutes,secondes);
    
 

   }
    
   

  

}