namespace SDL_cs;

/// <summary>
/// Packed component layout.
/// </summary>
public enum SDL_PackedLayout : byte
{
	None,
	Layout332,
	Layout4444,
	Layout1555,
	Layout5551,
	Layout565,
	Layout8888,
	Layout2101010,
	Layout1010102
}