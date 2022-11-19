using System;

using R5T.F0074;
using R5T.Z0017;


namespace R5T.F0075.Construction
{
    public static class Instances
    {
        public static IS3BucketExperiments S3BucketExperiments { get; } = Construction.S3BucketExperiments.Instance;

        public static IFilePaths FilePaths { get; } = Z0017.FilePaths.Instance;
        public static IRegionEndpoints RegionEndpoints { get; } = F0074.RegionEndpoints.Instance;
        public static IS3BucketNameOperator S3BucketNameOperator { get; } = F0074.S3BucketNameOperator.Instance;
        public static IS3BucketNames S3BucketNames { get; } = Construction.S3BucketNames.Instance;
        public static IS3BucketOperator S3BucketOperator { get; } = F0074.S3BucketOperator.Instance;
        public static IS3Operations S3Operations { get; } = Construction.S3Operations.Instance;
    }
}