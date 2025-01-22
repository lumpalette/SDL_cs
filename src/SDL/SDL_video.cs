﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

// SDL_video.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_video.h.
namespace SDL3;

/// <summary>
/// This is a unique ID for a display for the time it is connected to the system, and is never reused for the lifetime of the application.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_DisplayId : uint
{
	/// <summary>
	/// An invalid/null display ID.
	/// </summary>
	Invalid = 0
}

/// <summary>
/// This is a unique ID for a window.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WindowID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_WindowId : uint
{
	/// <summary>
	/// An invalid/null window ID.
	/// </summary>
	Invalid = 0
}

/// <summary>
/// System theme.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SystemTheme">documentation</see> for more details.
/// </remarks>
public enum SDL_SystemTheme
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
/// Internal display mode data.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayModeData">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_DisplayModeData;

/// <summary>
/// The structure that defines a display mode.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayMode">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_DisplayMode
{
	/// <summary>
	/// The display this mode is associated with.
	/// </summary>
	public SDL_DisplayId DisplayId;

	/// <summary>
	/// Pixel format.
	/// </summary>
	public SDL_PixelFormat Format;

	/// <summary>
	/// Width.
	/// </summary>
	public int Width;

	/// <summary>
	/// Height.
	/// </summary>
	public int Height;

	/// <summary>
	/// Scale converting size to pixels (e.g. a 1920x1080 mode with 2.0 scale would have 3840x2160 pixels).
	/// </summary>
	public float PixelDensity;

	/// <summary>
	/// Refresh rate (or zero for unspecified).
	/// </summary>
	public float RefreshRate;

	/// <summary>
	/// Precise refresh rate numerator (or 0 for unspecified).
	/// </summary>
	public int RefreshRateNumerator;

	/// <summary>
	/// Precise refresh rate denominator
	/// </summary>
	public int RefreshRateDenominator;

	private readonly SDL_DisplayModeData* _internal;
}

/// <summary>
/// Display orientation values; the way a display is rotated.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayOrientation">documentation</see> for more details.
/// </remarks>
public enum SDL_DisplayOrientation
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
/// The struct used as an opaque handle to a window.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Window">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_Window;

/// <summary>
/// The flags on a window.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WindowFlags">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_WindowFlags : ulong
{
	/// <summary>
	/// No window flags.
	/// </summary>
	None,

	/// <summary>
	/// Window is in fullscreen mode.
	/// </summary>
	Fullscreen = 0x0000000000000001uL,

	/// <summary>
	/// Window usable with OpenGL context.
	/// </summary>
	OpenGL = 0x0000000000000002uL,

	/// <summary>
	/// Window is occluded.
	/// </summary>
	Occluded = 0x0000000000000004uL,

	/// <summary>
	/// Window is neither mapped onto the desktop nor shown in the taskbar/dock/window list;
	/// <see cref="SDL.ShowWindow(SDL_Window*)"/> is required for it to become visible.
	/// </summary>
	Hidden = 0x0000000000000008uL,

	/// <summary>
	/// No window decoration.
	/// </summary>
	Borderless = 0x0000000000000010uL,

	/// <summary>
	/// Window can be resized.
	/// </summary>
	Resizable = 0x0000000000000020uL,

	/// <summary>
	/// Window is minimized.
	/// </summary>
	Minimized = 0x0000000000000040uL,

	/// <summary>
	/// Window is maximized.
	/// </summary>
	Maximized = 0x0000000000000080uL,

	/// <summary>
	/// Window has grabbed mouse focus.
	/// </summary>
	MouseGrabbed = 0x0000000000000100uL,

	/// <summary>
	/// Window has input focus.
	/// </summary>
	InputFocus = 0x0000000000000200uL,

	/// <summary>
	/// Window has mouse focus.
	/// </summary>
	MouseFocus = 0x0000000000000400uL,

	/// <summary>
	/// Window not created by SDL.
	/// </summary>
	External = 0x0000000000000800uL,

	/// <summary>
	/// Window is modal.
	/// </summary>
	Modal = 0x0000000000001000uL,

	/// <summary>
	/// Window uses high pixel density back buffer if possible.
	/// </summary>
	HighPixelDensity = 0x0000000000002000uL,

	/// <summary>
	/// Window has mouse captured (unrelated to <see cref="MouseGrabbed"/>).
	/// </summary>
	MouseCapture = 0x0000000000004000uL,

	/// <summary>
	/// Window has relative mode enabled.
	/// </summary>
	MouseRelativeMode = 0x0000000000008000uL,

	/// <summary>
	/// Window should always be above others.
	/// </summary>
	AlwaysOnTop = 0x0000000000010000uL,

	/// <summary>
	/// Window should be treated as a utility window, not showing in the task bar and window list.
	/// </summary>
	Utility = 0x0000000000020000uL,

	/// <summary>
	/// Window should be treated as a tooltip and does not get mouse or keyboard focus, requires a parent window.
	/// </summary>
	Tooltip = 0x0000000000040000uL,

	/// <summary>
	/// Window should be treated as a popup menu, requires a parent window.
	/// </summary>
	PopupMenu = 0x0000000000080000uL,

	/// <summary>
	/// Window has grabbed keyboard input.
	/// </summary>
	KeyboardGrabbed = 0x0000000000100000uL,

	/// <summary>
	/// Window usable for Vulkan surface.
	/// </summary>
	Vulkan = 0x0000000010000000uL,

	/// <summary>
	/// Window usable for Metal view.
	/// </summary>
	Metal = 0x0000000020000000uL,

	/// <summary>
	/// Window with transparent buffer.
	/// </summary>
	Transparent = 0x0000000040000000uL,

	/// <summary>
	/// Window should not be focusable.
	/// </summary>
	NotFocusable = 0x0000000080000000uL
}

