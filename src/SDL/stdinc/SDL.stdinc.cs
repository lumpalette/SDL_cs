using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_stdinc.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_stdinc.h.
public static unsafe partial class SDL
{
	[Macro]
	public static uint FourCC(byte a, byte b, byte c, byte d)
	{
		return (uint)(a | (b << 8) | (c << 16) | (d << 24));
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_malloc")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint malloc(nuint size);

	[LibraryImport(LibraryName, EntryPoint = "SDL_free")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void free(nint mem);

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