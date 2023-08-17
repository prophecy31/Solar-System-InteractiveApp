using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    // Start is called before the first frame update
    //Declare a game object variable that defines a target where the camera should LookAt
    public GameObject target;
    void Start()
    {
        if(target == null)
            target = this.gameObject;
            Debug.Log("change look target is not specified. Defaulting to parent object)");
    }

    // Update is called once per frame

    private void OnMouseDown() {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
    }
}
