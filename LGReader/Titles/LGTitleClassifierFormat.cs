using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace LGReader.Titles
{
    /// <summary>
    /// Defines an editor format for the LGTitleClassifier type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "LGTitleClassifier")]
    [Name("LGTitleClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(Before = Priority.Default)] // Set the priority to be after the default classifiers
    internal sealed class LGTitleClassifierFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LGTitleClassifierFormat"/> class.
        /// </summary>
        public LGTitleClassifierFormat()
        {
            this.DisplayName = "LGTitleClassifier"; // Human readable version of the name
            this.ForegroundColor = ThemeConstants.TitleForegroundColor;
            this.IsBold = true;
        }
    }
}
