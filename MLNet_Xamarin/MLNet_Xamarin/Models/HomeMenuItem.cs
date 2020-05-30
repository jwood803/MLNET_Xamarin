namespace MLNet_Xamarin.Models
{
    public enum MenuItemType
    {
        Browse,
        Predict
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
