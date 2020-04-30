using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_8.Models
{
   public class ToDoModel: INotifyPropertyChanged
    {
		public string CreationDate { get; set; } = DateTime.Now.ToString("dd.MM.yyyy");
		private bool _isDone;
		private string _todoDescription;
		private string _todoCategory;
		private string _todoPriority;
		private int _daysLeft;
		private string _todoDeadline;

		public bool IsDone
		{
			get { return _isDone; }
			set
			{
				if (_isDone == value)
					return;
				_isDone = value;
				OnPropertyChanged("isDone");
			}
		}

		public string ToDoCategory
		{
			get { return _todoCategory; }
			set
			{
				_todoCategory = value;
				OnPropertyChanged("ToDoCategory");
			}
		}

		public string ToDoDescription
		{
			get { return _todoDescription; }
			set 
			{
				if (_todoDescription == value)
					return;
				_todoDescription = value;
				OnPropertyChanged("ToDoDescription");
			}
		}

		public string ToDoPriority
		{
			get { return _todoPriority; }
			set
			{
				_todoPriority = value;
				OnPropertyChanged("ToDoPriority");
			}
		}

		public string ToDoDeadline
		{
			get { return _todoDeadline; }
			set
			{
				if (_todoDeadline == DateTime.Parse(value).ToShortDateString())
					return;

				_todoDeadline = DateTime.Parse(value).ToShortDateString();
				OnPropertyChanged("todoDeadline");
			}
		}

		public int DaysLeft
		{
			get { return _daysLeft; }
			set
			{
				_daysLeft = Convert.ToInt32(DateTime.Parse(_todoDeadline).Subtract(DateTime.Parse(CreationDate)).TotalDays);
				OnPropertyChanged("daysLeft");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
