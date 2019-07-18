using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInteractive : MonoBehaviour
{
    public enum GameParts { building, character};
    public GameParts GamePart;
    public bool Busy = false;


 protected virtual void ObjMessage()
    {

    }

}
