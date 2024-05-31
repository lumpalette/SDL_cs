using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_video.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_video.h.
unsafe partial class SDL
{
	partial class PropConsts
	{
		// CreateWindow() - WithProperties overload.
		public const string WindowCreateBooleanAlwaysOnTop = "always_on_top";
		public const string WindowCreateBooleanBorderless = "borderless";
		public const string WindowCreateBooleanCreateEGLWindow = "wayland.create_egl_window";
		public const string WindowCreateBooleanExternalGraphicsContext = "external_graphics_context";
		public const string WindowCreateBooleanFocusable = "focusable";
		public const string WindowCreateBooleanFullscreen = "fullscreen";
		public const string WindowCreateBooleanHidden = "hidden";
		public const string WindowCreateBooleanHighPixelDensity = "high_pixel_density";
		public const string WindowCreateBooleanMaximized = "maximized";
		public const string WindowCreateBooleanMenu = "menu";
		public const string WindowCreateBooleanMetal = "metal";
		public const string WindowCreateBooleanMinimized = "minimized";
		public const string WindowCreateBooleanModal = "modal";
		public const string WindowCreateBooleanMouseGrabbed = "mouse_grabbed";
		public const string WindowCreateBooleanOpenGL = "opengl";
		public const string WindowCreateBooleanResizable = "resizable";
		public const string WindowCreateBooleanTooltip = "tooltip";
		public const string WindowCreateBooleanTransparent = "transparent";
		public const string WindowCreateBooleanUtility = "utility";
		public const string WindowCreateBooleanVulkan = "vulkan";
		public const string WindowCreateBooleanWaylandSurfaceRoleCustom = "wayland.surface_role_custom";
		public const string WindowCreateNumberHeight = "height";
		public const string WindowCreateNumberWidth = "width";
		public const string WindowCreateNumberX = "x";
		public const string WindowCreateNumberX11Window = "x11.window";
		public const string WindowCreateNumberY = "y";
		public const string WindowCreatePointerCocoaView = "cocoa.view";
		public const string WindowCreatePointerCocoaWindow = "cocoa.window";
		public const string WindowCreatePointerParent = "parent";
		public const string WindowCreatePointerWaylandWLSurface = "wayland.wl_surface";
		public const string WindowCreatePointerWin32Hwnd = "win32.hwnd";
		public const string WindowCreatePointerWin32PixelFormatHwnd = "win32.pixel_format_hwnd";
		public const string WindowCreateStringTitle = "title";

		// GetWindowProperties()
		public const string WindowPointerShape = "SDL.window.shape";
		public const string WindowPointerAndroidWindow = "SDL.window.android.window";
		public const string WindowPointerAndroidSurface = "SDL.window.android.surface";
		public const string WindowPointerUIKitWindow = "SDL.window.uikit.window";
		public const string WindowNumberUIKitMetalViewTag = "SDL.window.uikit.metal_view_tag";
		public const string WindowNumberKmsDrmDeviceIndex = "SDL.window.kmsdrm.dev_index";
		public const string WindowNumberKmsDrmDrmFD = "SDL.window.kmsdrm.drm_fd";
		public const string WindowPointerKmsDrmGBMDevice = "SDL.window.kmsdrm.gbm_dev";
		public const string WindowPointerCocoaWindow = "SDL.window.cocoa.window";
		public const string WindowNumberCocoaMetalViewTag = "SDL.window.cocoa.metal_view_tag";
		public const string WindowPointerVivanteDisplay = "SDL.window.vivante.display";
		public const string WindowPointerVivanteWindow = "SDL.window.vivante.window";
		public const string WindowPointerVivanteSurface = "SDL.window.vivante.surface";
		public const string WindowPointerWinRTWindow = "SDL.window.winrt.window";
		public const string WindowPointerWin32Hwnd = "SDL.window.win32.hwnd";
		public const string WindowPointerWin32HDC = "SDL.window.win32.hdc";
		public const string WindowPointerWin32Instance = "SDL.window.win32.instance";
		public const string WindowPointerWaylandDisplay = "SDL.window.wayland.display";
		public const string WindowPointerWaylandSurface = "SDL.window.wayland.surface";
		public const string WindowPointerWaylandEGLWindow = "SDL.window.wayland.egl_window";
		public const string WindowPointerWaylandXDGSurface = "SDL.window.wayland.xdg_surface";
		public const string WindowPointerWaylandXDGTopLevel = "SDL.window.wayland.xdg_toplevel";
		public const string WindowStringWaylandXDGTopLevelExportHandle = "SDL.window.wayland.xdg_toplevel_export_handle";
		public const string WindowPointerWaylandXDGPopup = "SDL.window.wayland.xdg_popup";
		public const string WindowPointerWaylandXDGPositioner = "SDL.window.wayland.xdg_positioner";
		public const string WindowPointerX11Display = "SDL.window.x11.display";
		public const string WindowNumberX11Screen = "SDL.window.x11.screen";
		public const string WindowNumberX11Window = "SDL.window.x11.window";
	}

