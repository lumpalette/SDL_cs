using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_stdinc.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_stdinc.h.
unsafe partial class SDL
{
	[Macro]
	public static uint CREATE_FOURCC(byte a, byte b, byte c, byte d)
	{
		return (uint)(a | (b << 8) | (c << 16) | (d << 24));
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_free")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeFree(void* mem);
}