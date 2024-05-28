using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_video.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_video.h.
unsafe partial class SDL
{
	partial class PropNames
	{
		// CreateWindowWithProperties()
		public const string WINDOW_CREATE_ALWAYS_ON_TOP_BOOLEAN = "always_on_top";
		public const string WINDOW_CREATE_BORDERLESS_BOOLEAN = "borderless";
		public const string WINDOW_CREATE_FOCUSABLE_BOOLEAN = "focusable";
		public const string WINDOW_CREATE_EXTERNAL_GRAPHICS_CONTEXT_BOOLEAN = "external_graphics_context";
		public const string WINDOW_CREATE_FULLSCREEN_BOOLEAN = "fullscreen";
		public const string WINDOW_CREATE_HEIGHT_NUMBER = "height";
		public const string WINDOW_CREATE_HIDDEN_BOOLEAN = "hidden";
		public const string WINDOW_CREATE_HIGH_PIXEL_DENSITY_BOOLEAN = "high_pixel_density";
		public const string WINDOW_CREATE_MAXIMIZED_BOOLEAN = "maximized";
		public const string WINDOW_CREATE_MENU_BOOLEAN = "menu";
		public const string WINDOW_CREATE_METAL_BOOLEAN = "metal";
		public const string WINDOW_CREATE_MINIMIZED_BOOLEAN = "minimized";
		public const string WINDOW_CREATE_MODAL_BOOLEAN = "modal";
		public const string WINDOW_CREATE_MOUSE_GRABBED_BOOLEAN = "mouse_grabbed";
		public const string WINDOW_CREATE_OPENGL_BOOLEAN = "opengl";
		public const string WINDOW_CREATE_PARENT_POINTER = "parent";
		public const string WINDOW_CREATE_RESIZABLE_BOOLEAN = "resizable";
		public const string WINDOW_CREATE_TITLE_STRING = "title";
		public const string WINDOW_CREATE_TRANSPARENT_BOOLEAN = "transparent";
		public const string WINDOW_CREATE_TOOLTIP_BOOLEAN = "tooltip";
		public const string WINDOW_CREATE_UTILITY_BOOLEAN = "utility";
		public const string WINDOW_CREATE_VULKAN_BOOLEAN = "vulkan";
		public const string WINDOW_CREATE_WIDTH_NUMBER = "width";
		public const string WINDOW_CREATE_X_NUMBER = "x";
		public const string WINDOW_CREATE_Y_NUMBER = "y";
		public const string WINDOW_CREATE_COCOA_WINDOW_POINTER = "cocoa.window";
		public const string WINDOW_CREATE_COCOA_VIEW_POINTER = "cocoa.view";
		public const string WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN = "wayland.surface_role_custom";
		public const string WINDOW_CREATE_WWAYLAND_CREATE_EGL_WINDOW_BOOLEAN = "wayland.create_egl_window";
		public const string WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER = "wayland.wl_surface";
		public const string WINDOW_CREATE_WIN32_HWND_POINTER = "win32.hwnd";
		public const string WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER = "win32.pixel_format_hwnd";
		public const string WINDOW_CREATE_X11_WINDOW_Number = "x11.window";

		// GetWindowProperties()
		public const string WINDOW_SHAPE_POINTER = "SDL.window.shape";
		public const string WINDOW_ANDROID_WINDOW_POINTER = "SDL.window.android.window";
		public const string WINDOW_ANDROID_SURFACE_POINTER = "SDL.window.android.surface";
		public const string WINDOW_UIKIT_WINDOW_POINTER = "SDL.window.uikit.window";
		public const string WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER = "SDL.window.uikit.metal_view_tag";
		public const string WINDOW_KMSDRM_DEVICE_INDEX_NUMBER = "SDL.window.kmsdrm.dev_index";
		public const string WINDOW_KMSDRM_DRM_FD_NUMBER = "SDL.window.kmsdrm.drm_fd";
		public const string WINDOW_KMSDRM_GBM_DEVICE_POINTER = "SDL.window.kmsdrm.gbm_dev";
		public const string WINDOW_COCOA_WINDOW_POINTER = "SDL.window.cocoa.window";
		public const string WINDOW_COCOA_METAL_VIEW_TAG_NUMBER = "SDL.window.cocoa.metal_view_tag";
		public const string WINDOW_VIVANTE_DISPLAY_POINTER = "SDL.window.vivante.display";
		public const string WINDOW_VIVANTE_WINDOW_POINTER = "SDL.window.vivante.window";
		public const string WINDOW_VIVANTE_SURFACE_POINTER = "SDL.window.vivante.surface";
		public const string WINDOW_WINRT_WINDOW_POINTER = "SDL.window.winrt.window";
		public const string WINDOW_WIN32_HWND_POINTER = "SDL.window.win32.hwnd";
		public const string WINDOW_WIN32_HDC_POINTER = "SDL.window.win32.hdc";
		public const string WINDOW_WIN32_INSTANCE_POINTER = "SDL.window.win32.instance";
		public const string WINDOW_WAYLAND_DISPLAY_POINTER = "SDL.window.wayland.display";
		public const string WINDOW_WAYLAND_SURFACE_POINTER = "SDL.window.wayland.surface";
		public const string WINDOW_WAYLAND_EGL_WINDOW_POINTER = "SDL.window.wayland.egl_window";
		public const string WINDOW_WAYLAND_XDG_SURFACE_POINTER = "SDL.window.wayland.xdg_surface";
		public const string WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER = "SDL.window.wayland.xdg_toplevel";
		public const string WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING = "SDL.window.wayland.xdg_toplevel_export_handle";
		public const string WINDOW_WAYLAND_XDG_POPUP_POINTER = "SDL.window.wayland.xdg_popup";
		public const string WINDOW_WAYLAND_XDG_POSITIONER_POINTER = "SDL.window.wayland.xdg_positioner";
		public const string WINDOW_X11_DISPLAY_POINTER = "SDL.window.x11.display";
		public const string WINDOW_X11_SCREEN_NUMBER = "SDL.window.x11.screen";
		public const string WINDOW_X11_WINDOW_NUMBER = "SDL.window.x11.window";
	}

