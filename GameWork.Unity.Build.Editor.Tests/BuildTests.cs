﻿using System.IO;
using NUnit.Framework;
using UnityEditor;

namespace GameWork.Unity.Editor.Build.Tests
{
    [TestFixture]
    public static class BuildTests
    {
        [TestCase(BuildTarget.Android)]
        [TestCase(BuildTarget.iOS)]
        [TestCase(BuildTarget.StandaloneWindows)]

        public static void Build(BuildTarget buildTarget)
        {
            var buildPath = Builder.Build(buildTarget);

            var buildExists = File.Exists(buildPath) || Directory.Exists(buildPath);

            Assert.True(buildExists, "The build does not exist: " + buildPath);
        }
    }
}