using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerScript : MonoBehaviour
{
    public GameObject fruit;
    void Update()
    {
            Instantiate(fruit,transform.position,Quaternion.identity);
    }
}
