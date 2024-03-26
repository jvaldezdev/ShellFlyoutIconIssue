namespace ShellFlyoutIconIssue.Helpers;

public static class Icons
{
    public static FontImageSource ModalFlyout { get; } = new()
    {
        Glyph = DeviceInfo.Platform.Equals(DevicePlatform.Android) ? ArrowLeft : ChevronLeft,
        Size = 24,
        FontFamily = "MDI"
    };

    public const string ArrowLeft = "\U000f004d";
    public const string ChevronLeft = "\U000f0141";
    public const string HomeOutline = "\U000f06a1";
}