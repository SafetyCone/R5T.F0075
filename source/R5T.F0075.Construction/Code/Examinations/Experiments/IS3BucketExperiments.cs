using System;
using System.Threading.Tasks;

using R5T.T0141;


namespace R5T.F0075.Construction
{
	[ExperimentsMarker]
	public partial interface IS3BucketExperiments : IExperimentsMarker
	{
		public async Task WhatDoesAnEmptyPolicyLookLike()
        {
			var client = await Instances.S3Operations.GetS3Client();

			var bucketName =
				Instances.S3BucketNames.ExampleBucket_Public
				//Instances.S3BucketNames.ExampleBucket
				;

			var policy = await Instances.S3BucketOperator.HasPolicy(
				client,
				bucketName);
        }
	}
}