using UnityEngine;
public abstract class BaseCommand : MonoBehaviour
{
    public virtual void Execute() {}
    public virtual void ExecuteDown() {}
    public virtual void ExecuteUp() {}
}