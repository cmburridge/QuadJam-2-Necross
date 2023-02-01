using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HeldItem : ScriptableObject
{
    public ItemData item;

    public void ChangeItem(ItemData other)
    {
        item = other;
    }
}
