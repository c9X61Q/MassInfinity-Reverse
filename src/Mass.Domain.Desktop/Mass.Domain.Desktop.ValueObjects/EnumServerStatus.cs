namespace Mass.Domain.Desktop.ValueObjects;

public enum EnumServerStatus
{
	None = -1,
	ServerOff,
	ServerOn,
	Uninitialized,
	Opening,
	Closing,
	OutOfDate,
	SaveCleaning,
	Resetting,
	Upgrading,
	DiscOverflow
}
