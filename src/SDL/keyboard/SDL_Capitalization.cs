namespace SDL3;

/// <summary>
/// Auto capitalization type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Capitalization">documentation</see> for more details.
/// </remarks>
public enum SDL_Capitalization
{
	/// <summary>
	/// No auto-capitalization will be done.
	/// </summary>
	None,

	/// <summary>
	/// The first letter of sentences will be capitalized.
	/// </summary>
	Sentences,

	/// <summary>
	/// The first letter of words will be capitalized.
	/// </summary>
	Words,

	/// <summary>
	/// All letters will be capitalized.
	/// </summary>
	Letters
}