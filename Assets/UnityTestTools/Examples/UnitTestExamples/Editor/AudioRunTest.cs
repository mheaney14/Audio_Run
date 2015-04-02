using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using UnityEngine;

namespace UnityTest
{
    [TestFixture]
    [Category("Sample Tests")]
    internal class AudioRunTest
    {
		[Test]
		public static void TestPause()
		{
			Time.timeScale = 1;
			PauseGame.pause ();
			Assert.That (Time.timeScale == 0);
		}
		
		[Test]
		public static void TestChangeScene()
		{
			ManagerScript.changeScene ("Runner");
			//Assert.That (Application.loadedLevelName == "Runner");
			Assert.That (String.Equals (Application.loadedLevelName,"Runner"));
		}
	}
}
