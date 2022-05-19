using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public int Leitung;
    public Animator animatorDoor;

    public void TapeAdd()
    {
        Leitung++;

    }

    public void TapeAway()
    {
        Leitung--;
    }

    public void Update()
    {
        animatorDoor.SetInteger("GasStopped", Leitung);
    }
}
