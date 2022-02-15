﻿using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace AsyncApostle.AsyncHelpers.MissingAwaitChecker;

public interface IMissingAwaitChecker
{
   #region methods

   bool AwaitIsMissing(IInvocationExpression invocationExpression, IReturnStatement? returnStatement);

   #endregion
}