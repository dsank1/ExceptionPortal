﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFamework.Security
{
	public partial class UserCd
	{
		public int UserCdId { get; set; }
		public Guid EntityGuid { get; set; }
		public string UserCdName { get; set; }
		public bool IsSuppressed { get; set; }
		public DateTime CreatedDt { get; set; }
		public int CreatedByUserId { get; set; }
		public DateTime? UpdatedDt { get; set; }
		public int? UpdatedByUserId { get; set; }
		public Guid LastUpdateGuid { get; set; }
	}
}
