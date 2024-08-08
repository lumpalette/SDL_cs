using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

// SDL_video.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_video.h.
public static unsafe partial class SDL
{
	public static uint WindowposUndefinedDisplay(SDL_DisplayId x) => WindowposUndefinedMask | (uint)x;

	public static bool WindowposIsUndefined(uint x) => (x & 0xFFFF0000) == WindowposUndefinedMask;

	public static uint WindowposCenteredDisplay(SDL_DisplayId x) => WindowposCenteredMask | (uint)x;

	public static bool WindowposIsCentered(uint x) => (x & 0xFFFF0000) == WindowposCenteredMask;

	/// <summary>
	/// Get the number of video drivers compiled into SDL.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumVideoDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>A number >= 1 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumVideoDrivers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumVideoDrivers();

	/// <summary>
	/// Get the name of a built in video driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetVideoDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index">The index of a video driver.</param>
	/// <returns>The name of the video driver with the given <paramref name="index"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetVideoDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetVideoDriver(int index);

	/// <summary>
	/// Get the name of the currently initialized video driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentVideoDriver">documentation</see> for more details.
	/// </remarks>
	/// <returns>The name of the current video driver or <see langword="null"/> if no driver has been initialized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentVideoDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetCurrentVideoDriver();

	/// <summary>
	/// Get the current system theme.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSystemTheme">documentation</see> for more details.
	/// </remarks>
	/// <returns>The current system theme, light, dark, or unknown.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSystemTheme")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_SystemTheme GetSystemTheme();

	/// <summary>
	/// Get a list of currently connected displays.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplays">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of displays returned.</param>
	/// <returns>A null-terminated array of display instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplays")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayId* GetDisplays(out int count);

	/// <summary>
	/// Return the primary display.
	/// </summary>
	/// <returns>The instance ID of the primary display on success or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPrimaryDisplay")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayId GetPrimaryDisplay();

	/// <summary>
	/// Get the properties associated with a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetDisplayProperties(SDL_DisplayId instanceId);

	/// <summary>
	/// Get the name of a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayName">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <returns>The name of a display or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetDisplayName(SDL_DisplayId instanceId);

	/// <summary>
	/// Get the desktop area represented by a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayBounds">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure filled in with the display bounds.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayBounds")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetDisplayBounds(SDL_DisplayId instanceId, out SDL_Rect rect);

	/// <summary>
	/// Get the usable desktop area represented by a display, in screen coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayUsableBounds">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure filled in with the display bounds.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayUsableBounds")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetDisplayUsableBounds(SDL_DisplayId instanceId, out SDL_Rect rect);

	/// <summary>
	/// Get the orientation of a display when it is unrotated.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNaturalDisplayOrientation">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <returns>The <see cref="SDL_DisplayOrientation"/> enum value of the display, or <see cref="SDL_DisplayOrientation.Unknown"/> if it isn't available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNaturalDisplayOrientation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayOrientation GetNaturalDisplayOrientation(SDL_DisplayId instanceId);

	/// <summary>
	/// Get the orientation of a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentDisplayOrientation">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <returns>The <see cref="SDL_DisplayOrientation"/> enum value of the display, or <see cref="SDL_DisplayOrientation.Unknown"/> if it isn't available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayOrientation GetCurrentDisplayOrientation(SDL_DisplayId instanceId);

	/// <summary>
	/// Get the content scale of a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayContentScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <returns>The content scale of the display, or 0.0f on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayContentScale")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetDisplayContentScale(SDL_DisplayId instanceId);

	/// <summary>
	/// Get a list of fullscreen display modes available on a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetFullscreenDisplayModes">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <param name="count">A pointer filled in with the number of display modes returned.</param>
	/// <returns>A null-terminated array of display mode pointers or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This is a single allocation that should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetFullscreenDisplayModes")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayMode** GetFullscreenDisplayModes(SDL_DisplayId instanceId, out int count);

