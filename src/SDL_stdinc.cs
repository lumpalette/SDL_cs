using System.Runtime.InteropServices;

namespace SDL3;

// SDL_stdinc.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_stdinc.h.
unsafe partial class SDL
{
	[Macro]
	public static uint FOURCC(byte a, byte b, byte c, byte d)
	{
		return (uint)(a | (b << 8) | (c << 16) | (d << 24));
	}

	public static void Free(void* mem)
	{
		_PInvoke(mem);

		[DllImport(LibraryName, EntryPoint = "SDL_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(void* mem);
	}
}