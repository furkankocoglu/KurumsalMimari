using Core.Entities;
namespace Core.Utilities.Results
{
	public class ErrorDataResult<TList> :DataResult<TList>
	{
		public ErrorDataResult(TList data) : base(data, false)
		{

		}
		public ErrorDataResult(TList data, string message) : base(data, false, message)
		{

		}
		public ErrorDataResult() : base(default, false)
		{

		}
		public ErrorDataResult(string message) : base(default, false, message)
		{

		}
	}
}
