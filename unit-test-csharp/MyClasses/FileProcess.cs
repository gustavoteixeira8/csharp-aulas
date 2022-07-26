﻿namespace MyClasses;

public class FileProcess
{
    public bool FileExists(string filename) {
        if (string.IsNullOrEmpty(filename)) {
            throw new ArgumentNullException();
        }

        return File.Exists(filename);
    }
}

