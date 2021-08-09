using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{

    //velocidad de movimiento cada cuadro
    //cambio de direccion al llegar al borde de la escena
    //cambios de direccion de manera aleatoria
    //soltar una manzana cada cierto tiempo

    [Header("Set in Inspector")]
    public GameObject applePrefab;                    //prefab for instantiating apples
    public float speed = 1;                      //speed at which the apple tree will move
    public float leftAndRightEdge = 10f;         //distance where the apple tree turns arround
    public float chanceToChangeDirections = 0.1f;//chance that the apple tree wil change directions
    public float secondsBetweenAppleDrops = 0.5f;//rate at which the apples will be dropped
    // Start is called before the first frame update
    void Start()
    {
        //initialization and start dropping the apples
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement logic
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //change direction logic
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);//nos movemos hacia la derecha
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);//nos movemos hacia la izquierda
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;                //cambio de direccion   
        }
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;

        Invoke("DropApple", secondsBetweenAppleDrops);
    }
}
