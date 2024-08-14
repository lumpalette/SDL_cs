using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// A set of indexed colors representing a palette.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Palette">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_Palette
{
	/// <summary>
	/// Number of elements in <see cref="Colors"/>.
	/// </summary>
	public int NumColors;

	/// <summary>
	/// An array of <see cref="SDL_Color"/> structures representing this palette, <see cref="NumColors"/> long.
	/// </summary>
	public SDL_Color* Colors;

	private readonly uint _version;

	private readonly int _refCount;
}