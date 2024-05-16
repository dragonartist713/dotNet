using Interfaces;


namespace Components{
	public abstract class BaseWebComponent : IWebComponent{
		public string Id {get; set;}
		
		public BaseWebComponent(){}

		public BaseWebComponent(string id){
			this.Id = id;
		}
		
		public abstract string GenerateHtml();
	}
}