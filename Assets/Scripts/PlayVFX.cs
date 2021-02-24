using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class PlayVFX : MonoBehaviour
{
    private VisualEffect Smoke;

    void Start(){
        Smoke = GetComponent<VisualEffect>();
        Smoke.SendEvent("OnStop");
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("stop");
            Smoke.SendEvent("OnStop");
        }else if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log("play");
            Smoke.SendEvent("OnPlay");
        }
    }
}
