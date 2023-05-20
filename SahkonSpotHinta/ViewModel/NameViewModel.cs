using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SahkonSpotHinta.ViewModel
{
	public class NameViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public NameViewModel() 
		{
			name = Preferences.Default.Get("name", "nimetön");
		}
		private string name;
		public string Name
		{
			get => name;
			set
			{
				if (name == value) return;
				name = value;
				RaisePropertyChanged();
			}
		}

		private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			Preferences.Default.Set("name", name);
		}
	}
}
