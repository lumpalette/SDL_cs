namespace SDL_cs;

// SDL_keycode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keycode.h
unsafe partial class SDL
{
	[Macro]
	public static SDL_Keycode ScancodeToKeycode(SDL_Scancode scancode)
	{
		return (SDL_Keycode)((uint)scancode | ScancodeMask);
	}

	/// <summary>
	/// A mask used to map scancodes to keycodes.
	/// </summary>
	public const uint ScancodeMask = 1u << 30;
}