using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_cpuinfo.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_cpuinfo.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get the number of CPU cores available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCPUCount">documentation</see> for more details.
	/// </remarks>
	/// <returns>The total number of logical CPU cores. On CPUs that include technologies such as hyperthreading, the number of logical cores may be more than the number of physical cores.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCPUCount")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetCPUCount();

	/// <summary>
	/// Determine the L1 cache line size of the CPU.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCPUCacheLineSize">documentation</see> for more details.
	/// </remarks>
	/// <returns>The L1 cache line size of the CPU, in bytes.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCPUCacheLineSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetCPUCacheLineSize();

	/// <summary>
	/// Determine whether the CPU has AltiVec features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasAltiVec">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has AltiVec features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasAltiVec")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasAltiVec();

	/// <summary>
	/// A guess for the cacheline size used for padding.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CACHELINE_SIZE">documentation</see> for more details.
	/// </remarks>
	public const byte CachelineSize = 128;
}