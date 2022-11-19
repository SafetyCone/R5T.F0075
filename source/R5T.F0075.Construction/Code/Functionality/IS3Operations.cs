using System;
using System.Threading.Tasks;

using Amazon;
using Amazon.S3;

using R5T.T0132;


namespace R5T.F0075.Construction
{
	[FunctionalityMarker]
	public partial interface IS3Operations : IFunctionalityMarker,
		F0075.IS3Operations
	{
		public async Task<AmazonS3Client> GetS3Client()
        {
			var accessKeyFilePath = Instances.FilePaths.AwsAccessKeyFilePath_ForDavid;

			var client = await this.GetS3Client(
				accessKeyFilePath,
				Instances.RegionEndpoints.Default);

			return client;
        }
	}
}