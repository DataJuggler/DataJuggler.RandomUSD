

#region using statements


#endregion

using System.Runtime.CompilerServices;

namespace DataJuggler.RandomUSD
{

    #region class Settings
    /// <summary>
    /// This class [Enter Class Description]
    /// </summary>
    public class Settings
    {
        
        #region Private Variables
        private int scaleMin;
        private int scaleMax;        
        private int translateXMax;
        private int translateXMin;
        private int translateYMax;
        private int translateYMin;
        private int translateZMax;
        private int translateZMin;
        private string emptyUSDPath;
        private string outputFolderPath;
        private string outputFileName;
        private int objectsToCreate;
        private string objectTagName;
        private string lineBeforeLastBracketText;
        private string scaleTagText;
        private string translateTagText;
        private int additionalX;
        private int additionalY;
        private int additionalZ;
        private int additionalScale;
        private string objectName;
        private bool smallScale;        
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Settings object
        /// </summary>
        public Settings()
        {
            // Default values
            ScaleTagText = "[ScaleX]";
            TranslateTagText = "[TranslateX]";
            ScaleMin = 1;
            ScaleMax = 5;            
        }
        #endregion

        #region Properties

            #region AdditionalScale
            /// <summary>
            /// This property gets or sets the value for 'AdditionalScale'.
            /// </summary>
            public int AdditionalScale
            {
                get { return additionalScale; }
                set { additionalScale = value; }
            }
            #endregion
            
            #region AdditionalX
            /// <summary>
            /// This property gets or sets the value for 'AdditionalX'.
            /// </summary>
            public int AdditionalX
            {
                get { return additionalX; }
                set { additionalX = value; }
            }
            #endregion
            
            #region AdditionalY
            /// <summary>
            /// This property gets or sets the value for 'AdditionalY'.
            /// </summary>
            public int AdditionalY
            {
                get { return additionalY; }
                set { additionalY = value; }
            }
            #endregion
            
            #region AdditionalZ
            /// <summary>
            /// This property gets or sets the value for 'AdditionalZ'.
            /// </summary>
            public int AdditionalZ
            {
                get { return additionalZ; }
                set { additionalZ = value; }
            }
            #endregion
            
            #region EmptyUSDPath
            /// <summary>
            /// This property gets or sets the value for 'EmptyUSDPath'.
            /// </summary>
            public string EmptyUSDPath
            {
                get { return emptyUSDPath; }
                set { emptyUSDPath = value; }
            }
            #endregion
            
            #region LineBeforeLastBracketText
            /// <summary>
            /// This property gets or sets the value for 'LineBeforeLastBracketText'.
            /// </summary>
            public string LineBeforeLastBracketText
            {
                get { return lineBeforeLastBracketText; }
                set { lineBeforeLastBracketText = value; }
            }
            #endregion
            
            #region ObjectName
            /// <summary>
            /// This property gets or sets the value for 'ObjectName'.
            /// </summary>
            public string ObjectName
            {
                get { return objectName; }
                set { objectName = value; }
            }
            #endregion
            
            #region ObjectsToCreate
            /// <summary>
            /// This property gets or sets the value for 'ObjectsToCreate'.
            /// </summary>
            public int ObjectsToCreate
            {
                get { return objectsToCreate; }
                set { objectsToCreate = value; }
            }
            #endregion
            
            #region ObjectTagName
            /// <summary>
            /// This property gets or sets the value for 'ObjectTagName'.
            /// </summary>
            public string ObjectTagName
            {
                get { return objectTagName; }
                set { objectTagName = value; }
            }
            #endregion
            
            #region OutputFileName
            /// <summary>
            /// This property gets or sets the value for 'OutputFileName'.
            /// </summary>
            public string OutputFileName
            {
                get { return outputFileName; }
                set { outputFileName = value; }
            }
            #endregion
            
            #region OutputFolderPath
            /// <summary>
            /// This property gets or sets the value for 'OutputFolderPath'.
            /// </summary>
            public string OutputFolderPath
            {
                get { return outputFolderPath; }
                set { outputFolderPath = value; }
            }
            #endregion
            
            #region ScaleMax
            /// <summary>
            /// This property gets or sets the value for 'ScaleMax'.
            /// </summary>
            public int ScaleMax
            {
                get { return scaleMax; }
                set { scaleMax = value; }
            }
            #endregion
            
            #region ScaleMin
            /// <summary>
            /// This property gets or sets the value for 'ScaleMin'.
            /// </summary>
            public int ScaleMin
            {
                get { return scaleMin; }
                set { scaleMin = value; }
            }
            #endregion
            
            #region ScaleTagText
            /// <summary>
            /// This property gets or sets the value for 'ScaleTagText'.
            /// </summary>
            public string ScaleTagText
            {
                get { return scaleTagText; }
                set { scaleTagText = value; }
            }
            #endregion
            
            #region SmallScale
            /// <summary>
            /// This property gets or sets the value for 'SmallScale'.
            /// </summary>
            public bool SmallScale
            {
                get { return smallScale; }
                set { smallScale = value; }
            }
            #endregion
            
            #region TranslateTagText
            /// <summary>
            /// This property gets or sets the value for 'TranslateTagText'.
            /// </summary>
            public string TranslateTagText
            {
                get { return translateTagText; }
                set { translateTagText = value; }
            }
            #endregion
            
            #region TranslateXMax
            /// <summary>
            /// This property gets or sets the value for 'TranslateXMax'.
            /// </summary>
            public int TranslateXMax
            {
                get { return translateXMax; }
                set { translateXMax = value; }
            }
            #endregion
            
            #region TranslateXMin
            /// <summary>
            /// This property gets or sets the value for 'TranslateXMin'.
            /// </summary>
            public int TranslateXMin
            {
                get { return translateXMin; }
                set { translateXMin = value; }
            }
            #endregion
            
            #region TranslateYMax
            /// <summary>
            /// This property gets or sets the value for 'TranslateYMax'.
            /// </summary>
            public int TranslateYMax
            {
                get { return translateYMax; }
                set { translateYMax = value; }
            }
            #endregion
            
            #region TranslateYMin
            /// <summary>
            /// This property gets or sets the value for 'TranslateYMin'.
            /// </summary>
            public int TranslateYMin
            {
                get { return translateYMin; }
                set { translateYMin = value; }
            }
            #endregion
            
            #region TranslateZMax
            /// <summary>
            /// This property gets or sets the value for 'TranslateZMax'.
            /// </summary>
            public int TranslateZMax
            {
                get { return translateZMax; }
                set { translateZMax = value; }
            }
            #endregion
            
            #region TranslateZMin
            /// <summary>
            /// This property gets or sets the value for 'TranslateZMin'.
            /// </summary>
            public int TranslateZMin
            {
                get { return translateZMin; }
                set { translateZMin = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
