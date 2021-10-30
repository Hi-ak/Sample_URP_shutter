using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeCollider : MonoBehaviour
{
    public GameObject Shutter;
    public float LimitY;
    public static BoxCollider ShutterCollider;
    Vector3 ShutterPositionDefault;
    Vector3 ShutterScale;
    Vector3 ShutterPosition;
    

    float NowCenter;
    float BoxScaleY;

    float NewColliderCenterPositionY;
    float NewColliderSizeY;

    

    

    // Start is called before the first frame update
    void Start()


    {
        BoxScaleY = Shutter.transform.localScale.y;

        ShutterCollider = Shutter.GetComponent<BoxCollider>();

        ShutterScale = Shutter.transform.localScale;

        ShutterPositionDefault = Shutter.transform.position;

        ShutterPosition = Shutter.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        if (hit.gameObject == Shutter)

        {


            NowCenter = Shutter.transform.position.y;

            NewColliderCenterPositionY = -((NowCenter - ((LimitY - (NowCenter - BoxScaleY)) / 2) - (NowCenter - (BoxScaleY / 2))) / BoxScaleY);
            NewColliderSizeY = (LimitY - (NowCenter - (BoxScaleY / 2))) / BoxScaleY;




            ShutterPosition = Shutter.transform.position;

            Shutter.GetComponent<BoxCollider>().center = new Vector3(ShutterPositionDefault.x,NewColliderCenterPositionY,ShutterPositionDefault.z);

            Shutter.GetComponent<BoxCollider>().size = new Vector3(ShutterScale.x,NewColliderSizeY,ShutterScale.z);


                
        }
    }
}
