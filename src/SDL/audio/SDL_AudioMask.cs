namespace SDL_cs;

/// <summary>
/// Masks for different parts of <see cref="SDL_AudioFormat"/>.
/// </summary>
public enum SDL_AudioMask : ushort
{
	BitSize = 0xFF,
	Float = 1 << 8,
	BigEndian = 1 << 12,
	Signed = 1 << 15,
}