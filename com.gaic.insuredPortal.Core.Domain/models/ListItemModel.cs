namespace com.gaic.insuredPortal.Core.Domain.models
{
    public class ListItemModel
    {
        public ListItemModel(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public string Code { get; set; }
        public string Description { get; set; }
    }
}