

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
        private string forceTagText;
        private string velocityTagText;
        private int additionalX;
        private int additionalY;
        private int additionalZ;
        private int additionalScale;
        private string objectName;
        private bool smallScale;
        private bool enableForce;
        private int velocityXMin;
        private int velocityYMin;
        private int velocityZMin;
        private int velocityXMax;
        private int velocityYMax;
        private int velocityZMax;
        private int forceXMin;
        private int forceYMin;
        private int forceZMin;
        private int forceXMax;
        private int forceYMax;
        private int forceZMax;
        private int forcePercent;
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
            ForceTagText = "[ForceX]";
            VelocityTagText = "[VelocityX]";
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
            
            #region EnableForce
            /// <summary>
            /// This property gets or sets the value for 'EnableForce'.
            /// </summary>
            public bool EnableForce
            {
                get { return enableForce; }
                set { enableForce = value; }
            }
            #endregion

            #region EnableForceX
            /// <summary>
            /// This read only property returns true if ForceXMin or Max is not zero
            /// </summary>
            public bool EnableForceX
            {
                
                get
                {
                    // initial value
                    bool enableForceX = ((ForceXMin != 0) || (ForceYMax != 0));
                    
                    // return value
                    return enableForceX;
                }
            }
            #endregion

            #region EnableForceY
            /// <summary>
            /// This read only property returns true if ForceYMin or Max is not zero
            /// </summary>
            public bool EnableForceY
            {
                
                get
                {
                    // initial value
                    bool enableForceY = ((ForceYMin != 0) || (ForceYMax != 0));
                    
                    // return value
                    return enableForceY;
                }
            }
            #endregion

            #region EnableForceZ
            /// <summary>
            /// This read only property returns true if ForceZMin or Max is not zero
            /// </summary>
            public bool EnableForceZ
            {
                
                get
                {
                    // initial value
                    bool enableForceZ = ((ForceZMin != 0) || (ForceZMax != 0));
                    
                    // return value
                    return enableForceZ;
                }
            }
            #endregion
            
            #region EnableVelocityX
            /// <summary>
            /// This read only property returns true if VelocityXMin or Max is not zero
            /// </summary>
            public bool EnableVelocityX
            {
                
                get
                {
                    // initial value
                    bool enableVelocityX = ((VelocityXMin != 0) || (VelocityYMax != 0));
                    
                    // return value
                    return enableVelocityX;
                }
            }
            #endregion

            #region EnableVelocityY
            /// <summary>
            /// This read only property returns true if VelocityYMin or Max is not zero
            /// </summary>
            public bool EnableVelocityY
            {
                
                get
                {
                    // initial value
                    bool enableVelocityY = ((VelocityYMin != 0) || (VelocityYMax != 0));
                    
                    // return value
                    return enableVelocityY;
                }
            }
            #endregion

            #region EnableVelocityZ
            /// <summary>
            /// This read only property returns true if VelocityZMin or Max is not zero
            /// </summary>
            public bool EnableVelocityZ
            {
                
                get
                {
                    // initial value
                    bool enableVelocityZ = ((VelocityZMin != 0) || (VelocityZMax != 0));
                    
                    // return value
                    return enableVelocityZ;
                }
            }
            #endregion
            
            #region ForcePercent
            /// <summary>
            /// This property gets or sets the value for 'ForcePercent'.
            /// </summary>
            public int ForcePercent
            {
                get { return forcePercent; }
                set { forcePercent = value; }
            }
            #endregion
            
            #region ForcePercentReverse
            /// <summary>
            /// This read only property returns 100 - ForcePercent.
            /// </summary>
            public int ForcePercentReverse
            {
                
                get
                {
                    // initial value
                    int forcePercentReverse = 100 - ForcePercent;
                    
                    // return value
                    return forcePercentReverse;
                }
            }
            #endregion
            
            #region ForceTagText
            /// <summary>
            /// This property gets or sets the value for 'ForceTagText'.
            /// </summary>
            public string ForceTagText
            {
                get { return forceTagText; }
                set { forceTagText = value; }
            }
            #endregion
            
            #region ForceXMax
            /// <summary>
            /// This property gets or sets the value for 'ForceXMax'.
            /// </summary>
            public int ForceXMax
            {
                get { return forceXMax; }
                set { forceXMax = value; }
            }
            #endregion
            
            #region ForceXMin
            /// <summary>
            /// This property gets or sets the value for 'ForceXMin'.
            /// </summary>
            public int ForceXMin
            {
                get { return forceXMin; }
                set { forceXMin = value; }
            }
            #endregion
            
            #region ForceYMax
            /// <summary>
            /// This property gets or sets the value for 'ForceYMax'.
            /// </summary>
            public int ForceYMax
            {
                get { return forceYMax; }
                set { forceYMax = value; }
            }
            #endregion
            
            #region ForceYMin
            /// <summary>
            /// This property gets or sets the value for 'ForceYMin'.
            /// </summary>
            public int ForceYMin
            {
                get { return forceYMin; }
                set { forceYMin = value; }
            }
            #endregion
            
            #region ForceZMax
            /// <summary>
            /// This property gets or sets the value for 'ForceZMax'.
            /// </summary>
            public int ForceZMax
            {
                get { return forceZMax; }
                set { forceZMax = value; }
            }
            #endregion
            
            #region ForceZMin
            /// <summary>
            /// This property gets or sets the value for 'ForceZMin'.
            /// </summary>
            public int ForceZMin
            {
                get { return forceZMin; }
                set { forceZMin = value; }
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
            
            #region VelocityTagText
            /// <summary>
            /// This property gets or sets the value for 'VelocityTagText'.
            /// </summary>
            public string VelocityTagText
            {
                get { return velocityTagText; }
                set { velocityTagText = value; }
            }
            #endregion
            
            #region VelocityXMax
            /// <summary>
            /// This property gets or sets the value for 'VelocityXMax'.
            /// </summary>
            public int VelocityXMax
            {
                get { return velocityXMax; }
                set { velocityXMax = value; }
            }
            #endregion
            
            #region VelocityXMin
            /// <summary>
            /// This property gets or sets the value for 'VelocityXMin'.
            /// </summary>
            public int VelocityXMin
            {
                get { return velocityXMin; }
                set { velocityXMin = value; }
            }
            #endregion
            
            #region VelocityYMax
            /// <summary>
            /// This property gets or sets the value for 'VelocityYMax'.
            /// </summary>
            public int VelocityYMax
            {
                get { return velocityYMax; }
                set { velocityYMax = value; }
            }
            #endregion
            
            #region VelocityYMin
            /// <summary>
            /// This property gets or sets the value for 'VelocityYMin'.
            /// </summary>
            public int VelocityYMin
            {
                get { return velocityYMin; }
                set { velocityYMin = value; }
            }
            #endregion
            
            #region VelocityZMax
            /// <summary>
            /// This property gets or sets the value for 'VelocityZMax'.
            /// </summary>
            public int VelocityZMax
            {
                get { return velocityZMax; }
                set { velocityZMax = value; }
            }
            #endregion
            
            #region VelocityZMin
            /// <summary>
            /// This property gets or sets the value for 'VelocityZMin'.
            /// </summary>
            public int VelocityZMin
            {
                get { return velocityZMin; }
                set { velocityZMin = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
