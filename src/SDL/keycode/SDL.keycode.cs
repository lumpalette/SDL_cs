namespace SDL3;

// SDL_keycode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keycode.h
public static unsafe partial class SDL
{
	[Macro]
	public static SDL_Keycode ScancodeToKeycode(SDL_Scancode scancode) => (SDL_Keycode)((uint)scancode | ScancodeMask);

	/// <summary>
	/// A mask used to map scancodes to keycodes.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Keycode">documentation</see> for more details.
	/// </remarks>
	public const uint ScancodeMask = 1u << 30;
}