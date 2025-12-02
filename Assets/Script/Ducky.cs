using UnityEngine;

public class Ducky : PowerUpBase
{
    //for + Player Hp and Make Sound
    public override void ApplyEffect(Player player)
    {
        player.AddHealth(20);
    }

    void MakeSound()
    {
        Debug.Log("Player Make Sound : Duck Duck! [ You Get More Health. ]");
    }
}
