using Core.Entities;

namespace Core.Utilities.Results
{
	public class DataResult<TList>:Result,IDataResult<TList>
	{
        public DataResult(TList data,bool success,string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(TList data, bool success):base(success)
        {
			Data = data;
		}
        public TList Data { get; }
	}
}
