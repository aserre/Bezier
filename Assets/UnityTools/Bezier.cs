using UnityEngine;

namespace UnityTools
{
	public static class Bezier
	{
		public static float Quadratic(float a, float b, float c, float t)
		{
			return (((1-t) * (1-t)) * a) + (2 * t * (1 - t) * b) + ((t * t) * c);
		}

		public static Vector2 Quadratic(Vector2 a, Vector2 b, Vector2 c, float t)
		{
			return (((1-t) * (1-t)) * a) + (2 * t * (1 - t) * b) + ((t * t) * c);
		}

		public static Vector3 Quadratic(Vector3 a, Vector3 b, Vector3 c, float t)
		{
			return (((1-t) * (1-t)) * a) + (2 * t * (1 - t) * b) + ((t * t) * c);
		}

		public static Vector4 Quadratic(Vector4 a, Vector4 b, Vector4 c, float t)
		{
			return (((1-t) * (1-t)) * a) + (2 * t * (1 - t) * b) + ((t * t) * c);
		}

		public static float Cubic(float a, float b, float c, float d, float t)
		{
			  return (((-a + 3 * (b - c) + d) * t + (3 * (a + c) - 6 * b)) * t + 3 * (b - a)) * t + a;
		}

		public static Vector2 Cubic(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
		{
			  return (((-a + 3 * (b - c) + d) * t + (3 * (a + c) - 6 * b)) * t + 3 * (b - a)) * t + a;
		}

		public static Vector3 Cubic(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t)
		{
			  return (((-a + 3 * (b - c) + d) * t + (3 * (a + c) - 6 * b)) * t + 3 * (b - a)) * t + a;
		}

		public static Vector4 Cubic(Vector4 a, Vector4 b, Vector4 c, Vector4 d, float t)
		{
			  return (((-a + 3 * (b - c) + d) * t + (3 * (a + c) - 6 * b)) * t + 3 * (b - a)) * t + a;
		}
	}
}
