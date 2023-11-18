using Core.Entities;
namespace Core.Utilities.Results
{
	public interface IDataResult<TList>:IResult
	{
		TList Data { get; }
	}
}
