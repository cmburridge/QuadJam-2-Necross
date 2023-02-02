using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HeldItem : ScriptableObject
{
    public ItemData item;

    public void ResetItem(ItemData other)
    {
        item = other;
    }

    public void ChangeItem(ItemData other)
    {
        item = other;
    }
}
