﻿using System;

namespace AntData.ORM.Mapping
{
	public class InheritanceMapping
	{
		public object           Code;
		public bool             IsDefault;
		public Type             Type;
		public ColumnDescriptor Discriminator;

		public string DiscriminatorName
		{
			get { return Discriminator.MemberName; }
		}
	}
}
