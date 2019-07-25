using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInteractive : MonoBehaviour
{
    public enum GameParts { building, gatherer, builder, defender};
    public GameParts GamePart;
    public bool Busy = false;
    public bool HoldingOBJ = false;
    public GameObject heldobj;
    public bool CanMove = false;

    [SerializeField]
    Vector3 chosenpos1;
    [SerializeField]
    Vector3 chosonpos2;

 protected virtual void ObjMessage()
    {
        
    }


    protected virtual void Update()
    {
        if(CanMove)
        {
            
        }
    }

}
