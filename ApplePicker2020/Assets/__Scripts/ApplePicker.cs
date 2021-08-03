using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{

    //velocidad de movimiento cada cuadro
    //cambio de direccion al llegar al borde de la escena
    //cambios de direccion de manera aleatoria
    //soltar una manzana cada cierto tiempo

    [Header("Set in Inspector")]
    
    public GameObject       applePrefab;                    //prefab for instantiating apples
    public float            speed = 1;                      //speed at which the apple tree will move
    public float            leftAndRightEdge = 10f;         //distance where the apple tree turns arround
    public float            chanceToChangeDirections = 0.1f;//chance that the apple tree wil change directions
    public float            secondsBetweenAppleDrops = 0.5f;//rate at which the apples will be dropped




    // Start is called before the first frame update
    void Start()
    {
        //initialization and start dropping the apples
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement logic
        //change direction logic
    }
}
