using System;
using System.Collections.ObjectModel;

namespace AvaloniaHorizontalWheelBug
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Entry> Entries { get; set; }

        public MainWindowViewModel()
        {
            Entries = new ObservableCollection<Entry>();

            for (int i = 0; i < 50; i++)
            {
                Entries.Add(new Entry()
                {
                    Expiry = new DateTime(),
                    Id = $"Id {i}",
                    Status = $"Status {i}",
                    Symbol = $"Symbol {i}",
                    Type = $"Type {i}"
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
