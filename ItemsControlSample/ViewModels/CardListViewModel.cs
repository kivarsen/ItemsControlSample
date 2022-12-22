using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ItemsControlSample.ViewModels
{
    public class CardListViewModel : ViewModelBase
    {
        public CardListViewModel()
        {
            Cards = new ObservableCollection<CardViewModel> {
                new CardViewModel { Name = "Item1", Price = 1.24 },
                new CardViewModel { Name = "Item2", Price = 2.24 },
                new CardViewModel { Name = "Item3", Price = 3.24 },
                new CardViewModel { Name = "Item4", Price = 4.24 },
                new CardViewModel { Name = "Item5", Price = 5.24 }
            };
        }

        public ObservableCollection<CardViewModel> Cards { get; }
    }
}
