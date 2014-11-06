namespace iLab11ProtoNg.Core.Domain
{
    public class LookupListItem
    {
        public LookupListItem(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public string Code { get; set; }
        public string Description { get; set; }
    }
}