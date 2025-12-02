using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive) { player.SetInvulnerability(true); IsEffectActive = true; }  //set stats and do something
    }
}
