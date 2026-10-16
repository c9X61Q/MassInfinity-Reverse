using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetty.Buffers;
using Mass.Common.Helpers;
using Mass.Game.Proxy.Enums;

namespace Mass.Game.Proxy.Network.Particle;

public static class ParticleManager
{
	private static readonly ConcurrentDictionary<EnumProtocolVersion, BiDictionary<int, Type>> Particles;

	internal static ParticleManager DecorateScheduledStruct;

	unsafe static ParticleManager()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0027: Expected I4, but got Obj
		//IL_0335: Expected Obj, but got VT
		//IL_02a9: Expected Obj, but got I4
		//IL_005a: Expected I4, but got Obj
		//IL_0180: Expected Obj, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_015e: Expected I4, but got Obj
		//IL_0149: Expected Obj, but got I4
		//IL_0108: Expected I4, but got Obj
		//IL_0349->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0372->IL0012: Incompatible stack types: I4 vs Obj
		//IL_0354->IL0012: Incompatible stack types: I4 vs Obj
		//IL_037d->IL0012: Incompatible stack types: I4 vs Obj
		//IL_007c->IL0041: Incompatible stack types: I4 vs Obj
		//IL_00a7->IL0041: Incompatible stack types: I4 vs Obj
		//IL_0087->IL0041: Incompatible stack types: I4 vs Obj
		//IL_00b2->IL0041: Incompatible stack types: I4 vs Obj
		//IL_012a->IL00db: Incompatible stack types: I4 vs Obj
		//IL_0202->IL00db: Incompatible stack types: I4 vs Obj
		//IL_0135->IL00db: Incompatible stack types: I4 vs Obj
		//IL_020d->IL00db: Incompatible stack types: I4 vs Obj
		//IL_018a->IL00db: Incompatible stack types: I4 vs Obj
		//IL_01d1->IL00db: Incompatible stack types: I4 vs Obj
		//IL_01e2->IL00db: Incompatible stack types: I4 vs Obj
		//IL_01b6->IL00db: Incompatible stack types: I4 vs Obj
		//IL_0172->IL00db: Incompatible stack types: I4 vs Obj
		//IL_01c1->IL00db: Incompatible stack types: I4 vs Obj
		//IL_017d->IL00db: Incompatible stack types: I4 vs Obj
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			case 2:
				while (true)
				{
					IL_0087:
					object obj3;
					if (!((List<Type>.Enumerator*)(&obj))->MoveNext())
					{
						obj3 = 0;
						if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_d41bc0cdd1e949d2afb47c41a1c9089f == 0)
						{
							obj3 = 1;
						}
						goto IL_0041;
					}
					goto IL_005f;
					IL_005f:
					obj = ((List<Type>.Enumerator*)(&obj))->Current;
					obj3 = 0;
					if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_4ee690c04f264124bb83e115c5b10dd7 == 0)
					{
						obj3 = 0;
					}
					goto IL_0041;
					IL_0041:
					while (true)
					{
						switch ((int)obj3)
						{
						case 1:
							return;
						case 2:
							break;
						case 3:
							goto IL_0087;
						case 4:
							while (true)
							{
								IL_01e2:
								object obj4;
								if (!((IEnumerator)obj).MoveNext())
								{
									obj4 = 0;
									if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_98c5b65248ad40c7850a3ec59a5fe46e != 0)
									{
										obj4 = 3;
									}
									goto IL_00db;
								}
								goto IL_010d;
								IL_010d:
								obj = ((IEnumerator<ParticleAttribute>)obj).Current;
								obj4 = 8;
								if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_355e7fc10d1f46d197b28bfd57d07a3f == 0)
								{
									obj4 = 8;
								}
								goto IL_00db;
								IL_00db:
								while (true)
								{
									switch ((int)obj4)
									{
									case 3:
										break;
									case 6:
										goto IL_010d;
									case 2:
									case 5:
										if ((nint)obj >= ((Array)obj).Length)
										{
											obj = 7;
											obj4 = obj;
											continue;
										}
										goto case 4;
									case 9:
										RegisterParticle(((ParticleAttribute)obj).Version, (uint)(int)obj, obj);
										obj4 = 0;
										if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_b1b6d6de071946a88b9c0d9c948fdc15 != 0)
										{
											obj4 = 1;
										}
										continue;
									default:
										obj = 0;
										obj4 = 2;
										continue;
									case 8:
										obj = ((ParticleAttribute)obj).Ids;
										obj4 = 0;
										if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_8e1183352ec04b20b80cf7a7fbb841b7 != 0)
										{
											obj4 = 0;
										}
										continue;
									case 1:
										obj++;
										obj4 = 5;
										continue;
									case 4:
										obj = ((int[])obj)[obj];
										obj4 = 9;
										continue;
									case 7:
										goto IL_01e2;
									}
									break;
								}
								break;
							}
							goto IL_0087;
						default:
							obj = ((MemberInfo)obj).GetCustomAttributes<ParticleAttribute>().GetEnumerator();
							obj = 4;
							obj3 = obj;
							continue;
						}
						break;
					}
					goto IL_005f;
				}
			default:
				obj = typeof(ParticleManager).Assembly.GetTypes().Where([MethodImpl(MethodImplOptions.NoInlining)] (Type t) =>
				{
					//IL_0008: Expected I8, but got I4
					((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776388, new IntPtr(2737368324588L), 15))(null, 0, new IntPtr(0L));
					return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
				}).ToList()
					.GetEnumerator();
				obj2 = 2;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_d483e18103b04ef0b7339804b034eb43 == 0)
				{
					obj2 = 1;
				}
				break;
			case 1:
				Particles = new ConcurrentDictionary<EnumProtocolVersion, BiDictionary<int, Type>>();
				obj2 = 0;
				if (_003CModule_003E_007B83506d8c_002D9342_002D4b0b_002D8279_002D2ea9f32b06c7_007D.m_2e895178b14c4b639fefec9b6a992f73.m_394e36ae5ad54f788557117d337f595c == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void RegisterParticle(EnumProtocolVersion version, uint id, object type)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776440, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object GetParticle(EnumProtocolVersion version, uint id)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776443, new IntPtr(2737368332908L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static ParticleBase ReadParticle(this IByteBuffer buffer, EnumProtocolVersion version)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776442, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (ParticleBase)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static IByteBuffer WriteParticle(this IByteBuffer buffer, ParticleBase particle, EnumProtocolVersion version)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776437, new IntPtr(2737368329788L), 15))(null, 0, new IntPtr(0L));
		return (IByteBuffer)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static bool CheckFilteredReporter()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776436, new IntPtr(2737368302748L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static ParticleManager CheckAutomatedChain()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776439, new IntPtr(2737368301708L), 15))(null, 0, new IntPtr(0L));
		return (ParticleManager)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776438, new IntPtr(2737368322508L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䈀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776433, new IntPtr(2737368325628L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00䔀(EnumProtocolVersion P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776432, new IntPtr(2737368319388L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static object _FF00_FF00_FF00_FF00䘀(EnumProtocolVersion P_0, uint P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776435, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䜀(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776434, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䠀(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776397, new IntPtr(2737368320428L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䤀(object P_0, object P_1, EnumProtocolVersion P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776396, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776399, new IntPtr(2737368327708L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䬀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776398, new IntPtr(2737368308988L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00䰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776393, new IntPtr(2737368316268L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00䴀(object P_0, EnumProtocolVersion P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776392, new IntPtr(2737368318348L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_FF00_FF00_FF00一(EnumProtocolVersion P_0, uint P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776395, new IntPtr(2737368304828L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_FF00_FF00_FF00伀(EnumProtocolVersion P_0, uint P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776394, new IntPtr(2737368313148L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_FF00_FF00_FF00倀(EnumProtocolVersion P_0, uint P_1, object P_2)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790776389, new IntPtr(2737368306908L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
