using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private void Update()
    {
 if (Input.GetKey(KeyCode.W)) 
  this.transform.Translate(0,0,0.2f); 
  if (Input.GetKey(KeyCode.S)) 
  this.transform.Translate(0,0,-0.2f); 
  if (Input.GetKey(KeyCode.D)) 
  this.transform.Translate(0.2f,0,0); 
  if (Input.GetKey(KeyCode.A)) 
  this.transform.Translate(-0.2f,0,0); 
  } 
}