	/// <summary>
	/// The struct used as an opaque handle to a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Window">here</see>.
	/// </remarks>
	public readonly struct Window;

	/// <summary>
	/// Represents an id for a display. This structure serves as a wrapper for an unsigned 32-bit integer.
	/// </summary>
	public readonly struct DisplayId
	{
		internal DisplayId(uint value)
		{
			Id = value;
		}

		/// <summary>
		/// An invalid id for a display.
		/// </summary>
		/// <remarks>
		/// This is used when a function that returns a <see cref="DisplayId"/> instance fails.
		/// </remarks>
		public static DisplayId Invalid => new();

		/// <summary>
		/// The id value, as an unsigned 32-bit integer.
		/// </summary>
		public readonly uint Id;
	}

	/// <summary>
	/// Represents the internal id of a window. This structure serves as a wrapper for an unsigned 32-bit integer.
	/// </summary>
	public readonly struct WindowId
	{
		internal WindowId(uint value)
		{
			Id = value;
		}

		/// <summary>
		/// An invalid id for a window.
		/// </summary>
		/// <remarks>
		/// This is used when a function that returns a <see cref="WindowId"/> instance fails.
		/// </remarks>
		public static WindowId Invalid => new();

		/// <summary>
		/// The id value, as an unsigned 32-bit integer.
		/// </summary>
		public readonly uint Id;
	}

	/// <summary>
	/// The structure that defines a display mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayMode">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public readonly struct DisplayMode
	{
		/// <summary>
		/// The display this mode is associated with.
		/// </summary>
		public readonly DisplayId DisplayId;

		/// <summary>
		/// Pixel format.
		/// </summary>
		public readonly PixelFormatValue Format;

		/// <summary>
		/// Width, in pixels.
		/// </summary>
		public readonly int Width;

		/// <summary>
		/// Height, in pixels.
		/// </summary>
		public readonly int Height;

		/// <summary>
		/// Scale converting size to pixels (e.g. a 1920x1080 mode with 2.0 scale would have 3840x2160 pixels)
		/// </summary>
		public readonly float PixelDensity;

		/// <summary>
		/// Refresh rate (or zero for unspecified).
		/// </summary>
		public readonly float RefreshRate;

		/// <summary>
		/// Driver-specific data, initialize to 0.
		/// </summary>
		public readonly void* DriverData;
	}

	/// <summary>
	/// System theme.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SystemTheme">here</see>.
	/// </remarks>
	public enum SystemTheme
	{
		/// <summary>
		/// Unknown system theme.
		/// </summary>
		Unknown,

		/// <summary>
		/// Light colored system theme.
		/// </summary>
		Light,

		/// <summary>
		/// Dark colored system theme.
		/// </summary>
		Dark
	}

	/// <summary>
	/// Display orientation values; the way a display is rotated.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayOrientation">here</see>.
	/// </remarks>
	public enum DisplayOrientation
	{
		/// <summary>
		/// The display orientation can't be determined.
		/// </summary>
		Unknown,

		/// <summary>
		/// The display is in landscape mode, with the right side up, relative to portrait mode.
		/// </summary>
		Landscape,

		/// <summary>
		/// The display is in landscape mode, with the left side up, relative to portrait mode.
		/// </summary>
		LandscapeFlipped,

		/// <summary>
		/// The display is in portrait mode.
		/// </summary>
		Portrait,

		/// <summary>
		/// The display is in portrait mode, upside down.
		/// </summary>
		PortraitFlipped,
	}

	/// <summary>
	/// The flags on a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_WindowFlags">here</see>.
	/// </remarks>
	[Flags]
	public enum WindowFlags : uint
	{
		/// <summary>
		/// No window flags.
		/// </summary>
		None,

		/// <summary>
		/// Window is in fullscreen mode.
		/// </summary>
		Fullscreen = 0x00000001u,

		/// <summary>
		/// Window usable with OpenGL context.
		/// </summary>
		OpenGL = 0x00000002u,

		/// <summary>
		/// Window is occluded.
		/// </summary>
		Occluded = 0x00000004u,

		/// <summary>
		/// Window is neither mapped onto the desktop nor shown in the taskbar/dock/window list; <see cref="ShowWindow"/>
		/// is required for it to become visible.
		/// </summary>
		Hidden = 0x00000008u,

		/// <summary>
		/// No window decoration.
		/// </summary>
		Borderless = 0x00000010u,

		/// <summary>
		/// Window can be resized.
		/// </summary>
		Resizable = 0x00000020u,

		/// <summary>
		/// Window is minimized.
		/// </summary>
		Minimized = 0x00000040u,

		/// <summary>
		/// Window is maximized.
		/// </summary>
		Maximized = 0x00000080u,

		/// <summary>
		/// Window has grabbed mouse focus.
		/// </summary>
		MouseGrabbed = 0x00000100u,

		/// <summary>
		/// Window has input focus.
		/// </summary>
		InputFocus = 0x00000200u,

		/// <summary>
		/// Window has mouse focus.
		/// </summary>
		MouseFocus = 0x00000400u,

		/// <summary>
		/// Window not created by SDL.
		/// </summary>
		External = 0x00000800u,

		/// <summary>
		/// Window uses high pixel density back buffer if possible.
		/// </summary>
		HighPixelDensity = 0x00002000u,

		/// <summary>
		/// Window has mouse captured (unrelated to <see cref="MouseFocus"/>).
		/// </summary>
		MouseCapture = 0x00004000u,

		/// <summary>
		/// Window should always be above others.
		/// </summary>
		AlwaysOnTop = 0x00008000u,

		/// <summary>
		/// Window should be treated as a utility window, not showing in the task bar and window list.
		/// </summary>
		Utility = 0x00020000u,

		/// <summary>
		/// Window should be treated as a tooltip.
		/// </summary>
		Tooltip = 0x00040000U,

		/// <summary>
		/// Window should be treated as a popup menu.
		/// </summary>
		PopupMenu = 0x00080000u,

		/// <summary>
		/// Window has grabbed keyboard input.
		/// </summary>
		KeyboardGrabbed = 0x00100000u,

		/// <summary>
		/// Window usable for Vulkan surface.
		/// </summary>
		Vulkan = 0x10000000u,

