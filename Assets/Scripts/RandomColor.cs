using UnityEngine;

public class RandomColor : MonoBehaviour{

    void Start(){
        gameObject.GetComponent<MeshRenderer>().material.color =  Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

}
