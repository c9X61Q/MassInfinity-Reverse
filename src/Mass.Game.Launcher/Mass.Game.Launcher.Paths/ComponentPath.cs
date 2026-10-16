using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Mass.Domain.Desktop.Entities.Mods;

namespace Mass.Game.Launcher.Paths;

public class ComponentPath : GamePath
{
	public readonly bool IsDirectory;

	public readonly string Target;

	public readonly string Source;

	public readonly string ComponentName;

	public readonly string ComponentZip;

	public readonly string ComponentMd5;

	public readonly string ComponentCache;

	public readonly string ComponentExtension;

	public readonly EntitySubItemDownload Item;

	public readonly bool IsShaderPack;

	public readonly bool IsResourcePack;

	internal static ComponentPath ReflectEfficientVerifier;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ComponentPath(string @base, EntityItemDownload download, EntitySubItemDownload subItem)
	{
		//IL_00ee: Expected I4, but got Obj
		//IL_029c: Expected Obj, but got I4
		//IL_01e8: Expected Obj, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected I4, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected I4, but got Unknown
		//IL_041e: Expected Obj, but got I4
		//IL_048d: Expected Obj, but got I4
		//IL_0015->IL0029: Incompatible stack types: Obj vs Ref
		//IL_0020->IL0029: Incompatible stack types: I4 vs Ref
		//IL_0433->IL0029: Incompatible stack heights: 4 vs 1
		//IL_04b1->IL0029: Incompatible stack heights: 4 vs 1
		//IL_01ed->IL0025: Incompatible stack heights: 1 vs 0
		//IL_0327->IL0029: Incompatible stack heights: 4 vs 1
		//IL_04c0->IL0029: Incompatible stack heights: 0 vs 1
		//IL_01d0->IL0029: Incompatible stack heights: 0 vs 1
		//IL_02af->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0378->IL0029: Incompatible stack types: I4 vs Ref
		//IL_01a1->IL0029: Incompatible stack heights: 3 vs 1
		//IL_02f1->IL0029: Incompatible stack heights: 0 vs 1
		//IL_02e2->IL0029: Incompatible stack heights: 4 vs 1
		//IL_0351->IL0029: Incompatible stack types: I4 vs Ref
		//IL_03ca->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0138->IL0029: Incompatible stack heights: 4 vs 1
		//IL_0360->IL0029: Incompatible stack heights: 0 vs 1
		//IL_0255->IL0029: Incompatible stack heights: 0 vs 1
		//IL_03e4->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0443->IL0029: Incompatible stack heights: 0 vs 1
		//IL_030b->IL0029: Incompatible stack heights: 0 vs 1
		//IL_0108->IL0025: Incompatible stack heights: 3 vs 0
		//IL_0118->IL0029: Incompatible stack heights: 4 vs 1
		//IL_04da->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0470->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0388->IL0029: Incompatible stack types: I4 vs Ref
		//IL_021a->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0401->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0275->IL0029: Incompatible stack heights: 0 vs 1
		//IL_0029->IL0029: Incompatible stack types: Obj vs Ref
		//IL_01b6->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0192->IL0029: Incompatible stack types: I4 vs Ref
		//IL_04cb->IL0029: Incompatible stack types: I4 vs Ref
		//IL_01db->IL0029: Incompatible stack types: I4 vs Ref
		//IL_015d->IL0029: Incompatible stack heights: 0 vs 1
		//IL_02fc->IL0029: Incompatible stack types: I4 vs Ref
		//IL_03d5->IL0029: Incompatible stack heights: 3 vs 1
		//IL_036b->IL0029: Incompatible stack types: I4 vs Ref
		//IL_0260->IL0029: Incompatible stack types: I4 vs Ref
		//IL_03ef->IL0029: Incompatible stack heights: 2 vs 1
		//IL_044e->IL0029: Incompatible stack types: I4 vs Ref
		//IL_0316->IL0029: Incompatible stack types: I4 vs Ref
		//IL_047b->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0225->IL0029: Incompatible stack heights: 2 vs 1
		//IL_040c->IL0029: Incompatible stack heights: 3 vs 1
		//IL_02d2->IL0029: Incompatible stack types: I4 vs Ref
		//IL_023a->IL0029: Incompatible stack heights: 0 vs 1
		//IL_0280->IL0029: Incompatible stack types: I4 vs Ref
		//IL_01c1->IL0029: Incompatible stack heights: 2 vs 1
		//IL_0168->IL0029: Incompatible stack types: I4 vs Ref
		//IL_0245->IL0029: Incompatible stack types: I4 vs Ref
		//IL_053f->IL0029: Incompatible stack heights: 3 vs 1
		//IL_0514->IL0029: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		ref object reference = ref *(object*)this;
		if (4 != 0)
		{
			reference = ref *(object*)4;
		}
		object obj = default;
		while (true)
		{
			switch ((uint)Unsafe.AsPointer(ref reference))
			{
			case 36u:
				obj = 40;
				goto IL_0025;
			case 37u:
				_ = 8;
				break;
			case 29u:
				_ = 33;
				break;
			case 20u:
				switch (obj - 3)
				{
				case 0:
					goto IL_0246;
				case 2:
					goto IL_02d2;
				case 1:
					goto IL_0343;
				case 3:
					goto IL_04b1;
				}
				if (5 != 0)
				{
					reference = ref *(object*)2;
				}
				break;
			case 7u:
				reference = ref obj;
				if (23 != 0)
				{
					reference = ref *(object*)42;
				}
				break;
			case 19u:
				_ = ref obj;
				_ = 22;
				break;
			case 22u:
				throw ref obj;
			case 6u:
			case 13u:
			case 28u:
				if (34 == 0)
				{
					_ = 9;
				}
				break;
			case 12u:
				obj = (object)/*Error near IL_01c4: Stack underflow*/;
				if (17 == 0)
				{
					reference = ref *(object*)28;
				}
				break;
			case 9u:
				_ = ref obj;
				obj = 19;
				goto IL_0025;
			case 42u:
				_ = ref obj;
				if (false)
				{
					_ = 0;
				}
				break;
			case 46u:
				if ((nint)obj != 18)
				{
					if (6 != 0)
					{
						reference = ref *(object*)43;
					}
					break;
				}
				goto case 30u;
			case 2u:
				return;
			case 32u:
				goto IL_0246;
			case 15u:
				throw ref obj;
			case 1u:
			case 16u:
				obj = obj;
				if (17 == 0)
				{
					reference = ref *(object*)15;
				}
				break;
			case 4u:
				obj = download;
				obj = 45;
				goto IL_0025;
			case 14u:
				_ = ref obj;
				_ = 38;
				break;
			case 45u:
				switch (obj - 3)
				{
				case 0:
					break;
				default:
					goto IL_02c8;
				case 3:
					goto IL_02e2;
				case 1:
					goto IL_02fc;
				case 2:
					goto IL_03ef;
				}
				goto case 12u;
			case 5u:
			case 24u:
				goto IL_02d2;
			case 21u:
				goto IL_02e2;
			case 35u:
				goto IL_02fc;
			case 10u:
				_ = 27;
				break;
			case 26u:
				goto IL_0343;
			case 30u:
				obj = (object)/*Error near IL_0354: Stack underflow*/;
				if (0 == 0)
				{
					reference = ref *(object*)1;
				}
				break;
			case 18u:
				obj = (object)/*Error near IL_036e: Stack underflow*/;
				reference = ref *(object*)16;
				break;
			case 40u:
				obj = download;
				reference = ref *(object*)47;
				break;
			case 27u:
				if (2 == 0)
				{
					_ = 2;
				}
				break;
			case 33u:
				if (37 == 0)
				{
					_ = 14;
				}
				break;
			case 25u:
			case 44u:
				goto IL_03ef;
			default:
				throw ref obj;
			case 17u:
			case 23u:
			case 31u:
				obj = obj;
				obj = 36;
				goto IL_0025;
			case 3u:
				_ = ref obj;
				_ = 11;
				_ = 1;
				_ = 14;
				break;
			case 34u:
				obj = download;
				if (20 == 0)
				{
					reference = ref *(object*)8;
				}
				break;
			case 39u:
				_ = (nint)download == 6;
				if (29 != 0)
				{
					_ = 2;
				}
				break;
			case 43u:
				if ((nint)obj == 19)
				{
					obj = 18;
					goto IL_0025;
				}
				goto case 3u;
			case 8u:
				_ = 10;
				break;
			case 11u:
				goto IL_04b1;
			case 38u:
				_ = ref obj;
				_ = 15;
				break;
			case 47u:
				_ = 41;
				break;
			case 41u:
				{
					_ = 39;
					break;
				}
				IL_02d2:
				_ = ref obj;
				_ = 9;
				_ = 1;
				_ = 7;
				break;
				IL_0343:
				obj = download;
				reference = ref *(object*)46;
				break;
				IL_0246:
				obj = (object)/*Error near IL_0249: Stack underflow*/;
				if (2 == 0)
				{
					reference = ref *(object*)23;
				}
				break;
				IL_0025:
				reference = ref *(object*)obj;
				break;
				IL_03ef:
				_ = ref obj;
				_ = 9;
				_ = 1;
				if (6 != 0)
				{
					_ = 9;
				}
				break;
				IL_02fc:
				obj = (object)/*Error near IL_02ff: Stack underflow*/;
				if (6 == 0)
				{
					reference = ref *(object*)1;
				}
				break;
				IL_02e2:
				obj = (object)/*Error near IL_02e5: Stack underflow*/;
				if (13 != 0)
				{
					reference = ref *(object*)2;
				}
				break;
				IL_02c8:
				reference = ref *(object*)25;
				break;
				IL_04b1:
				obj = (object)/*Error near IL_04b4: Stack underflow*/;
				if (18 == 0)
				{
					reference = ref *(object*)31;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CloseRecord()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ComponentPath DecorateGlobalComparator()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00焀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778385, new IntPtr(2737337538764L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00爀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00猀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778384, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00稀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778383, new IntPtr(2737337563724L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00笀()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}
}
