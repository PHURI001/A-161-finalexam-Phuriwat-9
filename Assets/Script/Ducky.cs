using UnityEngine;

public class Ducky : PowerUpBase
{
    //for + Player Hp and Make Sound
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive) { MakeSound(); player.AddHealth(20); IsEffectActive = true; } //set stats and do something
    }

    void MakeSound()
    {
        Debug.Log("Player Make Sound : Duck Duck! [ You Get More Health. ]");
    }
}
