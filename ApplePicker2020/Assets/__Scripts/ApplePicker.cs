using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in inspector")]
    public GameObject               basketPrefab;
    public int                      numBaskets = 3;//numero de vidas o en este caso canastas
    public float                    basketBottomY = -14;//posicion de la primer canasta
    public float                    basketSpacingY = 2;//espacio entre canastas
    public List<GameObject>         basketList;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void AppleDestroyed() 
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject go in tAppleArray) 
        {
            Destroy(go);
        }

        //se destruye una de las canastas
        //obten el indice de la ultima canasta
        int basketIndex = basketList.Count - 1;
        //obten la referencia al Game Object de la canasta
        GameObject tbasketGO = basketList[basketIndex];
        //elimina la canasta de la lista y destruye el game object
        basketList.RemoveAt(basketIndex);
        Destroy(tbasketGO);

        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene 0");
        }
    }

    
}
