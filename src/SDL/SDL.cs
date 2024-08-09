using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

/// <summary>
/// Defines the C# bindings, properties and constants to interact with the SDL API.
/// </summary>
public static unsafe partial class SDL
{
	/// <summary>
	/// A collection of properties, used in various SDL systems.
	/// </summary>
	public static partial class Prop;
	
	/// <summary>
	/// The collection of hints used across SDL.
	/// </summary>
	public static partial class Hint;

	/// <summary>
	/// Converts an unmanaged UTF-8 string into a UTF-16 managed string.
	/// </summary>
	/// <remarks>
	/// This function is a wrapper for <see cref="Utf8StringMarshaller.ConvertToManaged(byte*)"/>.
	/// </remarks>
	/// <param name="str">The unmanaged string to convert.</param>
	/// <returns>The converted managed string, or <see langword="null"/> if <paramref name="str"/> is also <see langword="null"/>.</returns>
	public static string? UnmanagedToManagedString(byte* str)
	{
		return Utf8StringMarshaller.ConvertToManaged(str);
	}

	/// <summary>
	/// Converts an array of unmanaged UTF-8 strings into UTF-16 managed strings.
	/// </summary>
	/// <param name="strs">The array of unmanaged UTF-8 strings to convert.</param>
	/// <param name="count">The number of strings in the array.</param>
	/// <returns>An array of managed strings, or <see langword="null"/> if <paramref name="strs"/> is also <see langword="null"/>.</returns>
	public static string?[]? UnmanagedToManagedStrings(byte** strs, int count)
	{
		if (strs is null)
		{
			return null;
		}
		var strsManaged = new string?[count];
		for (int i = 0; i < count; i++)
		{
			strsManaged[i] = Utf8StringMarshaller.ConvertToManaged(strs[i]);
		}
		return strsManaged;
	}

	/// <summary>
	/// The name of the library: SDL3.
	/// </summary>
	internal const string LibraryName = "SDL3";

	/// <summary>
	/// The size of SDL_bool: an i4.
	/// </summary>
	internal const UnmanagedType NativeBool = UnmanagedType.I4;
}