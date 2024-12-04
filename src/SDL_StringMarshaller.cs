using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

/// <summary>
/// A marshaller for UTF-8 strings that are managed by SDL, i.e. string memory that the C# program <b>should not</b> free manually.
/// </summary>
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedOut, typeof(SDL_StringMarshaller))]
public static unsafe class SDL_StringMarshaller
{
	/// <summary>
	/// Converts an SDL string into a managed C# <see cref="string"/>.
	/// </summary>
	/// <param name="unmanaged">A pointer to the SDL string.</param>
	/// <returns>A managed <see cref="string"/>.</returns>
	public static string? ConvertToManaged(byte* unmanaged)
	{
		return Utf8StringMarshaller.ConvertToManaged(unmanaged);
	}
}