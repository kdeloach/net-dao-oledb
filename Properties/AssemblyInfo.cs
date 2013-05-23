﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Azavea.Open.DAO.OleDb")]
[assembly: AssemblyDescription("OleDb adapter for FastDAO, an object-relational mapper for the .NET framework")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("FastDAO")]
// Configure log4net using the .config file
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("42bf7382-f905-4c78-84e0-53f9ebb78d8c")]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("Azavea")]
[assembly: AssemblyCopyright("Copyright © Azavea 2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.5.0")]
[assembly: AssemblyFileVersion("1.0.5.0")]
// Used for nuget packaging
[assembly: AssemblyInformationalVersion("1.0.5")]