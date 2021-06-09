using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoScript : MonoBehaviour
{
    void Start()
    {
        if (PersistentData.Instance.gameSettings == PersistentData.GameSettings.Adults && PersistentData.Instance.Game2Available)
            Events.LoadScene("Adults");
        else if(PersistentData.Instance.Game1Available)
            Events.LoadScene("Kids");
    }
}