	/// <summary>
	/// Get the closest match to the requested display mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetClosestFullscreenDisplayMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <param name="width">The width in pixels of the desired display mode.</param>
	/// <param name="height">The height in pixels of the desired display mode.</param>
	/// <param name="refreshRate">The refresh rate of the desired display mode, or 0.0f for the desktop refresh rate.</param>
	/// <param name="includeHighDensityModes">Boolean to include high density modes in the search.</param>
	/// <param name="mode">A pointer filled in with the closest display mode equal to or larger than the desired mode.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetClosestFullscreenDisplayMode(SDL_DisplayId instanceId, int width, int height, float refreshRate, [MarshalAs(NativeBool)] bool includeHighDensityModes, out SDL_DisplayMode mode);

	/// <summary>
	/// Get information about the desktop's display mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDesktopDisplayMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <returns>A pointer to the desktop display mode or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDesktopDisplayMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayMode* GetDesktopDisplayMode(SDL_DisplayId instanceId);

	/// <summary>
	/// Get information about the current display mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentDisplayMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <returns>A pointer to the current display mode or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayMode* GetCurrentDisplayMode(SDL_DisplayId instanceId);

	/// <summary>
	/// Get the display containing a point.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForPoint">documentation</see> for more details.
	/// </remarks>
	/// <param name="point">The point to query.</param>
	/// <returns>The instance ID of the display containing the point or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForPoint")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayId GetDisplayForPoint(ref SDL_Point point);

	/// <summary>
	/// Get the display primarily containing a rect.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="rect">The rect to query.</param>
	/// <returns>The instance ID of the display entirely containing the rect or closest to the center of the rect on success or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayId GetDisplayForRect(ref SDL_Rect rect);

	/// <summary>
	/// Get the display associated with a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The instance ID of the display containing the center of the window on success or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayId GetDisplayForWindow(SDL_Window* window);

	/// <summary>
	/// Get the pixel density of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPixelDensity">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The pixel density or 0.0f on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPixelDensity")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetWindowPixelDensity(SDL_Window* window);

	/// <summary>
	/// Get the content display scale relative to a window's pixel size.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowDisplayScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The display scale, or 0.0f on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowDisplayScale")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetWindowDisplayScale(SDL_Window* window);

	/// <summary>
	/// Set the display mode to use when a window is visible and fullscreen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFullscreenMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to affect.</param>
	/// <param name="mode">A pointer to the display mode to use, which can be <see langword="null"/> for borderless fullscreen desktop mode, or one of the fullscreen modes returned by <see cref="GetFullscreenDisplayModes(SDL_DisplayId, out int)"/> to set an exclusive fullscreen mode.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreenMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowFullscreenMode(SDL_Window* window, ref SDL_DisplayMode mode);

	/// <summary>
	/// Query the display mode to use when a window is visible at fullscreen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFullscreenMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>A pointer to the exclusive fullscreen mode to use or <see langword="null"/> for borderless fullscreen desktop mode.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFullscreenMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayMode* GetWindowFullscreenMode(SDL_Window* window);

	/// <summary>
	/// Get the raw ICC profile data for the screen the window is currently on.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowICCProfile">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="size">The size of the ICC profile.</param>
	/// <returns>The raw ICC profile data on success or <see cref="nint.Zero"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowICCProfile")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint GetWindowICCProfile(SDL_Window* window, out nuint size);

	/// <summary>
	/// Get the pixel format associated with the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPixelFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The pixel format of the window on success or <see cref="SDL_PixelFormat.Unknown"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPixelFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PixelFormat GetWindowPixelFormat(SDL_Window* window);

	/// <summary>
	/// Get a list of valid windows.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindows">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of windows returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of window pointers or <see langword="null"/> on error; call <see cref="GetError"/> for more details. This is a single allocation that should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindows")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window** GetWindows(out int count);

