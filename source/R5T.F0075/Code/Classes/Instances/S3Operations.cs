using System;


namespace R5T.F0075
{
	public class S3Operations : IS3Operations
	{
		#region Infrastructure

	    public static IS3Operations Instance { get; } = new S3Operations();

	    private S3Operations()
	    {
        }

	    #endregion
	}
}