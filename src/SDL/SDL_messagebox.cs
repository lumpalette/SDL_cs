using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_messagebox.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_messagebox.h.
namespace SDL3;

/// <summary>
/// <see cref="SDL_MessageBoxData"/> flags.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxFlags">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_MessageBoxFlags : uint
{
	/// <summary>
	/// Error dialog.
	/// </summary>
	Error = 0x00000010u,

	/// <summary>
	/// Warning dialog.
	/// </summary>
	Warning = 0x00000020u,

	/// <summary>
	/// Informational dialog.
	/// </summary>
	Information = 0x00000040u,

	/// <summary>
	/// Buttons placed left to right.
	/// </summary>
	ButtonsLeftToRight = 0x00000080u,

	/// <summary>
	/// Buttons placed right to left.
	/// </summary>
	ButtonsRightToLeft = 0x00000100u
}

/// <summary>
/// <see cref="SDL_MessageBoxButtonData"/> flags.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxButtonFlags">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_MessageBoxButtonFlags : uint
{
	/// <summary>
	/// Marks the default button when return is hit.
	/// </summary>
	ReturnKeyDefault = 0x00000001u,

	/// <summary>
	/// Marks the default button when escape is hit.
	/// </summary>
	EscapeKeyDefault = 0x00000002u
}

/// <summary>
/// Individual button data.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxButtonData">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_MessageBoxButtonData
{
	/// <summary>
	/// Buttons flags.
	/// </summary>
	public SDL_MessageBoxButtonFlags Flags;

	/// <summary>
	/// User defined button id (value returned via <see cref="SDL.ShowMessageBox(SDL_MessageBoxData*, int*)"/>).
	/// </summary>
	public int ButtonId;

	/// <summary>
	/// The UTF-8 button text.
	/// </summary>
	public byte* Text;
}

/// <summary>
/// RGB value used in a message box color scheme
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxColor">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MessageBoxColor
{
	/// <summary>
	/// The red component.
	/// </summary>
	public byte R;

	/// <summary>
	/// The green component.
	/// </summary>
	public byte G;

	/// <summary>
	/// The blue component.
	/// </summary>
	public byte B;
}

/// <summary>
/// An enumeration of indices inside the colors array of <see cref="SDL_MessageBoxColorScheme"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxColorType">documentation</see> for more details.
/// </remarks>
public enum SDL_MessageBoxColorType
{
	Background,
	Text,
	ButtonBorder,
	ButtonBackground,
	ButtonSelected,

	/// <summary>
	/// Size of the colors array of <see cref="SDL_MessageBoxColorScheme"/>.
	/// </summary>
	Count
}

/// <summary>
/// A set of colors to use for message box dialogs
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxColorScheme">documentation</see> for more details.
/// </remarks>
public unsafe struct SDL_MessageBoxColorScheme
{
	/// <summary>
	/// An array of length <see cref="SDL_MessageBoxColorType.Count"/> containing the colors to use.
	/// </summary>
	/// <remarks>
	/// Since we can't use a fixed buffer here, assume the length is <see cref="SDL_MessageBoxColorType.Count"/>.
	/// </remarks>
	public SDL_MessageBoxColor* Colors;
}

/// <summary>
/// MessageBox structure containing title, text, window, etc.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxData">documentation</see> for more details.
/// </remarks>
public unsafe struct SDL_MessageBoxData
{
	/// <summary>
	/// Message box flags.
	/// </summary>
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

	/// <summary>
	/// The number of buttons the message box has.
	/// </summary>
	public int NumButtons;

	/// <summary>
	/// The data of each button.
	/// </summary>
	public SDL_MessageBoxButtonData* Buttons;

	/// <summary>
	/// <see cref="SDL_MessageBoxColorScheme"/>, can be <see langword="null"/> to use system settings.
	/// </summary>
	public SDL_MessageBoxColorScheme ColorScheme;
}

unsafe partial class SDL
{
	/// <summary>
	/// Create a modal message box.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowMessageBox">documentation</see> for more details.
	/// </remarks>
	/// <param name="messageBoxData">The <see cref="SDL_MessageBoxData"/> structure with title, text and other options.</param>
	/// <param name="buttonId">The pointer to which user id of hit button should be copied.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowMessageBox")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool ShowMessageBox([Const] SDL_MessageBoxData* messageBoxData, int* buttonId);

	/// <summary>
	/// Display a simple modal message box.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowSimpleMessageBox">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags">An <see cref="SDL_MessageBoxFlags"/> value.</param>
	/// <param name="title">UTF-8 title text.</param>
	/// <param name="message">UTF-8 message text.</param>
	/// <param name="window">The parent window, or <see langword="null"/> for no parent.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowSimpleMessageBox", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool ShowSimpleMessageBox(SDL_MessageBoxFlags flags, string title, string message, SDL_Window* window);
}