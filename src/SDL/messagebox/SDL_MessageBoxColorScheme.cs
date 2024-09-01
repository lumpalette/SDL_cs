namespace SDL3;

/// <summary>
/// A set of colors to use for message box dialogs
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxColorScheme">documentation</see> for more details.
/// </remarks>
public unsafe struct SDL_MessageBoxColorScheme
{
	// i can't use a fixed buffer here, so just suppose this have a length of SDL_MessageBoxColorType.Max.
	public SDL_MessageBoxColor* Colors;
}