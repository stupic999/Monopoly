using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDiceSocket : MonoBehaviour
{
    int DiceNum;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DiceNum = Random.Range(1, 7);
            Debug.Log(DiceNum);
        }
    }
}
