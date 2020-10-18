﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span=0.5f;
    float delta=0;

    // Update is called once per frame
    void Update()
    {
        //フレームの時間差取得
        this.delta+=Time.deltaTime;
        if(this.delta>this.span){
            this.delta=0;
            GameObject go=Instantiate(arrowPrefab) as GameObject;
            int px=Random.Range(-6,7);
            go.transform.position=new Vector3(px,7,0);
        }
    }
}
