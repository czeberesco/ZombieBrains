using ECS.ComponentsAndTags;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace ECS.AuthoringAndMono
{
	public class GraveyardAuthoring : MonoBehaviour
	{
		#region SerializeFields

		[SerializeField] private float2 m_fieldDimensions;
		[SerializeField] private int m_numberTombstonesToSpawn;
		[SerializeField] private GameObject m_tombstonePrefab;

		#endregion

		#region NestedTypes

		public class GraveyardPropertiesBaker : Baker<GraveyardAuthoring>
		{
			#region PublicMethods

			public override void Bake(GraveyardAuthoring authoring)
			{
				AddComponent(
					GetEntity(TransformUsageFlags.None),
					new GraveyardProperties
					{
						FieldDimensions = authoring.m_fieldDimensions,
						NumberTombstonesToSpawn = authoring.m_numberTombstonesToSpawn,
						TombstonePrefab = GetEntity(authoring.m_tombstonePrefab, TransformUsageFlags.Renderable)
					}
				);
			}

			#endregion
		}

		#endregion
	}
}
