using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrrouselScript : MonoBehaviour
{
    public GameObject[] listaObjetos;
    int index = -1; 
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject objeto in listaObjetos)
        {
            objeto.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            nextObject();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            previousObject();
        }
    }

    void deactivateObjects()
    {
        foreach (GameObject objeto in listaObjetos)
        {
            objeto.SetActive(false);
        }
    }

    void nextObject()
    {

        index++;   
        if (index >= listaObjetos.Length)
        {
            index = 0; 
        }
        deactivateObjects();
        listaObjetos[index].SetActive(true);

    }

    void previousObject()
    {
        index--; 
        if (index < 0)
        {
            index = listaObjetos.Length - 1; 
        }
        deactivateObjects();
        listaObjetos[index].SetActive(true);
    } 
}
