using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float veloc ;
    public float entradaHorizontal;
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Metodo Start de"+this.name) ;
      veloc = 3.0f ;
      transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime*veloc);
        entradaHorizontal = Input.GetAxis("Horizontal");
    }
}