/// <summary>
/// Window flash operation.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlashOperation">documentation</see> for more details.
/// </remarks>
public enum SDL_FlashOperation
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

/// <summary>
/// An opaque handle to an OpenGL context.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLContext">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_GLContext;

/// <summary>
/// Opaque EGL type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGLDisplay">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_EGLDisplay;

/// <summary>
/// Opaque EGL type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGLDisplay">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_EGLConfig;

/// <summary>
/// Opaque EGL type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGLDisplay">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_EGLSurface;

/// <summary>
/// Opaque EGL type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGLDisplay">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_EGLAttrib;

/// <summary>
/// Opaque EGL type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EGLDisplay">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_EGLint;

/// <summary>
/// An enumeration of OpenGL configuration attributes.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLAttr">documentation</see> for more details.
/// </remarks>
public enum SDL_GLAttr
{
	/// <summary>
	/// The minimum number of bits for the red channel of the color buffer; defaults to 3.
	/// </summary>
	RedSize,

	/// <summary>
	/// The minimum number of bits for the green channel of the color buffer; defaults to 3.
	/// </summary>
	GreenSize,

	/// <summary>
	/// The minimum number of bits for the blue channel of the color buffer; defaults to 2.
	/// </summary>
	BlueSize,

	/// <summary>
	/// The minimum number of bits for the alpha channel of the color buffer; defaults to 0.
	/// </summary>
	AlphaSize,

	/// <summary>
	/// The minimum number of bits for frame buffer size; defaults to 0.
	/// </summary>
	BufferSize,

	/// <summary>
	/// Whether the output is single or double buffered; defaults to double buffering on.
	/// </summary>
	DoubleBuffer,

	/// <summary>
	/// The minimum number of bits in the depth buffer; defaults to 16.
	/// </summary>
	DepthSize,

	/// <summary>
	/// The minimum number of bits in the stencil buffer; defaults to 0.
	/// </summary>
	StencilSize,

	/// <summary>
	/// The minimum number of bits for the red channel of the accumulation buffer; defaults to 0.
	/// </summary>
	AccumRedSize,

	/// <summary>
	/// The minimum number of bits for the green channel of the accumulation buffer; defaults to 0.
	/// </summary>
	AccumGreenSize,

	/// <summary>
	/// The minimum number of bits for the blue channel of the accumulation buffer; defaults to 0.
	/// </summary>
	AccumBlueSize,

	/// <summary>
	/// The minimum number of bits for the alpha channel of the accumulation buffer; defaults to 0.
	/// </summary>
	AccumAlphaSize,

	/// <summary>
	/// Whether the output is stereo 3D; defaults to off.
	/// </summary>
	Stereo,

	/// <summary>
	/// The number of buffers used for multisample anti-aliasing; defaults to 0.
	/// </summary>
	MultisampleBuffers,

	/// <summary>
	/// The number of samples used around the current pixel used for multisample anti-aliasing.
	/// </summary>
	MultisampleSamples,

	/// <summary>
	/// Set to 1 to require hardware acceleration, set to 0 to force software rendering; defaults to allow either.
	/// </summary>
	AcceleratedVisual,

	/// <summary>
	/// Not used (deprecated).
	/// </summary>
	RetainedBacking,

	/// <summary>
	/// OpenGL context major version.
	/// </summary>
	ContextMajorVersion,

	/// <summary>
	/// OpenGL context minor version.
	/// </summary>
	ContextMinorVersion,

	/// <summary>
	/// Some combination of 0 or more of elements of the <see cref="SDL_GLContextFlag"/> enumeration; defaults to 0.
	/// </summary>
	ContextFlags,

	/// <summary>
	/// Type of GL context (Core, Compatibility, ES). See <see cref="SDL_GLProfile"/>; default value depends on platform.
	/// </summary>
	ContextProfileMask,

	/// <summary>
	/// OpenGL context sharing; defaults to 0.
	/// </summary>
	ShareWithCurrentContext,

	/// <summary>
	/// Requests sRGB capable visual; defaults to 0.
	/// </summary>
	FramebufferSRGBCapable,

	/// <summary>
	/// Sets context the release behavior. See <see cref="SDL_GLContextReleaseFlag"/>; defaults to FLUSH.
	/// </summary>
	ContextReleaseBehaviour,

	/// <summary>
	/// Set context reset notification. See SDL_GLContextResetNotification; defaults to NO_NOTIFICATION.
	/// </summary>
	ContextResetNotification,
	ContextNoError,
	Floatbuffers,
	EGLPlatform
}

/// <summary>
/// Possible values to be set for the <see cref="SDL_GLAttr.ContextProfileMask"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLProfile">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLProfile : uint
{
	/// <summary>
	/// OpenGL Core Profile context.
	/// </summary>
	ContextProfileCore = 0x0001,

	/// <summary>
	/// OpenGL Compatibility Profile context.
	/// </summary>
	ContextProfileCompatibility = 0x0002,

	/// <summary>
	/// GLX_CONTEXT_ES2_PROFILE_BIT_EXT.
	/// </summary>
	ContextProfileES = 0x0004
}

/// <summary>
/// Possible flags to be set for the <see cref="SDL_GLAttr.ContextFlags"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLContextFlag">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextFlag : uint
{
	ContextDebug = 0x0001,
	ContextForwardCompatible = 0x0002,
	ContextRobustAccess = 0x0004,
	ContextResetIsolation = 0x0008
}

/// <summary>
/// Possible values to be set for the <see cref="SDL_GLAttr.ContextReleaseBehaviour"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLContextReleaseFlag">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextReleaseFlag : uint
{
	ContextReleaseBehaviourNone = 0x0000,
	ContextReleaseBehaviourFlush = 0x0001,
}

/// <summary>
/// Possible values to be set <see cref="SDL_GLAttr.ContextResetNotification"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLContextResetNotification">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextResetNotification : uint
{
	ContextResetNoNotification = 0x0000,
	ContextResetLoseContext = 0x0001,
}