	/// <summary>
	/// Create a window with the specified dimensions and flags.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="title">The title of the window, in UTF-8 encoding.</param>
	/// <param name="width">The width of the window.</param>
	/// <param name="height">The height of the window.</param>
	/// <param name="flags"><see cref="SDL_WindowFlags.None"/>, or one or more <see cref="SDL_WindowFlags"/> OR'd together.</param>
	/// <returns>The window that was created or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindow", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* CreateWindow(string title, int width, int height, SDL_WindowFlags flags);

	/// <summary>
	/// Create a child popup window of the specified parent window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePopupWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="parent">The parent of the window, must not be <see langword="null"/>.</param>
	/// <param name="offsetX">The x position of the popup window relative to the origin of the parent.</param>
	/// <param name="offsetY">The y position of the popup window relative to the origin of the parent.</param>
	/// <param name="width">The width of the window.</param>
	/// <param name="height">The height of the window.</param>
	/// <param name="flags"><see cref="SDL_WindowFlags.Tooltip"/> or <see cref="SDL_WindowFlags.PopupMenu"/>, and zero or more additional <see cref="SDL_WindowFlags"/> OR'd together.</param>
	/// <returns>The window that was created or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreatePopupWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* CreatePopupWindow(SDL_Window* parent, int offsetX, int offsetY, int width, int height, SDL_WindowFlags flags);

	/// <summary>
	/// Create a window with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to use.</param>
	/// <returns>The window that was created or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindowWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* CreateWindowWithProperties(SDL_PropertiesId props);

	/// <summary>
	/// Get the numeric ID of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowID">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The ID of the window on success or <see cref="SDL_WindowId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_WindowId GetWindowId(SDL_Window* window);

	/// <summary>
	/// Get a window from a stored ID.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFromID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The ID of the window.</param>
	/// <returns>The window associated with <paramref name="instanceId"/> or <see langword="null"/> if it doesn't exist; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFromID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GetWindowFromId(SDL_WindowId instanceId);

	/// <summary>
	/// Get parent of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowParent">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The parent of the window on success or <see langword="null"/> if the window has no parent.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowParent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GetWindowParent(SDL_Window* window);

	/// <summary>
	/// Get the properties associated with a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowProperties">documentation</see> for more details.
	/// Properties
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetWindowProperties(SDL_Window* window);

	/// <summary>
	/// Get the window flags.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFlags">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>A mask of the <see cref="SDL_WindowFlags"/> associated with <paramref name="window"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFlags")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_WindowFlags GetWindowFlags(SDL_Window* window);

	/// <summary>
	/// Set the title of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowTitle">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="title">The desired window title.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowTitle", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowTitle(SDL_Window* window, string title);

	/// <summary>
	/// Get the title of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowTitle">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The title of the window or an empty string if there is no title.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowTitle")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string GetWindowTitle(SDL_Window* window);

	/// <summary>
	/// Set the icon for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowIcon">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="icon">An <see cref="SDL_Surface"/> structure containing the icon for the window.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowIcon")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

	/// <summary>
	/// Request that the window's position be set.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowPosition">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to reposition.</param>
	/// <param name="x">The x coordinate of the window, or <see cref="WindowposCentered"/> or <see cref="WindowposUndefined"/>.</param>
	/// <param name="y">The y coordinate of the window, or <see cref="WindowposCentered"/> or <see cref="WindowposUndefined"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowPosition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowPosition(SDL_Window* window, int x, int y);

	/// <summary>
	/// Get the position of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPosition">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="x">A pointer filled in with the x position of the window.</param>
	/// <param name="y">A pointer filled in with the y position of the window.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPosition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowPosition(SDL_Window* window, out int x, out int y);

	/// <summary>
	/// Request that the size of a window's client area be set.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="width">The width of the window, must be greater than 0.</param>
	/// <param name="height">The height of the window, must be greater than 0.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowSize(SDL_Window* window, int width, int height);

