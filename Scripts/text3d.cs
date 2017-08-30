 using UnityEngine;
 
  using System.Collections;
 
  public class text3d : MonoBehaviour 
  {
 
     TextMesh textObject;
 
     // Use this for initialization
     void Start () {
     
         textObject= gameObject.GetComponent("TextMesh") as TextMesh;
     }
     
     // Update is called once per frame
     void Update () {
        int count = UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.collectibleCount;
        if (count < 7)
        {
            textObject.text = "Collectibles: " + count.ToString() + "/7";
        }
        else
        {
            textObject.text = "Congratulations!";
        }
     }
  }
 
 