/// <summary>
/// Possible return values from the SDL_HitTest callback.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HitTestResult">documentation</see> for more details.
/// </remarks>
public enum SDL_HitTestResult
{
	/// <summary>
	/// Region is normal. No special properties.
	/// </summary>
	Normal,

	/// <summary>
	/// Region can drag entire window.
	/// </summary>
	Draggable,

	/// <summary>
	/// Region is the resizable top-left corner border.
	/// </summary>
	ResizeTopLeft,

	/// <summary>
	/// Region is the resizable top border.
	/// </summary>
	ResizeTop,

	/// <summary>
	/// Region is the resizable top-right corner border.
	/// </summary>
	ResizeTopRight,

	/// <summary>
	/// Region is the resizable right border.
	/// </summary>
	ResizeRight,

	/// <summary>
	/// Region is the resizable bottom-right corner border.
	/// </summary>
	BottomRight,

	/// <summary>
	/// Region is the resizable bottom border.
	/// </summary>
	Bottom,

	/// <summary>
	/// Region is the resizable bottom-left corner border.
	/// </summary>
	BottomLeft,

	/// <summary>
	/// Region is the resizable left border.
	/// </summary>
	ResizeLeft
}

unsafe partial class SDL
{
	partial class Prop
	{
		/// <summary>
		/// Properties used for <see cref="GetDisplayProperties(SDL_DisplayId)"/>.
		/// </summary>
		public static class Display
		{
			/// <summary>
			/// True if the display has HDR headroom above the SDR white point. This is for informational and diagnostic purposes only,
			/// as not all platforms provide this information at the display level.
			/// </summary>
			public const string HdrEnabledBoolean = "SDL.display.HDR_enabled";

			/// <summary>
			/// The "panel orientation" property for the display in degrees of clockwise rotation. Note that this is provided only as
			/// a hint, and the application is responsible for any coordinate transformations needed to conform to the requested
			/// display orientation.
			/// </summary>
			public const string KmsDrmPanelOrientationNumber = "SDL.display.KMSDRM.panel_orientation";
		}

		/// <summary>
		/// Properties used for <see cref="CreateWindowWithProperties(SDL_PropertiesId)"/>.
		/// </summary>
		public static class WindowCreate
		{
			/// <summary>
			/// True if the window should be always on top.
			/// </summary>
			public const string AlwaysOnTopBoolean = "SDL.window.create.always_on_top";

			/// <summary>
			/// True if the window has no window decoration.
			/// </summary>
			public const string BorderlessBoolean = "SDL.window.create.borderless";

			/// <summary>
			/// True if the window should accept keyboard input (defaults true).
			/// </summary>
			public const string FocusableBoolean = "SDL.window.create.focusable";

			/// <summary>
			/// True if the window will be used with an externally managed graphics context.
			/// </summary>
			public const string ExternalGraphicsContextBoolean = "SDL.window.create.external_graphics_context";

			/// <summary>
			/// TODO: write official doc for this.
			/// </summary>
			public const string FlagsNumber = "SDL.window.create.flags";

			/// <summary>
			/// True if the window should start in fullscreen mode at desktop resolution.
			/// </summary>
			public const string FullscreenBoolean = "fullscreen";

			/// <summary>
			/// The height of the window.
			/// </summary>
			public const string HeightNumber = "SDL.window.create.height";

			/// <summary>
			/// True if the window should start hidden.
			/// </summary>
			public const string HiddenBoolean = "SDL.window.create.hidden";

			/// <summary>
			/// True if the window uses a high pixel density buffer if possible.
			/// </summary>
			public const string HighPixelDensityBoolean = "SDL.window.create.high_pixel_density";

			/// <summary>
			/// True if the window should start maximized.
			/// </summary>
			public const string MaximizedBoolean = "SDL.window.create.maximized";

			/// <summary>
			/// True if the window is a popup menu.
			/// </summary>
			public const string MenuBoolean = "SDL.window.create.menu";

			/// <summary>
			/// True if the window will be used with Metal rendering.
			/// </summary>
			public const string MetalBoolean = "SDL.window.create.metal";

			/// <summary>
			/// True if the window should start minimized.
			/// </summary>
			public const string MinimizedBoolean = "SDL.window.create.minimized";

			/// <summary>
			/// True if the window is modal to its parent.
			/// </summary>
			public const string ModalBoolean = "SDL.window.create.modal";

			/// <summary>
			/// True if the window starts with grabbed mouse focus.
			/// </summary>
			public const string MouseGrabbedBoolean = "SDL.window.create.mouse_grabbed";

			/// <summary>
			/// True if the window will be used with OpenGL rendering.
			/// </summary>
			public const string OpenGLBoolean = "SDL.window.create.opengl";

			/// <summary>
			/// An <see cref="SDL_Window"/> that will be the parent of this window, required for windows with the
			/// "toolip", "menu", and "modal" properties.
			/// </summary>
			public const string ParentPointer = "SDL.window.create.parent";

			/// <summary>
			/// True if the window should be resizable.
			/// </summary>
			public const string ResizableBoolean = "SDL.window.create.resizable";

			/// <summary>
			/// The title of the window, in UTF-8 encoding.
			/// </summary>
			public const string TitleString = "SDL.window.create.title";

			/// <summary>
			/// True if the window show transparent in the areas with alpha of 0.
			/// </summary>
			public const string TransparentBoolean = "SDL.window.create.transparent";

			/// <summary>
			/// True if the window is a tooltip.
			/// </summary>
			public const string TooltipBoolean = "SDL.window.create.tooltip";

			/// <summary>
			/// True if the window is a utility window, not showing in the task bar and window list.
			/// </summary>
			public const string UtilityBoolean = "SDL.window.create.utility";

