using Core.Entities;

namespace Core.Utilities.Results
{
	public class SuccessDataResult<TList>:DataResult<TList>
	{
        public SuccessDataResult(TList data) : base(data,true)
        {
            
        }
        public SuccessDataResult(TList data,string message):base(data,true,message) 
        {
            
        }
        public SuccessDataResult():base(default,true)
        {
            
        }
		public SuccessDataResult(string message) : base(default, true,message)
		{

		}
	}
}
