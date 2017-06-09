using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveText : MonoBehaviour {

    [SerializeField]
    public float speed;

    private RectTransform move; 

    void Awake()
    {
        move = GetComponent<RectTransform>();
    }
    void Update()
    {
        //if(move.rect.y != 0)move.rect.Set(move.rect.x,move.rect.y + speed,move.rect.width,move.rect.height);    
        if (move.position.y != 280) move.Translate(new Vector3(0, move.position.y*-speed,0));
    }
}
