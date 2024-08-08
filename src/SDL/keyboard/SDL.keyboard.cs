using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

// SDL_keyboard.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_keyboard.h
public static unsafe partial class SDL
{
	/// <summary>
	/// Return whether a keyboard is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasKeyboard">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if a keyboard is connected, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasKeyboard")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasKeyboard();

	/// <summary>
	/// Get a list of currently connected keyboards.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboards">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of keyboards returned.</param>
	/// <returns>A null-terminated array of keyboards instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboards")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_KeyboardId* GetKeyboards(out int count);

	/// <summary>
	/// Get the name of a keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardNameForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The keyboard instance ID.</param>
	/// <returns>The name of the selected keyboard or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardNameForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetKeyboardNameForId(SDL_KeyboardId instanceId);

	/// <summary>
	/// Query the window which currently has keyboard focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardFocus">documentation</see> for more details.
	/// </remarks>
	/// <returns>The window with keyboard focus.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardFocus")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GetKeyboardFocus();

	/// <summary>
	/// Get a snapshot of the current state of the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyboardState">documentation</see> for more details.
	/// </remarks>
	/// <param name="numKeys">Receives the length of the returned array.</param>
	/// <returns>A pointer to an array of key states.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial byte* GetKeyboardState(out int numKeys);

	/// <summary>
	/// Clear the state of the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResetKeyboard">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ResetKeyboard")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void ResetKeyboard();

	/// <summary>
	/// Get the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetModState">documentation</see> for more details.
	/// </remarks>
	/// <returns>An OR'd combination of the modifier keys for the keyboard. See <see cref="SDL_Keymod"/> for details.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetModState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Keymod GetModState();

	/// <summary>
	/// Set the current key modifier state for the keyboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetModState">documentation</see> for more details.
	/// </remarks>
	/// <param name="modState">The desired <see cref="SDL_Keymod"/> for the keyboard.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetModState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void SetModState(SDL_Keymod modState);

	/// <summary>
	/// Get the key code corresponding to the given scancode according to a default en_US keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultKeyFromScancode">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The desired <see cref="SDL_Scancode"/> to query.</param>
	/// <param name="modState">The modifier state to use when translating the scancode to a keycode.</param>
	/// <returns>The <see cref="SDL_Keycode"/> that corresponds to the given <see cref="SDL_Scancode"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultKeyFromScancode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Keycode GetDefaultKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modState);

	/// <summary>
	/// Get the key code corresponding to the given scancode according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyFromScancode">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The desired <see cref="SDL_Scancode"/> to query.</param>
	/// <param name="modState">The modifier state to use when translating the scancode to a keycode.</param>
	/// <param name="keyEvent">True if the keycode will be used in key events.</param>
	/// <returns>The <see cref="SDL_Keycode"/> that corresponds to the given <see cref="SDL_Scancode"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyFromScancode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Keycode GetKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modState, [MarshalAs(NativeBool)] bool keyEvent);

	/// <summary>
	/// Get the scancode corresponding to the given key code according to a default en_US keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <param name="modState">A pointer to the modifier state that would be used when the scancode generates this key, may be <see langword="null"/>.</param>
	/// <returns>The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultScancodeFromKey")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Scancode GetDefaultScancodeFromKey(SDL_Keycode key, ref SDL_Keymod modState);

	/// <summary>
	/// Get the scancode corresponding to the given key code according to a default en_US keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <param name="modState">A pointer to the modifier state that would be used when the scancode generates this key, may be <see langword="null"/>.</param>
	/// <returns>The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultScancodeFromKey")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Scancode GetDefaultScancodeFromKey(SDL_Keycode key, SDL_Keymod* modState);

	/// <summary>
	/// Get the scancode corresponding to the given key code according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <param name="modState">A pointer to the modifier state that would be used when the scancode generates this key, may be <see langword="null"/>.</param>
	/// <returns>The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeFromKey")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Scancode GetScancodeFromKey(SDL_Keycode key, ref SDL_Keymod modState);

	/// <summary>
	/// Get the scancode corresponding to the given key code according to the current keyboard layout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <param name="modState">A pointer to the modifier state that would be used when the scancode generates this key, may be <see langword="null"/>.</param>
	/// <returns>The <see cref="SDL_Scancode"/> that corresponds to the given <see cref="SDL_Keycode"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeFromKey")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Scancode GetScancodeFromKey(SDL_Keycode key, SDL_Keymod* modState);

	/// <summary>
	/// Set a human-readable name for a scancode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetScancodeName">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The desired <see cref="SDL_Scancode"/>.</param>
	/// <param name="name">The name to use for the scancode as UTF-8. The string is not copied, so the pointer given to this function must stay valid while SDL is being used.<br/>Use <see cref="Utf16StringMarshaller.ConvertToUnmanaged(string?)"/> and <see cref="Utf8StringMarshaller.Free(byte*)"/> to manually manage the string memory.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetScancodeName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetScancodeName(SDL_Scancode scancode, byte* name);