			/// <summary>
			/// True if the window will be used with Vulkan rendering.
			/// </summary>
			public const string VulkanBoolean = "SDL.window.create.vulkan";

			/// <summary>
			/// The width of the window.
			/// </summary>
			public const string WidthNumber = "SDL.window.create.width";

			/// <summary>
			/// The x position of the window, or <see cref="SDL.WindowposCentered"/>, defaults to <see cref="SDL.WindowposUndefined"/>.
			/// This is relative to the parent for windows with the "parent" property set.
			/// </summary>
			public const string XNumber = "SDL.window.create.x";

			/// <summary>
			/// The x position of the window, or <see cref="SDL.WindowposCentered"/>, defaults to <see cref="SDL.WindowposUndefined"/>.
			/// This is relative to the parent for windows with the "parent" property set.
			/// </summary>
			public const string YNumber = "SDL.window.create.y";

			/// <summary>
			/// The <c>(__unsafe_unretained) NSWindow</c> associated with the window, if you want to wrap an existing
			/// window.
			/// </summary>
			public const string CocoaWindowPointer = "SDL.window.create.cocoa.window";

			/// <summary>
			/// The <c>(__unsafe_unretained) NSView</c> associated with the window, defaults to
			/// <c>[window contentView]</c>.
			/// </summary>
			public const string CocoaViewPointer = "SDL.window.create.cocoa.view";

			/// <summary>
			/// True if the application wants to use the Wayland surface for a custom role and does not want it attached to an
			/// XDG toplevel window. See README/wayland for more information on using custom surfaces.
			/// </summary>
			public const string WaylandSurfaceRoleCustomBoolean = "SDL.window.create.wayland.surface_role_custom";

			/// <summary>
			/// True if the application wants an associated wl_egl_window object to be created, even if the window does not have
			/// the OpenGL property or flag set.
			/// </summary>
			public const string WaylandCreateEglWindowBoolean = "SDL.window.create.wayland.create_egl_window";

			/// <summary>
			/// The <c>wl_surface</c> associated with the window, if you want to wrap an existing window. See README/wayland for
			/// more information.
			/// </summary>
			public const string WaylandWLSurfacePointer = "SDL.window.create.wayland.wl_surface";

			/// <summary>
			/// The <c>HWND</c> associated with the window, if you want to wrap an existing window.
			/// </summary>
			public const string Win32HwndPointer = "SDL.window.create.win32.hwnd";

			/// <summary>
			/// Optional, another window to share pixel format with, useful for OpenGL windows.
			/// </summary>
			public const string Win32PixelFormatHwndPointer = "SDL.window.create.win32.pixel_format_hwnd";

			/// <summary>
			/// The X11 Window associated with the window, if you want to wrap an existing window.
			/// </summary>
			public const string X11WindowNumber = "SDL.window.create.x11.window";
		}

		/// <summary>
		/// Properties used for <see cref="GetWindowProperties(SDL_Window*)"/>.
		/// </summary>
		public static class Window
		{
			/// <summary>
			/// The surface associated with a shaped window.
			/// </summary>
			public const string ShapePointer = "SDL.window.shape";

			/// <summary>
			/// True if the window has HDR headroom above the SDR white point.
			/// </summary>
			/// <remarks>
			/// This property can change dynamically when <see cref="SDL_EventType.WindowHdrStateChanged"/> is sent.
			/// </remarks>
			public const string HdrEnabledBoolean = "SDL.window.HDR_enabled";

			/// <summary>
			/// The value of SDR white in the <see cref="SDL_Colorspace.SRGBLinear"/> colorspace.On Windows this corresponds to the
			/// SDR white level in scRGB colorspace, and on Apple platforms this is always 1.0 for EDR content. This property can
			/// change dynamically when <see cref="SDL_EventType.WindowHdrStateChanged"/> is sent.
			/// </summary>
			public const string SdrWhiteLevelFloat = "SDL.window.SDR_white_level";

			/// <summary>
			/// The additional high dynamic range that can be displayed, in terms of the SDR white point. When HDR is not
			/// enabled, this will be 1.0. This property can change dynamically when
			/// <see cref="SDL_EventType.WindowHdrStateChanged"/> is sent.
			/// </summary>
			public const string HdrHeadroomFloat = "SDL.window.HDR_headroom";

			/// <summary>
			/// The <c>ANativeWindow</c> associated with the window.
			/// </summary>
			public const string AndroidWindowPointer = "SDL.window.android.window";

			/// <summary>
			/// The <c>EGLSurface</c> associated with the window
			/// </summary>
			public const string AndroidSurfacePointer = "SDL.window.android.surface";

			/// <summary>
			/// The <c>(__unsafe_unretained) UIWindow</c> associated with the window.
			/// </summary> 
			public const string UIKitWindowPointer = "SDL.window.uikit.window";

			/// <summary>
			/// The <c>NSInteger</c> tag assocated with metal views on the window.
			/// </summary>
			public const string UIKitMetalViewTagNumber = "SDL.window.uikit.metal_view_tag";

			/// <summary>
			/// The OpenGL view's framebuffer object. It must be bound when rendering to the screen using OpenGL.
			/// </summary>
			public const string UIKitOpenGLFramebufferNumber = "SDL.window.uikit.opengl.framebuffer";

			/// <summary>
			/// The OpenGL view's renderbuffer object. It must be bound when <see cref="SDL.GL_SwapWindow(SDL_Window*)"/> is
			/// called.
			/// </summary>
			public const string UIKitOpenGLRenderbufferNumber = "SDL.window.uikit.opengl.renderbuffer";

			/// <summary>
			/// The OpenGL view's resolve framebuffer, when MSAA is used.
			/// </summary>
			public const string UIKitOpenGLResolveFramebufferNumber = "SDL.window.uikit.opengl.resolve_framebuffer";