	/// <summary>
	/// Get the size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query the width and height from.</param>
	/// <param name="width">A pointer filled in with the width of the window.</param>
	/// <param name="height">A pointer filled in with the height of the window.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowSize(SDL_Window* window, out int width, out int height);

	/// <summary>
	/// Get the safe area for this window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSafeArea">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="rect">A pointer filled in with the client area that is safe for interactive content.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSafeArea")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowSafeArea(SDL_Window* window, out SDL_Rect rect);

	/// <summary>
	/// Request that the aspect ratio of a window's client area be set.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowAspectRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="minAspect">The minimum aspect ratio of the window, or 0.0f for no limit.</param>
	/// <param name="maxAspect">The maximum aspect ratio of the window, or 0.0f for no limit.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowAspectRatio")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowAspectRatio(SDL_Window* window, float minAspect, float maxAspect);

	/// <summary>
	/// Get the size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowAspectRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query the width and height from.</param>
	/// <param name="minAspect">A pointer filled in with the minimum aspect ratio of the window.</param>
	/// <param name="maxAspect">A pointer filled in with the maximum aspect ratio of the window.</param>
	/// <returns></returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowAspectRatio")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowAspectRatio(SDL_Window* window, out float minAspect, out float maxAspect);

	/// <summary>
	/// Get the size of a window's borders (decorations) around the client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowBordersSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query the size values of the border (decorations) from.</param>
	/// <param name="top">Pointer to variable for storing the size of the top border.</param>
	/// <param name="left">Pointer to variable for storing the size of the left border.</param>
	/// <param name="bottom">Pointer to variable for storing the size of the bottom border.</param>
	/// <param name="right">Pointer to variable for storing the size of the right border.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowBordersSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowBordersSize(SDL_Window* window, out int top, out int left, out int bottom, out int right);

	/// <summary>
	/// Get the size of a window's client area, in pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSizeInPixels">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window from which the drawable size should be queried.</param>
	/// <param name="width">A pointer to variable for storing the width in pixels.</param>
	/// <param name="height">A pointer to variable for storing the height in pixels.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSizeInPixels")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowSizeInPixels(SDL_Window* window, out int width, out int height);

	/// <summary>
	/// Set the minimum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMinimumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="maxWidth">The minimum width of the window, or 0 for no limit.</param>
	/// <param name="minHeight">The minimum height of the window, or 0 for no limit.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMinimumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowMinimumSize(SDL_Window* window, int maxWidth, int minHeight);

	/// <summary>
	/// Get the minimum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMinimumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="minWidth">A pointer filled in with the minimum width of the window.</param>
	/// <param name="minHeight">A pointer filled in with the minimum height of the window.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMinimumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowMinimumSize(SDL_Window* window, out int minWidth, out int minHeight);

	/// <summary>
	/// Set the maximum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMaximumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="maxWidth">The maximum width of the window, or 0 for no limit.</param>
	/// <param name="maxHeight">The maximum height of the window, or 0 for no limit.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMaximumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowMaximumSize(SDL_Window* window, int maxWidth, int maxHeight);

	/// <summary>
	/// Get the maximum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMaximumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="maxWidth">A pointer filled in with the maximum width of the window.</param>
	/// <param name="maxHeight">A pointer filled in with the maximum height of the window.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMaximumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowMaximumSize(SDL_Window* window, out int maxWidth, out int maxHeight);

	/// <summary>
	/// Set the border state of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowBordered">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window of which to change the border state.</param>
	/// <param name="bordered">False to remove border, true to add border.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowBordered")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowBordered(SDL_Window* window, [MarshalAs(NativeBool)] bool bordered);

	/// <summary>
	/// Set the user-resizable state of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowResizable">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window of which to change the resizable state.</param>
	/// <param name="resizable">True to allow resizing, false to disallow.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowResizable")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowResizable(SDL_Window* window, [MarshalAs(NativeBool)] bool resizable);

