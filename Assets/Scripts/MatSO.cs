using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Material")]

public class MatSO : ScriptableObject
{
    public Sprite icon;
    public new string name;
    public int tradeValue;
}
