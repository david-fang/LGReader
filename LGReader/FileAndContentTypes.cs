using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace LGReader
{
    internal static class FileAndContentTypeDefinitions
    {
        [Export]
        [Name("lg")]
        [BaseDefinition("text")]
        internal static ContentTypeDefinition hidingContentTypeDefinition;

        [Export]
        [FileExtension(".lg")]
        [ContentType("lg")]
        internal static FileExtensionToContentTypeDefinition languageGenerationFileExtensionDefinition;
    }
}
