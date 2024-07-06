namespace SDL_cs;

// SDL_keycode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keycode.h
unsafe partial class SDL
{
	/// <summary>
	/// Converts a <see cref="SDL_Scancode"/> value into an <see cref="SDL_Keycode"/> value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Keycode">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The <see cref="SDL_Scancode"/> to convert.</param>
	/// <returns>The new <see cref="SDL_Keycode"/> value.</returns>
	[Macro]
	public static SDL_Keycode ScancodeToKeycode(SDL_Scancode scancode)
	{
		return (SDL_Keycode)((uint)scancode | ScancodeMask);
	}

	/// <summary>
	/// A mask used to map scancodes to keycodes.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Keycode">documentation</see> for more details.
	/// </remarks>
	public const uint ScancodeMask = 1u << 30;
}