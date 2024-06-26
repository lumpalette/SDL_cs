using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A rectangle, with the origin at the upper left (using floating point values).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FRect">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate of the origin.</param>
/// <param name="y">The y coordinate of the origin.</param>
/// <param name="width">The width of this rectangle.</param>
/// <param name="height">The height of this rectangle.</param>
/// <seealso cref="SDL.RectEmpty(ref SDL_FRect)"/>
/// <seealso cref="SDL.RectsEqual(ref SDL_FRect, ref SDL_FRect, float)"/>
/// <seealso cref="SDL.HasRectIntersection(ref SDL_FRect, ref SDL_FRect)"/>
/// <seealso cref="SDL.GetRectIntersection(ref SDL_FRect, ref SDL_FRect, out SDL_FRect)"/>
/// <seealso cref="SDL.GetRectAndLineIntersection(ref SDL_FRect, ref float, ref float, ref float, ref float)"/>
/// <seealso cref="SDL.GetRectAndLineIntersection(ref SDL_FRect, ref SDL_FPoint, ref SDL_FPoint)"/>
/// <seealso cref="SDL.GetRectUnion(ref SDL_FRect, ref SDL_FRect, out SDL_FRect)"/>
/// <seealso cref="SDL.GetRectEnclosingPoints(SDL_FPoint[], ref SDL_FRect, out SDL_FRect)"/>
/// <seealso cref="SDL.PointInRect(ref SDL_FPoint, ref SDL_FRect)"/>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_FRect(float x, float y, float width, float height)
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