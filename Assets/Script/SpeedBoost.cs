using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive) { player.SetMoveSpeed(2); IsEffectActive = true; }  //set stats and do something
    }
}
