using System;

namespace SDL3;

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
	/// Window should always be above others.
	/// </summary>
	AlwaysOnTop = 0x0000000000008000uL,

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