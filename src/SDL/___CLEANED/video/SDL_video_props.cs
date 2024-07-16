namespace SDL_cs;

partial class SDL_Prop
{
	/// <summary>
	/// Properties used in <see cref="SDL.GetDisplayProperties(SDL_DisplayId)"/>.
	/// </summary>
	public static class Display
	{
		/// <summary>
		/// True if the display has HDR headroom above the SDR white point. This is for informational and diagnostic
		/// purposes only, as not all platforms provide this information at the display level.
		/// </summary>
		public const string HdrEnabledBoolean = "SDL.display.HDR_enabled";

		/// <summary>
		/// The "panel orientation" property for the display in degrees of clockwise rotation. Note that this is provided
		/// only as a hint, and the application is responsible for any coordinate transformations needed to conform to
		/// the requested display orientation.
		/// </summary>
		public const string KmsDrmOrientationNumber = "SDL.display.KMSDRM.panel_orientation";
	}

	/// <summary>
	/// Properties used in <see cref="SDL.CreateWindowWithProperties(SDL_PropertiesId)"/>.
	/// </summary>
	public static class WindowCreate
	{
		/// <summary>
		/// True if the window should be always on top.
		/// </summary>
		public const string AlwaysOnTopBoolean = "always_on_top";

		/// <summary>
		/// True if the window has no window decoration.
		/// </summary>
		public const string BorderlessBoolean = "borderless";

		/// <summary>
		/// True if the window should accept keyboard input (defaults true).
		/// </summary>
		public const string FocusableBoolean = "focusable";
		
		/// <summary>
		/// True if the window will be used with an externally managed graphics context.
		/// </summary>
		public const string ExternalGraphicsContextBoolean = "external_graphics_context";

		/// <summary>
		/// True if the window should start in fullscreen mode at desktop resolution.
		/// </summary>
		public const string FullscreenBoolean = "fullscreen";

		/// <summary>
		/// The height of the window.
		/// </summary>
		public const string HeightNumber = "height";

		/// <summary>
		/// True if the window should start hidden.
		/// </summary>
		public const string HiddenBoolean = "hidden";

		/// <summary>
		/// True if the window uses a high pixel density buffer if possible.
		/// </summary>
		public const string HighPixelDensityBoolean = "high_pixel_density";

		/// <summary>
		/// True if the window should start maximized.
		/// </summary>
		public const string MaximizedBoolean = "maximized";

		/// <summary>
		/// True if the window is a popup menu.
		/// </summary>
		public const string MenuBoolean = "menu";

		/// <summary>
		/// True if the window will be used with Metal rendering.
		/// </summary>
		public const string MetalBoolean = "metal";

		/// <summary>
		/// True if the window should start minimized.
		/// </summary>
		public const string MinimizedBoolean = "minimized";

		/// <summary>
		/// True if the window is modal to its parent.
		/// </summary>
		public const string ModalBoolean = "modal";

		/// <summary>
		/// True if the window starts with grabbed mouse focus.
		/// </summary>
		public const string MouseGrabbedBoolean = "mouse_grabbed";

		/// <summary>
		/// True if the window will be used with OpenGL rendering.
		/// </summary>
		public const string OpenGLBoolean = "opengl";

		/// <summary>
		/// An <see cref="SDL_Window"/> that will be the parent of this window, required for windows with the
		/// "toolip", "menu", and "modal" properties.
		/// </summary>
		public const string ParentPointer = "parent";

		/// <summary>
		/// True if the window should be resizable.
		/// </summary>
		public const string ResizableBoolean = "resizable";

		/// <summary>
		/// The title of the window, in UTF-8 encoding.
		/// </summary>
		public const string TitleString = "title";

		/// <summary>
		/// True if the window show transparent in the areas with alpha of 0.
		/// </summary>
		public const string TransparentBoolean = "transparent";

		/// <summary>
		/// True if the window is a tooltip.
		/// </summary>
		public const string TooltipBoolean = "tooltip";

		/// <summary>
		/// True if the window is a utility window, not showing in the task bar and window list.
		/// </summary>
		public const string UtilityBoolean = "utility";

		/// <summary>
		/// True if the window will be used with Vulkan rendering.
		/// </summary>
		public const string VulkanBoolean = "vulkan";

