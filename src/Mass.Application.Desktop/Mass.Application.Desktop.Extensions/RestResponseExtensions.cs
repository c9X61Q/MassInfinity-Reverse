using System;
using System.Runtime.CompilerServices;
using Mass.Domain.Entities.Netease;
using RestSharp;

namespace Mass.Application.Desktop.Extensions;

public static class RestResponseExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T EnsureSuccessStatusCode<T>(this RestResponse<Entity<T>> response, string? message = null)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
