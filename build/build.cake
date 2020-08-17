#tool "nuget:?package=NUnit.ConsoleRunner&version=3.11.1"

var target = Argument("target", "Default");
var buildConfig = "Debug";
var solution = "../TddTrainingDay01.sln";

Task("Default")
    .IsDependentOn("Test");

Task("Build")
    .Does(() => {
        var buildSettings = new DotNetCoreBuildSettings
            {
                Configuration = buildConfig,
                NoRestore = false
            };

        DotNetCoreBuild(solution, buildSettings);
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() => {
        var projects = GetFiles("../test/**/*.Test.csproj");
        var testSettings = new DotNetCoreTestSettings() {
            Configuration = buildConfig,
            NoBuild = true
        };
        foreach(var project in projects) {
            DotNetCoreTest(project.FullPath, testSettings);
        }
    });

RunTarget(target);
