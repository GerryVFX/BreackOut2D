using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockN3 : Block
{
    [System.Obsolete]
    public override void Start()
    {
        resistencia = 3;
        powerUps = Random.RandomRange(1, 6);
    }
}
