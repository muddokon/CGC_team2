using System;
using UnityEngine;
using System.IO;

public class TextReader
{
    public static void WriteString(string path, string content)
    {
        //string path = "Assets/Resources/bichos.txt";
        
        StreamWriter writer = new StreamWriter(path, true);
        try
        {
            writer.WriteLine(content);
            Debug.Log("File saved!");
        }
        catch (Exception e)
        {
            Debug.Log(e);
            throw;
        }
        finally
        {
            writer.Close();
        }
    }
    public static string[] ReadString(string path)
    {
        //string path = "Assets/Resources/bichos.txt";
        
        StreamReader reader = new StreamReader(path); 
        Debug.Log(reader.ReadToEnd());
        string textRead = reader.ReadToEnd();
        string[] lines = textRead.Split(System.Environment.NewLine.ToCharArray());
        return lines;
    }
}