		/// <summary>
		/// Window usable for Metal view.
		/// </summary>
		Metal = 0x20000000u,

		/// <summary>
		/// Window with transparent buffer.
		/// </summary>
		Transparent = 0x40000000u,

		/// <summary>
		/// Window should not be focusable.
		/// </summary>
		NotFocusable = 0x80000000u
	}

	/// <summary>
	/// Window flash operation.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FlashOperation">here</see>.
	/// </remarks>
	public enum FlashOperation
	{
		/// <summary>
		/// Cancel any window flash state.
		/// </summary>
		Cancel,

		/// <summary>
		/// Flash the window briefly to get attention
		/// </summary>
		Briefly,

		/// <summary>
		/// Flash the window until it gets focus
		/// </summary>
		UntilFocused
	}

	[Macro]
	public static int WINDOWPOS_UNDEFINED_DISPLAY(int x)
	{
		return (int)(WINDOWPOS_UNDEFINED_MASK | x);
	}

	[Macro]
	public static bool WINDOWPOS_IS_UNDEFINED(int x)
	{
		return (x & 0xFFFF0000) == WINDOWPOS_UNDEFINED_MASK;
	}

	[Macro]
	public static int WINDOWPOS_CENTERED_DISPLAY(int x)
	{
		return (int)(WINDOWPOS_CENTERED_MASK | x);
	}

	[Macro]
	public static bool WINDOWPOS_IS_CENTERED(int x)
	{
		return (x & 0xFFFF0000) == WINDOWPOS_CENTERED_MASK;
	}

	/// <summary>
	/// Get the number of video drivers compiled into SDL.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumVideoDrivers">here</see>.
	/// </remarks>
	/// <returns> A number >= 1 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumVideoDrivers()
	{
		return _PInvokeGetNumVideoDrivers();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumVideoDrivers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetNumVideoDrivers();

	/// <summary>
	/// Get the name of a built in video driver.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetVideoDriver">here</see>.
	/// </remarks>
	/// <param name="index"> The index of a video driver. </param>
	/// <returns> The name of the video driver with the given <paramref name="index"/>. </returns>
	public static string GetVideoDriver(int index)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetVideoDriver(index))!;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetVideoDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetVideoDriver(int index);

	/// <summary>
	/// Get the name of the currently initialized video driver.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentVideoDriver">here</see>.
	/// </remarks>
	/// <returns> The name of the current video driver or null if no driver has been initialized. </returns>
	public static string? GetCurrentVideoDriver()
	{
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetCurrentVideoDriver());
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentVideoDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetCurrentVideoDriver();

