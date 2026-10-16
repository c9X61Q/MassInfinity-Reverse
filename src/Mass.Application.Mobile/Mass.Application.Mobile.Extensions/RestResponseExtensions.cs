using System;
using System.Runtime.CompilerServices;
using Mass.Domain.Mobile.Entities.Com4399;
using RestSharp;

namespace Mass.Application.Mobile.Extensions;

public static class RestResponseExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T EnsureSuccessStatusCode<T>(this RestResponse<EntityCom4399Response<T>> response, int code, string? message = null)
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}
}
