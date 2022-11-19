using System;
using System.Threading.Tasks;

using Amazon;
using Amazon.S3;
using Amazon.Runtime;

using R5T.F0074;
using R5T.T0132;


namespace R5T.F0075
{
	[FunctionalityMarker]
	public partial interface IS3Operations : IFunctionalityMarker
	{
		/// <summary>
		/// Creats an S3 bucket in which all objects have read-access.
		/// However:
		/// * The bucket cannot be publically listed.
		/// * There is no public write access.
		/// </summary>
		public async Task CreatePublicBucket(
			AmazonS3Client client,
			S3BucketName bucketName)
        {
			// Create the bucket.
			await Instances.S3BucketOperator.CreateBucket(
				client,
				bucketName);

			await Instances.S3BucketOperator.SetBucketObjectsPublicReadAccessByDefault(
				client,
				bucketName);
		}

		public AmazonS3Client GetS3Client(
			string accessKeyID,
			string secretAccessKey,
			RegionEndpoint regionEndpoint)
        {
			var basicAwsCredentials = new BasicAWSCredentials(
				accessKeyID,
				secretAccessKey);

			var s3Client = new AmazonS3Client(
				basicAwsCredentials,
				regionEndpoint);

			return s3Client;
		}

		public async Task<AmazonS3Client> GetS3Client(
			string accessKeyFilePath,
			RegionEndpoint regionEndpoint)
        {
			var awsCredentials = await Instances.JsonOperator.Deserialize<AwsCredentials>(
				accessKeyFilePath);

			var client = this.GetS3Client(
				awsCredentials.AccessKeyID,
				awsCredentials.SecretAccessKey,
				regionEndpoint);

			return client;
        }

		public async Task<AmazonS3Client> GetS3Client(
			string accessKeyFilePath)
        {
			var regionEndpoint = RegionEndpoints.Instance.Default;

			var client = await this.GetS3Client(
				accessKeyFilePath,
				regionEndpoint);

			return client;
		}

		public async Task UploadFile(
			AmazonS3Client client,
			S3BucketName bucketName,
			S3ObjectKey key,
			string filePath)
        {
			await Instances.S3ObjectOperator.UploadFile(
				client,
				bucketName,
				key,
				filePath);
        }
	}
}