	/// <summary>
	/// Set the window to always be above the others.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowAlwaysOnTop">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window of which to change the always on top state.</param>
	/// <param name="onTop">True to set the window always on top, false to disable.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowAlwaysOnTop")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowAlwaysOnTop(SDL_Window* window, [MarshalAs(NativeBool)] bool onTop);

	/// <summary>
	/// Show a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to show.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ShowWindow(SDL_Window* window);

	/// <summary>
	/// Hide a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HideWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to hide.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HideWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HideWindow(SDL_Window* window);

	/// <summary>
	/// Request that a window be raised above other windows and gain the input focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RaiseWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to raise.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RaiseWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int RaiseWindow(SDL_Window* window);

	/// <summary>
	/// Request that the window be made as large as possible.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MaximizeWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to maximize.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MaximizeWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int MaximizeWindow(SDL_Window* window);

	/// <summary>
	/// Request that the window be minimized to an iconic representation.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MinimizeWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to minimize.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MinimizeWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int MinimizeWindow(SDL_Window* window);

	/// <summary>
	/// Request that the size and position of a minimized or maximized window be restored.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RestoreWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to restore.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RestoreWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int RestoreWindow(SDL_Window* window);

	/// <summary>
	/// Request that the window's fullscreen state be changed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFullscreen">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="fullscreen">True for fullscreen mode, false for windowed mode.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreen")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowFullscreen(SDL_Window* window, [MarshalAs(NativeBool)] bool fullscreen);

	/// <summary>
	/// Block until any pending window state is finalized.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SyncWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which to wait for the pending state to be applied.</param>
	/// <returns>0 on success, a positive value if the operation timed out before the window was in the requested state, or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SyncWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SyncWindow(SDL_Window* window);

	/// <summary>
	/// Return whether the window has a surface associated with it.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WindowHasSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>True if there is a surface associated with the window, or false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WindowHasSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool WindowHasSurface(SDL_Window* window);

	/// <summary>
	/// Get the <see cref="SDL_Surface"/> associated with the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The surface associated with the window, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* GetWindowSurface(SDL_Window* window);

	/// <summary>
	/// Toggle VSync for the window surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowSurfaceVSync">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window.</param>
	/// <param name="vsync">The vertical refresh sync interval.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowSurfaceVSync")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowSurfaceVSync(SDL_Window* window, int vsync);

	/// <summary>
	/// Get VSync for the window surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSurfaceVSync">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="vsync">An int filled with the current vertical refresh sync interval. See <see cref="SetWindowSurfaceVSync(SDL_Window*, int)"/> for the meaning of the value.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSurfaceVSync")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetWindowSurfaceVSync(SDL_Window* window, out int vsync);

	/// <summary>
	/// Copy the window surface to the screen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to update.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int UpdateWindowSurface(SDL_Window* window);

	/// <summary>
	/// Copy areas of the window surface to the screen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateWindowSurfaceRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to update.</param>
	/// <param name="rects">An array of <see cref="SDL_Rect"/> structures representing areas of the surface to copy, in pixels.</param>
	/// <param name="numRects">The number of rectangles. Corresponds to <paramref name="rects"/>.Length.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurfaceRects")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int UpdateWindowSurfaceRects(SDL_Window* window, [In] SDL_Rect[] rects, int numRects);

	/// <summary>
	/// Destroy the surface associated with the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to update.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int DestroyWindowSurface(SDL_Window* window);

	/// <summary>
	/// Set a window's keyboard grab mode.
	/// </summary>
	/// <param name="window">The window for which the keyboard grab mode should be set.</param>
	/// <param name="grabbed">This is true to grab keyboard, and false to release.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowKeyboardGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowKeyboardGrab(SDL_Window* window, [MarshalAs(NativeBool)] bool grabbed);

	/// <summary>
	/// Set a window's mouse grab mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMouseGrab">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which the mouse grab mode should be set.</param>
	/// <param name="grabbed">This is true to grab mouse, and false to release.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMouseGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowMouseGrab(SDL_Window* window, [MarshalAs(NativeBool)] bool grabbed);