			/// <summary>
			/// The device index associated with the window (e.g. the X in /dev/dri/cardX).
			/// </summary>
			public const string KmsDrmDeviceIndexNumber = "SDL.window.kmsdrm.dev_index";

			/// <summary>
			/// The DRM FD associated with the window.
			/// </summary>
			public const string KmsDrmDrmFDNumber = "SDL.window.kmsdrm.drm_fd";

			/// <summary>
			/// The GBM device associated with the window.
			/// </summary>
			public const string KmsDrmGbmDevicePointer = "SDL.window.kmsdrm.gbm_dev";

			/// <summary>
			/// The <c>(__unsafe_unretained) NSWindow</c> associated with the window.
			/// </summary>
			public const string CocoaWindowPointer = "SDL.window.cocoa.window";

			/// <summary>
			/// The <c>NSInteger</c> tag assocated with metal views on the window.
			/// </summary>
			public const string CocoaMetalViewTagNumber = "SDL.window.cocoa.metal_view_tag";

			/// <summary>
			/// The <c>EGLNativeDisplayType</c> associated with the window.
			/// </summary>
			public const string VivanteDisplayPointer = "SDL.window.vivante.display";

			/// <summary>
			/// The <c>EGLNativeWindowType</c> associated with the window.
			/// </summary>
			public const string VivanteWindowPointer = "SDL.window.vivante.window";

			/// <summary>
			/// The EGLSurface associated with the window.
			/// </summary>
			public const string VivanteSurfacePointer = "SDL.window.vivante.surface";

			/// <summary>
			/// The <c>HWND</c> associated with the window.
			/// </summary>
			public const string Win32HwndPointer = "SDL.window.win32.hwnd";

			/// <summary>
			/// The HDC associated with the window.
			/// </summary>
			public const string Win32HdcPointer = "SDL.window.win32.hdc";

			/// <summary>
			/// The <c>HINSTANCE</c> associated with the window.
			/// </summary>
			public const string Win32InstancePointer = "SDL.window.win32.instance";

			/// <summary>
			/// The <c>wl_display</c> associated with the window.
			/// </summary>
			public const string WaylandDisplayPointer = "SDL.window.wayland.display";

			/// <summary>
			/// The <c>wl_surface</c> associated with the window.
			/// </summary>
			public const string WaylandSurfacePointer = "SDL.window.wayland.surface";

			/// <summary>
			/// The <c>wp_viewport</c> associated with the window.
			/// </summary>
			public const string WaylandViewportPointer = "SDL.window.wayland.surface";

			/// <summary>
			/// The <c>wl_egl_window</c> associated with the window.
			/// </summary>
			public const string WaylandEglWindowPointer = "SDL.window.wayland.egl_window";

			/// <summary>
			/// The <c>xdg_surface</c> associated with the window.
			/// </summary>
			public const string WaylandXdgSurfacePointer = "SDL.window.wayland.xdg_surface";

			/// <summary>
			/// The <c>xdg_toplevel</c> role associated with the window.
			/// </summary>
			public const string WaylandXdgTopLevelPointer = "SDL.window.wayland.xdg_toplevel";

			/// <summary>
			/// The export handle associated with the window.
			/// </summary>
			public const string WaylandXdgTopLevelExportHandleString = "SDL.window.wayland.xdg_toplevel_export_handle";

			/// <summary>
			/// The <c>xdg_popup</c> role associated with the window.
			/// </summary>
			public const string WaylandXdgPopupPointer = "SDL.window.wayland.xdg_popup";

			/// <summary>
			/// The <c>xdg_positioner</c> associated with the window, in popup mode.
			/// </summary>
			public const string WaylandXdgPositionerPointer = "SDL.window.wayland.xdg_positioner";

			/// <summary>
			/// The X11 Display associated with the window.
			/// </summary>
			public const string X11DisplayPointer = "SDL.window.x11.display";

			/// <summary>
			/// The screen number associated with the window.
			/// </summary>
			public const string X11ScreenNumber = "SDL.window.x11.screen";

			/// <summary>
			/// The X11 Window associated with the window.
			/// </summary>
			public const string X11WindowNumber = "SDL.window.x11.window";
		}

		/// <summary>
		/// The pointer to the global <c>wl_display</c> object used by the Wayland video backend.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PROP_GLOBAL_VIDEO_WAYLAND_WL_DISPLAY_POINTER">documentation</see> for more details.
		/// </remarks>
		public const string VideoWaylandWLDisplayPointer = "SDL.video.wayland.wl_display";
	}

	/// <summary>
	/// Used to indicate that you don't care what the window position is.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WINDOWPOS_UNDEFINED_MASK">documentation</see> for more details.
	/// </remarks>
	public const uint WindowposUndefinedMask = 0x1FFF0000u;

	public static uint WindowposUndefinedDisplay(SDL_DisplayId x) => WindowposUndefinedMask | (uint)x;

	/// <summary>
	/// Used to indicate that you don't care what the window position is.
	/// </summary>
	public static uint WindowposUndefined => WindowposUndefinedDisplay(0);

	public static bool WindowposIsUndefined(uint x) => (x & 0xFFFF0000) == WindowposUndefinedMask;

	/// <summary>
	/// Used to indicate that the window position should be centered.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WINDOWPOS_CENTERED_MASK">documentation</see> for more details.
	/// </remarks>
	public const uint WindowposCenteredMask = 0x2FFF0000u;

	public static uint WindowposCenteredDisplay(SDL_DisplayId x) => WindowposCenteredMask | (uint)x;

	/// <summary>
	/// Used to indicate that the window position should be centered.
	/// </summary>
	public static uint WindowposCentered => WindowposCenteredDisplay(0);

	public static bool WindowposIsCentered(uint x) => (x & 0xFFFF0000) == WindowposCenteredMask;

