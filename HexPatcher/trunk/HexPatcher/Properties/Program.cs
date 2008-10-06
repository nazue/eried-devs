using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using HexPatcher.Properties;

namespace HexPatcher
{

    class Program
    {
        static Boolean _verbose, _quiet;

        static void Main(string[] _args)
        {
            if (_args.Length <= 1)
                ShowHelp();

            // Variables
            Byte[] fileBytes, originalBytes, replaceBytes, startWithBytes;
            Boolean[] wildcardsOriginal = new Boolean[0],
                wildcardsStart = new Boolean[0],
                wildcardsReplace = new Boolean[0];

            ArrayList newFileBytes;

            bool continueReplacement, addSingle, matched, matchedStart, confirmedChange,
                _requireConfirmation, _noBackup;

            int position, i, j, replacements, nChanges,
                _max, _startFrom;

            string _fileInput, _startWith, _sequenceOrigin, _secuenceReplacement;

            string[] args;

            for (i = 0; i < _args.Length; i++)
                _args[i] = _args[i].Replace('/', '-').Trim();

            // Inicialización
            _fileInput = ""; _startWith = ""; _sequenceOrigin = "";
            _secuenceReplacement = ""; _requireConfirmation = false;
            _startFrom = 0; _max = 0; _noBackup = false; _quiet = false;
            replacements = 0; nChanges = 0;

            args = new string[_args.Length + 1];

            args[0] = "";
            for (i = 1; i < args.Length; i++)
                args[i] = _args[i - 1];

            // Mostrar ayuda
            if (ExistInArray(args, "-help")>0 || ExistInArray(args, "-?")>0)
                ShowHelp();

            // Parámetros de configuración
            try
            {
                j = ExistInArray(args, "-verbose"); _verbose = Convert.ToBoolean(j); args[j] = "";
                j = ExistInArray(args, "-query"); _requireConfirmation = Convert.ToBoolean(j); args[j] = "";
                j = ExistInArray(args, "-noBackup"); _noBackup = Convert.ToBoolean(j); args[j] = "";
                j = ExistInArray(args, "-quiet"); _quiet = Convert.ToBoolean(j); args[j] = "";

                j = ExistInArray(args, "-max");
                if (j > 0)
                {
                    _max = Math.Max(Convert.ToInt32(args[j + 1]), 0); args[j] = ""; args[j + 1] = "";
                }
                else
                    _max = 0;

                j = ExistInArray(args, "-startFrom");
                if (j > 0)
                {
                    _startFrom = Math.Max(Convert.ToInt32(args[j + 1]), 0); args[j] = ""; args[j + 1] = "";
                }
                else
                    _startFrom = 0;

                j = ExistInArray(args, "-startWith");
                if (j > 0)
                {
                    _startWith = args[j + 1]; args[j] = ""; args[j + 1] = "";
                }
                else
                    _startWith = "";

                // Asignar cadenas
                for (i = 0; i < args.Length; i++)
                    if (args[i].Length > 0 && !args[i].StartsWith("-"))
                    {
                        _sequenceOrigin = args[i]; break;
                    }

                for (i = i + 1; i < args.Length; i++)
                    if (args[i].Length > 0 && !args[i].StartsWith("-"))
                    {
                        _secuenceReplacement = args[i]; break;
                    }

                bool fileExists;
                for (j = args.Length - 1; j >= 0; j--)
                {
                    fileExists = File.Exists(args[j]);
                    if (args[j].Length > 0 && fileExists)
                    {
                        _fileInput = args[j]; break;
                    }
                }

                if (j == i)
                    _secuenceReplacement = "";

                if (_requireConfirmation && _quiet)
                {
                    _quiet = false;
                    Quit(Resources.ErrCantQueryInQuietMode);
                }
            }
            catch (Exception)
            {
                Quit(Resources.ErrInvalidArgs);
            }

            // Lectura del archivo de entrada
            try
            {
                fileBytes = File.ReadAllBytes(_fileInput);
            }
            catch (Exception)
            {
                fileBytes = null; // Para evitar problemas de inicialización
                Quit(Resources.ErrCantReadInputFile);
            }

            // Fragmentos de reemplazo
            if (_sequenceOrigin.Length % 2 != 0 || _secuenceReplacement.Length % 2 != 0)
            {
                Quit(Resources.ErrHexSeqMustHasEvenLength);
            }

            try
            {
                originalBytes = ConvertToBytes(_sequenceOrigin, ref wildcardsOriginal);
                replaceBytes = ConvertToBytes(_secuenceReplacement, ref wildcardsReplace);

                if (_startWith.Length > 0)
                    startWithBytes = ConvertToBytes(_startWith, ref wildcardsStart);
                else
                    startWithBytes = null;
            }
            catch (Exception)
            {
                originalBytes = null; replaceBytes = null; startWithBytes = null;  // Para evitar problemas de inicialización
                Quit(Resources.ErrHexSeqInvalid);
            }

            newFileBytes = new ArrayList();

            VerboseOutput(Resources.InfoInitializationReady);

            matchedStart = true;
            position = 0;

            // Avanzar hasta la posición definida por el usuario
            if (startWithBytes!=null)
            {
                matchedStart = false;
                continueReplacement = true;
                VerboseOutput(Resources.InfoSearchingBeginStartup);
                while (continueReplacement)
                {
                    if (IsEqual(fileBytes[position],startWithBytes[0],wildcardsStart[0]))
                    {
                        matched = true;
                        for (i = 1; i < startWithBytes.Length; i++)
                            if (position + i >= fileBytes.Length || !IsEqual(fileBytes[position + i], startWithBytes[i], wildcardsStart[i]))
                            {
                                matched = false;
                                break;
                            }

                        if (matched)
                        {
                            VerboseOutput(String.Format(Resources.InfoMatchFound,position));
                            continueReplacement = false;
                            matchedStart = true;
                        }

                    }
                    else
                    {
                        matched = false;
                    }

                    if (!matched)
                    {
                        newFileBytes.Add(fileBytes[position]);
                        position++;
                    }

                    if (position + startWithBytes.Length > fileBytes.Length)
                        continueReplacement = false;
                }
            }

            if (matchedStart)
            {
                continueReplacement = true;
                VerboseOutput(Resources.InfoSearchingBeginMain);
                while (continueReplacement)
                {
                    addSingle = false;

                    if (IsEqual(fileBytes[position],originalBytes[0],wildcardsOriginal[0]))
                    {
                        matched = true;

                        for (i = 1; i < originalBytes.Length; i++)
                            if (position + i >= fileBytes.Length || !IsEqual(fileBytes[position + i],originalBytes[i],wildcardsOriginal[i]))
                            {
                                matched = false;
                                break;
                            }

                        if (matched)
                        {
                            if (_requireConfirmation)
                            {
                                confirmedChange = false;
                                System.Console.Write(String.Format(Resources.MsgMatchFoundQuery,position));
                                j = System.Console.ReadKey().KeyChar;
                                j = j >= 'A' && j <= 'Z' ? j : j - 'a' + 'A';

                                if (j == Resources.AppUppercaseCharYes.ToCharArray()[0])
                                    confirmedChange = true;

                                Print("");
                            }
                            else
                                confirmedChange = true;

                            if (confirmedChange && replacements + 1 >= _startFrom)
                            {
                                VerboseOutput(String.Format(Resources.InfoMatchReplaced, position));
                                Byte[] originalBytesReplace = new Byte[replaceBytes.Length];
                                Array.ConstrainedCopy(fileBytes, position, originalBytesReplace,0, replaceBytes.Length);
                                newFileBytes.AddRange(ReplaceWildcards(replaceBytes, originalBytesReplace, wildcardsReplace));
                                nChanges++;
                            }
                            else
                            {
                                VerboseOutput(String.Format(Resources.InfoMatchNotReplaced, position));
                                newFileBytes.AddRange(originalBytes);
                            }

                            position += originalBytes.Length;
                            replacements++;

                            if (_max > 0)
                                if (replacements - _startFrom + 1 >= _max)
                                {
                                    VerboseOutput(Resources.InfoReachedMaxReplacements);
                                    continueReplacement = false;
                                }
                        }
                        else
                            addSingle = true;
                    }
                    else
                        addSingle = true;

                    if (addSingle)
                    {
                        newFileBytes.Add(fileBytes[position]);
                        position++;
                    }

                    if (position + originalBytes.Length > fileBytes.Length)
                        continueReplacement = false;
                }
            }
            else
                VerboseOutput(Resources.InfoStartupSeqNotFound);

            VerboseOutput(Resources.InfoNoMoreReplacements);

            if (nChanges==0)
            {
                VerboseOutput(Resources.InfoNoChanges);
                Print(Resources.MsgNoChanges);
            }
            else
            {

                // Copiar el final del archivo
                for (i = position; i < fileBytes.Length; i++)
                    newFileBytes.Add(fileBytes[i]);

                // Crear el nuevo archivo
                Byte[] finalBytes = new Byte[newFileBytes.Count];

                for (i = 0; i < finalBytes.Length; i++)
                    finalBytes[i] = (Byte)newFileBytes[i];

                VerboseOutput(Resources.InfoPreparingOutputFile);

                if (!_noBackup)
                {
                    string suggestedFilename;
                    i = 0;
                    do
                    {
                        suggestedFilename = _fileInput + Resources.AppBackupExtension;

                        if (++i > 1)
                            suggestedFilename += String.Format(" ({0})", i);

                    } while (File.Exists(suggestedFilename));

                    try
                    {
                        File.Move(_fileInput, suggestedFilename);
                    }
                    catch (Exception)
                    {
                        Quit(Resources.ErrBackupFailed);
                    }
                }
                else
                    VerboseOutput(Resources.InfoBackupFailed);

                try
                {
                    File.WriteAllBytes(_fileInput, finalBytes);
                }
                catch (Exception)
                {
                    Quit(Resources.ErrSaveFailed);
                }
                Print(String.Format(Resources.MsgTotalChanges,nChanges));
            }

            VerboseOutput(Resources.InfoFinished);
        }

