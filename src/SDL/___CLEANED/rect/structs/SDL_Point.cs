using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure that defines a point (using integers).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Point">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate.</param>
/// <param name="y">The y coordinate.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Point(int x, int y)
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