using System;


namespace R5T.F0075.Construction
{
	public class S3BucketNames : IS3BucketNames
	{
		#region Infrastructure

	    public static IS3BucketNames Instance { get; } = new S3BucketNames();

	    private S3BucketNames()
	    {
        }

	    #endregion
	}
}