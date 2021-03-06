﻿using MGXRM.Common.Framework.Interfaces;
using Microsoft.Xrm.Sdk;

namespace MGXRM.Common.Framework.Model
{
    public abstract class ModelBase<T> where T : Entity
    {
        protected IImageManager<T> Images { get; }
        protected IContextManager<T> Context { get; }
        protected IRepository Repository { get; }

        protected ModelBase(IImageManager<T> images, IContextManager<T> context, IRepository repository)
        {
            Images = images;
            Context = context;
            Repository = repository;
        }
    }
}
