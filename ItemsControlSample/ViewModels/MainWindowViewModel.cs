using System;
using System.Collections.Generic;
using System.Text;

namespace ItemsControlSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public CardListViewModel CardList { get; } = new CardListViewModel();

        public void AddItem()
        {
            CardList.Cards.Add(new CardViewModel {
                Name="New item",
                Price=2.34
            });
        }
    }
}
