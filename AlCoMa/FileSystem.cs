using CSharpFunctionalExtensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCoMa
{
    internal class FileSystem
    {
        public static Result<int> Save(string data, IFile file)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(file.Filename));
                File.Delete(file.Filename);
                File.WriteAllText(file.Filename, data);
                return Result.Success(0);
            }
            catch (Exception ex)
            {
                return Result.Failure<int>(ex.ToString());
            }
        }

        public static Result<string> Load(IFile file)
        {
            try
            {
                if (File.Exists(file.Filename))
                {
                    return Result.Success(File.ReadAllText(file.Filename));
                }
                else
                {
                    return Result.Failure<string>("File Not Found");
                }
            }
            catch (Exception ex)
            {
                return Result.Failure<string>(ex.ToString());
            }
        }
    }

    interface IFile
    {
        public string Filename { get; }
        public StreamReader GetReader();
    }

    public class UserFiles : IFile
    {
        public static UserFiles Token = new("token.txt");
        public static UserFiles Collection = new("collection.json");

        public string Filename { get; private set; }

        public UserFiles(string filename) => this.Filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AlCoMa", filename);

        public Result<int> Save(string data) => FileSystem.Save(data, this);

        public Result<string> Load() => FileSystem.Load(this);

        public StreamReader GetReader() => new StreamReader(this.Filename);
    }

    public class Masterdata : IFile
    {
        public static Masterdata Cards = new("cards_en.csv");

        public string Filename { get; private set; }

        public Masterdata(string filename) => this.Filename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "data", "results", filename);

        public Result<int> Save(string data) => FileSystem.Save(data, this);

        public Result<string> Load() => FileSystem.Load(this);

        public StreamReader GetReader() => new StreamReader(this.Filename);
    }
}
