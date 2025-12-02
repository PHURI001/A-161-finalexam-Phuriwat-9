using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        player.SetMoveSpeed(2);
    }
}
