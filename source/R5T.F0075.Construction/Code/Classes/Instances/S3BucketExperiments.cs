using System;


namespace R5T.F0075.Construction
{
	public class S3BucketExperiments : IS3BucketExperiments
	{
		#region Infrastructure

	    public static IS3BucketExperiments Instance { get; } = new S3BucketExperiments();

	    private S3BucketExperiments()
	    {
        }

	    #endregion
	}
}