	/// <summary>
	/// Get the number of video drivers compiled into SDL.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumVideoDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>The number of built in video drivers.</returns>
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
	/// <param name="count">A pointer filled in with the number of displays returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of display instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplays")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayId* GetDisplays(int* count);

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
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayBounds")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetDisplayBounds(SDL_DisplayId instanceId, SDL_Rect* rect);

	/// <summary>
	/// Get the usable desktop area represented by a display, in screen coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetDisplayUsableBounds">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The instance ID of the display to query.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure filled in with the display bounds.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayUsableBounds")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetDisplayUsableBounds(SDL_DisplayId instanceId, SDL_Rect* rect);

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
	/// <param name="count">A pointer filled in with the number of display modes returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of display mode pointers or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This is a single allocation that should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetFullscreenDisplayModes")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_DisplayMode** GetFullscreenDisplayModes(SDL_DisplayId instanceId, int* count);

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
	/// <param name="closest">A pointer filled in with the closest display mode equal to or larger than the desired mode.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetClosestFullscreenDisplayMode(SDL_DisplayId instanceId, int width, int height, float refreshRate, [MarshalAs(BoolSize)] bool includeHighDensityModes, SDL_DisplayMode* closest);

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
	[return: Const]
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
	[return: Const]
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
	public static partial SDL_DisplayId GetDisplayForPoint([Const] SDL_Point* point);

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
	public static partial SDL_DisplayId GetDisplayForRect([Const] SDL_Rect* rect);

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
	/// <param name="mode">A pointer to the display mode to use, which can be <see langword="null"/> for borderless fullscreen desktop mode, or one of the fullscreen modes returned by <see cref="GetFullscreenDisplayModes(SDL_DisplayId, int*)"/> to set an exclusive fullscreen mode.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreenMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowFullscreenMode(SDL_Window* window, [Const] SDL_DisplayMode* mode);

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
	[return: Const]
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
	public static partial nint GetWindowICCProfile(SDL_Window* window, nuint* size);

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
	/// <returns>A null-terminated array of window pointers or <see langword="null"/> on error; call <see cref="GetError"/> for more details. This is a single allocation that should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindows")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window** GetWindows(int* count);

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
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowTitle", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowTitle(SDL_Window* window, string title);

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
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowIcon")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

	/// <summary>
	/// Request that the window's position be set.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowPosition">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to reposition.</param>
	/// <param name="x">The x coordinate of the window, or <see cref="WindowposCentered"/> or <see cref="WindowposUndefined"/>.</param>
	/// <param name="y">The y coordinate of the window, or <see cref="WindowposCentered"/> or <see cref="WindowposUndefined"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowPosition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowPosition(SDL_Window* window, int x, int y);

	/// <summary>
	/// Get the position of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowPosition">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="x">A pointer filled in with the x position of the window, may be <see langword="null"/>.</param>
	/// <param name="y">A pointer filled in with the y position of the window, may be <see langword="null"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPosition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowPosition(SDL_Window* window, int* x, int* y);

	/// <summary>
	/// Request that the size of a window's client area be set.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="width">The width of the window, must be greater than 0.</param>
	/// <param name="height">The height of the window, must be greater than 0.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowSize(SDL_Window* window, int width, int height);

	/// <summary>
	/// Get the size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query the width and height from.</param>
	/// <param name="width">A pointer filled in with the width of the window, may be <see langword="null"/>.</param>
	/// <param name="height">A pointer filled in with the height of the window, may be <see langword="null"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowSize(SDL_Window* window, int* width, int* height);

	/// <summary>
	/// Get the safe area for this window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSafeArea">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="rect">A pointer filled in with the client area that is safe for interactive content.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSafeArea")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowSafeArea(SDL_Window* window, SDL_Rect* rect);

	/// <summary>
	/// Request that the aspect ratio of a window's client area be set.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowAspectRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="minAspect">The minimum aspect ratio of the window, or 0.0f for no limit.</param>
	/// <param name="maxAspect">The maximum aspect ratio of the window, or 0.0f for no limit.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowAspectRatio")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowAspectRatio(SDL_Window* window, float minAspect, float maxAspect);

	/// <summary>
	/// Get the size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowAspectRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query the width and height from.</param>
	/// <param name="minAspect">A pointer filled in with the minimum aspect ratio of the window, may be <see langword="null"/>.</param>
	/// <param name="maxAspect">A pointer filled in with the maximum aspect ratio of the window, may be <see langword="null"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowAspectRatio")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowAspectRatio(SDL_Window* window, float* minAspect, float* maxAspect);

	/// <summary>
	/// Get the size of a window's borders (decorations) around the client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowBordersSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query the size values of the border (decorations) from.</param>
	/// <param name="top">Pointer to variable for storing the size of the top border; <see langword="null"/> is permitted.</param>
	/// <param name="left">Pointer to variable for storing the size of the left border; <see langword="null"/> is permitted.</param>
	/// <param name="bottom">Pointer to variable for storing the size of the bottom border; <see langword="null"/> is permitted.</param>
	/// <param name="right">Pointer to variable for storing the size of the right border; <see langword="null"/> is permitted.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowBordersSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right);

	/// <summary>
	/// Get the size of a window's client area, in pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSizeInPixels">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window from which the drawable size should be queried.</param>
	/// <param name="width">A pointer to variable for storing the width in pixels, may be <see langword="null"/>.</param>
	/// <param name="height">A pointer to variable for storing the height in pixels, may be <see langword="null"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSizeInPixels")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowSizeInPixels(SDL_Window* window, int* width, int* height);

	/// <summary>
	/// Set the minimum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMinimumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="minWidth">The minimum width of the window, or 0 for no limit.</param>
	/// <param name="minHeight">The minimum height of the window, or 0 for no limit.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMinimumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowMinimumSize(SDL_Window* window, int minWidth, int minHeight);

