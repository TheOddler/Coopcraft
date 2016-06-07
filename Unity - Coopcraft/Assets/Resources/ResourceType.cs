using UnityEngine;
using System.Collections;

[CreateAssetMenu]
public class ResourceType : ScriptableObject
{
	public string Name { get { return name; } }

	[SerializeField]
	string _unit = "kg";

	[SerializeField]
	float _perUnitWorth = 1f;
}
