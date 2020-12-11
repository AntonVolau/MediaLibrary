using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.Enums;

namespace MediaLibrary.Implementation.DataModels
{
    public interface IFile
    {
        Guid Guid { get; set; }
        string Name { get; set; }
        decimal Size { get; set; }
        string Location { get; set; }
        MediaFileTypes Type { get; set; }
    }
}