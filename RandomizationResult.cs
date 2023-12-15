

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace DataJuggler.RandomUSD
{

    #region class RandomizationResult
    /// <summary>
    /// This class is used to return the result of the Randomization
    /// </summary>
    public class RandomizationResult
    {
        
        #region Private Variables
        private int objectsCreated;
        private string outputFileName;
        private bool success;
        private Exception error;
        #endregion

        #region Properties

            #region Error
            /// <summary>
            /// This property gets or sets the value for 'Error'.
            /// </summary>
            public Exception Error
            {
                get { return error; }
                set { error = value; }
            }
            #endregion
            
            #region HasError
            /// <summary>
            /// This property returns true if this object has an 'Error'.
            /// </summary>
            public bool HasError
            {
                get
                {
                    // initial value
                    bool hasError = (this.Error != null);
                    
                    // return value
                    return hasError;
                }
            }
            #endregion
            
            #region HasOutputFileName
            /// <summary>
            /// This property returns true if the 'OutputFileName' exists.
            /// </summary>
            public bool HasOutputFileName
            {
                get
                {
                    // initial value
                    bool hasOutputFileName = (!String.IsNullOrEmpty(this.OutputFileName));
                    
                    // return value
                    return hasOutputFileName;
                }
            }
            #endregion
            
            #region ObjectsCreated
            /// <summary>
            /// This property gets or sets the value for 'ObjectsCreated'.
            /// </summary>
            public int ObjectsCreated
            {
                get { return objectsCreated; }
                set { objectsCreated = value; }
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
            
            #region Success
            /// <summary>
            /// This property gets or sets the value for 'Success'.
            /// </summary>
            public bool Success
            {
                get { return success; }
                set { success = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
