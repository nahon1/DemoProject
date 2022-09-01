using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour{

    [SerializeField]
    private Transform cam;

 
    private void Update() {

        float forward = Input.GetAxis("Vertical") * Time.deltaTime * 10f;
        float sideways = Input.GetAxis("Horizontal") * Time.deltaTime * 10f;

        float turn = Input.GetAxis("Mouse X") * Time.deltaTime * 500f;
        float tilt = Input.GetAxis("Mouse Y") * Time.deltaTime * -500f;

        float currentFacing = transform.eulerAngles.y + turn;
        float currentTilt = cam.localEulerAngles.x + tilt;

        transform.eulerAngles = new Vector3(0, currentFacing, 0);
        cam.localEulerAngles = new Vector3(tilt, 0, 0);
        transform.position += transform.TransformDirection(new Vector3(sideways, 0, forward));

    }

}
