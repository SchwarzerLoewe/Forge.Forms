﻿using System.Windows.Controls;

namespace Forge.Forms.Collections.Interfaces
{
    public interface IColumnCreationInterceptor
    {
        IColumnCreationInterceptorContext Intercept(IColumnCreationInterceptorContext context);
    }
}