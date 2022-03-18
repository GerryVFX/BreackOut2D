using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockN5 : Block
{
    [System.Obsolete]
    public override void Start()
    {
        resistencia = 5;
        powerUps = Random.RandomRange(1, 6);
    }
}
