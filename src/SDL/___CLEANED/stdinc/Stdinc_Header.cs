namespace SDL_cs;

// SDL_stdinc.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_stdinc.h.
unsafe partial class SDL
{
	[Macro]
	public static uint FourCC(byte a, byte b, byte c, byte d)
	{
		return (uint)(a | (b << 8) | (c << 16) | (d << 24));
	}

	/// <summary>
	/// Free memory allocated by SDL.
	/// </summary>
	/// <param name="mem"> A pointer to the memory to free. </param>
	public static void Free(void* mem)
	{
		PInvoke.SDL_free(mem);
	}
}