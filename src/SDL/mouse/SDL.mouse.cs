using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_mouse.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_mouse.h
public static unsafe partial class SDL
{
	[Macro]
	public static SDL_MouseButtonFlags Button(byte x) => (SDL_MouseButtonFlags)(1u << (x - 1));

	/// <summary>
	/// Return whether a mouse is currently connected.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasMouse">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if a mouse is connected, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasMouse")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasMouse();

	/// <summary>
	/// Get a list of currently connected mice.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMice">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of mice returned.</param>
	/// <returns>A null-terminated array of mouse instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more details. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_MouseId* GetMice(out int count);

	/// <summary>
	/// Get the name of a mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseNameForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The mouse instance ID.</param>
	/// <returns>The name of the selected mouse, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseNameForID", StringMarshallingCustomType = typeof(SDL_StringMarshaller))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetMouseNameForId(SDL_MouseId instanceId);

	/// <summary>
	/// Get the window which currently has mouse focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseFocus">documentation</see> for more details.
	/// </remarks>
	/// <returns>The window with mouse focus.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseFocus")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GetMouseFocus();

	/// <summary>
	/// Retrieve the current state of the mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The x coordinate of the mouse cursor position relative to the focus window.</param>
	/// <param name="y">The y coordinate of the mouse cursor position relative to the focus window.</param>
	/// <returns>A 32-bit button bitmask of the current button state.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_MouseButtonFlags GetMouseState(out float x, out float y);

	/// <summary>
	/// Get the current state of the mouse in relation to the desktop.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGlobalMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The current X coord relative to the desktop.</param>
	/// <param name="y">The current X coord relative to the desktop.</param>
	/// <returns>The current button state as a bitmask.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGlobalMouseState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_MouseButtonFlags GetGlobalMouseState(out float x, out float y);

	/// <summary>
	/// Retrieve the relative state of the mouse.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseState">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The last recorded x coordinate of the mouse.</param>
	/// <param name="y">The last recorded y coordinate of the mouse.</param>
	/// <returns>A 32-bit button bitmask of the relative button state.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRelativeMouseState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_MouseButtonFlags GetRelativeMouseState(out float x, out float y);

	/// <summary>
	/// Move the mouse cursor to the given position within the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseInWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to move the mouse into, or <see langword="null"/> for the current mouse focus.</param>
	/// <param name="x">The x coordinate within the window.</param>
	/// <param name="y">The y coordinate within the window.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WarpMouseInWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void WarpMouseInWindow(SDL_Window* window, float x, float y);

	/// <summary>
	/// Move the mouse to the given position in global screen space.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WarpMouseGlobal">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">The x coordinate.</param>
	/// <param name="y">The y coordinate.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WarpMouseGlobal")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int WarpMouseGlobal(float x, float y);

	/// <summary>
	/// Set relative mouse mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRelativeMouseMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="enabled">True to enable relative mode, false to disable.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRelativeMouseMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetRelativeMouseMode([MarshalAs(NativeBool)] bool enabled);

	/// <summary>
	/// Capture the mouse and to track input outside an SDL window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CaptureMouse">documentation</see> for more details.
	/// </remarks>
	/// <param name="enabled">True to enable capturing, false to disable.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CaptureMouse")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int CaptureMouse([MarshalAs(NativeBool)] bool enabled);

	/// <summary>
	/// Query whether relative mouse mode is enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRelativeMouseMode">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if relative mode is enabled or false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRelativeMouseMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRelativeMouseMode();

	/// <summary>
	/// Create a cursor using the specified bitmap data and mask (in MSB format).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="data">The color value for each pixel of the cursor.</param>
	/// <param name="mask">The mask value for each pixel of the cursor.</param>
	/// <param name="width">The width of the cursor.</param>
	/// <param name="height">The height of the cursor.</param>
	/// <param name="hotX">The x-axis offset from the left of the cursor image to the mouse x position, in the range of 0 to <paramref name="width"/> - 1.</param>
	/// <param name="hotY">The y-axis offset from the top of the cursor image to the mouse y position, in the range of 0 to <paramref name="height"/> - 1.</param>
	/// <returns>A new cursor with the specified parameters on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* CreateCursor([In] byte[] data, [In] byte[] mask, int width, int height, int hotX, int hotY);

	/// <summary>
	/// Create a color cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateColorCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">An <see cref="SDL_Surface"/> structure representing the cursor image.</param>
	/// <param name="hotX">The x position of the cursor hot spot.</param>
	/// <param name="hotY">The y position of the cursor hot spot.</param>
	/// <returns>The new cursor on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateColorCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* CreateColorCursor(SDL_Surface* surface, int hotX, int hotY);

	/// <summary>
	/// Create a system cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSystemCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="id">An <see cref="SDL_SystemCursor"/> enum value.</param>
	/// <returns>A cursor on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateSystemCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* CreateSystemCursor(SDL_SystemCursor id);

	/// <summary>
	/// Set the active cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="cursor">A cursor to make active.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetCursor(SDL_Cursor* cursor);

	/// <summary>
	/// Get the active cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>The active cursor or <see langword="null"/> if there is no mouse.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* GetCursor();

	/// <summary>
	/// Get the default cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDefaultCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>The default cursor on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Cursor* GetDefaultCursor();

	/// <summary>
	/// Free a previously-created cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyCursor">documentation</see> for more details.
	/// </remarks>
	/// <param name="cursor">The cursor to free.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyCursor(SDL_Cursor* cursor);

	/// <summary>
	/// Show the cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ShowCursor();

	/// <summary>
	/// Hide the cursor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HideCursor">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HideCursor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HideCursor();

	/// <summary>
	/// Return whether the cursor is currently being shown.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CursorVisible">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the cursor is being shown, or false if the cursor is hidden.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CursorVisible")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool CursorVisible();
}