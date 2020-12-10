using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public interface IFile
    {
        Guid Guid { get; set; }
        string Name { get; set; }
        decimal Size { get; set; }
        string Location { get; set; }
        string Type { get; set; }
    }
}