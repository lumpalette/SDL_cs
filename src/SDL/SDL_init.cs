using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_init.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_init.h.
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

unsafe partial class SDL
{
	/// <summary>
	/// Initialize the SDL library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Init">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags">Subsystem initialization flags.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_Init")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool Init(SDL_InitFlags flags);

	/// <summary>
	/// Compatibility function to initialize the SDL library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_InitSubSystem">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags">Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_InitSubSystem")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool InitSubSystem(SDL_InitFlags flags);

	/// <summary>
	/// Shut down specific SDL subsystems.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_QuitSubSystem">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags">Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_QuitSubSystem")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void QuitSubSystem(SDL_InitFlags flags);

	/// <summary>
	/// Get a mask of the specified subsystems which are currently initialized.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WasInit">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags">Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details.</param>
	/// <returns>A mask of all initialized subsystems if <paramref name="flags"/> is <see cref="SDL_InitFlags.None"/>, otherwise it returns the initialization status of the specified subsystems.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WasInit")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_InitFlags WasInit(SDL_InitFlags flags);

	/// <summary>
	/// Clean up all initialized subsystems.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Quit">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_Quit")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void Quit();
}