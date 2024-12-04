using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_cpuinfo.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_cpuinfo.h.
namespace SDL3;

unsafe partial class SDL
{
	/// <summary>
	/// A guess for the cacheline size used for padding.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CACHELINE_SIZE">documentation</see> for more details.
	/// </remarks>
	public const byte CachelineSize = 128;

	/// <summary>
	/// Get the number of logical CPU cores available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumLogicalCPUCores">documentation</see> for more details.
	/// </remarks>
	/// <returns>The total number of logical CPU cores. On CPUs that include technologies such as hyperthreading, the number of logical cores may be more than the number of physical cores.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumLogicalCPUCores")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumLogicalCPUCores();

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
	/// Determine whether the CPU has MMX features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasMMX">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has MMX features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasMMX")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasMMX();

	/// <summary>
	/// Determine whether the CPU has SSE features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasSSE">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has SSE features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasSSE();

	/// <summary>
	/// Determine whether the CPU has SSE2 features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasSSE2">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has SSE2 features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE2")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasSSE2();

	/// <summary>
	/// Determine whether the CPU has SSE3 features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasSSE3">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has SSE3 features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE3")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasSSE3();

	/// <summary>
	/// Determine whether the CPU has SSE4.1 features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasSSE41">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has SSE4.1 features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE41")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasSSE41();

	/// <summary>
	/// Determine whether the CPU has SSE4.2 features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasSSE42">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has SSE4.2 features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE42")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasSSE42();

	/// <summary>
	/// Determine whether the CPU has AVX features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasAVX">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has AVX features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasAVX")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasAVX();

	/// <summary>
	/// Determine whether the CPU has AVX2 features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasAVX2">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has AVX features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasAVX2")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasAVX2();

	/// <summary>
	/// Determine whether the CPU has AVX-512F (foundation) features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasAVX512F">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has AVX-512F features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasAVX512F")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasAVX512F();

	/// <summary>
	/// Determine whether the CPU has ARM SIMD (ARMv6) features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasARMSIMD">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has ARM SIMD features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasARMSIMD")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasARMSimd();

	/// <summary>
	/// Determine whether the CPU has NEON (ARM SIMD) features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasARMSIMD">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has ARM NEON features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasNEON")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasNeon();

	/// <summary>
	/// Determine whether the CPU has LASX (LOONGARCH SIMD) features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasLSX">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has LOONGARCH LASX features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasLSX")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasLSX();

	/// <summary>
	/// Determine whether the CPU has LASX (LOONGARCH SIMD) features.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasLASX">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the CPU has LOONGARCH LASX features or false if not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasLASX")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasLASX();

	/// <summary>
	/// Get the amount of RAM configured in the system.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSystemRAM">documentation</see> for more details.
	/// </remarks>
	/// <returns>The amount of RAM configured in the system in MiB.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSystemRAM")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSystemRAM();

	/// <summary>
	/// Report the alignment this system needs for SIMD allocations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSIMDAlignment">documentation</see> for more details.
	/// </remarks>
	/// <returns>The alignment in bytes needed for available, known SIMD instructions.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSIMDAlignment")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nuint GetSimdAlignment();
}