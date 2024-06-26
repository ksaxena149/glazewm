namespace GlazeWM.Domain.UserConfigs
{
  /// <summary>
  /// <para>
  /// A component to display information about the battery of the device, namely the battery level and
  /// whether the device is connected to power or is in power saving mode.
  /// </para>
  /// <para>
  /// There are 3 labels that are used depending on the situation, and the variable
  /// <c>{battery_level}</c> is replaced with the current battery level of the device.
  /// </para>
  /// <para>
  /// When the device does not have a dedicated battery, the battery level is displayed
  /// as 100% at all times.
  /// </para>
  /// </summary>
  public class BatteryComponentConfig : BarComponentConfig
  {
    /// <summary>
    /// Formatted text to display when the device is draining battery power with percentage greater than 80.
    /// </summary>
    public string LabelHigh { get; set; } = "{battery_level}% (high)";
    /// <summary>
    /// Formatted text to display when the device is draining battery power with percentage greater than 40.
    /// </summary>
    public string LabelMedium { get; set; } = "{battery_level}% (medium)";
    /// <summary>
    /// Formatted text to display when the device is draining battery power with percentage less than 40.
    /// </summary>
    public string LabelLow { get; set; } = "{battery_level}% (low)";
    /// <summary>
    /// Formatted text to display when the device is in power saving mode.
    /// </summary>
    public string LabelPowerSaver { get; set; } = "{battery_level}% (power saver)";
    /// <summary>
    /// Formatted text to display when the device is connected to power.
    /// </summary>
    public string LabelCharging { get; set; } = "{battery_level}% (charging)";
  }
}