		/// <summary>
		/// The width of the window.
		/// </summary>
		public const string WidthNumber = "width";

		/// <summary>
		/// The x position of the window, or <see cref="SDL.WindowposCentered"/>, defaults to <see cref="SDL.WindowposUndefined"/>.
		/// This is relative to the parent for windows with the "parent" property set.
		/// </summary>
		public const string XNumber = "x";

		/// <summary>
		/// The x position of the window, or <see cref="SDL.WindowposCentered"/>, defaults to <see cref="SDL.WindowposUndefined"/>.
		/// This is relative to the parent for windows with the "parent" property set.
		/// </summary>
		public const string YNumber = "y";

		/// <summary>
		/// The <c>(__unsafe_unretained) NSWindow</c> associated with the window, if you want to wrap an existing
		/// window.
		/// </summary>
		public const string CocoaWindowPointer = "cocoa.window";

		/// <summary>
		/// The <c>(__unsafe_unretained) NSView</c> associated with the window, defaults to
		/// <c>[window contentView]</c>.
		/// </summary>
		public const string CocoaViewPointer = "cocoa.view";

		/// <summary>
		/// True if the application wants to use the Wayland surface for a custom role and does not want it attached to an
		/// XDG toplevel window. See README/wayland for more information on using custom surfaces.
		/// </summary>
		public const string WaylandSurfaceRoleCustomBoolean = "wayland.surface_role_custom";

		/// <summary>
		/// True if the application wants an associated wl_egl_window object to be created, even if the window does not have
		/// the OpenGL property or flag set.
		/// </summary>
		public const string WaylandCreateEglWindowBoolean = "wayland.create_egl_window";

		/// <summary>
		/// The <c>wl_surface</c> associated with the window, if you want to wrap an existing window. See README/wayland
		/// for more information.
		/// </summary>
		public const string WaylandWLSurfacePointer = "wayland.wl_surface";

		/// <summary>
		/// The <c>HWND</c> associated with the window, if you want to wrap an existing window.
		/// </summary>
		public const string Win32HwndPointer = "win32.hwnd";

		/// <summary>
		/// Optional, another window to share pixel format with, useful for OpenGL windows.
		/// </summary>
		public const string Win32PixelFormatHwndPointer = "win32.pixel_format_hwnd";

		/// <summary>
		/// The X11 Window associated with the window, if you want to wrap an existing window.
		/// </summary>
		public const string X11WindowNumber = "x11.window";
	}

	/// <summary>
	/// Properties used in <see cref="SDL.GetWindowProperties(SDL_Window*)"/>.
	/// </summary>
	public static class Window
	{
		/// <summary>
		/// The surface associated with a shaped window.
		/// </summary>
		public const string ShapePointer = "SDL.window.shape";

		/// <summary>
		/// True if the window has HDR headroom above the SDR white point. This property can change dynamically when
		/// <see cref="FIXME:SDL_EVENT_WINDOW_HDR_STATE_CHANGED"/> is sent.
		/// </summary>
		public const string HdrEnabledBoolean = "SDL.window.HDR_enabled";

		/// <summary>
		/// The value of SDR white in the <see cref="SDL_Colorspace.SRGBLinear"/> colorspace.On Windows this corresponds
		/// to the SDR white level in scRGB colorspace, and on Apple platforms this is always 1.0 for EDR content. This
		/// property can change dynamically when <see cref="FIXME:SDL_EVENT_WINDOW_HDR_STATE_CHANGED"/> is sent.
		/// </summary>
		public const string SdrWhiteLevelFloat = "SDL.window.SDR_white_level";

		/// <summary>
		/// The additional high dynamic range that can be displayed, in terms of the SDR white point. When HDR is not
		/// enabled, this will be 1.0. This property can change dynamically when
		/// <see cref="FIXME:SDL_EVENT_WINDOW_HDR_STATE_CHANGED"/> is sent.
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
		/// The OpenGL view's renderbuffer object. It must be bound when <see cref="FIXME:SDL_GL_SwapWindow"/> is
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
		/// The <c>IInspectable CoreWindow</c> associated with the window.
		/// </summary>
		public const string WinRTWindowPointer = "SDL.window.winrt.window";

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