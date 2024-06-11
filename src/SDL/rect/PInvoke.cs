namespace SDL_cs;

// SDL_rect.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_rect.h.
unsafe partial class SDL
{
	/// <summary>
	/// Determine whether a point resides inside a rectangle.
	/// </summary>
	/// <remarks>
	/// This is not inlined, as C# does not support inline functions. Refer to the official documentation
	/// <see href="https://wiki.libsdl.org/SDL3/SDL_PointInRect">here</see>.
	/// </remarks>
	/// <param name="p"> The point to test. </param>
	/// <param name="r"> The rectangle to test. </param>
	/// <returns>True if <paramref name="p"/> is contained by <paramref name="r"/>, false otherwise.  </returns>
	public static bool PointInRect(SDL_Point p, SDL_Rect r)
	{
		return (p.X >= r.X) && (p.X < (r.X + r.Width)) && (p.Y >= r.Y) && (p.Y < (r.Y + r.Height));
	}

	/// <summary>
	/// Determine whether a rectangle has no area.
	/// </summary>
	/// <remarks>
	/// This is not inlined, as C# does not support inline functions. Refer to the official documentation
	/// <see href="https://wiki.libsdl.org/SDL3/SDL_RectEmpty">here</see>.
	/// </remarks>
	/// <param name="r"> The rectangle to test. </param>
	/// <returns> True if the rectangle is "empty" (has zero or negative area), false otherwise. </returns>
	public static bool RectEmpty(SDL_Rect r)
	{
		return (r.Width <= 0) && (r.Height <= 0);
	}
}