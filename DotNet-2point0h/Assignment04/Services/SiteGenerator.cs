using Components;
using Models;

namespace Services{

public class SiteGenerator {
    private List<TvShow> Shows { get; }
    public string BaseDirPath { get; set; }
    public string WriteDirPath { get; set; }    

    public SiteGenerator(string basePath, string writePath, List<TvShow> shows) {
        
        this.BaseDirPath = basePath;
        this.WriteDirPath = writePath;
        this.Shows = shows;       
    }

    public void GeneratePages() {
        /*
			TODO:
			Create the WriteDirPath directory and move into it.*/
            TvShowWriter writer = new TvShowWriter(baseDir, "TV-Shows");
                
			/*Loop through all of the shows in the TvShows list and create
			a web page for each using the methods you've written in this 
			SiteGenerator class. Each web page should be named after the TvShow's
			id. For example, each file will be named <show.Id>.html like 60625.html.*/
            foreach (Tvshow show in Shows) {
                string SiteHtml = @"<!DOCTYPE html>
<html lang='en'>";
                SiteHtml += GenerateHeader(show.Name);
                SiteHtml += GenerateBody();

                SiteHtml += "</html>";
            }
			
            /*After writing out all of the shows, the method should move the program
			back out to the BaseDirPath.

			Pseudo Code:
			foreach ( ListOfTvShows ) {
				string page = "";
				page += @"<!DOCTYPE html>
                        <html>";
                
                // Add to the page variable all the other parts of the page

                page += @"</html>"

                // Write out the page using the show's id as the filename like:
                // <show.Id>.html
			}
			
        */
    }

    private string GenerateHeader(string title) {
        /*
        	TODO:
			This method generates and returns the markup needed for the
			header HTML. Make sure to include the title passed to this method
			in the appropriate place in the markup.
        */

    	/*
    		TODO: 
    		Make sure to make this the return value that is required.
    		Just returning null for now to avoid compilation errors.k
    	*/
        return null;
    }

    private string GenerateNav(){
        /*
			TODO:
			This method creates a navigation component and returns the 
			HTML generated from it.
        */
        NavComponent nav = new NavComponent();
    	/*
    		TODO: 
    		Make sure to make this the return value that is required.
    		Just returning null for now to avoid compilation errors.k
    	*/
        return nav.GenerateHtml();
    }

    private string GenerateBody(TvShow show) {

        /*
			TODO:
			Create an instance of a select component, and an instance
			of a TvShow component.
        */
        
        string body = "<body>";
        body += GenerateNav();
        
        /*
			TODO:
			Generate the HTML for the select component and TvShow component, and
			add this to the body. Finally, add the bottom scripts to the body
			as well.
        */
               body += @$"<div class='container mx-auto px-4 py-12'>
          <div class='bg-white rounded-lg shadow-lg w-full md:w-1/2 mx-auto' data-aos='fade-up'>
            <div class='flex justify-center'>
              <img class='object-cover object-center rounded-t-lg' 
                src='{show.PosterPath}' alt='{show.Name}'>
            </div>
            <div class='p-6'>
              <h2 class='text-xl font-semibold mb-2'>{show.Name}</h2>
              <p class='text-gray-700 text-sm mb-4'>{show.Overview}
              </p>
              <div class='grid grid-cols-2 gap-4'>
                <div>
                  <p class='text-gray-600 text-xs'>Popularity:</p>
                  <p class='text-sm'>{show.Popularity}</p>
                </div>
                <div>
                  <p class='text-gray-600 text-xs'>Vote Average:</p>
                  <p class='text-sm'>{show.VoteAverage}</p>
                </div>
                <div>
                  <p class='text-gray-600 text-xs'>Vote Count:</p>
                  <p class='text-sm'>{show.VoteCount}</p>
                </div>
              </div>
            </div>
          </div>
        </div>"


        body += GenerateBottomScriptIncludes();
        body += "</body>";
        
        return body;
    }

    /*
		This method has already been implemented and does not need to be modified.
    */
    private string GenerateBottomScriptIncludes(){
        return @"
            <script src=""https://cdnjs.cloudflare.com/ajax/libs/aos/2.3.4/aos.js"" integrity=""sha512-A7AYk1fGKX6S2SsHywmPkrnzTZHrgiVT7GcQkLGDe2ev0aWb8zejytzS8wjo7PGEXKqJOrjQ4oORtnimIRZBtw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
            <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN"" crossorigin=""anonymous""></script>
            <script src=""https://cdn.tailwindcss.com""></script>
            <script type=""text/javascript"">
                AOS.init({
                    duration: 1200,
                });
                
                function getValue() {
                    let dropdown = document.getElementById(""tv-show-select"");
                    let selectedValue = dropdown.value;
                    let url = document.URL;
                    let newUrl = url.split('/').slice(0,-1).join('/') + '/' + selectedValue + '.html';
                    window.location = newUrl;
                }
      
            </script>
        ";
    }

}
}
