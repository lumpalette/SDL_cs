using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_video.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_video.h.
unsafe partial class SDL_old
{
	[Macro]
	public static uint WindowPosUndefinedDisplay(uint x)
	{
		return WindowPosUndefinedMask | x;
	}

	[Macro]
	public static bool WindowPosIsUndefined(uint x)
	{
		return (x & 0xFFFF0000) == WindowPosUndefinedMask;
	}

	[Macro]
	public static uint WindowPosCenteredDisplay(uint x)
	{
		return WindowPosCenteredMask | x;
	}

	[Macro]
	public static bool WindowPosIsCentered(uint x)
	{
		return (x & 0xFFFF0000) == WindowPosCenteredMask;
	}

	/// <summary>
	/// Get the number of video drivers compiled into SDL.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumVideoDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns> A number >= 1 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumVideoDrivers()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumVideoDrivers", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get the name of a built in video driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetVideoDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index"> The index of a video driver. </param>
	/// <returns> The name of the video driver with the given <paramref name="index"/>. </returns>
	public static string GetVideoDriver(int index)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(index))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetVideoDriver", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(int index);
	}

	/// <summary>
	/// Get the name of the currently initialized video driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentVideoDriver">documentation</see> for more details.
	/// </remarks>
	/// <returns> The name of the current video driver or null if no driver has been initialized. </returns>
	public static string? GetCurrentVideoDriver()
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke());

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentVideoDriver", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke();
	}

	/// <summary>
	/// Get the current system theme.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSystemTheme">documentation</see> for more details.
	/// </remarks>
	/// <returns> The current system theme, light, dark, or unknown. </returns>
	public static SDL_SystemTheme GetSystemTheme()
	{
		return (SDL_SystemTheme)_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetSystemTheme", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get a list of currently connected displays.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplays">documentation</see> for more details.
	/// </remarks>
	/// <param name="count"> Returns the number of displays returned. </param>
	/// <returns> An array of display instance IDs, or null on error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_DisplayId[]? GetDisplays(out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_DisplayId* d = _PInvoke(countPtr);
			if (d is null)
			{
				return null;
			}
			SDL_DisplayId[] ids = new SDL_DisplayId[count];
			for (int i = 0; i < count; i++)
			{
				ids[i] = d[i];
			}
			Free(d);
			return ids;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplays", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayId* _PInvoke(int* count);
	}

	/// <summary>
	/// Return the primary display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPrimaryDisplay">documentation</see> for more details.
	/// </remarks>
	/// <returns> The instance ID of the primary display on success or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_DisplayId GetPrimaryDisplay()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetPrimaryDisplay", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayId _PInvoke();
	}

	/// <summary>
	/// Get the properties associated with a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetDisplayProperties(SDL_DisplayId displayId)
	{
		return _PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayProperties", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_PropertiesId _PInvoke(SDL_DisplayId displayId);
	}

	/// <summary>
	/// Get the name of a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayName">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <returns> The name of a display or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static string? GetDisplayName(SDL_DisplayId displayId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(displayId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayName", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(SDL_DisplayId displayId);
	}

	/// <summary>
	/// Get the desktop area represented by a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayBounds">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <param name="rect"> Returns the <see cref="SDL_Rect"/> structure filled in with the display bounds. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetDisplayBounds(SDL_DisplayId displayId, out SDL_Rect rect)
	{
		fixed (SDL_Rect* rectPtr = &rect)
		{
			return _PInvoke(displayId, rectPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayBounds", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_DisplayId displayId, SDL_Rect* rect);
	}

	/// <summary>
	/// Get the usable desktop area represented by a display, in screen coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayUsableBounds">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <param name="rect"> Returns the <see cref="SDL_Rect"/> structure filled in with the display bounds </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetDisplayUsableBounds(SDL_DisplayId displayId, out SDL_Rect rect)
	{
		fixed (SDL_Rect* rectPtr = &rect)
		{
			return _PInvoke(displayId, rectPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayUsableBounds", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_DisplayId displayId, SDL_Rect* rect);
	}

	/// <summary>
	/// Get the orientation of a display when it is unrotated.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNaturalDisplayOrientation">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <returns> The <see cref="SDL_DisplayOrientation"/> enum value of the display, or <see cref="SDL_DisplayOrientation.Unknown"/> if it isn't available. </returns>
	public static SDL_DisplayOrientation GetNaturalDisplayOrientation(SDL_DisplayId displayId)
	{
		return (SDL_DisplayOrientation)_PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetNaturalDisplayOrientation", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_DisplayId displayId);
	}

	/// <summary>
	/// Get the orientation of a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentDisplayOrientation">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <returns> The <see cref="SDL_DisplayOrientation"/> enum value of the display, or <see cref="SDL_DisplayOrientation.Unknown"/> if it isn't available. </returns>
	public static SDL_DisplayOrientation GetCurrentDisplayOrientation(SDL_DisplayId displayId)
	{
		return (SDL_DisplayOrientation)_PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_DisplayId displayId);
	}

	/// <summary>
	/// Get the content scale of a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayContentScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <returns> The content scale of the display, or 0.0f on error; call <see cref="GetError"/> for more details. </returns>
	public static float GetDisplayContentScale(SDL_DisplayId displayId)
	{
		return _PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation", CallingConvention = CallingConvention.Cdecl)]
		static extern float _PInvoke(SDL_DisplayId displayId);
	}

	/// <summary>
	/// Get a list of fullscreen display modes available on a display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetFullscreenDisplayModes">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <param name="count"> Returns the number of display modes returned. </param>
	/// <returns> An array of display modes or null on error; call <see cref="GetError"/> for more details. </returns>
	public static SDL_DisplayMode[]? GetFullscreenDisplayModes(SDL_DisplayId displayId, out int count)
	{
		fixed (int* countPtr = &count)
		{
			SDL_DisplayMode** d = _PInvoke(displayId, countPtr);
			if (d is null)
			{
				return null;
			}
			SDL_DisplayMode[] modes = new SDL_DisplayMode[count];
			for (int i = 0; i < count; i++)
			{
				modes[i] = *d[i];
			}
			Free(d);
			return modes;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetFullscreenDisplayModes", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayMode** _PInvoke(SDL_DisplayId displayId, int* count);
	}

	/// <summary>
	/// Get the closest match to the requested display mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetClosestFullscreenDisplayMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <param name="width"> The width in pixels of the desired display mode. </param>
	/// <param name="height"> The height in pixels of the desired display mode. </param>
	/// <param name="refreshRate"> The refresh rate of the desired display mode, or 0.0f for the desktop refresh rate. </param>
	/// <param name="includeHighDensityModes"> Include high density modes in the search. </param>
	/// <returns> The closest display mode equal to or larger than the desired mode, or null on error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_DisplayMode* GetClosestFullscreenDisplayMode(SDL_DisplayId displayId, int width, int height, float refreshRate, bool includeHighDensityModes)
	{
		return _PInvoke(displayId, width, height, refreshRate, includeHighDensityModes ? 1 : 0);
		

		[DllImport(LibraryName, EntryPoint = "SDL_GetClosestFullscreenDisplayMode", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayMode* _PInvoke(SDL_DisplayId displayId, int width, int height, float refreshRate, int includeHighDensityModes);
	}

	/// <summary>
	/// Get information about the desktop's display mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDesktopDisplayMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query </param>
	/// <returns> The desktop display mode or null on error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_DisplayMode* GetDesktopDisplayMode(SDL_DisplayId displayId)
	{
		return _PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDesktopDisplayMode", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayMode* _PInvoke(SDL_DisplayId displayId);
	}

	/// <summary>
	/// Get information about the current display mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentDisplayMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="displayId"> The instance ID of the display to query. </param>
	/// <returns> The desktop display mode or null on error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_DisplayMode* GetCurrentDisplayMode(SDL_DisplayId displayId)
	{
		return _PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayMode", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayMode* _PInvoke(SDL_DisplayId displayId);
	}

	/// <summary>
	/// Get the display containing a point.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForPoint">documentation</see> for more details.
	/// </remarks>
	/// <param name="point"> The point to query. </param>
	/// <returns> The instance ID of the display containing the point or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_DisplayId GetDisplayForPoint(SDL_Point* point)
	{
		return _PInvoke(point);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForPoint", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayId _PInvoke(SDL_Point* point);
	}

	/// <summary>
	/// Get the display primarily containing a rect.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="rect"> The rect to query. </param>
	/// <returns> The instance ID of the display entirely containing the rect or closest to the center of the rect on success or <see cref="SDL_DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_DisplayId GetDisplayForRect(SDL_Rect* rect)
	{
		return _PInvoke(rect);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForRect", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayId _PInvoke(SDL_Rect* rect);
	}

	/// <summary>
	/// Get the display associated with a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The instance ID of the display containing the center of the window on success or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_DisplayId GetDisplayForWindow(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayId _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the pixel density of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPixelDensity">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The pixel density or 0.0f on failure; call <see cref="GetError"/> for more information. </returns>
	public static float GetWindowPixelDensity(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowPixelDensity", CallingConvention = CallingConvention.Cdecl)]
		static extern float _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the content display scale relative to a window's pixel size.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowDisplayScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The display scale, or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static float GetWindowDisplayScale(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowDisplayScale", CallingConvention = CallingConvention.Cdecl)]
		static extern float _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Set the display mode to use when a window is visible and fullscreen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFullscreenMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to affect. </param>
	/// <param name="displayMode"> The display mode to use, which can be null for borderless fullscreen desktop mode, or one of the fullscreen modes returned by <see cref="GetFullscreenDisplayModes"/> to set an exclusive fullscreen mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetWindowFullscreenMode(SDL_Window* window, SDL_DisplayMode* mode)
	{
		return _PInvoke(window, mode);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreenMode", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, SDL_DisplayMode* mode);
	}

	/// <summary>
	/// Query the display mode to use when a window is visible at fullscreen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFullscreenMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The exclusive fullscreen mode to use or null for borderless fullscreen desktop mode. </returns>
	public static SDL_DisplayMode* GetWindowFullscreenMode(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowFullscreenMode", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_DisplayMode* _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the raw ICC profile data for the screen the window is currently on.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowICCProfile">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <param name="size"> The size of the ICC profile. </param>
	/// <returns> The raw ICC profile data on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static void* GetWindowICCProfile(SDL_Window* window, out nuint size)
	{
		fixed (nuint* sizePtr = &size)
		{
			return _PInvoke(window, sizePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowICCProfile", CallingConvention = CallingConvention.Cdecl)]
		static extern void* _PInvoke(SDL_Window* window, nuint* size); // this shit looks and IS very cursed.
	}

	/// <summary>
	/// Get the pixel format associated with the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPixelFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The pixel format of the window on success or <see cref="SDL_PixelFormatEnum.Unknown"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PixelFormatEnum GetWindowPixelFormat(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowPixelFormat", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_PixelFormatEnum _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Create a window with the specified dimensions and flags.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="title"> The title of the window. </param>
	/// <param name="width"> The width of the window. </param>
	/// <param name="height"> The height of the window. </param>
	/// <param name="flags"> Zero or more <see cref="SDL_WindowFlags"/> OR'd together. </param>
	/// <returns> The window that was created or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Window* CreateWindow(string title, int width, int height, SDL_WindowFlags flags)
	{
		fixed (byte* titlePtr = Encoding.UTF8.GetBytes(title))
		{
			return _PInvoke(titlePtr, width, height, flags);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_CreateWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Window* _PInvoke(byte* title, int width, int height, SDL_WindowFlags flags);
	}

	/// <summary>
	/// Create a window with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to use. </param>
	/// <returns> The window that was created or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Window* CreateWindowWithProperties(SDL_PropertiesId props)
	{
		return _PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateWindowWithProperties", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Window* _PInvoke(SDL_PropertiesId props);
	}

	/// <summary>
	/// Create a child popup window of the specified parent window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePopupWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="parent"> The parent of the window, must not be null. </param>
	/// <param name="offsetX"> The x x of the popup window relative to the origin of the parent window. </param>
	/// <param name="offsetY"> The y x of the popup window relative to the origin of the parent window. </param>
	/// <param name="width"> The width of the window </param>
	/// <param name="height"> The height of the window. </param>
	/// <param name="flags"> <see cref="SDL_WindowFlags.Tooltip"/> or <see cref="SDL_WindowFlags.PopupMenu"/> and zero or more <see cref="SDL_WindowFlags"/> OR'd together. </param>
	/// <returns> The window that was created or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Window* CreatePopupWindow(SDL_Window* parent, int offsetX, int offsetY, int width, int height, SDL_WindowFlags flags)
	{
		return _PInvoke(parent, offsetX, offsetY, width, height, (uint)flags);

		[DllImport(LibraryName, EntryPoint = "SDL_CreatePopupWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Window* _PInvoke(SDL_Window* parent, int offsetX, int offsetY, int width, int height, uint flags);
	}

	/// <summary>
	/// Get the numeric ID of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowID">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The ID of the window on success or <see cref="SDL_WindowId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_WindowId GetWindowId(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowID", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_WindowId _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get a window from a stored ID.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFromID">documentation</see> for more details.
	/// </remarks>
	/// <param name="id"> The ID of the window. </param>
	/// <returns> The window associated with <paramref name="id"/> or null if it doesn't exist; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Window* GetWindowFromId(SDL_WindowId id)
	{
		return _PInvoke(id);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowFromID", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Window* _PInvoke(SDL_WindowId id);
	}

	/// <summary>
	/// Get parent of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowParent">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The parent of the window on success or null if the window has no parent. </returns>
	public static SDL_Window* GetWindowParent(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowParent", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Window* _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the properties associated with a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetWindowProperties(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowProperties", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_PropertiesId _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the window flags.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFlags">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query </param>
	/// <returns> A mask of the <see cref="SDL_WindowFlags"/> associated with <paramref name="window"/>. </returns>
	public static SDL_WindowFlags GetWindowFlags(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowFlags", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_WindowFlags _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Set the title of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowTitle">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="title"> The desired window title. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowTitle(SDL_Window* window, string title)
	{
		fixed (byte* titlePtr = Encoding.UTF8.GetBytes(title))
		{
			return _PInvoke(window, titlePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowTitle", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, byte* title);
	}

	/// <summary>
	/// Get the title of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowTitle">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The title of the window or an empty string if there is no title. </returns>
	public static string GetWindowTitle(SDL_Window* window)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(window))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowTitle", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Set the icon for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowIcon">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="surface"> An <see cref="SDL_Surface"/> structure containing the icon for the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowIcon(SDL_Window* window, SDL_Surface* surface)
	{
		return _PInvoke(window, surface);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowIcon", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, SDL_Surface* icon);
	}

	/// <summary>
	/// Request that the window's x be set.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowPosition">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to reposition. </param>
	/// <param name="x"> The x coordinate of the window, or <see cref="SDL_Windowpos.Centered"/> or <see cref="WindowPosUndefined"/>. </param>
	/// <param name="y"> The y coordinate of the window, or <see cref="WindowPosCentered"/> or <see cref="WindowPosUndefined"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowPosition(SDL_Window* window, int x, int y)
	{
		return _PInvoke(window, x, y);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowPosition", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int x, int y);
	}

	/// <summary>
	/// Get the x of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPosition">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <param name="x"> Returns the x x of the window. </param>
	/// <param name="y"> Returns the y x of the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowPosition(SDL_Window* window, out int x, out int y)
	{
		fixed (int* xPtr = &x, yPtr = &y)
		{
			return _PInvoke(window, xPtr, yPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowPosition", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int* x, int* y);
	}

	/// <summary>
	/// Request that the size of a window's client area be set.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="width"> The width of the window, must be &gt; 0. </param>
	/// <param name="height"> The height of the window, must be &gt; 0. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowSize(SDL_Window* window, int width, int height)
	{
		return _PInvoke(window, width, height);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int width, int height);
	}

	/// <summary>
	/// Get the size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query the width and height from. </param>
	/// <param name="width"> Returns the width of the window. </param>
	/// <param name="height"> Returns the height of the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowSize(SDL_Window* window, out int width, out int height)
	{
		fixed (int* widthPtr = &width, heightPtr = &height)
		{
			return _PInvoke(window, widthPtr, heightPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int* width, int* height);
	}

	/// <summary>
	/// Get the size of a window's borders (decorations) around the client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowBordersSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query the size values of the border (decorations) from. </param>
	/// <param name="top"> Returns the size of the top border. </param>
	/// <param name="left"> Returns the size of the left border. </param>
	/// <param name="bottom"> Returns the size of the bottom border. </param>
	/// <param name="right"> Returns the size of the right border. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowBordersSize(SDL_Window* window, out int top, out int left, out int bottom, out int right)
	{
		fixed (int* topPtr = &top, leftPtr = &left, bottomPtr = &bottom, rightPtr = &right)
		{
			return _PInvoke(window, topPtr, leftPtr, bottomPtr, rightPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowBordersSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int* top, int* left, int* bottom, int* right);
	}

	/// <summary>
	/// Get the size of a window's client area, in pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSizeInPixels">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window from which the drawable size should be queried. </param>
	/// <param name="width"> Returns the width in pixels. </param>
	/// <param name="height"> Returns the height in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowSizeInPixels(SDL_Window* window, out int width, out int height)
	{
		fixed (int* widthPtr = &width, heightPtr = &height)
		{
			return _PInvoke(window, widthPtr, heightPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowSizeInPixels", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int* width, int* height);
	}

	/// <summary>
	/// Set the minimum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMinimumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="minW"> The minimum width of the window, or 0 for no limit. </param>
	/// <param name="minH"> The minimum height of the window, or 0 for no limit. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowMinimumSize(SDL_Window* window, int minW, int minH)
	{
		return _PInvoke(window, minW, minH);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowMinimumSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int minW, int minH);
	}

	/// <summary>
	/// Get the minimum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMinimumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="widow"> The window to query. </param>
	/// <param name="width"> Returns the minimum width of the window. </param>
	/// <param name="height"> Returns the minimum height of the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowMinimumSize(SDL_Window* widow, out int width, out int height)
	{
		fixed (int* widthPtr = &width, heightPtr = &height)
		{
			return _PInvoke(widow, widthPtr, heightPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowMinimumSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int* width, int* height);
	}

	/// <summary>
	/// Set the maximum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMaximumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="maxW"> The maximum width of the window, or 0 for no limit. </param>
	/// <param name="maxH"> The maximum height of the window, or 0 for no limit. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowMaximumSize(SDL_Window* window, int maxW, int maxH)
	{
		return _PInvoke(window, maxW, maxH);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowMaximumSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int maxW, int maxH);
	}

	/// <summary>
	/// Get the maximum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMaximumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <param name="width"> Returns the maximum width of the window. </param>
	/// <param name="height"> Returns the maximum height of the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowMaximumSize(SDL_Window* window, out int width, out int height)
	{
		fixed (int* widthPtr = &width, heightPtr = &height)
		{
			return _PInvoke(window, widthPtr, heightPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowMaximumSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int* width, int* height);
	}

	/// <summary>
	/// Set the border state of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowBordered">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window of which to change the border state. </param>
	/// <param name="bordered"> False to remove border, true to add border. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowBordered(SDL_Window* window, bool bordered)
	{
		return _PInvoke(window, bordered ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowBordered", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int bordered);
	}

	/// <summary>
	/// Set the user-resizable state of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowResizable">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window of which to change the resizable state. </param>
	/// <param name="resizable"> True to allow resizing, false to disallow. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowResizable(SDL_Window* window, bool resizable)
	{
		return _PInvoke(window, resizable ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowResizable", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int resizable);
	}

	/// <summary>
	/// Set the window to always be above the others.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowAlwaysOnTop">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window of which to change the always on top state. </param>
	/// <param name="onTop"> True to set the window always on top, false to disable. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowAlwaysOnTop(SDL_Window* window, bool onTop)
	{
		return _PInvoke(window, onTop ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowAlwaysOnTop", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int onTop);
	}

	/// <summary>
	/// Show a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to show. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int ShowWindow(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_ShowWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Hide a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HideWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to hide. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int HideWindow(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_HideWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Raise a window above other windows and set the input focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RaiseWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to raise. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int RaiseWindow(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_RaiseWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Request that the window be made as large as possible.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MaximizeWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to maximize. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int MaximizeWindow(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_MaximizeWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Request that the window be minimized to an iconic representation.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MinimizeWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to minimize. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int MinimizeWindow(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_MinimizeWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Request that the size and x of a minimized or maximized window be restored.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RestoreWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to restore. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int RestoreWindow(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_RestoreWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Request that the window's fullscreen state be changed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFullscreen">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="fullscreen"> True for fullscreen mode, false for windowed mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowFullscreen(SDL_Window* window, bool fullscreen)
	{
		return _PInvoke(window, fullscreen ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreen", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int fullscreen);
	}

	/// <summary>
	/// Block until any pending window state is finalized.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SyncWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window for which to wait for the pending state to be applied. </param>
	/// <returns> 0 on success, a positive value if the operation timed out before the window was in the requested state, or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SyncWindow(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_SyncWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Return whether the window has a surface associated with it.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WindowHasSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> True if there is a surface associated with the window, or false otherwise. </returns>
	public static bool WindowHasSurface(SDL_Window* window)
	{
		return _PInvoke(window) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_WindowHasSurface", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the SDL surface associated with the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The surface associated with the window, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* GetWindowSurface(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowSurface", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Surface* _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Copy the window surface to the screen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to update. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int UpdateWindowSurface(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurface", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Copy areas of the window surface to the screen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateWindowSurfaceRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to update. </param>
	/// <param name="rects"> An array of <see cref="SDL_Rect"/> structures representing areas of the surface to copy, in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int UpdateWindowSurfaceRects(SDL_Window* window, SDL_Rect[] rects)
	{
		fixed (SDL_Rect* rectsPtr = rects)
		{
			return _PInvoke(window, rectsPtr, rects.Length);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurfaceRects", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, SDL_Rect* rects, int numRects);
	}

	/// <summary>
	/// Destroy the surface associated with the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to update. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int DestroyWindowSurface(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyWindowSurface", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Set a window's keyboard grab mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowKeyboardGrab">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window for which the keyboard grab mode should be set. </param>
	/// <param name="grabbed"> This is true to grab keyboard, and false to release. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowKeyboardGrab(SDL_Window* window, bool grabbed)
	{
		return _PInvoke(window, grabbed ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowKeyboardGrab", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int grabbed);
	}

	/// <summary>
	/// Set a window's mouse grab mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMouseGrab">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window for which the mouse grab mode should be set. </param>
	/// <param name="grabbed"> This is true to grab mouse, and false to release. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowMouseGrab(SDL_Window* window, bool grabbed)
	{
		return _PInvoke(window, grabbed ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowMouseGrab", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int grabbed);
	}

	/// <summary>
	/// Get a window's keyboard grab mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowKeyboardGrab">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> True if keyboard is grabbed, and false otherwise. </returns>
	public static bool GetWindowKeyboardGrab(SDL_Window* window)
	{
		return _PInvoke(window) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowKeyboardGrab", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get a window's mouse grab mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMouseGrab">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> True if keyboard is grabbed, and false otherwise. </returns>
	public static bool GetWindowMouseGrab(SDL_Window* window)
	{
		return _PInvoke(window) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowMouseGrab", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the window that currently has an input grab enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetGrabbedWindow">documentation</see> for more details.
	/// </remarks>
	/// <returns> The window if input is grabbed or null otherwise. </returns>
	public static SDL_Window* GetGrabbedWindow()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetGrabbedWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Window* _PInvoke();
	}

	/// <summary>
	/// Confines the cursor to the specified area of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMouseRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window that will be associated with the barrier. </param>
	/// <param name="rect"> A rectangle area in window-relative coordinates. If null, the barrier for the specified window will be destroyed. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowMouseRect(SDL_Window* window, SDL_Rect* rect)
	{
		// "the barrier [...] will be destroyed" undertale reference???
		// anyway more boring pinvoke shit.
		return _PInvoke(window, rect);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowMouseRect", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, SDL_Rect* rect);
	}

	/// <summary>
	/// Get the mouse confinement rectangle of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMouseRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The mouse confinement rectangle of a window, or null if there isn't one. </returns>
	public static SDL_Rect* GetWindowMouseRect(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowMouseRect", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Rect* _PInvoke(void* window);
	}

	/// <summary>
	/// Set the opacity for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowOpacity">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window which will be made transparent or opaque. </param>
	/// <param name="opacity"> The opacity value (0.0f - transparent, 1.0f - opaque). </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowOpacity(SDL_Window* window, float opacity)
	{
		return _PInvoke(window, opacity);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowOpacity", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, float opacity);
	}

	/// <summary>
	/// Get the opacity of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowOpacity">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> the window to get the current opacity value from. </param>
	/// <param name="opacity"> Returns the float filled in (0.0f - transparent, 1.0f - opaque). </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowOpacity(SDL_Window* window, out float opacity)
	{
		fixed (float* opacityPtr = &opacity)
		{
			return _PInvoke(window, opacityPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowOpacity", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, float* opacity);
	}

	/// <summary>
	/// Set the window as a modal to a parent window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowModalFor">documentation</see> for more details.
	/// </remarks>
	/// <param name="modalWindow"> The window that should be set modal. </param>
	/// <param name="parentWindow"> The parent window for the modal window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowModalFor(SDL_Window* modalWindow, SDL_Window* parentWindow)
	{
		return _PInvoke(modalWindow, parentWindow);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowModalFor", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* modalWindow, SDL_Window* parentWindow);
	}

	/// <summary>
	/// Explicitly set input focus to the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowInputFocus">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window that should get the input focus. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowInputFocus(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowInputFocus", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Set whether the window may have input focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFocusable">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to set focusable state. </param>
	/// <param name="focusable"> True to allow input focus, false to not allow input focus. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowFocusable(SDL_Window* window, bool focusable)
	{
		return _PInvoke(window, focusable ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowFocusable", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int focusable);
	}

	/// <summary>
	/// Display the system-level window menu.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowWindowSystemMenu">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window for which the menu will be displayed. </param>
	/// <param name="x"> The x coordinate of the menu, relative to the origin (top-left) of the client area. </param>
	/// <param name="y"> The y coordinate of the menu, relative to the origin (top-left) of the client area. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int ShowWindowSystemMenu(SDL_Window* window, int x, int y)
	{
		return _PInvoke(window, x, y);

		[DllImport(LibraryName, EntryPoint = "SDL_ShowWindowSystemMenu", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, int x, int y);
	}

	// FIXME: implement SDL_HitTest
	// FIXME: implement SDL_HitTestResult
	// FIXME: implement SDL_SetWindowHitTest()

	/// <summary>
	/// Set the shape of a transparent window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowShape">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window. </param>
	/// <param name="shape"> The surface representing the shape of the window, or null to remove any current shape. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowShape(SDL_Window* window, SDL_Surface* shape)
	{
		if (shape is not null)
		{
			return _PInvoke(window, shape);
		}
		return _PInvoke(window, null);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowShape", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, SDL_Surface* shape);
	}

	/// <summary>
	/// Request a window to demand attention from the user.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlashWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The <see cref="SDL_Window"/> to be flashed. </param>
	/// <param name="operation"> The <see cref="SDL_FlashOperation"/> to perform. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int FlashWindow(SDL_Window* window, SDL_FlashOperation operation)
	{
		return _PInvoke(window, operation);

		[DllImport(LibraryName, EntryPoint = "SDL_FlashWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Window* window, SDL_FlashOperation operation);
	}

	/// <summary>
	/// Destroy a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to destroy. </param>
	public static void DestroyWindow(SDL_Window* window)
	{
		_PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Check whether the screensaver is currently enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ScreenSaverEnabled">documentation</see> for more details.
	/// </remarks>
	/// <returns> True if the screensaver is enabled, false if it is disabled. </returns>
	public static bool ScreenSaverEnabled()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_ScreenSaverEnabled", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Allow the screen to be blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EnableScreenSaver">documentation</see> for more details.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int EnableScreenSaver()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_EnableScreenSaver", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Prevent the screen from being blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisableScreenSaver">documentation</see> for more details.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int DisableScreenSaver()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_DisableScreenSaver", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Used to indicate that you don't care what the window position is.
	/// </summary>
	public const uint WindowPosUndefined = WindowPosCenteredMask | 0;

	/// <summary>
	/// Used to indicate that the window position should be centered.
	/// </summary>
	public const uint WindowPosCentered = WindowPosCenteredMask | 0;

	public const uint WindowPosUndefinedMask = 0x1FFF0000u;
	public const uint WindowPosCenteredMask = 0x2FFF0000u;
}