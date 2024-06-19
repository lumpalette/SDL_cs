using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The SDL keysym structure, used in key events.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_Keysym">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Keysym
{
	/// <summary>
	/// SDL physical key code - see <see cref="SDL.SDL_Scancode"/> for details.
	/// </summary>
	public SDL_Scancode Scancode;

	/// <summary>
	/// SDL virtual key code - see <see cref="SDL_Keycode"/> for details.
	/// </summary>
	public SDL_Keycode Sym;

	/// <summary>
	/// Current key modifiers.
	/// </summary>
	public SDL_Keymod Mod;

	private readonly ushort _unused;
}