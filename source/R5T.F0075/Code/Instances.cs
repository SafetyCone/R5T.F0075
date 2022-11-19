using System;

using R5T.F0032;
using R5T.F0074;


namespace R5T.F0075
{
    public static class Instances
    {
        public static IJsonOperator JsonOperator { get; } = F0032.JsonOperator.Instance;
        public static IS3BucketOperator S3BucketOperator { get; } = F0074.S3BucketOperator.Instance;
        public static IS3ObjectOperator S3ObjectOperator { get; } = F0074.S3ObjectOperator.Instance;
    }
}