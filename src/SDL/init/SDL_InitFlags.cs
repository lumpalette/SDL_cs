using System;

namespace SDL3;

/// <summary>
/// Initialization flags for <see cref="SDL.Init(SDL_InitFlags)"/> and/or <see cref="SDL.InitSubSystem(SDL_InitFlags)"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_InitFlags">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_InitFlags : uint
{
	/// <summary>
	/// No subsystem is targetted.
	/// </summary>
	None = 0x00000000u,

	/// <summary>
	/// Audio subsystem.
	/// </summary>
	Audio = 0x00000010u,

	/// <summary>
	/// Video subsystem. Implies <see cref="Events"/>.
	/// </summary>
	Video = 0x00000020u,

	/// <summary>
	/// Joystick subsystem. Implies <see cref="Events"/>.
	/// </summary>
	/// <remarks>
	/// This subsystem should be initialized on the same thread as <see cref="Video"/> on Windows if you don't set
	/// <see cref="SDL.Hint.JoystickThread"/>.
	/// </remarks>
	Joystick = 0x00000200u,

	/// <summary>
	/// Haptic subsystem.
	/// </summary>
	Haptic = 0x00001000u,

	/// <summary>
	/// Gamepad subsystem. Implies <see cref="Joystick"/>.
	/// </summary>
	Gamepad = 0x00002000u,

	/// <summary>
	/// Events subsystem.
	/// </summary>
	Events = 0x00004000u,

	/// <summary>
	/// Sensor subsystem. Implies <see cref="Events"/>.
	/// </summary>
	Sensor = 0x00008000u,

	/// <summary>
	/// Camera subsystem. Implies <see cref="Events"/>.
	/// </summary>
	Camera = 0x00010000u
}