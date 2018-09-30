using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestTouch : MonoBehaviour {
    Touch myTouch;
    Touch[] myTouches;

    public int toquesI;
    public int toquesD;
    public int seconds;
    int puntosI = 1;
    int puntosD = 1;
    bool posibleI = false;
    bool posibleD = false;

    public GameObject congelarI;
    public GameObject dobleI;
    public GameObject congelarD;
    public GameObject dobleD;

    public GameObject botonI;
    public GameObject botonD;


    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame

    void Update() {

        if (toquesD == 10)
        {
            congelarD.SetActive(true);
        } else if(toquesD == 20 && posibleD)
        {
            dobleD.SetActive(true);
        }

        if (toquesI == 10)
        {
            congelarI.SetActive(true);
        }
        else if (toquesI == 20 && posibleI)
        {
            dobleI.SetActive(true);
        }


        /*
        myTouch = Input.GetTouch(0);

        for(int i = 0; i < Input.touchCount; i++)
        {
            if (myTouch.position.x < 0 && transform.position.x > -5)
            {
                transform.Translate(-0.1f,0,0);
                //Debug.Log("Hola");
            }
            if (myTouch.position.x > 0 && transform.position.x < 5)
            {
                transform.Translate(+0.1f, 0, 0);
                //Debug.Log("Adios");
            }
        }*/
    }
    public void MoverI()
    {
        if (puntosI == 1)
        {
            transform.Translate(-0.5f, 0, 0);
        }else if (puntosI == 2)
        {
            transform.Translate(-1f, 0, 0);
        }
        
        //Debug.Log("Adios");
        toquesI += puntosI;
    }
    public void MoverD()
    {
        if (puntosD == 1)
        {
            transform.Translate(+0.5f, 0, 0);
        }
        else if (puntosD == 2)
        {
            transform.Translate(+1f, 0, 0);
        }
        //Debug.Log("Hola");
        toquesD += puntosD;
    }

    public void FreezeI()
    {
        posibleI = true;
        congelarI.SetActive(false);
        StartCoroutine("CongI");        
    }
    public IEnumerator CongI()
    {
        botonD.SetActive(false);
        yield return new WaitForSeconds(seconds);
        botonD.SetActive(true);
    }

    public void FreezeD()
    {
        posibleD = true;
        congelarD.SetActive(false);
        StartCoroutine("CongD");
    }
    public IEnumerator CongD()
    {
        botonI.SetActive(false);
        yield return new WaitForSeconds(seconds);
        botonI.SetActive(true);
    }

    public void MultiplicadorI()
    {
        posibleI = false;
        dobleI.SetActive(false);
        StartCoroutine("DoubleI");
    }
    public IEnumerator DoubleI()
    {
        puntosI = 2;
        yield return new WaitForSeconds(seconds);
    }

    public void MultiplicadorD()
    {
        posibleD = false;
        dobleD.SetActive(false);
        StartCoroutine("DoubleD");
    }
    public IEnumerator DoubleD()
    {
        puntosD = 2;
        yield return new WaitForSeconds(seconds);
    }
}
