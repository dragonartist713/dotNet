using System.Text.Json;
using System;
using System.IO;


namespace Models{
	public class TvShowWriter{
		/* 
			BaseDirPath is the directory that your program should always
			return to after traversing into other directories. This should
			be an absolute path. For our purposes, when instantiating an instance
			this TvShowWriter class in your Program.cs, you should pass the 
			baseDirectory parameter that you pass should be the absolute path of 
			the root directory of this project.
		*/
		public string BaseDirPath {get; set;}
		
		/*
			WriteDirPath is the path (relative or absolute) to the directory
			that you want this program to be writing to.
		*/
		public string WriteDirPath {get; set;}
		
		/*
			ALL WRITE METHODS WRITE TO THE WriteDirPath UNLESS OTHERWISE SPECIFIED.
			IF THE DIRECTORY WriteDirPath DOES NOT EXIST, HAVE YOUR PROGRAM CREATE IT.		
		*/
		
		public TvShowWriter(string baseDirectory, string writeDirectoryPath){
			/* Set instance vars and create the directory at WriteDirPath. */
			this.BaseDirPath = baseDirectory;
			this.WriteDirPath = writeDirectoryPath;
			bool exists = Directory.Exists(writeDirectoryPath);

			if (!exists) {
				Directory.CreateDirectory(writeDirectoryPath);
			}
		}

		public void MoveToBaseDir(){
			/*
				Sets the current working directory to the BaseDirPath.
			*/
			Directory.SetCurrentDirectory(this.BaseDirPath);
		}

		public void Write(TvShow tvShow){
			/* 
				Writes out all of the properties of the passed tvShow
				to a txt file which is named <tvShow_id>.txt
							
			*/		
			this.Write(tvShow, this.WriteDirPath);
			//Console.WriteLine((tvShow.name));
			
		}

		private void Write(TvShow tvShow, string dirPath){
			/* 
				Writes out all of the properties of the passed tvShow
				to a txt file which is named <tvShow_id>.txt
							
			*/		
			this.MoveToBaseDir();
			string pathToFile = dirPath + "/" + tvShow.Id + ".txt";
			string content = $"ID: {tvShow.Id}\nBackdrop Path: {tvShow.Backdrop}\nName: {tvShow.Name}\nOrigin Country: {tvShow.OriginCountry}\nOriginal Language: {tvShow.OriginalLanguage}\nOriginal Name: {tvShow.OriginalName}\nOverview: {tvShow.Overview}\nPopularity: {tvShow.Popularity}\nPoster Path: {tvShow.PosterPath}\nVote Average: {tvShow.VoteAverage}\nVote Count: {tvShow.VoteCount}";
			File.WriteAllText(pathToFile, content);
			//Console.WriteLine((tvShow.name));
			
		}

		public int CreateCountryDirectories(List<TvShow> tvShows, string countryDirName, bool returnToBasePath = true){
			int count = 0;
			/*
				Inside of the WritePathDir, create a new directory named {countryDirName}
				if one does not already exist. Traverse into this directory. Then, create
				a directory for each country that appears in the tvShows list in the tvShow's
				OriginCountry property. There should only be one directory per country, so make
				sure not to create duplicate directories.
				
				If the returnToBasePath is set to true, then return to the BaseDirPath.

				Returns the total number of directories that were created.
			*/
			string countryDir = WriteDirPath + "\\" + countryDirName;
			bool exists = Directory.Exists(countryDir);

			if (!exists) {
				Directory.CreateDirectory(countryDir);
			};
			
			Directory.SetCurrentDirectory(countryDir);

			HashSet<string> countries = new HashSet<string>();

			foreach(TvShow show in tvShows){
				countries.Add(show.OriginCountry);
			};
			foreach(string country in countries){
				exists = Directory.Exists(country);

				if (!exists) {
					Directory.CreateDirectory(country);
					count++;
				};
			};

			if(returnToBasePath){
				this.MoveToBaseDir();
			}
			return count;
		}
		
		public void WriteShowsByCountry(List<TvShow> tvShows, string countryDirName, bool returnToBasePath = true){
			/*
				Inside of the WriteDirPath directory, create a new directory named
				{countryDirName} if one does not already exist. Traverse into this directory
				and create a directory for each country. Inside of each country directory,
				write only those tvShows that have their OriginCountry equal to that country.
			*/
			this.CreateCountryDirectories(tvShows, countryDirName, true);
			foreach(TvShow show in tvShows){
				string showDir = WriteDirPath + "\\" + countryDirName + "\\" + show.OriginCountry;
				Write(show, showDir);
			}
			if(returnToBasePath){
				this.MoveToBaseDir();
			}
		}

	}
}