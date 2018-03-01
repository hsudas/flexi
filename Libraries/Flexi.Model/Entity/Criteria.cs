namespace Flexi.Model
{
    public class Criteria
    {
        public string Key { get; set; }
        public object Value { get; set; }

        public string GetTypeName()
        {
            if (Value == null)
            {
                return "";
            }
            else
            {
                return Value.GetType().Name;
            }
        }

    }
}
