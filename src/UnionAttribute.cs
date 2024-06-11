using System;

namespace SDL_cs;

/// <summary>
/// Indicates that some type is defined as a union in SDL.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
sealed class UnionAttribute : Attribute;