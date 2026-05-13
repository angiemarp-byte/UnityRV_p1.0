using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TurnSwitchController : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurnProvider;
    public ActionBasedContinuousTurnProvider continuousTurnProvider;

    public bool snapTurnActive = true;

    public void SwitchTurn()
    {
        if (snapTurnActive == true)
        {
            snapTurnProvider.turnAmount = 0;
            continuousTurnProvider.turnSpeed = 20;

            snapTurnActive = false;
        }
        else
        {
            snapTurnProvider.turnAmount = 15;
            continuousTurnProvider.turnSpeed = 0;

            snapTurnActive = true;
        }
    }
}