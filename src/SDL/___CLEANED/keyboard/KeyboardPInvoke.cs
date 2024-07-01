using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class SDL_PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_HasKeyboard();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_KeyboardId* SDL_GetKeyboards(int* count);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetKeyboardInstanceName(SDL_KeyboardId keyboardId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Window* SDL_GetKeyboardFocus();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetKeyboardState(int* numKeys);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_ResetKeyboard();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Keymod SDL_GetModState();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_SetModState(SDL_Keymod modState);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Keycode SDL_GetDefaultKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modState);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Keycode SDL_GetKeyFromScancode(SDL_Scancode scancode, SDL_Keymod modState);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Scancode SDL_GetDefaultScancodeFromKey(SDL_Keycode key, SDL_Keymod* modState);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Scancode SDL_GetScancodeFromKey(SDL_Keycode key, SDL_Keymod* modState);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetScancodeName(SDL_Scancode scancode, byte* name);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetScancodeName(SDL_Scancode scancode);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Scancode SDL_GetScancodeFromName(byte* name);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetKeyName(SDL_Keycode key);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Keycode SDL_GetKeyFromName(byte* name);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_StartTextInput(SDL_Window* window);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_TextInputActive(SDL_Window* window);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_StopTextInput(SDL_Window* window);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ClearComposition(SDL_Window* window);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetTextInputRect(SDL_Window* window, SDL_Rect* rect);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_HasScreenKeyboardSupport();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ScreenKeyboardShown(SDL_Window* window);
}