	/// <summary>
	/// Get a window's keyboard grab mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowKeyboardGrab">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>True if keyboard is grabbed, and false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowKeyboardGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetWindowKeyboardGrab(SDL_Window* window);

	/// <summary>
	/// Get a window's mouse grab mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMouseGrab">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>True if mouse is grabbed, and false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMouseGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetWindowMouseGrab(SDL_Window* window);

	/// <summary>
	/// Get the window that currently has an input grab enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGrabbedWindow">documentation</see> for more details.
	/// </remarks>
	/// <returns>The window if input is grabbed or <see langword="null"/> otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGrabbedWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GetGrabbedWindow();

	/// <summary>
	/// Confines the cursor to the specified area of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMouseRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window that will be associated with the barrier.</param>
	/// <param name="rect">A rectangle area in window-relative coordinates. If <see langword="null"/> the barrier for the specified window will be destroyed.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMouseRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowMouseRect(SDL_Window* window, ref SDL_Rect rect);

	/// <summary>
	/// Get the mouse confinement rectangle of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMouseRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>A pointer to the mouse confinement rectangle of a window, or <see langword="null"/> if there isn't one.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMouseRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Rect* GetWindowMouseRect(SDL_Window* window);

	/// <summary>
	/// Set the opacity for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowOpacity">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window which will be made transparent or opaque.</param>
	/// <param name="opacity">The opacity value (0.0f - transparent, 1.0f - opaque).</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowOpacity")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowOpacity(SDL_Window* window, float opacity);

	/// <summary>
	/// Get the opacity of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowOpacity">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to get the current opacity value from.</param>
	/// <returns>The opacity, (0.0f - transparent, 1.0f - opaque), or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowOpacity")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetWindowOpacity(SDL_Window* window);

	/// <summary>
	/// Set the window as a modal to a parent window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowModalFor">documentation</see> for more details.
	/// </remarks>
	/// <param name="modalWindow">The window that should be set modal.</param>
	/// <param name="parentWindow">The parent window for the modal window.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowModalFor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowModalFor(SDL_Window* modalWindow, SDL_Window* parentWindow);

	/// <summary>
	/// Set whether the window may have input focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFocusable">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to set focusable state.</param>
	/// <param name="focusable">True to allow input focus, false to not allow input focus.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFocusable")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowFocusable(SDL_Window* window, [MarshalAs(NativeBool)] bool focusable);

	/// <summary>
	/// Display the system-level window menu.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowWindowSystemMenu">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which the menu will be displayed.</param>
	/// <param name="x">The x coordinate of the menu, relative to the origin (top-left) of the client area.</param>
	/// <param name="y">The y coordinate of the menu, relative to the origin (top-left) of the client area.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindowSystemMenu")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ShowWindowSystemMenu(SDL_Window* window, int x, int y);

	/// <summary>
	/// Provide a callback that decides if a window region has special properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowHitTest">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to set hit-testing on.</param>
	/// <param name="callback">The function to call when doing a hit-test.</param>
	/// <param name="callbackData">An app-defined void pointer passed to <paramref name="callback"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowHitTest")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowHitTest(SDL_Window* window, delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, nint, SDL_HitTestResult> callback, nint callbackData);

	/// <summary>
	/// Set the shape of a transparent window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowShape">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window.</param>
	/// <param name="surface">The surface representing the shape of the window, or <see langword="null"/> to remove any current shape.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowShape")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetWindowShape(SDL_Window* window, SDL_Surface* surface);

	/// <summary>
	/// Request a window to demand attention from the user.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlashWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to be flashed.</param>
	/// <param name="operation">The operation to perform.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FlashWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

	/// <summary>
	/// Destroy a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to destroy.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyWindow(SDL_Window* window);

	/// <summary>
	/// Check whether the screensaver is currently enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ScreenSaverEnabled">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the screensaver is enabled, false if it is disabled.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ScreenSaverEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ScreenSaverEnabled();

