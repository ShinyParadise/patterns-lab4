namespace Lab4.Models
{
    public class SubscribersList
    {
        private SubscribersList()
        {
            Subscribers = new();
        }

        public void AddSub(Subscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void RemoveSub(Subscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public static SubscribersList Instance
        {
            get
            {
                if (_instance == null) _instance = new();
                return _instance;
            }
        }

        public Subscriber this[int i]
        {
            get { return Subscribers[i]; }
        }

        public Subscriber? FindSub(int userId)
        {
            return Subscribers.FirstOrDefault(x => x.Id == userId);
        }

        public int SubCount => Subscribers.Count;

        public List<Subscriber> Subscribers { get; private set; }
        private static SubscribersList? _instance;
    }
}