	/// <summary>
	/// Get a human-readable name for a scancode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeName">documentation</see> for more details.
	/// </remarks>
	/// <param name="scancode">The desired <see cref="SDL_Scancode"/> to query.</param>
	/// <returns>The name for the scancode. If the scancode doesn't have a name this function returns an empty string.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string GetScancodeName(SDL_Scancode scancode);

	/// <summary>
	/// Get a scancode from a human-readable name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetScancodeFromName">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The human-readable scancode name.</param>
	/// <returns>The <see cref="SDL_Scancode"/>, or <see cref="SDL_Scancode.Unknown"/> if the name wasn't recognized; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeFromName", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Scancode GetScancodeFromName(string name);

	/// <summary>
	/// Get a human-readable name for a key.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyName">documentation</see> for more details.
	/// </remarks>
	/// <param name="key">The desired <see cref="SDL_Keycode"/> to query.</param>
	/// <returns>A string of the key name.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string GetKeyName(SDL_Keycode key);

	/// <summary>
	/// Get a key code from a human-readable name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetKeyFromName">documentation</see> for more details.
	/// </remarks>
	/// <param name="name">The human-readable key name.</param>
	/// <returns>The <see cref="SDL_Keycode"/>, or <see cref="SDL_Keycode.Unknown"/> if the name wasn't recognized; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyFromName", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Keycode GetKeyFromName(string name);

	/// <summary>
	/// Start accepting Unicode text input events in a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StartTextInput">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to enable text input.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_StartTextInput")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int StartTextInput(SDL_Window* window);

	/// <summary>
	/// Start accepting Unicode text input events in a window, with properties describing the input.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StartTextInputWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to enable text input</param>
	/// <param name="props">The properties to use.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_StartTextInputWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int StartTextInputWithProperties(SDL_Window* window, SDL_PropertiesId props);

	/// <summary>
	/// Check whether or not Unicode text input events are enabled for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputActive">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to check.</param>
	/// <returns>True if text input events are enabled else false.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_TextInputActive")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool TextInputActive(SDL_Window* window);

	/// <summary>
	/// Stop receiving any text input events in a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StopTextInput">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to disable text input.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_StopTextInput")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int StopTextInput(SDL_Window* window);

	/// <summary>
	/// Dismiss the composition window/IME without disabling the subsystem.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearComposition">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to affect.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearComposition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ClearComposition(SDL_Window* window);

	/// <summary>
	/// Set the area used to type Unicode text input.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextInputArea">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which to set the text input area.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> representing the text input area, in window coordinates, or <see langword="null"/> to clear it.</param>
	/// <param name="cursor">The offset of the current cursor location relative to <paramref name="rect"/>.X, in window coordinates.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextInputArea")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetTextInputArea(SDL_Window* window, ref SDL_Rect rect, int cursor);

	/// <summary>
	/// Set the area used to type Unicode text input.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextInputArea">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which to set the text input area.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> representing the text input area, in window coordinates, or <see langword="null"/> to clear it.</param>
	/// <param name="cursor">The offset of the current cursor location relative to <paramref name="rect"/>.X, in window coordinates.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextInputArea")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetTextInputArea(SDL_Window* window, SDL_Rect* rect, int cursor);

	/// <summary>
	/// Get the area used to type Unicode text input.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextInputArea">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which to query the text input area.</param>
	/// <param name="rect">A pointer to an <see cref="SDL_Rect"/> filled in with the text input area, may be <see langword="null"/>.</param>
	/// <param name="cursor">A pointer to the offset of the current cursor location relative to <paramref name="rect"/>.X.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextInputArea")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetTextInputArea(SDL_Window* window, out SDL_Rect rect, out int cursor);

	/// <summary>
	/// Get the area used to type Unicode text input.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextInputArea">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which to query the text input area.</param>
	/// <param name="rect">A pointer to an <see cref="SDL_Rect"/> filled in with the text input area, may be <see langword="null"/>.</param>
	/// <param name="cursor">A pointer to the offset of the current cursor location relative to <paramref name="rect"/>.X.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextInputArea")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetTextInputArea(SDL_Window* window, SDL_Rect* rect, out int cursor);

	/// <summary>
	/// Check whether the platform has screen keyboard support.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasScreenKeyboardSupport">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the platform has some screen keyboard support or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasScreenKeyboardSupport")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasScreenKeyboardSupport();

	/// <summary>
	/// Check whether the screen keyboard is shown for given window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ScreenKeyboardShown">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which screen keyboard should be queried.</param>
	/// <returns>True if screen keyboard is shown or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ScreenKeyboardShown")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ScreenKeyboardShown(SDL_Window* window);
}