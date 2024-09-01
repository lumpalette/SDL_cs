namespace SDL3;

/// <summary>
/// MessageBox structure containing title, text, window, etc.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxData">documentation</see> for more details.
/// </remarks>
public unsafe struct SDL_MessageBoxData
{
	public SDL_MessageBoxFlags Flags;

	/// <summary>
	/// Parent window, can be <see langword="null"/>.
	/// </summary>
	public SDL_Window* Window;

	/// <summary>
	/// UTF-8 title.
	/// </summary>
	public byte* Title;

	/// <summary>
	/// UTF-8 message text.
	/// </summary>
	public byte* Message;

	public int NumButtons;

	public SDL_MessageBoxButtonData* Buttons;

	/// <summary>
	/// <see cref="SDL_MessageBoxColorScheme"/>, can be <see langword="null"/> to use system settings.
	/// </summary>
	public SDL_MessageBoxColorScheme ColorScheme;
}