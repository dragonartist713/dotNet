using Interfaces;

namespace Components{
	class NavComponent : IWebComponent{
	
    public string GenerateHtml(){
      string website = "https://zaphoradraik.com/";
      string home = "#";
      string about = "#";
      string contact = "#";
      
      string nav = @"<nav class='fixed top-0 left-0 right-0 z-10 bg-gray-900 text-white p-4'>
          <div class='max-w-7xl mx-auto'>
            <div class='flex justify-between items-center'>
              <a href='" + website + @"' class='text-2xl font-bold'>My Website</a>
              <div class='hidden md:flex items-center'>
                <a href='" + home + @"' class='px-3 py-2 hover:bg-gray-800'>Home</a>
                <a href='" + about + @"' class='px-3 py-2 hover:bg-gray-800'>About</a>
                <a href='" + contact + @"' class='px-3 py-2 hover:bg-gray-800'>Contact</a>
              </div>
            </div>
          </div>
        </nav>";


      return nav;
    }

	}
}