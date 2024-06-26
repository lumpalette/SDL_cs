using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A rectangle, with the origin at the upper (left using integers).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Rect">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate of the origin.</param>
/// <param name="y">The y coordinate of the origin.</param>
/// <param name="width">The width of this rectangle.</param>
/// <param name="height">The height of this rectangle.</param>
/// <seealso cref="SDL.RectEmpty(ref SDL_Rect)"/>
/// <seealso cref="SDL.RectsEqual(ref SDL_Rect, ref SDL_Rect)"/>
/// <seealso cref="SDL.HasRectIntersection(ref SDL_Rect, ref SDL_Rect)"/>
/// <seealso cref="SDL.GetRectIntersection(ref SDL_Rect, ref SDL_Rect, out SDL_Rect)"/>
/// <seealso cref="SDL.GetRectAndLineIntersection(ref SDL_Rect, ref int, ref int, ref int, ref int)"/>
/// <seealso cref="SDL.GetRectAndLineIntersection(ref SDL_Rect, ref SDL_Point, ref SDL_Point)"/>
/// <seealso cref="SDL.GetRectUnion(ref SDL_Rect, ref SDL_Rect, out SDL_Rect)"/>
/// <seealso cref="SDL.GetRectEnclosingPoints(SDL_Point[], ref SDL_Rect, out SDL_Rect)"/>
/// <seealso cref="SDL.PointInRect(ref SDL_Point, ref SDL_Rect)"/>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Rect(int x, int y, int width, int height)
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