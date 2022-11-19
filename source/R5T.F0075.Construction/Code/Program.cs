using System;
using System.Threading.Tasks;


namespace R5T.F0075.Construction
{
    class Program
    {
        static async Task Main()
        {
            await Instances.S3BucketExperiments.WhatDoesAnEmptyPolicyLookLike();
        }
    }
}