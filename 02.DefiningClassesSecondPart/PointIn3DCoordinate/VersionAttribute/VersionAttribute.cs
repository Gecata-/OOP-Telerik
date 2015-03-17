//Problem 11. Version attribute

//Create a [Version] attribute that can be applied to structures, classes, interfaces, 
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.

namespace DefiningClassesSecondPart.VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
                                                    AttributeTargets.Enum | AttributeTargets.Method , AllowMultiple = false)]

    public class Version : Attribute
    {
        public int major { get; set; }
        public int minor { get; set; }


        public Version(string version)
        {
            string[] versionParts = version.Split('.');

            this.major = int.Parse(versionParts[0]);
            this.minor = int.Parse(versionParts[1]);
        }
    }

}
