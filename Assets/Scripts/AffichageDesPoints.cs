using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class AffichageDesPoints : MonoBehaviour
{
   //Texte qui affiche le nombre de points dans le canvas de l'interface joueur
    [SerializeField] private TMP_Text _texteNbPoints;
     //Référence aux scriptable objects 
    [SerializeField] private InfosJoueurs _infosJoueurs;


   void Start(){
    _infosJoueurs._nbPoints = 0;
   }

    // Update is called once per frame
    void Update()
    {
        AfficherPoints();
    }

    //Pour cacher le conseil 
   
    // Pour afficher le texte des points qui augmente dans l'interface joueur 
    public void AfficherPoints(){
       
       _texteNbPoints.text = _infosJoueurs._nbPoints.ToString();
         
    }
    
    
   
    

 
 
   
}