	/// <summary>
	/// Allow the screen to be blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EnableScreenSaver">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EnableScreenSaver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int EnableScreenSaver();

	/// <summary>
	/// Prevent the screen from being blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisableScreenSaver">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DisableScreenSaver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int DisableScreenSaver();

	/// <summary>
	/// Dynamically load an OpenGL library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_LoadLibrary">documentation</see> for more details.
	/// </remarks>
	/// <param name="path">The platform dependent OpenGL library name, or <see langword="null"/> to open the default OpenGL library.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_LoadLibrary", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GL_LoadLibrary(string? path);

	/// <summary>
	/// Get an OpenGL function by name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_GetProcAddress">documentation</see> for more details.
	/// </remarks>
	/// <param name="proc">The name of an OpenGL function.</param>
	/// <returns>A pointer to the named OpenGL function. The returned pointer should be cast to the appropriate function signature.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetProcAddress", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint GL_GetProcAddress(string proc);

	/// <summary>
	/// Get an EGL library function by name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGL_GetProcAddress">documentation</see> for more details.
	/// </remarks>
	/// <param name="proc">The name of an EGL function.</param>
	/// <returns>A pointer to the named EGL function. The returned pointer should be cast to the appropriate function signature.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EGL_GetProcAddress", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint EGL_GetProcAddress(string proc);

	/// <summary>
	/// Unload the OpenGL library previously loaded by <see cref="GL_LoadLibrary(string?)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_UnloadLibrary">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_UnloadLibrary")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void GL_UnloadLibrary();

	/// <summary>
	/// Check if an OpenGL extension is supported for the current context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_ExtensionSupported">documentation</see> for more details.
	/// </remarks>
	/// <param name="extension">The name of the extension to check.</param>
	/// <returns>True if the extension is supported, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_ExtensionSupported", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GL_ExtensionSupported(string extension);

	/// <summary>
	/// Reset all previously set OpenGL context attributes to their default values.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_ResetAttributes">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_ResetAttributes")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void GL_ResetAttributes();

	/// <summary>
	/// Set an OpenGL window attribute before window creation.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_SetAttribute">documentation</see> for more details.
	/// </remarks>
	/// <param name="attr">An <see cref="SDL_GLAttr"/> enum value specifying the OpenGL attribute to set.</param>
	/// <param name="value">The desired value for the attribute.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SetAttribute")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GL_SetAttribute(SDL_GLAttr attr, int value);

	/// <summary>
	/// Get the actual value for an attribute from the current context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_GetAttribute">documentation</see> for more details.
	/// </remarks>
	/// <param name="attr">An <see cref="SDL_GLAttr"/> enum value specifying the OpenGL attribute to get.</param>
	/// <param name="value">A pointer filled in with the current value of <paramref name="attr"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetAttribute")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GL_GetAttribute(SDL_GLAttr attr, out int value);

	/// <summary>
	/// Create an OpenGL context for an OpenGL window, and make it current.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_CreateContext">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to associate with the context.</param>
	/// <returns>The OpenGL context associated with <paramref name="window"/> or <see langword="null"/> on failure; call <see cref="GetError"/> for more details.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_CreateContext")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GLContext* GL_CreateContext(SDL_Window* window); // TODO: check if this is correct.

	/// <summary>
	/// Set up an OpenGL context for rendering into an OpenGL window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_MakeCurrent">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to associate with the context.</param>
	/// <param name="context">The window to associate with the context.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_MakeCurrent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GL_MakeCurrent(SDL_Window* window, SDL_GLContext* context);

	/// <summary>
	/// Get the currently active OpenGL window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_GetCurrentWindow">documentation</see> for more details.
	/// </remarks>
	/// <returns>The currently active OpenGL window on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetCurrentWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GL_GetCurrentWindow();

