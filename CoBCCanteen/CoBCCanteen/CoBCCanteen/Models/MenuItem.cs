﻿using System;
using SQLite;

namespace CoBCCanteen.Models
{
	[Table("Menu")]
	public class MenuItem
	{
		[PrimaryKey, AutoIncrement, Column("Id"), NotNull]
		public int Id { get; set; }
		[MaxLength(64), Column("Name"), NotNull]
		public string Name { get; set; }
		[MaxLength(64), Column("Type"), NotNull]
		public string Type { get; set; }
		[MaxLength(32)]
		public string Container { get; set; }
		[Column("Price"), NotNull]
		public int Price { get; set; }
		[MaxLength(254), Column("Description"), NotNull]
		public string Description { get; set; }
		[Column("Image"), NotNull]
		public Uri Image { get; set; }
		[Column("Stock"), NotNull]
		public int Stock { get; set; }
		[Column("Available"), NotNull]
		public bool Available { get; set; }
		[Column("Rotation")]
		public string Rotation { get; set; }
		[Column("Calories"), NotNull]
		public int Calories { get; set; }
		[Column("Fats"), NotNull]
		public float Fats { get; set; }
		[Column("Saturates"), NotNull]
		public float Saturates { get; set; }
		[Column("Sugars"), NotNull]
		public float Suagrs { get; set; }
		[Column("Salts"), NotNull]
		public float Salts { get; set; }
		[Column("Allergens"), NotNull]
		public string Allergens { get; set; }
	}
}

