using System;
using System.Collections.ObjectModel;

namespace AvaloniaHorizontalWheelBug
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Entry> Entries { get; set; }

        private Random _random = new Random();

        public MainWindowViewModel()
        {
            Entries = new ObservableCollection<Entry>();

            for (int i = 0; i < 50; i++)
            {
                Entries.Add(new Entry()
                {
                    Expiry = new DateTime(),
                    Id = (_random.Next() * 10000).ToString(),
                    Status = (_random.Next() * 10000).ToString(),
                    Symbol = (_random.NextDouble() * 1000000.0).ToString(),
                    Type = (_random.Next() * 10000).ToString(),
                });
            }
        }
    }

    public class Entry
    {
        public string Id { get; set; }
        public string Status { get; set; }

        public string Symbol { get; set; }

        public DateTime Expiry { get; set; }

        public string Type { get; set; }
    }
}
