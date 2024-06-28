using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_keyboard.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keyboard.h
unsafe partial class SDL
{
	/// <summary>
	/// Return whether a keyboard is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasKeyboard">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if a keyboard is connected, false otherwise.</returns>
	public static bool HasKeyboard()
	{
		return PInvoke.SDL_HasKeyboard() == 1;
	}

	/// <summary>
	/// Get a list of currently connected keyboards.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboards">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">The number of keyboards returned.</param>
	/// <returns>An array of keyboard instance IDs, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_KeyboardId[]? GetKeyboards(out int count)
	{
		fixed (int* countPtr = &count)
		{
			var keyboardsPtr = PInvoke.SDL_GetKeyboards(countPtr);
			if (keyboardsPtr is null)
			{
				return null;
			}
			var keyboards = new SDL_KeyboardId[count];
			for (int i = 0; i < count; i++)
			{
				keyboards[i] = keyboardsPtr[i];
			}
			Free(keyboardsPtr);
			return keyboards;
		}
	}

	/// <summary>
	/// Get the name of a keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardInstanceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="keyboardId">The keyboard instance ID.</param>
	/// <returns>The name of the selected keyboard, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static string? GetKeyboardInstanceName(SDL_KeyboardId keyboardId)
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetKeyboardInstanceName(keyboardId));
	}

	/// <summary>
	/// Query the window which currently has keyboard focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardFocus">documentation</see> for more details.
	/// </remarks>
	/// <returns>The window with keyboard focus.</returns>
	public static SDL_Window* GetKeyboardFocus()
	{
		return PInvoke.SDL_GetKeyboardFocus();
	}

	/// <summary>
	/// Get a snapshot of the current state of the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardState">documentation</see> for more details.
	/// </remarks>
	/// <param name="numKeys">The length of the returned array.</param>
	/// <returns>A pointer to an array of key states.</returns>
	public static byte* GetKeyboardState(out int numKeys)
	{
		fixed (int* numKeysPtr = &numKeys)
		{
			return PInvoke.SDL_GetKeyboardState(numKeysPtr);
		}
	}

	/// <summary>
	/// Clear the state of the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResetKeyboard">documentation</see> for more details.
	/// </remarks>
	public static void ResetKeyboard()
	{
		PInvoke.SDL_ResetKeyboard();
	}

	/// <summary>
	/// Get the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetModState">documentation</see> for more details.
	/// </remarks>
	/// <returns>An OR'd combination of the modifier keys for the keyboard. See <see cref="SDL_Keymod"/> for details.</returns>
	public static SDL_Keymod GetModState()
	{
		return PInvoke.SDL_GetModState();
	}

	/// <summary>
	/// Set the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetModState">documentation</see> for more details.
	/// </remarks>
	/// <param name="modState">The desired <see cref="SDL_Keymod"/> for the keyboard.</param>
	public static void SetModState(SDL_Keymod modState)
	{
		PInvoke.SDL_SetModState(modState);
	}

	/// <summary>
	/// Get the key code corresponding to the given scancode according to a default en_US keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultKeyFromScancode">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The desired <see cref="SDL_Scancode"/> to query.</param>
	/// <param name="modState">The modifier state to use when translating the scancode to a keycode.</param>
	/// <returns>The <see cref="SDL_Keycode"/> that corresponds to the given <see cref="SDL_Scancode"/>.</returns>
	public static SDL_Keycode GetDefaultKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modState)
	{
		return PInvoke.SDL_GetDefaultKeyFromScancode(scancode, modState);
	}

	/// <summary>
	/// Get the key code corresponding to the given scancode according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyFromScancode">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The desired <see cref="SDL_Scancode"/> to query.</param>
	/// <param name="modState">The modifier state to use when translating the scancode to a keycode.</param>
	/// <returns>The <see cref="SDL_Keycode"/> that corresponds to the given <see cref="SDL_Scancode"/>.</returns>
	public static SDL_Keycode GetKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modState)
	{
		return PInvoke.SDL_GetKeyFromScancode(scancode, modState);
	}

	/// <summary>
	/// Get the scancode corresponding to the given key code according to a default en_US keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <param name="modState">The modifier state that would be used when the scancode generates this key, may be <see langword="null"/>.</param>
	/// <returns>The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>.</returns>
	public static SDL_Scancode GetDefaultScancodeFromKey(SDL_Keycode key, ref SDL_Keymod modState)
	{
		fixed (SDL_Keymod* modStatePtr = &modState)
		{
			return PInvoke.SDL_GetDefaultScancodeFromKey(key, modStatePtr);
		}
	}

	/// <summary>
	/// Get the scancode corresponding to the given key code according to a default en_US keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <param name="modState">The modifier state that would be used when the scancode generates this key, may be <see langword="null"/>.</param>
	/// <returns>The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>.</returns>
	public static SDL_Scancode GetDefaultScancodeFromKey(SDL_Keycode key, SDL_Keymod* modState)
	{
		return PInvoke.SDL_GetDefaultScancodeFromKey(key, modState);
	}

	/// <summary>
	/// Get the scancode corresponding to the given key code according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <param name="modState">The modifier state that would be used when the scancode generates this key, may be <see langword="null"/>.</param>
	/// <returns>The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>.</returns>
	public static SDL_Scancode GetScancodeFromKey(SDL_Keycode key, ref SDL_Keymod modState)
	{
		fixed (SDL_Keymod* modStatePtr = &modState)
		{
			return PInvoke.SDL_GetScancodeFromKey(key, modStatePtr);
		}
	}

	/// <summary>
	/// Get the scancode corresponding to the given key code according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <param name="modState">The modifier state that would be used when the scancode generates this key, may be <see langword="null"/>.</param>
	/// <returns>The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>.</returns>
	public static SDL_Scancode GetScancodeFromKey(SDL_Keycode key, SDL_Keymod* modState)
	{
		return PInvoke.SDL_GetScancodeFromKey(key, modState);
	}

	/// <summary>
	/// Set a human-readable name for a scancode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetScancodeName">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The desired <see cref="SDL_Scancode"/>.</param>
	/// <param name="name">The name to use for the scancode.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetScancodeName(SDL_Scancode scancode, string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return PInvoke.SDL_SetScancodeName(scancode, namePtr);
		}
	}

	/// <summary>
	/// Get a human-readable name for a scancode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeName">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The desired <see cref="SDL_Scancode"/> to query.</param>
	/// <returns>The name for the scancode. If the scancode doesn't have a name this function returns an empty string.</returns>
	public static string GetScancodeName(SDL_Scancode scancode)
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetScancodeName(scancode))!;
	}

	/// <summary>
	/// Get a scancode from a human-readable name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromName">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The human-readable scancode name.</param>
	/// <returns>The <see cref="SDL_Scancode"/>, or <see cref="SDL_Scancode.Unknown"/> if the name wasn't recognized; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Scancode GetScancodeFromName(string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return PInvoke.SDL_GetScancodeFromName(namePtr);
		}
	}

	/// <summary>
	/// Get a human-readable name for a key.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyName">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <returns>The name of the key. If the key doesn't have a name, this function returns an empty string.</returns>
	public static string GetKeyName(SDL_Keycode key)
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetKeyName(key))!;
	}

	/// <summary>
	/// Get a key code from a human-readable name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyFromName">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The human-readable key name.</param>
	/// <returns>The <see cref="SDL_Keycode"/>, or <see cref="SDL_Keycode.Unknown"/> if the name wasn't recognized; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Keycode GetKeyFromName(string name)
	{
		fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
		{
			return PInvoke.SDL_GetKeyFromName(namePtr);
		}
	}

	/// <summary>
	/// Start accepting Unicode text input events in a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StartTextInput">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to enable text input.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int StartTextInput(SDL_Window* window)
	{
		return PInvoke.SDL_StartTextInput(window);
	}

	/// <summary>
	/// Check whether or not Unicode text input events are enabled for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputActive">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to check.</param>
	/// <returns>True if text input events are enabled else false.</returns>
	public static bool TextInputActive(SDL_Window* window)
	{
		return PInvoke.SDL_TextInputActive(window) == 1;
	}

	/// <summary>
	/// Stop receiving any text input events in a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StopTextInput">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to disable text input.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int StopTextInput(SDL_Window* window)
	{
		return PInvoke.SDL_StopTextInput(window);
	}

	/// <summary>
	/// Dismiss the composition window/IME without disabling the subsystem.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearComposition">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to affect.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ClearComposition(SDL_Window* window)
	{
		return PInvoke.SDL_ClearComposition(window);
	}

	/// <summary>
	/// Set the rectangle used to type Unicode text inputs.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextInputRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which to set the text input rectangle.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the rectangle to receive text (ignored if <see langword="null"/>).</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetTextInputRect(SDL_Window* window, ref SDL_Rect rect)
	{
		fixed (SDL_Rect* rectPtr = &rect)
		{
			return PInvoke.SDL_SetTextInputRect(window, rectPtr);
		}
	}

	/// <summary>
	/// Set the rectangle used to type Unicode text inputs.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextInputRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which to set the text input rectangle.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the rectangle to receive text (ignored if <see langword="null"/>).</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetTextInputRect(SDL_Window* window, SDL_Rect* rect)
	{
		return PInvoke.SDL_SetTextInputRect(window, rect);
	}

	/// <summary>
	/// Check whether the platform has screen keyboard support.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasScreenKeyboardSupport">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the platform has some screen keyboard support or false if not.</returns>
	public static bool HasScreenKeyboardSupport()
	{
		return PInvoke.SDL_HasScreenKeyboardSupport() == 1;
	}

	/// <summary>
	/// Check whether the screen keyboard is shown for given window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ScreenKeyboardShown">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which screen keyboard should be queried.</param>
	/// <returns>True if screen keyboard is shown or false if not.</returns>
	public static bool ScreenKeyboardShown(SDL_Window* window)
	{
		return PInvoke.SDL_ScreenKeyboardShown(window) == 1;
	}
}