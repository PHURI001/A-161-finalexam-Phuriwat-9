using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected bool IsEffectActive;

    public abstract void ApplyEffect(Player player);
}
