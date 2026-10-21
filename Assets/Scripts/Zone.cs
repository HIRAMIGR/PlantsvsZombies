using UnityEngine;

public class Zone : MonoBehaviour
{
private bool isOccuped = false;
public bool IsOccupied
    {
            get {return isOccuped;}
            set {isOccuped = value;}
    }
}
