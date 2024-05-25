using System.Runtime.InteropServices;

namespace SDL3;

// SDL_rect.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_rect.h.
unsafe partial class SDL
{
	/// <summary>
	/// The structure that defines a point using integers.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Point">here</see>.
	/// </remarks>
	/// <param name="x"> The x coordinate. </param>
	/// <param name="y"> The y coordinate. </param>
	[StructLayout(LayoutKind.Sequential)]
	public struct Point(int x, int y)
	{
		/// <summary>
		/// The x coordinate of this point.
		/// </summary>
		public int X = x;

		/// <summary>
		/// The y coordinate of this point.
		/// </summary>
		public int Y = y;
	}

	/// <summary>
	/// The structure that defines a point using floating point values.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FPoint">here</see>.
	/// </remarks>
	/// <param name="x"> The x coordinate. </param>
	/// <param name="y"> The y coordinate. </param>
	[StructLayout(LayoutKind.Sequential)]
	public struct FPoint(float x, float y)
	{
		/// <summary>
		/// The x coordinate of this point.
		/// </summary>
		public float X = x;

		/// <summary>
		/// The y coordinate of this point.
		/// </summary>
		public float Y = y;
	}

	/// <summary>
	/// A rectangle, with the origin at the upper left using integers.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Rect">here</see>.
	/// </remarks>
	/// <param name="x"> The x coordinate of the origin. </param>
	/// <param name="y"> The y coordinate of the origin. </param>
	/// <param name="width"> The width of this rectangle. </param>
	/// <param name="height"> The height of this rectangle. </param>
	[StructLayout(LayoutKind.Sequential)]
	public struct Rect(int x, int y, int width, int height)
	{
		/// <summary>
		/// The x coordinate of the upper-left corner of this rectangle.
		/// </summary>
		public int X = x;

		/// <summary>
		/// The y coordinate of the upper-left corner of this rectangle.
		/// </summary>
		public int Y = y;

		/// <summary>
		/// The width of this rectangle.
		/// </summary>
		public int Width = width;

		/// <summary>
		/// The height of this rectangle.
		/// </summary>
		public int Height = height;
	}

	/// <summary>
	/// A rectangle, with the origin at the upper left using floating point values.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FRect">here</see>.
	/// </remarks>
	/// <param name="x"> The x coordinate of the origin. </param>
	/// <param name="y"> The y coordinate of the origin. </param>
	/// <param name="width"> The width of this rectangle. </param>
	/// <param name="height"> The height of this rectangle. </param>
	[StructLayout(LayoutKind.Sequential)]
	public struct FRect(float x, float y, float width, float height)
	{
		/// <summary>
		/// The x coordinate of the upper-left corner of this rectangle.
		/// </summary>
		public float X = x;

		/// <summary>
		/// The y coordinate of the upper-left corner of this rectangle.
		/// </summary>
		public float Y = y;

		/// <summary>
		/// The width of this rectangle.
		/// </summary>
		public float Width = width;

		/// <summary>
		/// The height of this rectangle.
		/// </summary>
		public float Height = height;
	}
}