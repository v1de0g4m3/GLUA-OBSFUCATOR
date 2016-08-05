/*
    /////////////////////////////////////
    // GLUA OBSFUCATOR                 //
    // By Senator                      //
    /////////////////////////////////////
    // Project Started: 05-08-2016     //
    // Project Ended: -/-/-            //
    /////////////////////////////////////
*/

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace glua_obsfucator
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initial Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("PRODUCT NOTICE\n\nthis Is freeware. If you paid any amount of money for this program\nrefund it as you were just scammed.", "NOTICE", MessageBoxButtons.OK);
            MessageBox.Show(
                "PRODUCT NOTICE\n\nThis is merely a project.\n not a professional application, expect bugs and issues.\nits an obsfucator, they are not perfect.",
                "NOTICE", MessageBoxButtons.OK);
        }

        //  Credits to Original Source: http://stackoverflow.com/questions/16999604/convert-string-to-hex-string-in-c-sharp
        private string StringToHex(string hexstring)
        {
            var sb = new StringBuilder();
            foreach (var t in hexstring)
            {
                sb.Append("\\x" + Convert.ToInt32(t).ToString("x"));
            }
            return sb.ToString();
        }

        // Credits to Original Source: http://stackoverflow.com/questions/1122483/random-string-generator-returning-same-string
        private static readonly Random Random = new Random((int)DateTime.Now.Ticks);
        private static string RandomString(int size)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Obsfucation Function Main
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void obsfucate_lua_Click(object sender, EventArgs e)
        {
            obsfucation_status.Items.Clear();

            obsfucation_status.Items.Add("Obsfucation Start");
            obsfucation_status.Items.Add("*****************");

            // Obsfucation Start...
            var obsfucated = "";
            var nonobsfucated = not_ob_text.Text;
            var iCount = 0;
            var bSwitchCommentSpam = false;

            // Lua Data Types
            var LUA_VARIABLES = new string[] {}.ToList();
            var LUA_FUNCTIONS = new string[] {}.ToList();

            // Remove Comments
            if (obs_removecomments.Checked)
            {
                nonobsfucated = new Regex(@"\/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+\/").Replace(nonobsfucated, "");
                nonobsfucated = new Regex(@"\/\/.*").Replace(nonobsfucated, ""); // Remove // Comments
            }

            string line;
            var strReader = new StringReader(nonobsfucated);
            while (null != (line = strReader.ReadLine()))
            {
                var sLine = line;

                // Type of line is a variable
                var regex = new Regex(@"local.*="); // Detect if condition
                var match = regex.Match(sLine);
                if (match.Success && obs_variables.Checked)
                {
                    var sVariable = sLine;

                    var rgx = new Regex("local."); // Remove local operator (if there is one)
                    sVariable = rgx.Replace(sVariable, "");

                    rgx = new Regex("=.*"); // Anything after = operator
                    sVariable = rgx.Replace(sVariable, "");

                    sVariable = sVariable.Replace(" ", ""); // Remove unwanted spaces for checking
                    sVariable = sVariable.Replace("	", ""); // Remove unwanted spaces for checking

                    obsfucation_status.Items.Add("LUA_VARIABLE '" + sVariable + "'");

                    LUA_VARIABLES.Add(sVariable);
                }

                // Type of line is a function
                regex = new Regex(@"function .*\(.*\)a*"); // Detect function condition
                match = regex.Match(sLine);
                if (match.Success & obs_variables.Checked)
                {
                    var sVariable = match.Value;

                    if (!sVariable.Contains("function"))
                        continue;

                    var rgx = new Regex("local."); // Remove local operator (if there is one)
                    sVariable = rgx.Replace(sVariable, "");

                    rgx = new Regex("function."); // Remove Function operator
                    sVariable = rgx.Replace(sVariable, "");

                    rgx = new Regex(@"\(([^\)]+)\)"); // Bracket Operator
                    sVariable = rgx.Replace(sVariable, "");

                    sVariable = sVariable.Replace(" ", ""); // Remove unwanted spaces for checking

                    obsfucation_status.Items.Add("LUA_FUNCTION '" + sVariable + "'");

                    LUA_FUNCTIONS.Add(sVariable);
                }

                obsfucated += (obs_commentspam.Checked
                    ? " " + (!bSwitchCommentSpam ? "/*" : "--[[") + " " +
                      StringToHex(RandomString(line.Length*(obs_lowratio.Checked ? 3 : 20))) +
                      " " + (!bSwitchCommentSpam ? "*/" : "]]")
                    : "") + sLine +
                              (obs_commentspam.Checked
                                  ? " " + (bSwitchCommentSpam ? "/*" : "--[[") + " " +
                                    StringToHex(RandomString(line.Length*(obs_lowratio.Checked ? 5 : 25))) +
                                    " " + (bSwitchCommentSpam ? "*/" : "]]")
                                  : "") +
                              (obs_spacecode.Checked
                                  ? new string('\n', line.Length) + new string(' ', line.Length)
                                  : "\n");

                bSwitchCommentSpam = !bSwitchCommentSpam;
            }

            // Random Seed
            var rSeed = new Random();

            // REPLACE ALL VARIABLES IN TABLE
            foreach (var sCurBuffer in LUA_VARIABLES.ToArray())
            {
                iCount += 2;

                var sRandom = new string('‬', iCount); // Create Random Length Variable
                obsfucated = obsfucated.Replace(sCurBuffer, sRandom);

                obsfucation_status.Items.Add("LUA_VARIABLES Obsfucated '" + sCurBuffer + "'");
            }

            // REPLACE ALL FUNCTIONS IN TABLE
            foreach (var sCurBuffer in LUA_FUNCTIONS.ToArray())
            {
                iCount += 2;

                var sRandom = new string('‬', iCount); // Create Random Length Variable
                obsfucated = obsfucated.Replace(sCurBuffer, sRandom);

                obsfucation_status.Items.Add("LUA_FUNCTIONS Obsfucated '" + sCurBuffer + "'");
            }

            //// Math Fuck
            //var sMathFuck = new Regex(@"[=|==|+|-|/|*|(|)|[|\]|^]\s{1,}[0-9]{1,}").Matches(obsfucated); // Detect if variable is a number
            //foreach (Match match in sMathFuck)
            //{
            //    var sMathString = match.Value;

            //    var rgx = new Regex("local."); // Remove local operator (if there is one)
            //    sVariable = rgx.Replace(sVariable, "");

            //    var iEquation = int.Parse(sMathString);

            //    MessageBox.Show(sMathString);
            //}

            // String Obsfucation
            var sStrings = new Regex(@"""[^""\\]*(?:\\.[^""\\]*)*""").Matches(obsfucated);

            // Detect Qouted Strings ("hello")
            if (obs_strings.Checked)
            {
                foreach (Match match in sStrings)
                {
                    var sString = match.Value;

                    sString = new Regex("^\"|\"$").Replace(sString, ""); // Strip Strings From Sentence

                    obsfucated = obsfucated.Replace(match.Value, "\"" + StringToHex(sString) + "\"");
                    // Obsfucate Sentence

                    obsfucation_status.Items.Add("LUA_STRING Obsfucated '" + sString + "'");
                }
            }

            // Replace Known Functions With obsfucation
            var LUA_FUNCTIONHASHING = new string[] {}.ToList();

            var file = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "function_hashes.dat");

            var iConstructers = 0;
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("//") || line.Length <= 1)
                    continue;

                iConstructers += 1;
                LUA_FUNCTIONHASHING.Add(line);
            }

            file.Close();

            obsfucation_status.Items.Add("function_hashes.dat Created " + iConstructers + " Function Hashes");

            // Function Hashing
            if (obs_hexfunctions.Checked)
            {
                foreach (var sCurBuffer in LUA_FUNCTIONHASHING.ToArray())
                {
                    var sFuncs = new Regex(sCurBuffer + @"\(([^\)]+)\)").Matches(obsfucated);
                    // Detect Function-Style Comment
                    foreach (Match match in sFuncs)
                    {
                        var sFunction = match.Value;
                        var sParamaters = Regex.Match(sFunction, @"\(([^\)]+)\)").Value; // Get Paramaters From Function

                        if (sFunction.Contains("."))
                        {
                            var sClassSplit = sFunction.Split('.');
                            var sSendSegment = sClassSplit[1].Replace(sParamaters, "");

                            obsfucated = obsfucated.Replace(sFunction,
                                "getfenv()[\"" + StringToHex(sClassSplit[0]) + "\"]" + "[\"" + StringToHex(sSendSegment) +
                                "\"]" + sParamaters); // Generate Obsfucated Function Call
                        }
                        else
                        {
                            obsfucated = obsfucated.Replace(sFunction,
                                "getfenv()[\"" + StringToHex(sCurBuffer) + "\"]" + sParamaters);
                            // Generate Obsfucated Function Call
                        }

                        obsfucation_status.Items.Add("LUA_FUNCTIONS Hashed '" + sCurBuffer + "'");
                    }
                }
            }


            if (obs_striplines.Checked)
                obsfucated = obsfucated.Replace("\n", "");

            ob_text.Text = obsfucated;

            obsfucation_status.Items.Add("*****************");
            obsfucation_status.Items.Add("Obsfucation End");
        }

        private void obs_spacecode_CheckedChanged(object sender, EventArgs e)
        {
            if (obs_spacecode.Checked)
                obs_removecomments.Checked = true;
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "GLUA OBSFUCATOR\nBy Senator\n\nthanks To The Following:\n\n-Daz\n-Dark\n-Hollow\n-Phage\nAnyone else who contributed/idea's for the project!",
                @"GLUA OBSFUCATOR");
        }
    }
}