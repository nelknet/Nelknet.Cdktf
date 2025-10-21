namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontOriginAccessIdentityState<'Id> = { assignments: ResizeArray<aws.DataAwsCloudfrontOriginAccessIdentity.DataAwsCloudfrontOriginAccessIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_access_identity">aws_cloudfront_origin_access_identity</a>.
    /// </summary>
    type DataAwsCloudfrontOriginAccessIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontOriginAccessIdentityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontOriginAccessIdentityState<Missing>)

        member _.Zero(()) : DataAwsCloudfrontOriginAccessIdentityState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontOriginAccessIdentityState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_access_identity#id-1">DataAwsCloudfrontOriginAccessIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontOriginAccessIdentityState<Missing>, value: string) : DataAwsCloudfrontOriginAccessIdentityState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsCloudfrontOriginAccessIdentityState<Present>)

        member _.Run(state: DataAwsCloudfrontOriginAccessIdentityState<Present>) : aws.DataAwsCloudfrontOriginAccessIdentity.DataAwsCloudfrontOriginAccessIdentity =
            let config = aws.DataAwsCloudfrontOriginAccessIdentity.DataAwsCloudfrontOriginAccessIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontOriginAccessIdentity.DataAwsCloudfrontOriginAccessIdentity(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudfrontOriginAccessIdentity: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudfrontOriginAccessIdentityState<_>) : aws.DataAwsCloudfrontOriginAccessIdentity.DataAwsCloudfrontOriginAccessIdentity =
            Unchecked.defaultof<aws.DataAwsCloudfrontOriginAccessIdentity.DataAwsCloudfrontOriginAccessIdentity>
