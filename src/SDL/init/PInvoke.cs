using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_init.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_init.h.
unsafe partial class SDL
{
	/// <summary>
	/// Initialize the SDL library.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_Init">here</see> for more details.
	/// </remarks>
	/// <param name="flags"> Subsystem initialization flags. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int Init(SDL_InitFlags flags)
	{
		return _PInvoke(flags);

		[DllImport(LibraryName, EntryPoint = "SDL_Init", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_InitFlags flags);
	}

	/// <summary>
	/// Compatibility function to initialize the SDL library.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_InitSubSystem">here</see> for more details.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int InitSubSystem(SDL_InitFlags flags)
	{
		return _PInvoke(flags);

		[DllImport(LibraryName, EntryPoint = "SDL_InitSubSystem", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_InitFlags flags);
	}

	/// <summary>
	/// Shut down specific SDL subsystems.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_QuitSubSystem">here</see> for more details.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details. </param>
	public static void QuitSubSystem(SDL_InitFlags flags)
	{
		_PInvoke(flags);

		[DllImport(LibraryName, EntryPoint = "SDL_QuitSubSystem", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_InitFlags flags);
	}

	/// <summary>
	/// Get a mask of the specified subsystems which are currently initialized.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_WasInit">here</see> for more details.
	/// </remarks>
	/// <param name="flags"> Any of the flags used by <see cref="Init(SDL_InitFlags)"/>; see <see cref="Init(SDL_InitFlags)"/> for details. </param>
	/// <returns> A mask of all initialized subsystems if <paramref name="flags"/> is 0, otherwise it returns the initialization status of the specified subsystems. </returns>
	public static SDL_InitFlags WasInit(SDL_InitFlags flags)
	{
		return _PInvoke(flags);

		[DllImport(LibraryName, EntryPoint = "SDL_WasInit", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_InitFlags _PInvoke(SDL_InitFlags flags);
	}

	/// <summary>
	/// Clean up all initialized subsystems.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_Quit">here</see> for more details.
	/// </remarks>
	public static void Quit()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_Quit", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke();
	}
}