namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailBucketResourceAccessState<'BucketName, 'ResourceName> = { assignments: ResizeArray<aws.LightsailBucketResourceAccess.LightsailBucketResourceAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket_resource_access">aws_lightsail_bucket_resource_access</a>.
    /// </summary>
    type LightsailBucketResourceAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailBucketResourceAccessState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailBucketResourceAccessState<Missing, Missing>)

        member _.Zero(()) : LightsailBucketResourceAccessState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailBucketResourceAccessState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket_resource_access#bucket_name-1">LightsailBucketResourceAccess#bucket_name</a>.
        /// </summary>
        [<CustomOperation "bucket_name">]
        member _.BucketName(state: LightsailBucketResourceAccessState<Missing, 'ResourceName>, value: string) : LightsailBucketResourceAccessState<Present, 'ResourceName> =
            state.assignments.Add(fun config -> config.BucketName <- value)
            ({ assignments = state.assignments } : LightsailBucketResourceAccessState<Present, 'ResourceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket_resource_access#resource_name-1">LightsailBucketResourceAccess#resource_name</a>.
        /// </summary>
        [<CustomOperation "resource_name">]
        member _.ResourceName(state: LightsailBucketResourceAccessState<'BucketName, Missing>, value: string) : LightsailBucketResourceAccessState<'BucketName, Present> =
            state.assignments.Add(fun config -> config.ResourceName <- value)
            ({ assignments = state.assignments } : LightsailBucketResourceAccessState<'BucketName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_bucket_resource_access#id-1">LightsailBucketResourceAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailBucketResourceAccessState<'BucketName, 'ResourceName>, value: string) : LightsailBucketResourceAccessState<'BucketName, 'ResourceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailBucketResourceAccessState<'BucketName, 'ResourceName>

        member _.Run(state: LightsailBucketResourceAccessState<Present, Present>) : aws.LightsailBucketResourceAccess.LightsailBucketResourceAccess =
            let config = aws.LightsailBucketResourceAccess.LightsailBucketResourceAccessConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailBucketResourceAccess.LightsailBucketResourceAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailBucketResourceAccess: missing required arguments. Must call: bucket_name, resource_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailBucketResourceAccessState<_, _>) : aws.LightsailBucketResourceAccess.LightsailBucketResourceAccess =
            Unchecked.defaultof<aws.LightsailBucketResourceAccess.LightsailBucketResourceAccess>
