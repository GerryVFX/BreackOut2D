using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockN4 : Block
{
    [System.Obsolete]
    public override void Start()
    {
        resistencia = 4;
        powerUps = Random.RandomRange(1, 6);
    }
}