	/// <summary>
	/// Get the current system theme.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSystemTheme">here</see>.
	/// </remarks>
	/// <returns> The current system theme, light, dark, or unknown. </returns>
	public static SystemTheme GetSystemTheme()
	{
		return (SystemTheme)_PInvokeGetSystemTheme();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSystemTheme")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetSystemTheme();

	/// <summary>
	/// Get a list of currently connected displays.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplays">here</see>.
	/// </remarks>
	/// <param name="count"> Returns the number of displays returned. </param>
	/// <returns> An array of display instance IDs or null on error; call <see cref="GetError"/> for more information. </returns>
	public static DisplayId[]? GetDisplays(out int count)
	{
		fixed (int* c = &count)
		{
			DisplayId* d = _PInvokeGetDisplays(c);
			if (d is null)
			{
				return null;
			}
			var ids = new DisplayId[count];
			for (int i = 0; i < count; i++)
			{
				ids[i] = d[i];
			}
			_PInvokeFree(d);
			return ids;
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplays")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayId* _PInvokeGetDisplays(int* count);

	/// <summary>
	/// Return the primary display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetPrimaryDisplay">here</see>.
	/// </remarks>
	/// <returns> The instance id of the primary display on success or <see cref="DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static DisplayId GetPrimaryDisplay()
	{
		return _PInvokeGetPrimaryDisplay();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPrimaryDisplay")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayId _PInvokeGetPrimaryDisplay();

	/// <summary>
	/// Get the properties associated with a display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayProperties">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <returns> A valid property id on success or <see cref="DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId GetDisplayProperties(DisplayId displayId)
	{
		return _PInvokeGetDisplayProperties(displayId);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial PropertiesId _PInvokeGetDisplayProperties(DisplayId displayId);

	/// <summary>
	/// Get the name of a display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayName">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <returns> The name of a display or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static string? GetDisplayName(DisplayId displayId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetDisplayName(displayId));
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetDisplayName(DisplayId displayId);

	/// <summary>
	/// Get the desktop area represented by a display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayBounds">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <param name="rect"> Returns the <see cref="Rect"/> structure filled in with the display bounds. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetDisplayBounds(DisplayId displayId, out Rect rect)
	{
		fixed (Rect* r = &rect)
		{
			return _PInvokeGetDisplayBounds(displayId, r);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayBounds")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetDisplayBounds(DisplayId displayId, Rect* rect);

	/// <summary>
	/// Get the usable desktop area represented by a display, in screen coordinates.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayUsableBounds">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <param name="rect"> Returns the <see cref="Rect"/> structure filled in with the display bounds </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetDisplayUsableBounds(DisplayId displayId, out Rect rect)
	{
		fixed (Rect* r = &rect)
		{
			return _PInvokeGetDisplayUsableBounds(displayId, r);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayUsableBounds")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetDisplayUsableBounds(DisplayId displayId, Rect* rect);

	/// <summary>
	/// Get the orientation of a display when it is unrotated.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetNaturalDisplayOrientation">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <returns> The <see cref="DisplayOrientation"/> enum value of the display, or <see cref="DisplayOrientation.Unknown"/> if it isn't available. </returns>
	public static DisplayOrientation GetNaturalDisplayOrientation(DisplayId displayId)
	{
		return (DisplayOrientation)_PInvokeGetNaturalDisplayOrientation(displayId);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNaturalDisplayOrientation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetNaturalDisplayOrientation(DisplayId displayId);

	/// <summary>
	/// Get the orientation of a display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentDisplayOrientation">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <returns> The <see cref="DisplayOrientation"/> enum value of the display, or <see cref="DisplayOrientation.Unknown"/> if it isn't available. </returns>
	public static DisplayOrientation GetCurrentDisplayOrientation(DisplayId displayId)
	{
		return (DisplayOrientation)_PInvokeGetCurrentDisplayOrientation(displayId);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetCurrentDisplayOrientation(DisplayId displayId);

	/// <summary>
	/// Get the content scale of a display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayContentScale">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <returns> The content scale of the display, or 0.0f on error; call <see cref="GetError"/> for more details. </returns>
	public static float GetDisplayContentScale(DisplayId displayId)
	{
		return _PInvokeGetDisplayContentScale(displayId);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial float _PInvokeGetDisplayContentScale(DisplayId displayId);

	/// <summary>
	/// Get a list of fullscreen display modes available on a display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetFullscreenDisplayModes">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <param name="count"> Returns the number of display modes returned. </param>
	/// <returns> An array of display modes or null on error; call <see cref="GetError"/> for more details. </returns>
	public static DisplayMode[]? GetFullscreenDisplayModes(DisplayId displayId, out int count)
	{
		fixed (int* c = &count)
		{
			DisplayMode** d = _PInvokeGetFullscreenDisplayModes(displayId, c);
			if (d is null)
			{
				return null;
			}
			DisplayMode[] modes = new DisplayMode[count];
			for (int i = 0; i < count; i++)
			{
				modes[i] = *d[i];
			}
			_PInvokeFree(d);
			return modes;
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetFullscreenDisplayModes")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayMode** _PInvokeGetFullscreenDisplayModes(DisplayId displayId, int* count);

	/// <summary>
	/// Get the closest match to the requested display mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetClosestFullscreenDisplayMode">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <param name="width"> The width in pixels of the desired display mode. </param>
	/// <param name="height"> The height in pixels of the desired display mode. </param>
	/// <param name="refreshRate"> The refresh rate of the desired display mode, or 0.0f for the desktop refresh rate. </param>
	/// <param name="includeHighDensityModes"> Include high density modes in the search. </param>
	/// <returns> The closest display mode equal to or larger than the desired mode, or null on error; call <see cref="GetError"/> for more information. </returns>
	public static DisplayMode? GetClosestFullscreenDisplayMode(DisplayId displayId, int width, int height, float refreshRate, bool includeHighDensityModes)
	{
		DisplayMode* d = _PInvokeGetClosestFullscreenDisplayMode(displayId, width, height, refreshRate, includeHighDensityModes ? 1 : 0);
		if (d is null)
		{
			return null;
		}
		return *d;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayMode* _PInvokeGetClosestFullscreenDisplayMode(DisplayId displayId, int width, int height, float refreshRate, int includeHighDensityModes);

	/// <summary>
	/// Get information about the desktop's display mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDesktopDisplayMode">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query </param>
	/// <returns> The desktop display mode or null on error; call <see cref="GetError"/> for more information. </returns>
	public static DisplayMode? GetDesktopDisplayMode(DisplayId displayId)
	{
		DisplayMode* d = _PInvokeGetDesktopDisplayMode(displayId);
		if (d is null)
		{
			return null;
		}
		return *d;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDesktopDisplayMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayMode* _PInvokeGetDesktopDisplayMode(DisplayId displayId);

	/// <summary>
	/// Get information about the current display mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentDisplayMode">here</see>.
	/// </remarks>
	/// <param name="displayId"> The instance id of the display to query. </param>
	/// <returns> The desktop display mode or null on error; call <see cref="GetError"/> for more information. </returns>
	public static DisplayMode? GetCurrentDisplayMode(DisplayId displayId)
	{
		DisplayMode* d = _PInvokeGetCurrentDisplayMode(displayId);
		if (d is null)
		{
			return null;
		}
		return *d;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayMode* _PInvokeGetCurrentDisplayMode(DisplayId displayId);

	/// <summary>
	/// Get the display containing a point.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForPoint">here</see>.
	/// </remarks>
	/// <param name="point"> The point to query. </param>
	/// <returns> The instance id of the display containing the point or <see cref="DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static DisplayId GetDisplayForPoint(Point point)
	{
		return _PInvokeGetDisplayForPoint(&point);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForPoint")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayId _PInvokeGetDisplayForPoint(Point* point);

	/// <summary>
	/// Get the display primarily containing a rect.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForRect">here</see>.
	/// </remarks>
	/// <param name="rect"> The rect to query. </param>
	/// <returns> The instance id of the display entirely containing the rect or closest to the center of the rect on success or <see cref="DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static DisplayId GetDisplayForRect(Rect rect)
	{
		return _PInvokeGetDisplayForRect(&rect);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayId _PInvokeGetDisplayForRect(Rect* rect);

	/// <summary>
	/// Get the display associated with a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayForWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The instance id of the display containing the center of the window on success or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static DisplayId GetDisplayForWindow(Window* window)
	{
		return _PInvokeGetDisplayForWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayId _PInvokeGetDisplayForWindow(Window* window);

	/// <summary>
	/// Get the pixel density of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPixelDensity">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The pixel density or 0.0f on failure; call <see cref="GetError"/> for more information. </returns>
	public static float GetWindowPixelDensity(Window* window)
	{
		return _PInvokeGetWindowPixelDensity(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPixelDensity")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial float _PInvokeGetWindowPixelDensity(Window* window);

	/// <summary>
	/// Get the content display scale relative to a window's pixel size.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowDisplayScale">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The display scale, or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static float GetWindowDisplayScale(Window* window)
	{
		return _PInvokeGetWindowDisplayScale(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowDisplayScale")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial float _PInvokeGetWindowDisplayScale(Window* window);

	/// <summary>
	/// Set the display mode to use when a window is visible and fullscreen.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFullscreenMode">here</see>.
	/// </remarks>
	/// <param name="window"> The window to affect. </param>
	/// <param name="displayMode"> The display mode to use, which can be null for borderless fullscreen desktop mode, or one of the fullscreen modes returned by <see cref="GetFullscreenDisplayModes"/> to set an exclusive fullscreen mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetWindowFullscreenMode(Window* window, DisplayMode? displayMode)
	{
		if (displayMode.HasValue)
		{
			DisplayMode dm = displayMode.Value;
			return _PInvokeSetWindowFullscreenMode(window, &dm);
		}
		return _PInvokeSetWindowFullscreenMode(window, null);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreenMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowFullscreenMode(Window* window, DisplayMode* displayMode);

	/// <summary>
	/// Query the display mode to use when a window is visible at fullscreen.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFullscreenMode">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The exclusive fullscreen mode to use or null for borderless fullscreen desktop mode. </returns>
	public static DisplayMode? GetWindowFullscreenMode(Window* window)
	{
		DisplayMode* d = _PInvokeGetWindowFullscreenMode(window);
		if (d is null)
		{
			return null;
		}
		return *d;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFullscreenMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial DisplayMode* _PInvokeGetWindowFullscreenMode(Window* window);

	/// <summary>
	/// Get the pixel format associated with the window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPixelFormat">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The pixel format of the window on success or <see cref="PixelFormatEnum.Unknown"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PixelFormatValue GetWindowPixelFormat(Window* window)
	{
		return _PInvokeGetWindowPixelFormat(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPixelFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial PixelFormatValue _PInvokeGetWindowPixelFormat(Window* window);

	/// <summary>
	/// Create a window with the specified dimensions and flags.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindow">here</see>.
	/// </remarks>
	/// <param name="title"> The title of the window. </param>
	/// <param name="width"> The width of the window. </param>
	/// <param name="height"> The height of the window. </param>
	/// <param name="flags"> Zero or more <see cref="WindowFlags"/> OR'd together. </param>
	/// <returns> The window that was created or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Window* CreateWindow(string title, int width, int height, WindowFlags flags)
	{
		fixed (byte* t = Encoding.UTF8.GetBytes(title))
		{
			return _PInvokeCreateWindow(t, width, height, flags);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Window* _PInvokeCreateWindow(byte* title, int width, int height, WindowFlags flags);

	/// <summary>
	/// Create a child popup window of the specified parent window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePopupWindow">here</see>.
	/// </remarks>
	/// <param name="parent"> The parent of the window, must not be null. </param>
	/// <param name="offsetX"> The x position of the popup window relative to the origin of the parent window. </param>
	/// <param name="offsetY"> The y position of the popup window relative to the origin of the parent window. </param>
	/// <param name="width"> The width of the window </param>
	/// <param name="height"> The height of the window. </param>
	/// <param name="flags"> <see cref="WindowFlags.Tooltip"/> or <see cref="WindowFlags.PopupMenu"/> and zero or more <see cref="WindowFlags"/> OR'd together. </param>
	/// <returns> The window that was created or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Window* CreatePopupWindow(Window* parent, int offsetX, int offsetY, int width, int height, WindowFlags flags)
	{
		return _PInvokeCreatePopupWindow(parent, offsetX, offsetY, width, height, (uint)flags);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreatePopupWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Window* _PInvokeCreatePopupWindow(Window* parent, int offsetX, int offsetY, int width, int height, uint flags);

	/// <summary>
	/// Create a window with the specified properties.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropNames"/>; they have 'WINDOW_CREATE_' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowWithProperties">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to use. </param>
	/// <returns> The window that was created or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Window* CreateWindowWithProperties(PropertiesId props)
	{
		return _PInvokeCreateWindowWithProperties(props);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindowWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Window* _PInvokeCreateWindowWithProperties(PropertiesId props);

	/// <summary>
	/// Get the numeric id of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowID">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The id of the window on success or <see cref="WindowId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static WindowId GetWindowId(Window* window)
	{
		return _PInvokeGetWindowId(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial WindowId _PInvokeGetWindowId(Window* window);

	/// <summary>
	/// Get a window from a stored id.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFromID">here</see>.
	/// </remarks>
	/// <param name="id"> The id of the window. </param>
	/// <returns> The window associated with <paramref name="id"/> or null if it doesn't exist; call <see cref="GetError"/> for more information. </returns>
	public static Window* GetWindowFromId(WindowId id)
	{
		return GetWindowFromId(id);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFromID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Window* _PInvokeGetWindowFromId(WindowId id);

	/// <summary>
	/// Get parent of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowParent">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The parent of the window on success or null if the window has no parent. </returns>
	public static Window* GetWindowParent(Window* window)
	{
		return _PInvokeGetWindowParent(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowParent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Window* _PInvokeGetWindowParent(Window* window);

	/// <summary>
	/// Get the properties associated with a window.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropNames"/>; they have 'WINDOW_' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowProperties">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> A valid property id on success or <see cref="PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId GetWindowProperties(Window* window)
	{
		return _PInvokeGetWindowProperties(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial PropertiesId _PInvokeGetWindowProperties(Window* window);

	/// <summary>
	/// Get the window flags.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowFlags">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query </param>
	/// <returns> A mask of the <see cref="WindowFlags"/> associated with <paramref name="window"/>. </returns>
	public static WindowFlags GetWindowFlags(Window* window)
	{
		return _PInvokeGetWindowFlags(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFlags")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial WindowFlags _PInvokeGetWindowFlags(Window* window);

	/// <summary>
	/// Set the title of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowTitle">here</see>.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="title"> The desired window title. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowTitle(Window* window, string title)
	{
		fixed (byte* t = Encoding.UTF8.GetBytes(title))
		{
			return _PInvokeSetWindowTitle(window, t);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowTitle")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowTitle(Window* window, byte* title);

	/// <summary>
	/// Get the title of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowTitle">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The title of the window or an empty string if there is no title. </returns>
	public static string GetWindowTitle(Window* window)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetWindowTitle(window))!;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowTitle")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetWindowTitle(Window* window);

	/// <summary>
	/// Set the icon for a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowIcon">here</see>.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="surface"> A <see cref="Surface"/> structure containing the icon for the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowIcon(Window* window, Surface* surface)
	{
		return _PInvokeSetWindowIcon(window, surface);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowIcon")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowIcon(Window* window, Surface* icon);

	/// <summary>
	/// Request that the window's position be set.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowPosition">here</see>.
	/// </remarks>
	/// <param name="window"> The window to reposition. </param>
	/// <param name="x"> The x coordinate of the window, or <see cref="WINDOWPOS_CENTERED"/> or <see cref="WINDOWPOS_UNDEFINED"/>. </param>
	/// <param name="y"> The y coordinate of the window, or <see cref="WINDOWPOS_CENTERED"/> or <see cref="WINDOWPOS_UNDEFINED"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowPosition(Window* window, int x, int y)
	{
		return _PInvokeSetWindowPosition(window, x, y);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowPosition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowPosition(Window* window, int x, int y);

	/// <summary>
	/// Get the position of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPosition">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <param name="x"> Returns the x position of the window. </param>
	/// <param name="y"> Returns the y position of the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowPosition(Window* window, out int x, out int y)
	{
		fixed (int* xx = &x, yy = &y)
		{
			return _PInvokeGetWindowPosition(window, xx, yy);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPosition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowPosition(Window* window, int* x, int* y);

	/// <summary>
	/// Request that the size of a window's client area be set.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowSize">here</see>.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="width"> The width of the window, must be &gt; 0. </param>
	/// <param name="height"> The height of the window, must be &gt; 0. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowSize(Window* window, int width, int height)
	{
		return _PInvokeSetWindowSize(window, width, height);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowSize(Window* window, int width, int height);

	/// <summary>
	/// Get the size of a window's client area.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSize">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query the width and height from. </param>
	/// <param name="width"> Returns the width of the window. </param>
	/// <param name="height"> Returns the height of the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowSize(Window* window, out int width, out int height)
	{
		fixed (int* w = &width, h = &height)
		{
			return _PInvokeGetWindowSize(window, w, h);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowSize(Window* window, int* width, int* height);

	/// <summary>
	/// Get the size of a window's borders (decorations) around the client area.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowBordersSize">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query the size values of the border (decorations) from. </param>
	/// <param name="top"> Returns the size of the top border. </param>
	/// <param name="left"> Returns the size of the left border. </param>
	/// <param name="bottom"> Returns the size of the bottom border. </param>
	/// <param name="right"> Returns the size of the right border. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowBordersSize(Window* window, out int top, out int left, out int bottom, out int right)
	{
		fixed (int* t = &top, l = &left, b = &bottom, r = &right)
		{
			return _PInvokeGetWindowBordersSize(window, t, l, b, r);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowBordersSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowBordersSize(Window* window, int* top, int* left, int* bottom, int* right);

	/// <summary>
	/// Get the size of a window's client area, in pixels.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSizeInPixels">here</see>.
	/// </remarks>
	/// <param name="window"> The window from which the drawable size should be queried. </param>
	/// <param name="width"> Returns the width in pixels. </param>
	/// <param name="height"> Returns the height in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowSizeInPixels(Window* window, out int width, out int height)
	{
		fixed (int* w = &width, h = &height)
		{
			return _PInvokeGetWindowSizeInPixels(window, w, h);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSizeInPixels")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowSizeInPixels(Window* window, int* width, int* height);

	/// <summary>
	/// Set the minimum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMinimumSize">here</see>.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="minW"> The minimum width of the window, or 0 for no limit. </param>
	/// <param name="minH"> The minimum height of the window, or 0 for no limit. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowMinimumSize(Window* window, int minW, int minH)
	{
		return _PInvokeSetWindowMinimumSize(window, minW, minH);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMinimumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowMinimumSize(Window* window, int minW, int minH);

	/// <summary>
	/// Get the minimum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMinimumSize">here</see>.
	/// </remarks>
	/// <param name="widow"> The window to query. </param>
	/// <param name="width"> Returns the minimum width of the window. </param>
	/// <param name="height"> Returns the minimum height of the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowMinimumSize(Window* widow, out int width, out int height)
	{
		fixed (int* w = &width, h = &height)
		{
			return _PInvokeGetWindowMinimumSize(widow, w, h);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMinimumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowMinimumSize(Window* window, int* width, int* height);

	/// <summary>
	/// Set the maximum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMaximumSize">here</see>.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="maxW"> The maximum width of the window, or 0 for no limit. </param>
	/// <param name="maxH"> The maximum height of the window, or 0 for no limit. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowMaximumSize(Window* window, int maxW, int maxH)
	{
		return _PInvokeSetWindowMaximumSize(window, maxW, maxH);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMaximumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowMaximumSize(Window* window, int maxW, int maxH);

	/// <summary>
	/// Get the maximum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMaximumSize">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <param name="width"> Returns the maximum width of the window. </param>
	/// <param name="height"> Returns the maximum height of the window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowMaximumSize(Window* window, out int width, out int height)
	{
		fixed (int* w = &width, h = &height)
		{
			return _PInvokeGetWindowMaximumSize(window, w, h);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMaximumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowMaximumSize(Window* window, int* width, int* height);

	/// <summary>
	/// Set the border state of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowBordered">here</see>.
	/// </remarks>
	/// <param name="window"> The window of which to change the border state. </param>
	/// <param name="bordered"> False to remove border, true to add border. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowBordered(Window* window, bool bordered)
	{
		return _PInvokeSetWindowBordered(window, bordered ? 1 : 0);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowBordered")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowBordered(Window* window, int bordered);

	/// <summary>
	/// Set the user-resizable state of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowResizable">here</see>.
	/// </remarks>
	/// <param name="window"> The window of which to change the resizable state. </param>
	/// <param name="resizable"> True to allow resizing, false to disallow. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowResizable(Window* window, bool resizable)
	{
		return _PInvokeSetWindowResizable(window, resizable ? 1 : 0);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowResizable")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowResizable(Window* window, int resizable);

	/// <summary>
	/// Set the window to always be above the others.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowAlwaysOnTop">here</see>.
	/// </remarks>
	/// <param name="window"> The window of which to change the always on top state. </param>
	/// <param name="onTop"> True to set the window always on top, false to disable. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowAlwaysOnTop(Window* window, bool onTop)
	{
		return _PInvokeSetWindowAlwaysOnTop(window, onTop ? 1 : 0);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowAlwaysOnTop")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowAlwaysOnTop(Window* window, int onTop);

	/// <summary>
	/// Show a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ShowWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to show. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int ShowWindow(Window* window)
	{
		return _PInvokeShowWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeShowWindow(Window* window);

	/// <summary>
	/// Hide a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_HideWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to hide. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int HideWindow(Window* window)
	{
		return _PInvokeHideWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_HideWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeHideWindow(Window* window);

	/// <summary>
	/// Raise a window above other windows and set the input focus.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_RaiseWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to raise. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int RaiseWindow(Window* window)
	{
		return _PInvokeRaiseWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_RaiseWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeRaiseWindow(Window* window);

	/// <summary>
	/// Request that the window be made as large as possible.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_MaximizeWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to maximize. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int MaximizeWindow(Window* window)
	{
		return _PInvokeMaximizeWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_MaximizeWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeMaximizeWindow(Window* window);

	/// <summary>
	/// Request that the window be minimized to an iconic representation.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_MinimizeWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to minimize. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int MinimizeWindow(Window* window)
	{
		return _PInvokeMinimizeWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_MinimizeWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeMinimizeWindow(Window* window);

	/// <summary>
	/// Request that the size and position of a minimized or maximized window be restored.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_RestoreWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to restore. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int RestoreWindow(Window* window)
	{
		return _PInvokeRestoreWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_RestoreWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeRestoreWindow(Window* window);

	/// <summary>
	/// Request that the window's fullscreen state be changed.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFullscreen">here</see>.
	/// </remarks>
	/// <param name="window"> The window to change. </param>
	/// <param name="fullscreen"> True for fullscreen mode, false for windowed mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowFullscreen(Window* window, bool fullscreen)
	{
		return _PInvokeSetWindowFullscreen(window, fullscreen ? 1 : 0);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreen")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowFullscreen(Window* window, int fullscreen);

	/// <summary>
	/// Block until any pending window state is finalized.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SyncWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window for which to wait for the pending state to be applied. </param>
	/// <returns> 0 on success, a positive value if the operation timed out before the window was in the requested state, or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SyncWindow(Window* window)
	{
		return _PInvokeSyncWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SyncWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSyncWindow(Window* window);

	/// <summary>
	/// Return whether the window has a surface associated with it.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_WindowHasSurface">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> True if there is a surface associated with the window, or false otherwise. </returns>
	public static bool WindowHasSurface(Window* window)
	{
		return _PInvokeWindowHasSurface(window) == 1;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_WindowHasSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeWindowHasSurface(Window* window);

	/// <summary>
	/// Get the SDL surface associated with the window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSurface">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The surface associated with the window, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Surface* GetWindowSurface(Window* window)
	{
		return _PInvokeGetWindowSurface(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Surface* _PInvokeGetWindowSurface(Window* window);

	/// <summary>
	/// Copy the window surface to the screen.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateWindowSurface">here</see>.
	/// </remarks>
	/// <param name="window"> The window to update. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int UpdateWindowSurface(Window* window)
	{
		return _PInvokeUpdateWindowSurface(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeUpdateWindowSurface(Window* window);

	/// <summary>
	/// Copy areas of the window surface to the screen.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateWindowSurfaceRects">here</see>.
	/// </remarks>
	/// <param name="window"> The window to update. </param>
	/// <param name="rects"> An array of <see cref="Rect"/> structures representing areas of the surface to copy, in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int UpdateWindowSurfaceRects(Window* window, Rect[] rects)
	{
		fixed (Rect* r = rects)
		{
			return _PInvokeUpdateWindowSurfaceRects(window, r, rects.Length);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurfaceRects")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeUpdateWindowSurfaceRects(Window* window, Rect* rects, int numRects);

	/// <summary>
	/// Destroy the surface associated with the window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyWindowSurface">here</see>.
	/// </remarks>
	/// <param name="window"> The window to update. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int DestroyWindowSurface(Window* window)
	{
		return _PInvokeDestroyWindowSurface(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeDestroyWindowSurface(Window* window);

	/// <summary>
	/// Set a window's keyboard grab mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowKeyboardGrab">here</see>.
	/// </remarks>
	/// <param name="window"> The window for which the keyboard grab mode should be set. </param>
	/// <param name="grabbed"> This is true to grab keyboard, and false to release. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowKeyboardGrab(Window* window, bool grabbed)
	{
		return _PInvokeSetWindowKeyboardGrab(window, grabbed ? 1 : 0);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowKeyboardGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowKeyboardGrab(Window* window, int grabbed);

	/// <summary>
	/// Set a window's mouse grab mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMouseGrab">here</see>.
	/// </remarks>
	/// <param name="window"> The window for which the mouse grab mode should be set. </param>
	/// <param name="grabbed"> This is true to grab mouse, and false to release. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowMouseGrab(Window* window, bool grabbed)
	{
		return _PInvokeSetWindowMouseGrab(window, grabbed ? 1 : 0);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMouseGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowMouseGrab(Window* window, int grabbed);

	/// <summary>
	/// Get a window's keyboard grab mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowKeyboardGrab">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> True if keyboard is grabbed, and false otherwise. </returns>
	public static bool GetWindowKeyboardGrab(Window* window)
	{
		return _PInvokeGetWindowKeyboardGrab(window) == 1;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowKeyboardGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowKeyboardGrab(Window* window);

	/// <summary>
	/// Get a window's mouse grab mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMouseGrab">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> True if keyboard is grabbed, and false otherwise. </returns>
	public static bool GetWindowMouseGrab(Window* window)
	{
		return _PInvokeGetWindowMouseGrab(window) == 1;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMouseGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowMouseGrab(Window* window);

	/// <summary>
	/// Get the window that currently has an input grab enabled.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetGrabbedWindow">here</see>.
	/// </remarks>
	/// <returns> The window if input is grabbed or null otherwise. </returns>
	public static Window* GetGrabbedWindow()
	{
		return _PInvokeGetGrabbedWindow();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetGrabbedWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Window* _PInvokeGetGrabbedWindow();

	/// <summary>
	/// Confines the cursor to the specified area of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMouseRect">here</see>.
	/// </remarks>
	/// <param name="window"> The window that will be associated with the barrier. </param>
	/// <param name="rect"> A rectangle area in window-relative coordinates. If null, the barrier for the specified window will be destroyed. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowMouseRect(Window* window, Rect? rect)
	{
		// "the barrier [...] will be destroyed" undertale reference???
		// anyway more boring pinvoke shit.
		if (rect.HasValue)
		{
			Rect r = rect.Value;
			return _PInvokeSetWindowMouseRect(window, &r);
		}
		return _PInvokeSetWindowMouseRect(window, null);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMouseRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowMouseRect(Window* window, Rect* rect);

	/// <summary>
	/// Get the mouse confinement rectangle of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMouseRect">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The mouse confinement rectangle of a window, or null if there isn't one. </returns>
	public static Rect? GetWindowMouseRect(Window* window)
	{
		Rect* r = _PInvokeGetWindowMouseRect(window);
		if (r != null)
		{
			return *r;
		}
		return null;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMouseRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Rect* _PInvokeGetWindowMouseRect(void* window);

	/// <summary>
	/// Set the opacity for a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowOpacity">here</see>.
	/// </remarks>
	/// <param name="window"> The window which will be made transparent or opaque. </param>
	/// <param name="opacity"> The opacity value (0.0f - transparent, 1.0f - opaque). </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowOpacity(Window* window, float opacity)
	{
		return _PInvokeSetWindowOpacity(window, opacity);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowOpacity")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowOpacity(Window* window, float opacity);

	/// <summary>
	/// Get the opacity of a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowOpacity">here</see>.
	/// </remarks>
	/// <param name="window"> the window to get the current opacity value from. </param>
	/// <param name="opacity"> Returns the float filled in (0.0f - transparent, 1.0f - opaque). </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int GetWindowOpacity(Window* window, out float opacity)
	{
		fixed (float* o = &opacity)
		{
			return _PInvokeGetWindowOpacity(window, o);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowOpacity")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetWindowOpacity(Window* window, float* opacity);

	/// <summary>
	/// Set the window as a modal to a parent window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowModalFor">here</see>.
	/// </remarks>
	/// <param name="modalWindow"> The window that should be set modal. </param>
	/// <param name="parentWindow"> The parent window for the modal window. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowModalFor(Window* modalWindow, Window* parentWindow)
	{
		return _PInvokeSetWindowModalFor(modalWindow, parentWindow);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowModalFor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowModalFor(Window* modalWindow, Window* parentWindow);

	/// <summary>
	/// Explicitly set input focus to the window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowInputFocus">here</see>.
	/// </remarks>
	/// <param name="window"> The window that should get the input focus. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowInputFocus(Window* window)
	{
		return _PInvokeSetWindowInputFocus(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowInputFocus")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowInputFocus(Window* window);

	/// <summary>
	/// Set whether the window may have input focus.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFocusable">here</see>.
	/// </remarks>
	/// <param name="window"> The window to set focusable state. </param>
	/// <param name="focusable"> True to allow input focus, false to not allow input focus. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowFocusable(Window* window, bool focusable)
	{
		return _PInvokeSetWindowFocusable(window, focusable ? 1 : 0);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFocusable")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowFocusable(Window* window, int focusable);

	/// <summary>
	/// Display the system-level window menu.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ShowWindowSystemMenu">here</see>.
	/// </remarks>
	/// <param name="window"> The window for which the menu will be displayed. </param>
	/// <param name="x"> The x coordinate of the menu, relative to the origin (top-left) of the client area. </param>
	/// <param name="y"> The y coordinate of the menu, relative to the origin (top-left) of the client area. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int ShowWindowSystemMenu(Window* window, int x, int y)
	{
		return _PInvokeShowWindowSystemMenu(window, x, y);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindowSystemMenu")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeShowWindowSystemMenu(Window* window, int x, int y);

	// ADDME:SDL_HitTest
	// ADDME:SDL_HitTestResult
	// ADDME:SDL_SetWindowHitTest()

	/// <summary>
	/// Set the shape of a transparent window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowShape">here</see>.
	/// </remarks>
	/// <param name="window"> The window. </param>
	/// <param name="shape"> The surface representing the shape of the window, or null to remove any current shape. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowShape(Window* window, Surface* shape)
	{
		if (shape is not null)
		{
			return _PInvokeSetWindowShape(window, shape);
		}
		return _PInvokeSetWindowShape(window, null);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowShape")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetWindowShape(Window* window, Surface* shape);

	/// <summary>
	/// Request a window to demand attention from the user.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FlashWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to be flashed. </param>
	/// <param name="operation"> The flash operation. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int FlashWindow(Window* window, FlashOperation operation)
	{
		return _PInvokeFlashWindow(window, operation);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_FlashWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeFlashWindow(Window* window, FlashOperation operation);

	/// <summary>
	/// Destroy a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to destroy. </param>
	public static void DestroyWindow(Window* window)
	{
		_PInvokeDestroyWindow(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeDestroyWindow(Window* window);

	/// <summary>
	/// Check whether the screensaver is currently enabled.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ScreenSaverEnabled">here</see>.
	/// </remarks>
	/// <returns> True if the screensaver is enabled, false if it is disabled. </returns>
	public static bool ScreenSaverEnabled()
	{
		return _PInvokeScreenSaverEnabled() == 1;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ScreenSaverEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeScreenSaverEnabled();

	/// <summary>
	/// Allow the screen to be blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_EnableScreenSaver">here</see>.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int EnableScreenSaver()
	{
		return _PInvokeEnableScreenSaver();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_EnableScreenSaver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeEnableScreenSaver();

	/// <summary>
	/// Prevent the screen from being blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DisableScreenSaver">here</see>.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int DisableScreenSaver()
	{
		return _PInvokeDisableScreenSaver();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_DisableScreenSaver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeDisableScreenSaver();

	/// <summary>
	/// Used to indicate that you don't care what the window position is.
	/// </summary>
	public const uint WINDOWPOS_UNDEFINED = WINDOWPOS_UNDEFINED_MASK;

	/// <summary>
	/// Used to indicate that the window position should be centered.
	/// </summary>
	public const uint WINDOWPOS_CENTERED = WINDOWPOS_CENTERED_MASK;

	private const uint WINDOWPOS_UNDEFINED_MASK = 0x1FFF0000u;
	private const uint WINDOWPOS_CENTERED_MASK = 0x2FFF0000u;
}