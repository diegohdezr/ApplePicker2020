using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in inspector")]
    public GameObject               basketPrefab;
    public int                      numBaskets = 3;//numero de vidas o en este caso canastas
    public float                    basketBottomY = -14;//posicion de la primer canasta
    public float                    basketSpacingY = 2;//espacio entre canastas

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    

    
}
