using System;

using R5T.F0074;
using R5T.T0131;


namespace R5T.F0075.Construction
{
	[ValuesMarker]
	public partial interface IS3BucketNames : IValuesMarker
	{
		public S3BucketName ExampleBucket => Instances.S3BucketNameOperator.ToS3BucketName_WithoutValidation("bucket.351673f3-4a09-8529-fdff-2cb38696b28f");
		public S3BucketName ExampleBucket_Public => Instances.S3BucketNameOperator.ToS3BucketName_WithoutValidation("public-bucket.351673f3-4a09-8529-fdff-2cb38696b28f");
	}
}