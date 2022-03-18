using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockN2 : Block
{
    [System.Obsolete]
    public override void Start()
    {
        resistencia = 2;
        powerUps = Random.RandomRange(1, 6);
    }


}
