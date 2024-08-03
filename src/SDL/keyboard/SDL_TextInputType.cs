namespace SDL3;

/// <summary>
/// Text input type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputType">documentation</see> for more details.
/// </remarks>
public enum SDL_TextInputType
{
	/// <summary>
	/// The input is text.
	/// </summary>
	Text,

	/// <summary>
	/// The input is a person's name.
	/// </summary>
	TextName,

	/// <summary>
	/// The input is an e-mail address.
	/// </summary>
	TextEmail,

	/// <summary>
	/// The input is a username.
	/// </summary>
	TextUsername,

	/// <summary>
	/// The input is a secure password that is hidden.
	/// </summary>
	TextPasswordHidden,

	/// <summary>
	/// The input is a secure password that is visible.
	/// </summary>
	TextPasswordVisible,

	/// <summary>
	/// The input is a number.
	/// </summary>
	Number,

	/// <summary>
	/// The input is a secure PIN that is hidden.
	/// </summary>
	NumberPasswordHidden,

	/// <summary>
	/// The input is a secure PIN that is visible.
	/// </summary>
	NumberPasswordVisible
}