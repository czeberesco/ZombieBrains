using Unity.Entities;
using Unity.Mathematics;

namespace ECS.ComponentsAndTags
{
	public struct GraveyardProperties : IComponentData
	{
		#region PublicFields

		public float2 FieldDimensions;
		public int NumberTombstonesToSpawn;
		public Entity TombstonePrefab;

		#endregion
	}
}
