using Sitecore.Data;

namespace Sitecore.Feature.Events
{
  public struct Templates
  {
    public struct Event
    {
      public static readonly ID ID = new ID("{0191766A-0D85-4222-95D6-AD36905CFC2A}");
      public struct Fields
      {
        public static readonly ID Title = new ID("{BA255E88-5274-48F8-B13B-B58F2CBCB608}");
        public static readonly ID Description = new ID("{577F12B1-CE31-4EFB-B02E-CF9D7933DE2C}");
        public static readonly ID Date = new ID("{986163EA-481B-42A7-A00B-2A73A16EF08B}");
        public static readonly ID Venue = new ID("{7DA98158-B1E7-4F55-89EE-BB302AC1299A}");
        public static readonly ID VenueAddress = new ID("{34512D57-941D-42C9-8D8A-D86C05411890}");
      }
    }
  }
}