	/// <summary>
	/// The struct used as a handle to a window. This structure is an opaque type.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Window">here</see>.
	/// </remarks>
	public readonly struct Window;

	/// <summary>
	/// Represents an id for a display. The structure is a wrapper for an unsigned 32-bit integer.
	/// </summary>
	public readonly struct DisplayId // CHECK:wrapper
	{
		internal DisplayId(uint value)
		{
			_value = value;
		}
		
		/// <inheritdoc/>
		public override bool Equals([NotNullWhen(true)] object? obj)
		{
			if (obj is DisplayId cast)
			{
				return _value == cast._value;
			}
			return false;
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}

		public static explicit operator uint(DisplayId x) => x._value;
		public static explicit operator DisplayId(uint x) => new(x);

		public static bool operator ==(DisplayId a, DisplayId b) => a._value == b._value;
		public static bool operator !=(DisplayId a, DisplayId b) => a._value != b._value;

		/// <summary>
		/// An invalid id for a display.
		/// </summary>
		/// <remarks>
		/// This is used when a function that returns a <see cref="DisplayId"/> instance fails.
		/// </remarks>
		public static DisplayId Invalid => new(0);

		private readonly uint _value;
	}

	/// <summary>
	/// Represents the internal id of a window. The structure is a wrapper for an unsigned 32-bit integer.
	/// </summary>
	public readonly struct WindowId // CHECK:wrapper
	{
		internal WindowId(uint value)
		{
			_value = value;
		}

		/// <inheritdoc/>
		public override bool Equals([NotNullWhen(true)] object? obj)
		{
			if (obj is WindowId cast)
			{
				return _value == cast._value;
			}
			return false;
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}

		public static explicit operator uint(WindowId x) => x._value;
		public static explicit operator WindowId(uint x) => new(x);

		public static bool operator ==(WindowId a, WindowId b) => a._value == b._value;
		public static bool operator !=(WindowId a, WindowId b) => a._value != b._value;

		/// <summary>
		/// An invalid id for a window.
		/// </summary>
		/// <remarks>
		/// This is used when a function that returns a <see cref="WindowId"/> instance fails.
		/// </remarks>
		public static WindowId Invalid => new(0);

		private readonly uint _value;
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
	public static uint GetWindowPosUndefinedDisplay(uint displayIndex)
	{
		return WindowPosUndefinedMask | displayIndex;
	}

	[Macro]
	public static bool IsWindowPosUndefined(uint position)
	{
		return (position & 0xFFFF0000) == WindowPosUndefinedMask;
	}

	[Macro]
	public static uint GetWindowPosCenteredDisplay(uint displayIndex)
	{
		return WindowPosCenteredMask | displayIndex;
	}

	[Macro]
	public static bool IsWindowPosCentered(uint position)
	{
		return (position & 0xFFFF0000) == WindowPosCenteredMask;
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
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumVideoDrivers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

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
		return Marshal.PtrToStringUTF8((nint)_PInvoke(index))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetVideoDriver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(int index);
	}

	/// <summary>
	/// Get the name of the currently initialized video driver.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentVideoDriver">here</see>.
	/// </remarks>
	/// <returns> The name of the current video driver or null if no driver has been initialized. </returns>
	public static string? GetCurrentVideoDriver()
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke());

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentVideoDriver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke();
	}

	/// <summary>
	/// Get the current system theme.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSystemTheme">here</see>.
	/// </remarks>
	/// <returns> The current system theme, light, dark, or unknown. </returns>
	public static SystemTheme GetSystemTheme()
	{
		return (SystemTheme)_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetSystemTheme", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Get a list of currently connected displays.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplays">here</see>.
	/// </remarks>
	/// <param name="count"> Returns the number of displays returned. </param>
	/// <returns> An array of display instance ids, or null on error; call <see cref="GetError"/> for more information. </returns>
	public static DisplayId[]? GetDisplays(out int count)
	{
		fixed (int* c = &count)
		{
			DisplayId* d = _PInvoke(c);
			if (d is null)
			{
				return null;
			}
			var ids = new DisplayId[count];
			for (int i = 0; i < count; i++)
			{
				ids[i] = d[i];
			}
			Free(d);
			return ids;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplays", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayId* _PInvoke(int* count);
	}

	/// <summary>
	/// Return the primary display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetPrimaryDisplay">here</see>.
	/// </remarks>
	/// <returns> The instance id of the primary display on success or <see cref="DisplayId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static DisplayId GetPrimaryDisplay()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetPrimaryDisplay", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayId _PInvoke();
	}

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
		return _PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern PropertiesId _PInvoke(DisplayId displayId);
	}

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
		return Marshal.PtrToStringUTF8((nint)_PInvoke(displayId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(DisplayId displayId);
	}

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
			return _PInvoke(displayId, r);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayBounds", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(DisplayId displayId, Rect* rect);
	}

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
			return _PInvoke(displayId, r);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayUsableBounds", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(DisplayId displayId, Rect* rect);
	}

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
		return (DisplayOrientation)_PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetNaturalDisplayOrientation", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(DisplayId displayId);
	}

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
		return (DisplayOrientation)_PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(DisplayId displayId);
	}

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
		return _PInvoke(displayId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern float _PInvoke(DisplayId displayId);
	}

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
			DisplayMode** d = _PInvoke(displayId, c);
			if (d is null)
			{
				return null;
			}
			DisplayMode[] modes = new DisplayMode[count];
			for (int i = 0; i < count; i++)
			{
				modes[i] = *d[i];
			}
			Free(d);
			return modes;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetFullscreenDisplayModes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayMode** _PInvoke(DisplayId displayId, int* count);
	}

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
		DisplayMode* d = _PInvoke(displayId, width, height, refreshRate, includeHighDensityModes ? 1 : 0);
		if (d is null)
		{
			return null;
		}
		return *d;

		[DllImport(LibraryName, EntryPoint = "SDL_GetClosestFullscreenDisplayMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayMode* _PInvoke(DisplayId displayId, int width, int height, float refreshRate, int includeHighDensityModes);
	}

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
		DisplayMode* d = _PInvoke(displayId);
		if (d is null)
		{
			return null;
		}
		return *d;

		[DllImport(LibraryName, EntryPoint = "SDL_GetDesktopDisplayMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayMode* _PInvoke(DisplayId displayId);
	}

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
		DisplayMode* d = _PInvoke(displayId);
		if (d is null)
		{
			return null;
		}
		return *d;

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayMode* _PInvoke(DisplayId displayId);
	}

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
		return _PInvoke(&point);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForPoint", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayId _PInvoke(Point* point);
	}

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
		return _PInvoke(&rect);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayId _PInvoke(Rect* rect);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayId _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowPixelDensity", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern float _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowDisplayScale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern float _PInvoke(Window* window);
	}

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
			return _PInvoke(window, &dm);
		}
		return _PInvoke(window, null);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreenMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, DisplayMode* displayMode);
	}

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
		DisplayMode* d = _PInvoke(window);
		if (d is null)
		{
			return null;
		}
		return *d;

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowFullscreenMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern DisplayMode* _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowPixelFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern PixelFormatValue _PInvoke(Window* window);
	}

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
	public static Window* CreateWindow(string title, int width, int height, WindowFlags flags) // CHECK:overload
	{
		fixed (byte* t = Encoding.UTF8.GetBytes(title))
		{
			return _PInvoke(t, width, height, flags);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_CreateWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Window* _PInvoke(byte* title, int width, int height, WindowFlags flags);
	}

	/// <summary>
	/// Create a window with the specified properties.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropConsts"/>; they have 'WindowCreate' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowWithProperties">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to use. </param>
	/// <returns> The window that was created or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Window* CreateWindow(PropertiesId props) // CHECK:overload
	{
		return _PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateWindowWithProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Window* _PInvoke(PropertiesId props);
	}

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
		return _PInvoke(parent, offsetX, offsetY, width, height, (uint)flags);

		[DllImport(LibraryName, EntryPoint = "SDL_CreatePopupWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Window* _PInvoke(Window* parent, int offsetX, int offsetY, int width, int height, uint flags);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern WindowId _PInvoke(Window* window);
	}

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
		return _PInvoke(id);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowFromID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Window* _PInvoke(WindowId id);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowParent", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Window* _PInvoke(Window* window);
	}

	/// <summary>
	/// Get the properties associated with a window.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropConsts"/>; they have 'Window' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowProperties">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> A valid property id on success or <see cref="PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId GetWindowProperties(Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern PropertiesId _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowFlags", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern WindowFlags _PInvoke(Window* window);
	}

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
			return _PInvoke(window, t);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowTitle", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, byte* title);
	}

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
		return Marshal.PtrToStringUTF8((nint)_PInvoke(window))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowTitle", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(Window* window);
	}

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
		return _PInvoke(window, surface);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowIcon", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, Surface* icon);
	}

	/// <summary>
	/// Request that the window's position be set.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowPosition">here</see>.
	/// </remarks>
	/// <param name="window"> The window to reposition. </param>
	/// <param name="x"> The x coordinate of the window, or <see cref="WindowPosCentered"/> or <see cref="WindowPosUndefined"/>. </param>
	/// <param name="y"> The y coordinate of the window, or <see cref="WindowPosCentered"/> or <see cref="WindowPosUndefined"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int SetWindowPosition(Window* window, int x, int y)
	{
		return _PInvoke(window, x, y);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowPosition", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int x, int y);
	}

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
			return _PInvoke(window, xx, yy);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowPosition", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int* x, int* y);
	}

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
		return _PInvoke(window, width, height);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int width, int height);
	}

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
			return _PInvoke(window, w, h);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int* width, int* height);
	}

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
			return _PInvoke(window, t, l, b, r);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowBordersSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int* top, int* left, int* bottom, int* right);
	}

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
			return _PInvoke(window, w, h);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowSizeInPixels", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int* width, int* height);
	}

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
		return _PInvoke(window, minW, minH);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowMinimumSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int minW, int minH);
	}

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
			return _PInvoke(widow, w, h);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowMinimumSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int* width, int* height);
	}

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
		return _PInvoke(window, maxW, maxH);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowMaximumSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int maxW, int maxH);
	}

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
			return _PInvoke(window, w, h);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowMaximumSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int* width, int* height);
	}

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
		return _PInvoke(window, bordered ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowBordered", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int bordered);
	}

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
		return _PInvoke(window, resizable ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowResizable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int resizable);
	}

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
		return _PInvoke(window, onTop ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowAlwaysOnTop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int onTop);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_ShowWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_HideWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_RaiseWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_MaximizeWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_MinimizeWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_RestoreWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window, fullscreen ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int fullscreen);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_SyncWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_WindowHasSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Surface* _PInvoke(Window* window);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
			return _PInvoke(window, r, rects.Length);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurfaceRects", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, Rect* rects, int numRects);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyWindowSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window, grabbed ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowKeyboardGrab", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int grabbed);
	}

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
		return _PInvoke(window, grabbed ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowMouseGrab", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int grabbed);
	}

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
		return _PInvoke(window) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowKeyboardGrab", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowMouseGrab", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

	/// <summary>
	/// Get the window that currently has an input grab enabled.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetGrabbedWindow">here</see>.
	/// </remarks>
	/// <returns> The window if input is grabbed or null otherwise. </returns>
	public static Window* GetGrabbedWindow()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetGrabbedWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Window* _PInvoke();
	}

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
			return _PInvoke(window, &r);
		}
		return _PInvoke(window, null);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowMouseRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, Rect* rect);
	}

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
		Rect* r = _PInvoke(window);
		if (r != null)
		{
			return *r;
		}
		return null;

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowMouseRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Rect* _PInvoke(void* window);
	}

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
		return _PInvoke(window, opacity);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowOpacity", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, float opacity);
	}

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
			return _PInvoke(window, o);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetWindowOpacity", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, float* opacity);
	}

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
		return _PInvoke(modalWindow, parentWindow);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowModalFor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* modalWindow, Window* parentWindow);
	}

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
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowInputFocus", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window);
	}

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
		return _PInvoke(window, focusable ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowFocusable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int focusable);
	}

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
		return _PInvoke(window, x, y);

		[DllImport(LibraryName, EntryPoint = "SDL_ShowWindowSystemMenu", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, int x, int y);
	}

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
			return _PInvoke(window, shape);
		}
		return _PInvoke(window, null);

		[DllImport(LibraryName, EntryPoint = "SDL_SetWindowShape", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, Surface* shape);
	}

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
		return _PInvoke(window, operation);

		[DllImport(LibraryName, EntryPoint = "SDL_FlashWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Window* window, FlashOperation operation);
	}

	/// <summary>
	/// Destroy a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyWindow">here</see>.
	/// </remarks>
	/// <param name="window"> The window to destroy. </param>
	public static void DestroyWindow(Window* window)
	{
		_PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(Window* window);
	}

	/// <summary>
	/// Check whether the screensaver is currently enabled.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ScreenSaverEnabled">here</see>.
	/// </remarks>
	/// <returns> True if the screensaver is enabled, false if it is disabled. </returns>
	public static bool ScreenSaverEnabled()
	{
		return _PInvoke() == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_ScreenSaverEnabled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Allow the screen to be blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_EnableScreenSaver">here</see>.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int EnableScreenSaver()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_EnableScreenSaver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Prevent the screen from being blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DisableScreenSaver">here</see>.
	/// </remarks>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more informatiom. </returns>
	public static int DisableScreenSaver()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_DisableScreenSaver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Used to indicate that you don't care what the window position is.
	/// </summary>
	public static uint WindowPosUndefined => GetWindowPosUndefinedDisplay(0);

	/// <summary>
	/// Used to indicate that the window position should be centered.
	/// </summary>
	public static uint WindowPosCentered => GetWindowPosCenteredDisplay(0);

	public const uint WindowPosUndefinedMask = 0x1FFF0000u;

	public const uint WindowPosCenteredMask = 0x2FFF0000u;
}
