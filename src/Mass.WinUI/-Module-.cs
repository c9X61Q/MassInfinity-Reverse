using Microsoft.Windows.ApplicationModel.WindowsAppRuntime.Common;
using WinRT.Mass_WinUIGenericHelpers;

internal class _003CModule_003E
{
	internal static _003CModule_003E ExecuteAttribute;

	static _003CModule_003E()
	{
		ZYXDNGuarder.Startup();
		ZYDNGuard();
	}

	internal static void m8DF246D1D4E3A30()
	{
	}

	internal static bool DetachAttribute()
	{
		return ExecuteAttribute == null;
	}

	internal static _003CModule_003E CheckAccessibleAttribute()
	{
		return ExecuteAttribute;
	}

	static void ZYDNGuard()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				m8DF246D1D4E3A30();
				num2 = 2;
				break;
			case 2:
				AutoInitialize.InitializeWindowsAppSDK();
				num2 = 0;
				if (_003CModule_003E_007Bcdc0cbc7_002D464a_002D4cb5_002D949f_002Deb12b1e2047b_007D.m_1f9c47eae2c64b22a37472c24214705c.m_f2626ee8eb4b455e805efc5c95f39047 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				GlobalVtableLookup.InitializeGlobalVtableLookup();
				num2 = 1;
				if (_003CModule_003E_007Bcdc0cbc7_002D464a_002D4cb5_002D949f_002Deb12b1e2047b_007D.m_1f9c47eae2c64b22a37472c24214705c.m_592d9c1f2e9d4a42bdcc326ceacafc61 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}
}
