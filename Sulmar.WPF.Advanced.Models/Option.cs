namespace Sulmar.WPF.Advanced.Models
{
    public class Option : Base
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public OptionType Type { get; set; }
    }

    public enum OptionType
    {
        Text,
        Numeric,
        Logical
    }
}
