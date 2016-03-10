﻿using GalaSoft.MvvmLight;

namespace ObservableTables
{
	public class TaskModel :ObservableObject
	{
		public TaskModel()
		{
		}

		public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
	}
}

