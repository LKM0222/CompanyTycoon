using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoSingleton<MapManager>
{
    
    #region Life Cycle

    protected override void OnAwakeRoutine()
    {
        base.OnAwakeRoutine();

        print("awake");
    }

    protected override void OnDestroyRoutine()
    {
        base.OnDestroyRoutine();
    }

    #endregion
}
