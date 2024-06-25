using System;

namespace SDL_cs;

/// <summary>
/// The flags on a window.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WindowFlags">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_WindowFlags : uint
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