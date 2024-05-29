using System.Runtime.InteropServices;

namespace SDL3;

// SDL_init.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_init.h.
unsafe partial class SDL
{
	/// <summary>
	/// Initialization flags for <see cref="Init"/> and/or <see cref="InitSubSystem"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_InitFlags">here</see>.
	/// </remarks>
	[Flags]
	public enum InitFlags : uint
	{
		Timer = 0x00000001,
		Audio = 0x00000010,
		Video = 0x00000020,
		Joystick = 0x00000200,
		Haptic = 0x00001000,
		Gamepad = 0x00002000,
		Events = 0x00004000,
		Sensor = 0x00008000,
		Camera = 0x00010000
	}

	/// <summary>
	/// Initialize the SDL library.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Init">here</see>.
	/// </remarks>
	/// <param name="flags"> Subsystem initialization flags. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int Init(InitFlags flags)
	{
		return _PInvoke(flags);

		[DllImport(LibraryName, EntryPoint = "SDL_Init", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(InitFlags flags);
	}

	/// <summary>
	/// Compatibility function to initialize the SDL library.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_InitSubSystem">here</see>.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init"/>; see <see cref="Init"/> for details. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int InitSubSystem(InitFlags flags)
	{
		return _PInvoke(flags);

		[DllImport(LibraryName, EntryPoint = "SDL_InitSubSystem", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(InitFlags flags);
	}

	/// <summary>
	/// Shut down specific SDL subsystems.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_QuitSubSystem">here</see>.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init"/>; see <see cref="Init"/> for details. </param>
	public static void QuitSubSystem(InitFlags flags)
	{
		_PInvoke(flags);

		[DllImport(LibraryName, EntryPoint = "SDL_QuitSubSystem", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(InitFlags flags);
	}

	/// <summary>
	/// Get a mask of the specified subsystems which are currently initialized.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_WasInit">here</see>.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init"/>; see <see cref="Init"/> for details. </param>
	/// <returns> A mask of all initialized subsystems if <paramref name="flags"/> is 0, otherwise it returns the initialization status of the specified subsystems. </returns>
	public static InitFlags WasInit(InitFlags flags)
	{
		return _PInvoke(flags);

		[DllImport(LibraryName, EntryPoint = "SDL_WasInit", CallingConvention = CallingConvention.Cdecl)]
		static extern InitFlags _PInvoke(InitFlags flags);
	}

	/// <summary>
	/// Clean up all initialized subsystems.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Quit">here</see>.
	/// </remarks>
	public static void Quit()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_Quit", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke();
	}
}