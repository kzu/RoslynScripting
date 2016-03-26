// Guids.cs
// MUST match guids.h
using System;

namespace Scripting.AboutBoxPackage
{
	static class GuidList
	{
		public const string guidAboutBoxPackagePkgString = "c9538008-d54a-4d34-8292-28890adc23a9";
		public const string guidAboutBoxPackageCmdSetString = "29eea736-c712-4f62-af5b-7f9f82808e74";

		public static readonly Guid guidAboutBoxPackageCmdSet = new Guid(guidAboutBoxPackageCmdSetString);
	};
}