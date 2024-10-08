﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class EfDavaTurDal : EfEntityRepositoryBase<DavaTur, Context>, IDavaTurDal
	{
		public EfDavaTurDal(Context context) : base(context)
		{
		}
	}
}