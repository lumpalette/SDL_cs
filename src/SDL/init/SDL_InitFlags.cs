using System;

namespace SDL_cs;

/// <summary>
/// Initialization flags for <see cref="SDL.Init(SDL_InitFlags)"/> and/or <see cref="SDL.InitSubSystem(SDL_InitFlags)"/>.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_InitFlags">here</see>.
/// </remarks>
[Flags]
public enum SDL_InitFlags : uint
{
	Timer = 0x00000001u,
	Audio = 0x00000010u,
	Video = 0x00000020u,
	Joystick = 0x00000200u,
	Haptic = 0x00001000u,
	Gamepad = 0x00002000u,
	Events = 0x00004000u,
	Sensor = 0x00008000u,
	Camera = 0x00010000u
}