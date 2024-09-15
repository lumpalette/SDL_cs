namespace SDL3;

unsafe partial class SDL
{
	partial class Prop
	{
		/// <summary>
		/// Properties used for <see cref="StartTextInputWithProperties(SDL_Window*, SDL_PropertiesId)"/>.
		/// </summary>
		public static class TextInput
		{
			/// <summary>
			/// An <see cref="SDL_TextInputType"/> value that describes text being input, defaults to
			/// <see cref="SDL_TextInputType.Text"/>.
			/// </summary>
			public const string TypeNumber = "SDL.textinput.type";

			/// <summary>
			/// An <see cref="SDL_Capitalization"/> value that describes how text should be capitalized,
			/// defaults to <see cref="SDL_Capitalization.None"/>.
			/// </summary>
			public const string CapitalizationNumber = "SDL.textinput.capitalization";

			/// <summary>
			/// True to enable auto completion and auto correction.
			/// </summary>
			public const string AutocorrectBoolean = "SDL.textinput.autocorrect";

			/// <summary>
			/// True if multiple lines of text are allowed. This defaults to true if <see cref="Hint.ReturnKeyHidesIme"/>
			/// is "0" or is not set, and defaults to false if <see cref="Hint.ReturnKeyHidesIme"/> is "1".
			/// </summary>
			public const string MultilineBoolean = "SDL.textinput.multiline";

			/// <summary>
			/// The text input type to use, overriding other properties. This is documented at
			/// <see href="https://developer.android.com/reference/android/text/InputType"/>.
			/// </summary>
			public const string AndroidInputTypeNumber = "SDL.textinput.android.inputtype";
		}
	}
}