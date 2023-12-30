

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataJuggler.RandomShuffler;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using DataJuggler.RandomShuffler.Enumerations;

#endregion

namespace DataJuggler.RandomUSD
{

    #region class Randomizer
    /// <summary>
    /// This class is used to randomly position objects in a USD file.
    /// </summary>
    public class Randomizer
    {
        
        #region Private Variables
        #endregion
        
        #region Methods
            
            #region FindTextLine(List<TextLine> lines, string textToFind)
            /// <summary>
            /// returns the Text Line
            /// </summary>
            public static TextLine FindTextLine(List<TextLine> lines, string textToFind)
            {
                // initial value
                TextLine textLine = null;

                // If the lines collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(lines))
                {
                    // Iterate the collection of TextLine objects
                    foreach (TextLine line in lines)
                    {
                        // if this line contains the text to find                        
                        if (line.Text.Contains(textToFind))
                        {
                            // Set the return value
                            textLine = line;    

                            // break out of the loop
                            break;
                        }
                    }
                }
                
                // return value
                return textLine;
            }
            #endregion
            
            #region Randomize(Settings settings)
            /// <summary>
            /// Randomly position objects in a USD file.
            /// </summary>
            /// <returns></returns>
            public static RandomizationResult Randomize(Settings settings)
            {
                // initial value
                RandomizationResult result = new RandomizationResult();

                try
                {
                    // If the settings object exists
                    if (NullHelper.Exists(settings))
                    {
                        // locals
                        string path = settings.EmptyUSDPath;                        
                        string fileText = File.ReadAllText(path);
                        int count = 0;
                        int objectStartLineNumber = 0;
                        int objectEndLineNumber = 0;
                        int forceLineNumber = 0;
                        int velocityLineNumber = 0;
                        int scaleLineNumber = 0;
                        int translateLineNumber = 0;
                        int objectScaleLineNumber = 0;
                        int objectTranslateLineNumber = 0;
                        int objectForceLineNumber = 0;
                        int objectVelocityLineNumber = 0;
                        int insertIndex = 0;
                        int objectCount = 0;
                        int additionalY = settings.AdditionalY;
                        int objectsToCreate = settings.ObjectsToCreate;
                       

                        // If the fileText string exists
                        if (TextHelper.Exists(fileText))
                        {
                            // get the lines
                            List<TextLine> lines = TextHelper.GetTextLines(fileText);

                            // If the lines collection exists and has one or more items
                            if (ListHelper.HasOneOrMoreItems(lines))
                            {
                                // attempt to find the objectStartLine
                                TextLine objectStartLine = FindTextLine(lines, settings.ObjectTagName);

                                // If the objectStartLine object exists
                                if (NullHelper.Exists(objectStartLine))
                                {
                                    // Set the objectStartLineNumber
                                    objectStartLineNumber = objectStartLine.LineNumber;
                                }

                                // Find the ScaleLine
                                TextLine scaleTextLine = FindTextLine(lines, settings.ScaleTagText);

                                // If the scaleTextLine object exists
                                if (NullHelper.Exists(scaleTextLine))
                                {
                                    // Set the value for scaleLineNumber
                                    scaleLineNumber = scaleTextLine.LineNumber;
                                }

                                // Find the translateTextLine
                                TextLine translateTextLine = FindTextLine(lines, settings.TranslateTagText);

                                // If the translateTextLine object exists
                                if (NullHelper.Exists(translateTextLine))
                                {
                                    // Set the value for translateLineNumber
                                    translateLineNumber = translateTextLine.LineNumber;
                                }

                                // Find the ForceTextLine
                                TextLine forceTextLine = FindTextLine(lines, settings.ForceTagText);

                                // If the forceTextLine object exists
                                if (NullHelper.Exists(forceTextLine))
                                {
                                    // Set the forceLineNumber
                                    forceLineNumber = forceTextLine.LineNumber;
                                }

                                // Find the velociityTextLine
                                TextLine velociityTextLine = FindTextLine(lines, settings.VelocityTagText);

                                // If the velociityTextLine object exists
                                if (NullHelper.Exists(velociityTextLine))
                                {
                                    // Set the velocityLineNumber
                                    velocityLineNumber = velociityTextLine.LineNumber;
                                }

                                // Find the last text line before the bracket
                                TextLine lineBeforeLastBracket = FindTextLine(lines, settings.LineBeforeLastBracketText);

                                // If the lineBeforeLastBracket object exists
                                if (NullHelper.Exists(lineBeforeLastBracket))
                                {
                                    // Set the value for insertIndex
                                    insertIndex = lineBeforeLastBracket.LineNumber;

                                    // Set the value for objectEndLineNumber
                                    objectEndLineNumber = insertIndex + 1;
                                }

                                 // Copy the lines of the spheres
                                int numberLines = objectEndLineNumber - objectStartLineNumber + 1;
                                List<TextLine> objectLines = lines.GetRange(objectStartLineNumber - 1, numberLines);

                                // clone the lines
                                List<TextLine> cloneOfObjectLines = TextHelper.CloneLines(objectLines);

                                // Find objectScaleLine
                                TextLine objectScaleLine = FindTextLine(cloneOfObjectLines, settings.ScaleTagText);

                                // If the objectScaleLine object exists
                                if (NullHelper.Exists(objectScaleLine))
                                {
                                    // set the value for objectScaleLineNumber
                                    objectScaleLineNumber = objectScaleLine.LineNumber;
                                }

                                // Find objectTranslateLine
                                TextLine objectTranslateLine = FindTextLine(cloneOfObjectLines, settings.TranslateTagText);

                                // If the objectTranslateLine object exists
                                if (NullHelper.Exists(objectTranslateLine))
                                {
                                    // set the value for 
                                    objectTranslateLineNumber = objectTranslateLine.LineNumber;
                                }

                                // Find objectForceLine
                                TextLine objectForceLine = FindTextLine(cloneOfObjectLines, settings.ForceTagText);

                                // If the objectForceLine object exists
                                if (NullHelper.Exists(objectForceLine))
                                {
                                    // set the value for objectForceLineNumber
                                    objectForceLineNumber = objectForceLine.LineNumber;
                                }

                                // Find objectVelocityLine
                                TextLine objectVelocityLine = FindTextLine(cloneOfObjectLines, settings.VelocityTagText);

                                // If the objectVelocityLine object exists
                                if (NullHelper.Exists(objectVelocityLine))
                                {
                                    // set the value for 
                                    objectVelocityLineNumber = objectVelocityLine.LineNumber;
                                }

                                // update the line for Name
                                lines[objectStartLineNumber - 1].Text = lines[objectStartLineNumber - 1].Text.Replace(settings.ObjectTagName, settings.ObjectName);

                                 // Create the shufflers
                                RandomShuffler.RandomShuffler shufflerX = new RandomShuffler.RandomShuffler(settings.TranslateXMin, settings.TranslateXMax, 3);
                                RandomShuffler.LargeNumberShuffler shufflerY = new RandomShuffler.LargeNumberShuffler(settings.TranslateYMax.ToString().Length, settings.TranslateYMin, settings.TranslateYMax, NumberOutOfRangeOptionEnum.ReturnModulus);
                                RandomShuffler.RandomShuffler shufflerZ = new RandomShuffler.RandomShuffler(settings.TranslateZMin, settings.TranslateZMax, 3);

                                // Create the rotate shuffler
                                RandomShuffler.RandomShuffler shufflerScale = new RandomShuffler.RandomShuffler(settings.ScaleMin, settings.ScaleMax, 3);
                                string scaleX = (shufflerScale.PullNextItem() + settings.AdditionalScale).ToString();
                                string scaleY = (shufflerScale.PullNextItem() + settings.AdditionalScale).ToString();
                                string scaleZ = (shufflerScale.PullNextItem() + settings.AdditionalScale).ToString();

                                // Declare a force shuffler
                                RandomShuffler.RandomShuffler velocityXShuffler = null;
                                RandomShuffler.RandomShuffler velocityYShuffler = null;
                                RandomShuffler.RandomShuffler velocityZShuffler = null;
                                RandomShuffler.RandomShuffler forceXShuffler = null;
                                RandomShuffler.RandomShuffler forceYShuffler = null;
                                RandomShuffler.RandomShuffler forceZShuffler = null;

                                // If the value for the property settings.EnableForce is true
                                if (settings.EnableForce)
                                {
                                    // if VelocityXMin or Max is not zero
                                    if (settings.EnableVelocityX)
                                    {
                                        // Create the velocityXShuffler
                                        velocityXShuffler = new RandomShuffler.RandomShuffler(settings.VelocityXMin, settings.VelocityXMax, 3);
                                    }

                                    // if VelocityYMin or Max is not zero
                                    if (settings.EnableVelocityY)
                                    {
                                        // Create the velocityYShuffler
                                        velocityYShuffler = new RandomShuffler.RandomShuffler(settings.VelocityYMin, settings.VelocityYMax, 3);
                                    }                                    

                                    // if VelocityZMin or Max is not zero
                                    if (settings.EnableVelocityZ)
                                    {
                                        // Create the velocityZShuffler
                                        velocityZShuffler = new RandomShuffler.RandomShuffler(settings.VelocityZMin, settings.VelocityZMax, 3);
                                    }
                                    
                                    // if ForceXMin or Max is not zero
                                    if (settings.EnableForceX)
                                    {
                                        // Create the forceXShuffler
                                        forceXShuffler = new RandomShuffler.RandomShuffler(settings.ForceXMin, settings.ForceXMax, 3);
                                    }

                                    // if ForceYMin or Max is not zero
                                    if (settings.EnableForceY)
                                    {
                                        // Create the forceYShuffler
                                        forceYShuffler = new RandomShuffler.RandomShuffler(settings.ForceYMin, settings.ForceYMax, 3);
                                    }                                    

                                    // if ForceZMin or Max is not zero
                                    if (settings.EnableForceZ)
                                    {
                                        // Create the forceZShuffler
                                        forceZShuffler = new RandomShuffler.RandomShuffler(settings.ForceZMin, settings.ForceZMax, 3);
                                    } 
                                }

                                // if small scale
                                if (settings.SmallScale)
                                {
                                    // add the .0
                                    scaleX = ".0" + scaleX;
                                    scaleY = ".0" + scaleY;
                                    scaleZ = ".0" + scaleZ;
                                }

                                // set the text for the Translate
                                lines[scaleLineNumber - 1].Text = lines[scaleLineNumber - 1].Text.Replace("[ScaleX]", scaleX).Replace("[ScaleY]", scaleY).Replace("[ScaleZ]", scaleZ);

                                // get some values
                                int x = shufflerX.PullNextItem() + settings.AdditionalX;
                                int y = shufflerY.PullNumber() + settings.AdditionalY;
                                int z = shufflerZ.PullNextItem() + settings.AdditionalZ;

                                // set the text for the Translate
                                lines[translateLineNumber - 1].Text = lines[translateLineNumber - 1].Text.Replace("[TranslateX]", x.ToString()).Replace("[TranslateY]", y.ToString()).Replace("[TranslateZ]", z.ToString());

                                // if Enable Force is true
                                if (settings.EnableForce)
                                {
                                    // if ForceXMin or Max is not zero
                                    if (settings.EnableForceX)
                                    {
                                        // pull a value
                                        int forceX = forceXShuffler.PullNextItem();

                                        // set the value
                                        lines[forceLineNumber - 1].Text = lines[forceLineNumber - 1].Text.Replace("[ForceX]", forceX.ToString());
                                    }
                                    else
                                    {
                                        // zero out
                                        lines[forceLineNumber - 1].Text = lines[forceLineNumber - 1].Text.Replace("[ForceX]", "0");
                                    }

                                    // if ForceYMin or Max is not zero
                                    if (settings.EnableForceY)
                                    {
                                        // pull a value
                                        int forceY = forceYShuffler.PullNextItem();

                                        // set the value
                                        lines[forceLineNumber - 1].Text = lines[forceLineNumber - 1].Text.Replace("[ForceY]", forceY.ToString());
                                    }
                                    else
                                    {
                                        // zero out
                                        lines[forceLineNumber - 1].Text = lines[forceLineNumber - 1].Text.Replace("[ForceY]", "0");
                                    }

                                    // if ForceZMin or Max is not zero
                                    if (settings.EnableForceZ)
                                    {
                                        // pull a value
                                        int forceZ = forceZShuffler.PullNextItem();

                                        // set the value
                                        lines[forceLineNumber - 1].Text = lines[forceLineNumber - 1].Text.Replace("[ForceZ]", forceZ.ToString());
                                    }
                                    else
                                    {
                                        // zero out
                                        lines[forceLineNumber - 1].Text = lines[forceLineNumber - 1].Text.Replace("[ForceZ]", "0");
                                    }

                                    // if VelocityXMin or Max is not zero
                                    if (settings.EnableVelocityX)
                                    {
                                        // pull a value
                                        int velocityX = velocityXShuffler.PullNextItem();

                                        // set the value
                                        lines[velocityLineNumber - 1].Text = lines[velocityLineNumber - 1].Text.Replace("[VelocityX]", velocityX.ToString());
                                    }
                                    else
                                    {
                                        // zero out
                                        lines[velocityLineNumber - 1].Text = lines[velocityLineNumber - 1].Text.Replace("[VelocityX]", "0");
                                    }

                                    // if VelocityYMin or Max is not zero
                                    if (settings.EnableVelocityY)
                                    {
                                        // pull a value
                                        int velocityY = velocityYShuffler.PullNextItem();

                                        // set the value
                                        lines[velocityLineNumber - 1].Text = lines[velocityLineNumber - 1].Text.Replace("[VelocityY]", velocityY.ToString());
                                    }
                                    else
                                    {
                                        // zero out
                                        lines[velocityLineNumber - 1].Text = lines[velocityLineNumber - 1].Text.Replace("[VelocityY]", "0");
                                    }

                                    // if VelocityZMin or Max is not zero
                                    if (settings.EnableVelocityZ)
                                    {
                                        // pull a value
                                        int velocityZ = velocityZShuffler.PullNextItem();

                                        // set the value
                                        lines[velocityLineNumber - 1].Text = lines[velocityLineNumber - 1].Text.Replace("[VelocityZ]", velocityZ.ToString());
                                    }
                                    else
                                    {
                                        // zero out
                                        lines[velocityLineNumber - 1].Text = lines[velocityLineNumber - 1].Text.Replace("[VelocityZ]", "0");
                                    }
                                }
                                else
                                {
                                    // zero out all force and velocity x, y and z.
                                    lines[forceLineNumber - 1].Text = lines[forceLineNumber - 1].Text.Replace("[ForceX]", "0").Replace("[ForceY]", "0").Replace("[ForceZ]", "0");
                                    lines[velocityLineNumber - 1].Text = lines[velocityLineNumber - 1].Text.Replace("[VelocityX]", "0").Replace("[VelocityY]", "0").Replace("[VelocityZ]", "0");
                                }

                                // if there are at least 30 lines in the object
                                if (ListHelper.HasXOrMoreItems(objectLines, 30))
                                {
                                    // Increment the value for insertIndex
                                    insertIndex++;

                                    // Insert this line
                                    lines.Insert(insertIndex, new TextLine());

                                    // iterate up to the number of objects to create
                                    for (int a = 0; a < objectsToCreate; a++)
                                    {
                                        // Increment the value for objectCount
                                        objectCount++;

                                        // clone the lines                                
                                        List<TextLine> cloneOfObjectLines2 = TextHelper.CloneLines(cloneOfObjectLines);

                                        // reset
                                        count = 0;

                                        // Iterate the collection of TextLine objects
                                        foreach (TextLine textLine in cloneOfObjectLines2)
                                        {
                                            // Increment the value for count
                                            count++;

                                            // Increment the value for insertIndex
                                            insertIndex++;

                                            // if count
                                            if (count == 1)
                                            {
                                                // Replace out the object name
                                                textLine.Text = textLine.Text.Replace(settings.ObjectTagName, settings.ObjectName + objectCount);
                                            }
                                            else if (count == objectScaleLineNumber)
                                            {
                                                scaleX = (shufflerScale.PullNextItem() + settings.AdditionalScale).ToString();
                                                scaleY = (shufflerScale.PullNextItem() + settings.AdditionalScale).ToString();
                                                scaleZ = (shufflerScale.PullNextItem() + settings.AdditionalScale).ToString();

                                                // if small scale
                                                if (settings.SmallScale)
                                                {
                                                    // add the .0
                                                    scaleX = ".0" + scaleX;
                                                    scaleY = ".0" + scaleY;
                                                    scaleZ = ".0" + scaleZ;
                                                }

                                                // set the text for the Translate
                                                textLine.Text = textLine.Text.Replace("[ScaleX]", scaleX).Replace("[ScaleY]", scaleY).Replace("[ScaleZ]", scaleZ);
                                            }
                                            else if (count == objectTranslateLineNumber)
                                            {
                                                // get some values
                                                x = shufflerX.PullNextItem() + settings.AdditionalX;
                                                y = shufflerY.PullNumber() + settings.AdditionalY;
                                                z = shufflerZ.PullNextItem() + settings.AdditionalZ;

                                                // Set the Text
                                                textLine.Text = textLine.Text.Replace("[TranslateX]", x.ToString()).Replace("[TranslateY]", y.ToString()).Replace("[TranslateZ]", z.ToString());
                                            }
                                            else if (count == objectForceLineNumber)
                                            {
                                                // if Enable Force is true
                                                if (settings.EnableForce)
                                                {
                                                    // if ForceXMin or Max is not zero
                                                    if (settings.EnableForceX)
                                                    {
                                                        // pull a value
                                                        int forceX = forceXShuffler.PullNextItem();

                                                        // set the value
                                                        textLine.Text = textLine.Text.Replace("[ForceX]", forceX.ToString());
                                                    }
                                                    else
                                                    {
                                                        // Zero out
                                                        textLine.Text = textLine.Text.Replace("[ForceX]", "0");
                                                    }

                                                    // if ForceYMin or Max is not zero
                                                    if (settings.EnableForceY)
                                                    {
                                                        // pull a value
                                                        int forceY = forceYShuffler.PullNextItem();

                                                        // set the value
                                                        textLine.Text = textLine.Text.Replace("[ForceY]", forceY.ToString());
                                                    }
                                                    else
                                                    {
                                                        // Zero out
                                                        textLine.Text = textLine.Text.Replace("[ForceY]", "0");
                                                    }

                                                    // if ForceZMin or Max is not zero
                                                    if (settings.EnableForceZ)
                                                    {
                                                        // pull a value
                                                        int forceZ = forceZShuffler.PullNextItem();

                                                        // set the value
                                                        textLine.Text = textLine.Text.Replace("[ForceZ]", forceZ.ToString());
                                                    }
                                                    else
                                                    {
                                                        // Zero out
                                                        textLine.Text = textLine.Text.Replace("[ForceZ]", "0");
                                                    }
                                                }
                                                else
                                                {
                                                    // Zero out all
                                                    textLine.Text = textLine.Text.Replace("[ForceX]", "0").Replace("[ForceY]", "0").Replace("[ForceZ]", "0");    
                                                }
                                            }
                                            else if (count == objectVelocityLineNumber)
                                            {
                                                // if Enable Force is true
                                                if (settings.EnableForce)
                                                {
                                                    // if VelocityXMin or Max is not zero
                                                    if (settings.EnableVelocityX)
                                                    {
                                                        // pull a value
                                                        int velocityX = velocityXShuffler.PullNextItem();

                                                        // set the value
                                                        textLine.Text = textLine.Text.Replace("[VelocityX]", velocityX.ToString());
                                                    }
                                                    else
                                                    {
                                                        // Zero out
                                                        textLine.Text = textLine.Text.Replace("[VelocityX]", "0");
                                                    }

                                                    // if VelocityYMin or Max is not zero
                                                    if (settings.EnableVelocityY)
                                                    {
                                                        // pull a value
                                                        int velocityY = velocityYShuffler.PullNextItem();

                                                        // set the value
                                                        textLine.Text = textLine.Text.Replace("[VelocityY]", velocityY.ToString());
                                                    }
                                                    else
                                                    {
                                                        // Zero out
                                                        textLine.Text = textLine.Text.Replace("[VelocityY]", "0");
                                                    }

                                                    // if VelocityZMin or Max is not zero
                                                    if (settings.EnableVelocityZ)
                                                    {
                                                        // pull a value
                                                        int velocityZ = velocityZShuffler.PullNextItem();

                                                        // set the value
                                                        textLine.Text = textLine.Text.Replace("[VelocityZ]", velocityZ.ToString());
                                                    }
                                                    else
                                                    {
                                                        // Zero out
                                                        textLine.Text = textLine.Text.Replace("[VelocityZ]", "0");
                                                    }
                                                }
                                                else
                                                {
                                                    // Zero out all
                                                    textLine.Text = textLine.Text.Replace("[VelocityX]", "0").Replace("[VelocityY]", "0").Replace("[VelocityZ]", "0");    
                                                }
                                            }

                                            // Insert this line
                                            lines.Insert(insertIndex, textLine);
                                        }
                                    }

                                    // Set the filePath
                                    string filePath = Path.Combine(settings.OutputFolderPath, settings.OutputFileName);
                                    filePath = FileHelper.CreateFileNameWithPartialGuid(filePath, 12);

                                    // Set the OutputFileName
                                    result.OutputFileName = filePath;

                                    // Export the contents
                                    string fileContents = TextHelper.ExportTextLines(lines);
                                    File.WriteAllText(filePath, fileContents);

                                    // Set the return value
                                    result.Success = FileHelper.Exists(filePath);
                                }
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // store the error
                    result.Error = error;
                }

                // return value
                return result;
            }
            #endregion

            #region RandomizeAsync(Settings settings)
            /// <summary>
            /// Randomly position objects in a USD file.
            /// </summary>
            /// <returns></returns>
            public static async Task<RandomizationResult> RandomizeAsync(Settings settings)
            {
                // initial value
                RandomizationResult result = new RandomizationResult();

                try
                {
                    // run async
                    result = await Task.Run(() => Randomize(settings));
                }
                catch (Exception error)
                {
                    // store the error
                    result.Error = error;
                }

                // return value
                return result;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
