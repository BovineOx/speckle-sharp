﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using Eto.Forms;

namespace ConnectorGrasshopper;

public class CSOViewModel : INotifyPropertyChanged
{
  private TreeGridItem selectedItem;

  public TreeGridItem SelectedItem
  {
    get => selectedItem;
    set
    {
      if (selectedItem != value)
      {
        selectedItem = value;
        OnPropertyChanged();
      }
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  private void OnPropertyChanged([CallerMemberName] string memberName = null)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
  }
}
