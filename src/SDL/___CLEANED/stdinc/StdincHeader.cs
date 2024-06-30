namespace SDL_cs;

// SDL_stdinc.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_stdinc.h.
unsafe partial class SDL
{
	/// <summary>
	/// Define a four character code as a 32-bit unsigned integer.
	/// </summary>
	/// <param name="a">1st character of the code.</param>
	/// <param name="b">2nd character of the code.</param>
	/// <param name="c">3rd character of the code.</param>
	/// <param name="d">4th character of the code.</param>
	/// <returns>A 32-bit code composed by 4 characters.</returns>
	[Macro]
	public static uint FourCC(byte a, byte b, byte c, byte d)
	{
		return (uint)(a | (b << 8) | (c << 16) | (d << 24));
	}

	/// <summary>
	/// Free memory allocated by SDL.
	/// </summary>
	/// <param name="mem">A pointer to the memory to free.</param>
	public static void Free(void* mem)
	{
		PInvoke.SDL_free(mem);
	}
}