	/// <summary>
	/// Get the minimum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMinimumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="minWidth">A pointer filled in with the minimum width of the window, may be <see langword="null"/>.</param>
	/// <param name="minHeight">A pointer filled in with the minimum height of the window, may be <see langword="null"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMinimumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowMinimumSize(SDL_Window* window, int* minWidth, int* minHeight);

	/// <summary>
	/// Set the maximum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMaximumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="maxWidth">The maximum width of the window, or 0 for no limit.</param>
	/// <param name="maxHeight">The maximum height of the window, or 0 for no limit.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMaximumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowMaximumSize(SDL_Window* window, int maxWidth, int maxHeight);

	/// <summary>
	/// Get the maximum size of a window's client area.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowMaximumSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="maxWidth">A pointer filled in with the maximum width of the window, may be <see langword="null"/>.</param>
	/// <param name="maxHeight">A pointer filled in with the maximum height of the window, may be <see langword="null"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMaximumSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowMaximumSize(SDL_Window* window, int* maxWidth, int* maxHeight);

	/// <summary>
	/// Set the border state of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowBordered">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window of which to change the border state.</param>
	/// <param name="bordered">False to remove border, true to add border.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowBordered")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowBordered(SDL_Window* window, [MarshalAs(BoolSize)] bool bordered);

	/// <summary>
	/// Set the user-resizable state of a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowResizable">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window of which to change the resizable state.</param>
	/// <param name="resizable">True to allow resizing, false to disallow.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowResizable")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowResizable(SDL_Window* window, [MarshalAs(BoolSize)] bool resizable);

	/// <summary>
	/// Set the window to always be above the others.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowAlwaysOnTop">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window of which to change the always on top state.</param>
	/// <param name="onTop">True to set the window always on top, false to disable.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowAlwaysOnTop")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowAlwaysOnTop(SDL_Window* window, [MarshalAs(BoolSize)] bool onTop);

	/// <summary>
	/// Show a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to show.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool ShowWindow(SDL_Window* window);

	/// <summary>
	/// Hide a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HideWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to hide.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HideWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool HideWindow(SDL_Window* window);

	/// <summary>
	/// Request that a window be raised above other windows and gain the input focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RaiseWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to raise.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RaiseWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool RaiseWindow(SDL_Window* window);

	/// <summary>
	/// Request that the window be made as large as possible.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MaximizeWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to maximize.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MaximizeWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool MaximizeWindow(SDL_Window* window);

	/// <summary>
	/// Request that the window be minimized to an iconic representation.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MinimizeWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to minimize.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MinimizeWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool MinimizeWindow(SDL_Window* window);

	/// <summary>
	/// Request that the size and position of a minimized or maximized window be restored.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RestoreWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to restore.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RestoreWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool RestoreWindow(SDL_Window* window);

	/// <summary>
	/// Request that the window's fullscreen state be changed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFullscreen">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <param name="fullscreen">True for fullscreen mode, false for windowed mode.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreen")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowFullscreen(SDL_Window* window, [MarshalAs(BoolSize)] bool fullscreen);

	/// <summary>
	/// Block until any pending window state is finalized.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SyncWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which to wait for the pending state to be applied.</param>
	/// <returns>True on success or false if the operation timed out before the window was in the requested state.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SyncWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SyncWindow(SDL_Window* window);

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
	[return: MarshalAs(BoolSize)]
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
	/// Please refer to <see cref="SetWindowSurfaceVSync(SDL_Window*, int)"/> for details.
	/// </summary>
	public const int WindowSurfaceVSyncDisabled = 0;

	/// <summary>
	/// Please refer to <see cref="SetWindowSurfaceVSync(SDL_Window*, int)"/> for details.
	/// </summary>
	public const int WindowSurfaceVSyncAdaptive = -1;

	/// <summary>
	/// Toggle VSync for the window surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowSurfaceVSync">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window.</param>
	/// <param name="vsync">The vertical refresh sync interval.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowSurfaceVSync")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowSurfaceVSync(SDL_Window* window, int vsync);

	/// <summary>
	/// Get VSync for the window surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetWindowSurfaceVSync">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <param name="vsync">An int filled with the current vertical refresh sync interval. See <see cref="SetWindowSurfaceVSync(SDL_Window*, int)"/> for the meaning of the value.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSurfaceVSync")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetWindowSurfaceVSync(SDL_Window* window, int* vsync);

	/// <summary>
	/// Copy the window surface to the screen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to update.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool UpdateWindowSurface(SDL_Window* window);

	/// <summary>
	/// Copy areas of the window surface to the screen.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateWindowSurfaceRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to update.</param>
	/// <param name="rects">An array of <see cref="SDL_Rect"/> structures representing areas of the surface to copy, in pixels.</param>
	/// <param name="numRects">The number of rectangles.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurfaceRects")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool UpdateWindowSurfaceRects(SDL_Window* window, [Const] SDL_Rect* rects, int numRects);

	/// <summary>
	/// Destroy the surface associated with the window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyWindowSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to update.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyWindowSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool DestroyWindowSurface(SDL_Window* window);

	/// <summary>
	/// Set a window's keyboard grab mode.
	/// </summary>
	/// <param name="window">The window for which the keyboard grab mode should be set.</param>
	/// <param name="grabbed">This is true to grab keyboard, and false to release.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowKeyboardGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowKeyboardGrab(SDL_Window* window, [MarshalAs(BoolSize)] bool grabbed);

	/// <summary>
	/// Set a window's mouse grab mode.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowMouseGrab">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which the mouse grab mode should be set.</param>
	/// <param name="grabbed">This is true to grab mouse, and false to release.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMouseGrab")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowMouseGrab(SDL_Window* window, [MarshalAs(BoolSize)] bool grabbed);

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
	[return: MarshalAs(BoolSize)]
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
	[return: MarshalAs(BoolSize)]
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
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMouseRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowMouseRect(SDL_Window* window, [Const] SDL_Rect* rect);

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
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowOpacity")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowOpacity(SDL_Window* window, float opacity);

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
	/// Set the window as a child of a parent window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowParent">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window that should become the child of a parent.</param>
	/// <param name="parent">The new parent window for the child window.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowParent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowParent(SDL_Window* window, SDL_Window* parent);

