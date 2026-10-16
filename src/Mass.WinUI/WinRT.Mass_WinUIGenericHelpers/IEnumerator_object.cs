using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ABI.System.Collections.Generic;

namespace WinRT.Mass_WinUIGenericHelpers;

internal static class IEnumerator_object
{
	private static readonly nint _initialized = (int)Init();

	internal static object CheckIsolatedAttribute;

	internal static bool Initialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte Init()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_MoveNext_2(nint thisPtr, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00䀀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_GetMany_3(nint thisPtr, uint __itemsSize, nint items, uint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00䜀(thisPtr, __itemsSize, items, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_Current_0(nint thisPtr, nint* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00㴀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[UnmanagedCallersOnly(CallConvs = new Type[] { typeof(CallConvStdcall) })]
	private unsafe static uint Do_Abi_get_HasCurrent_1(nint thisPtr, byte* __return_value__)
	{
		return _FF00_FF00_FF00_FF00_FF00_FF00䘀(thisPtr, __return_value__);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAutomatableAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IEnumerator_object LoadAttribute()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00㤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775460, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte _FF00_FF00_FF00_FF00_FF00_FF00㨀()
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentNullException: Value cannot be null. (Parameter 'source')
		//    at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
		//    at System.Linq.Enumerable.Skip[TSource](IEnumerable`1 source, Int32 count)
		//    at ICSharpCode.Decompiler.CSharp.ArgumentList.GetArgumentResolveResultsDirect(Int32 skipCount) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 124
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Probe() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 493
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.Run() in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 438
		//    at ICSharpCode.Decompiler.CSharp.Disambiguator.ForMethodReference(ExpressionBuilder expressionBuilder, IMethod method, IType targetType, TranslatedExpression target, Boolean requireTarget, ExpectedTargetDetails expectedTargetDetails, Boolean isExtensionMethodReference, Boolean castTargetUpFront) in /_/ICSharpCode.Decompiler/CSharp/Disambiguator.cs:line 131
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.DisambiguateDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1718
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildDelegateReference(IMethod method, IMethod invokeMethod, ExpectedTargetDetails expectedTargetDetails, ILInstruction thisArg) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1648
		//    at ICSharpCode.Decompiler.CSharp.CallBuilder.BuildMethodReference(IMethod method, Boolean isVirtual) in /_/ICSharpCode.Decompiler/CSharp/CallBuilder.cs:line 1639
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitLdFtn(LdFtn inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 5058
		//    at ICSharpCode.Decompiler.IL.LdFtn.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 3175
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.VisitStObj(StObj inst, TranslationContext context) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 3166
		//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[C,T](ILVisitor`2 visitor, C context) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4386
		//    at ICSharpCode.Decompiler.CSharp.ExpressionBuilder.Translate(ILInstruction inst, IType typeHint) in /_/ICSharpCode.Decompiler/CSharp/ExpressionBuilder.cs:line 173
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitStObj(StObj inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 140
		//    at ICSharpCode.Decompiler.IL.StObj.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 4382
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockStatement blockStatement, BlockContainer container, IEnumerable`1 blocks, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1565
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertBlockContainer(BlockContainer container, Boolean isLoop) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1452
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.VisitBlockContainer(BlockContainer container) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 1338
		//    at ICSharpCode.Decompiler.IL.BlockContainer.AcceptVisitor[T](ILVisitor`1 visitor) in /_/ICSharpCode.Decompiler/IL/Instructions.cs:line 857
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.Convert(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 82
		//    at ICSharpCode.Decompiler.CSharp.StatementBuilder.ConvertAsBlock(ILInstruction inst) in /_/ICSharpCode.Decompiler/CSharp/StatementBuilder.cs:line 87
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2435
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㬀()
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001a: Expected Obj, but got I
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_FF00_FF00_FF00_FF00㰀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775461, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00㴀(nint P_0, nint* P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_0126->IL0026: Incompatible stack types: I4 vs Obj
		//IL_014d->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0131->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0158->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
			{
				obj = ExceptionHelpers.GetHRForException((Exception)P_0);
				int num = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						((Action<object[], nint>)P_1)((object[])obj, 1);
						*(_003F*)(nint)/*Error near IL_0088: Stack underflow*/ = /*Error near IL_0088: Stack underflow*/;
						num = 0;
						if (IList_object.PatchAttribute == null)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				goto case 1;
			}
			case 2:
				*P_1 = 0;
				obj2 = 0;
				if (IEnumerator_System_IDisposable.ReflectTransferableAttribute != null)
				{
					obj2 = 0;
				}
				break;
			case 1:
				return 0u;
			case 3:
				obj = null;
				obj2 = 2;
				if (IEnumerable_System_IDisposable.CombineAttribute != null)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00㸀(nint P_0, nint* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775458, new IntPtr(2737316775212L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00㼀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775459, new IntPtr(2737316770012L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䀀(nint P_0, byte* P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0043: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I
		//IL_014a->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0155->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0062->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				obj = 0;
				obj2 = 2;
				if (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged.JoinAttribute == null)
				{
					obj2 = 0;
				}
				break;
			default:
				return 0u;
			case 1:
				/*Error near IL_0069: Member reference must be method, but was: Field*/;
			case 2:
				*P_1 = 0;
				obj2 = 1;
				if (IEnumerable_System_IDisposable._initialized != 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䄀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775456, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䈀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized == unchecked((nint)null)) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䌀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775457, new IntPtr(2737316783532L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00_FF00_FF00_FF00_FF00_FF00䐀()
	{
		//IL_0011: Expected Obj, but got Ref
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		return (byte)IReadOnlyList_System_ComponentModel_INotifyPropertyChanged._initialized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䔀(nint P_0, byte* P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775470, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䘀(nint P_0, byte* P_1)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003b: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_0145->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0123->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0150->IL0026: Incompatible stack types: I4 vs Obj
		//IL_012e->IL0026: Incompatible stack types: I4 vs Obj
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
			{
				obj = ExceptionHelpers.GetHRForException((Exception)P_0);
				int num = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						*P_1 = ((obj != null) ? ((byte)1) : ((byte)0));
						num = 0;
						if (IList_object._initialized == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				break;
			}
			case 2:
				obj = 0;
				obj2 = 0;
				if (IEnumerator_System_IDisposable._initialized == 0)
				{
					obj2 = 1;
				}
				continue;
			case 1:
				*P_1 = 0;
				obj2 = 0;
				if (IEnumerable_System_IDisposable._initialized != 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				break;
			}
			break;
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䜀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0011: Expected Obj, but got Ref
		//IL_001d: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_013d: Expected Obj, but got I4
		//IL_016d: Expected I, but got Obj
		//IL_004d: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got I4
		//IL_008c: Expected I4, but got Obj
		//IL_0186->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0151->IL0026: Incompatible stack types: I4 vs Obj
		//IL_0179->IL0026: Incompatible stack heights: 2 vs 1
		//IL_015c->IL0026: Incompatible stack types: I4 vs Obj
		//IL_00c8->IL0072: Incompatible stack heights: 4 vs 2
		//IL_00d3->IL0072: Incompatible stack heights: 4 vs 2
		((ExceptionHelpers)Regex/*cast due to constrained. prefix*/).SetErrorInfo((Exception)Unsafe.AsPointer(ref _003CModule_003E.ExecuteAttribute));
		if ((int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
			{
				obj = ExceptionHelpers.GetHRForException((Exception)(&obj));
				int num = 1;
				if (IEnumerable_System_ComponentModel_INotifyPropertyChanged._initialized == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						*P_3 = (uint)(int)obj;
						num = 0;
						if (IList_object._initialized == 0)
						{
							num = 2;
						}
						continue;
					case 1:
						IEnumeratorMethods<object>.Abi_get_Current_0((IntPtr)P_2);
						_ = 0;
						if (IReadOnlyList_System_IDisposable._initialized == 0)
						{
							_ = 0;
						}
						continue;
					case 2:
						break;
					}
					break;
				}
				break;
			}
			case 1:
				obj = 0;
				obj2 = 0;
				if (IEnumerable_object._initialized != 0)
				{
					obj2 = 0;
				}
				continue;
			case 3:
				obj = IEnumerableMethods<INotifyPropertyChanged>.Abi_First_0((IntPtr)(nint)new IReadOnlyListMethods<INotifyPropertyChanged>((IntPtr)P_2));
				_ = 4;
				continue;
			default:
				*P_3 = 0u;
				obj2 = 3;
				continue;
			case 2:
				break;
			}
			break;
		}
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static uint _FF00_FF00_FF00_FF00_FF00_FF00䠀(nint P_0, uint P_1, nint P_2, uint* P_3)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790775471, new IntPtr(2737316780412L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}
}
