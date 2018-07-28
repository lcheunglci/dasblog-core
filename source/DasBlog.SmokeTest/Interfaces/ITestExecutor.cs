﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DasBlog.SmokeTest.Interfaces
{
	public interface ITestExecutor
	{
		void Execute(IList<TestStep> steps, TestResults testResults, [CallerMemberName] string testName = null);
	}
}