	/// <summary>
	/// Toggle the state of the window as modal.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowModal">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window on which to set the modal state.</param>
	/// <param name="modal">True to toggle modal status on, false to toggle it off.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowModal")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowModal(SDL_Window* window, [MarshalAs(BoolSize)] bool modal);

	/// <summary>
	/// Set whether the window may have input focus.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowFocusable">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to set focusable state.</param>
	/// <param name="focusable">True to allow input focus, false to not allow input focus.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFocusable")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowFocusable(SDL_Window* window, [MarshalAs(BoolSize)] bool focusable);

	/// <summary>
	/// Display the system-level window menu.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowWindowSystemMenu">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window for which the menu will be displayed.</param>
	/// <param name="x">The x coordinate of the menu, relative to the origin (top-left) of the client area.</param>
	/// <param name="y">The y coordinate of the menu, relative to the origin (top-left) of the client area.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindowSystemMenu")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool ShowWindowSystemMenu(SDL_Window* window, int x, int y);

	/// <summary>
	/// Provide a callback that decides if a window region has special properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowHitTest">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to set hit-testing on.</param>
	/// <param name="callback">The function to call when doing a hit-test.</param>
	/// <param name="callbackData">An app-defined void pointer passed to <paramref name="callback"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowHitTest")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowHitTest(SDL_Window* window, delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, nint, SDL_HitTestResult> callback, nint callbackData);

	/// <summary>
	/// Set the shape of a transparent window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetWindowShape">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window.</param>
	/// <param name="surface">The surface representing the shape of the window, or <see langword="null"/> to remove any current shape.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowShape")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool SetWindowShape(SDL_Window* window, SDL_Surface* surface);

	/// <summary>
	/// Request a window to demand attention from the user.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlashWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to be flashed.</param>
	/// <param name="operation">The operation to perform.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FlashWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

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
	[return: MarshalAs(BoolSize)]
	public static partial bool ScreenSaverEnabled();

	/// <summary>
	/// Allow the screen to be blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EnableScreenSaver">documentation</see> for more details.
	/// </remarks>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EnableScreenSaver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool EnableScreenSaver();

	/// <summary>
	/// Prevent the screen from being blanked by a screen saver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisableScreenSaver">documentation</see> for more details.
	/// </remarks>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DisableScreenSaver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool DisableScreenSaver();

	/// <summary>
	/// Dynamically load an OpenGL library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_LoadLibrary">documentation</see> for more details.
	/// </remarks>
	/// <param name="path">The platform dependent OpenGL library name, or <see langword="null"/> to open the default OpenGL library.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_LoadLibrary", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GL_LoadLibrary(string? path);

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
	[return: MarshalAs(BoolSize)]
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
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SetAttribute")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GL_SetAttribute(SDL_GLAttr attr, int value);

	/// <summary>
	/// Get the actual value for an attribute from the current context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_GetAttribute">documentation</see> for more details.
	/// </remarks>
	/// <param name="attr">An <see cref="SDL_GLAttr"/> enum value specifying the OpenGL attribute to get.</param>
	/// <param name="value">A pointer filled in with the current value of <paramref name="attr"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetAttribute")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GL_GetAttribute(SDL_GLAttr attr, int* value);

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
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_MakeCurrent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GL_MakeCurrent(SDL_Window* window, SDL_GLContext* context);

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
	/// <param name="platformAttribCallback">Callback for attributes to pass to <c>eglGetPlatformDisplay</c>, may be <see langword="null"/>.</param>
	/// <param name="surfaceAttribCallback">Callback for attributes to pass to <c>eglCreateSurface</c>, may be <see langword="null"/>.</param>
	/// <param name="contextAttribCallback">Callback for attributes to pass to <c>eglCreateContext</c>, may be <see langword="null"/>.</param>
	/// <param name="userData">A pointer that is passed to the callbacks.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void EGL_SetAttributeCallbacks(delegate* unmanaged[Cdecl]<nint, SDL_EGLAttrib*> platformAttribCallback, delegate* unmanaged[Cdecl]<nint, SDL_EGLDisplay*, SDL_EGLConfig*, SDL_EGLint*> surfaceAttribCallback, delegate* unmanaged[Cdecl]<nint, SDL_EGLDisplay*, SDL_EGLConfig*, SDL_EGLint*> contextAttribCallback, nint userData);

	/// <summary>
	/// Set the swap interval for the current OpenGL context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_SetSwapInterval">documentation</see> for more details.
	/// </remarks>
	/// <param name="interval">0 for immediate updates, 1 for updates synchronized with the vertical retrace, -1 for adaptive vsync.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SetSwapInterval")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GL_SetSwapInterval(int interval);

	/// <summary>
	/// Get the swap interval for the current OpenGL context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_GetSwapInterval">documentation</see> for more details.
	/// </remarks>
	/// <param name="interval">Output interval value. 0 if there is no vertical retrace synchronization, 1 if the buffer swap is synchronized with the vertical retrace, and -1 if late swaps happen immediately instead of waiting for the next retrace.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetSwapInterval")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GL_GetSwapInterval(int* interval);

	/// <summary>
	/// Update a window with OpenGL rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_SwapWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to change.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_SwapWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GL_SwapWindow(SDL_Window* window);

	/// <summary>
	/// Delete an OpenGL context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GL_DestroyContext">documentation</see> for more details.
	/// </remarks>
	/// <param name="context">The OpenGL context to be deleted.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GL_DestroyContext")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GL_DestroyContext(SDL_GLContext* context);
}