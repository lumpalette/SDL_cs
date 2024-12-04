using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_stdinc.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_stdinc.h.
namespace SDL3;

unsafe partial class SDL
{
	/// <summary>
	/// Define a four character code as a <see cref="uint"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FOURCC">documentation</see> for more details.
	/// </remarks>
	/// <param name="a">The first ASCII character.</param>
	/// <param name="b">The second ASCII character.</param>
	/// <param name="c">The third ASCII character.</param>
	/// <param name="d">The fourth ASCII character.</param>
	/// <returns>The four characters converted into a <see cref="uint"/>, one character per-byte.</returns>
	[Macro]
	public static uint FourCC(byte a, byte b, byte c, byte d)
	{
		return (uint)(a | (b << 8) | (c << 16) | (d << 24));
	}

	/// <summary>
	/// Allocate uninitialized memory.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_malloc">documentation</see> for more details.
	/// </remarks>
	/// <param name="size">The size to allocate.</param>
	/// <returns>A pointer to the allocated memory, or <see langword="null"/> if allocation failed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_malloc")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint malloc(nuint size);

	/// <summary>
	/// Free allocated memory.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_free">documentation</see> for more details.
	/// </remarks>
	/// <param name="mem">A pointer to allocated memory, or <see langword="null"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_free")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void free(nint mem);

	/// <summary>
	/// Free allocated memory.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_free">documentation</see> for more details.
	/// </remarks>
	/// <param name="mem">A pointer to allocated memory, or <see langword="null"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_free")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void free(void* mem);

	/// <summary>
	/// Epsilon constant, used for comparing floating-point numbers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FLT_EPSILON">documentation</see> for more details.
	/// </remarks>
	public const float FloatEpsilon = 1.1920928955078125e-07f;
}