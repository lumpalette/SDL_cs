namespace SDL_cs;

/// <summary>
/// A 128-bit identifier for an input device that identifies that device across runs of SDL programs on the same platform.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUID">documentation</see> for more details.
/// </remarks>
public unsafe struct SDL_Guid
{
	public fixed byte Data[16];
}