	/// <summary>
	/// Get the currently active OpenGL context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_GetCurrentContext">documentation</see> for more details.
	/// </remarks>
	/// <returns>The currently active OpenGL context or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetCurrentContext")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_GLContext* GL_GetCurrentContext();

	/// <summary>
	/// Get the currently active EGL display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGL_GetCurrentDisplay">documentation</see> for more details.
	/// </remarks>
	/// <returns>The currently active EGL display or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EGL_GetCurrentDisplay")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_EGLDisplay* EGL_GetCurrentDisplay();

	/// <summary>
	/// Get the currently active EGL config.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGL_GetCurrentConfig">documentation</see> for more details.
	/// </remarks>
	/// <returns>The currently active EGL config or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EGL_GetCurrentConfig")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_EGLConfig* EGL_GetCurrentConfig();

	/// <summary>
	/// Get the EGL surface associated with the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGL_GetWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The EGLSurface pointer associated with the window, or <see langword="null"/> on failure.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EGL_GetWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_EGLSurface* EGL_GetWindowSurface(SDL_Window* window);

	/// <summary>
	/// Sets the callbacks for defining custom EGLAttrib arrays for EGL initialization.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGL_SetAttributeCallbacks">documentation</see> for more details.
	/// </remarks>
	/// <param name="platformAttribCallback">Callback for attributes to pass to <c>eglGetPlatformDisplay</c>.</param>
	/// <param name="surfaceAttribCallback">Callback for attributes to pass to <c>eglCreateSurface</c>.</param>
	/// <param name="contextAttribCallback">Callback for attributes to pass to <c>eglCreateContext</c>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void EGL_SetAttributeCallbacks(delegate* unmanaged[Cdecl]<SDL_EGLAttrib*> platformAttribCallback, delegate* unmanaged[Cdecl]<SDL_EGLint*> surfaceAttribCallback, delegate* unmanaged[Cdecl]<SDL_EGLint*> contextAttribCallback);

	/// <summary>
	/// Set the swap interval for the current OpenGL context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_SetSwapInterval">documentation</see> for more details.
	/// </remarks>
	/// <param name="interval">0 for immediate updates, 1 for updates synchronized with the vertical retrace, -1 for adaptive vsync.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SetSwapInterval")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GL_SetSwapInterval(int interval);

	/// <summary>
	/// Get the swap interval for the current OpenGL context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_GetSwapInterval">documentation</see> for more details.
	/// </remarks>
	/// <param name="interval">Output interval value. 0 if there is no vertical retrace synchronization, 1 if the buffer swap is synchronized with the vertical retrace, and -1 if late swaps happen immediately instead of waiting for the next retrace.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetSwapInterval")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GL_GetSwapInterval(out int interval);

	/// <summary>
	/// Update a window with OpenGL rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_SwapWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SwapWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GL_SwapWindow(SDL_Window* window);

	/// <summary>
	/// Delete an OpenGL context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_DestroyContext">documentation</see> for more details.
	/// </remarks>
	/// <param name="context">The OpenGL context to be deleted.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_DestroyContext")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GL_DestroyContext(SDL_GLContext* context);

	/// <summary>
	/// Used to indicate that you don't care what the window position is.
	/// </summary>
	public static uint WindowposUndefined => WindowposUndefinedDisplay(0);

	/// <summary>
	/// Used to indicate that the window position should be centered.
	/// </summary>
	public static uint WindowposCentered => WindowposCenteredDisplay(0);

	public const uint WindowposUndefinedMask = 0x1FFF0000u;

	public const uint WindowposCenteredMask = 0x2FFF0000u;

	/// <summary>
	/// Please refer to <see cref="SetWindowSurfaceVSync(SDL_Window*, int)"/> for details.
	/// </summary>
	public const int WindowSurfaceVSyncDisabled = 0;

	/// <summary>
	/// Please refer to <see cref="SetWindowSurfaceVSync(SDL_Window*, int)"/> for details.
	/// </summary>
	public const int WindowSurfaceVSyncAdaptive = -1;
}