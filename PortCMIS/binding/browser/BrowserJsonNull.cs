namespace PortCMIS.binding.browser
{
    /// <summary>The null value for Json</summary>
    internal static class BrowserJsonNull
    {
        /// <summary>Default null string</summary>
        private const string DefaultValue = "null";

        /// <summary>Get the null value string</summary>
        public static string Value { get; set; } = DefaultValue;
    }
}