        /// <summary>
        /// Reemplaza los comodines por los carácteres originales de una cadena de reemplazo
        /// </summary>
        /// <param name="replaceBytes">Arreglo de reemplazo</param>
        /// <param name="originalBytes">Bytes originales</param>
        /// <param name="wildcardsReplace">Asignación de comodines</param>
        /// <returns></returns>
        private static byte[] ReplaceWildcards(byte[] replaceBytes, byte[] originalBytes, bool[] wildcardsReplace)
        {
            for (int i = 0; i < Math.Min(replaceBytes.Length, originalBytes.Length); i++)
                replaceBytes[i] = wildcardsReplace[i] ? originalBytes[i] : replaceBytes[i];

            return replaceBytes;
        }

        /// <summary>
        /// Devuelve si dos bytes son idénticos cuando el tercer parámetro es
        /// falso, de otra forma siempre devuelve verdadero
        /// </summary>
        /// <param name="a">Primer byte</param>
        /// <param name="b">Segundo byte</param>
        /// <param name="m">Devolver verdadero</param>
        /// <returns></returns>
        private static bool IsEqual(byte a, byte b, bool m)
        {
            return m ? true : a == b;
        }

        /// <summary>
        /// Convierte la entrada en un arreglo de bytes
        /// </summary>
        /// <param name="hexSequence">Cadena de entrada</param>
        /// <returns>Arreglo de bytes convertidos</returns>
        static Byte[] ConvertToBytes(string hexSequence)
        {
            return ConvertToBytes(hexSequence, false);
        }

        /// <summary>
        /// Convierte la entrada en un arreglo de bytes
        /// </summary>
        /// <param name="hexSequence">Cadena de entrada</param>
        /// <param name="haltOnWildcard">No admitir comodines</param>
        /// <returns>Arreglo de bytes convertidos</returns>
        static Byte[] ConvertToBytes(string hexSequence, Boolean haltOnWildcard)
        {
            Boolean[] temp = new Boolean[0];
            return ConvertToBytes(hexSequence, ref temp, haltOnWildcard ? "" : "??");
        }

        /// <summary>
        /// Convierte la entrada en un arreglo de bytes
        /// </summary>
        /// <param name="hexSequence">Cadena de entrada</param>
        /// <param name="isWildcard">Referencia a un arreglo que contendrá los comodines encontrados</param>
        /// <returns>Arreglo de bytes convertidos</returns>
        static Byte[] ConvertToBytes(string hexSequence, ref Boolean[] isWildcard)
        {
            return ConvertToBytes(hexSequence, ref isWildcard, "??");
        }

        /// <summary>
        /// Convierte la entrada en un arreglo de bytes
        /// </summary>
        /// <param name="hexSequence">Cadena de entrada</param>
        /// <param name="isWildcard">Referencia a un arreglo que contendrá los comodines encontrados</param>
        /// <param name="wildcard">Cadena utilizado como comodín</param>
        /// <returns>Arreglo de bytes convertidos</returns>
        static Byte[] ConvertToBytes(string hexSequence, ref Boolean[] isWildcard, String wildcard)
        {
            Byte[] output = new Byte[hexSequence.Length / 2];
            isWildcard = new Boolean[output.Length];

            for (int i = 0; i < hexSequence.Length; i += 2)
                if (hexSequence.Substring(i, 2).CompareTo(wildcard)!=0)
                {
                    output[i / 2] = Convert.ToByte(hexSequence.Substring(i, 2), 16);
                    isWildcard[i / 2] = false;
                }
                else
                    isWildcard[i / 2] = true;

            return output;
        }

        static int ExistInArray(string[] searchHere, string thisString)
        {
            for (int i = 0; i < searchHere.Length; i++)
                if (searchHere[i].ToLower() == thisString.ToLower())
                    return i;
            return 0;
        }

        static void VerboseOutput(string msg)
        {
            if (_verbose)
            {
                string lt;
                DateTime c = DateTime.Now;

                lt = String.Format("{0}:{1}:{2}.{3} \t", c.Hour, c.Minute, c.Second, c.Millisecond);
                Print(lt + msg);
            }
        }

        static void Print(string msg)
        {
            if(!_quiet)
                System.Console.WriteLine(msg);
        }

        static void Quit(string msg)
        {
            Print(msg); ExitApp();
        }

        static void ExitApp()
        {
            Print(Resources.MsgAppFinished);
            Environment.Exit(0);
        }

        static void ShowHelp()
        {
            Print(String.Format("\n{0}\n\n{1}\n\n{2}\n\n{3}", 
                Resources.HelpDescription,
                Resources.HelpCommandLineParameters,
                Resources.HelpParametersDetails,
                Resources.HelpRemarks));
            Environment.Exit(1);
        }
    }
}
