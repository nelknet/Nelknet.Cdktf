namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontOriginAccessIdentitiesState = { assignments: ResizeArray<aws.DataAwsCloudfrontOriginAccessIdentities.DataAwsCloudfrontOriginAccessIdentitiesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_access_identities">aws_cloudfront_origin_access_identities</a>.
    /// </summary>
    type DataAwsCloudfrontOriginAccessIdentitiesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontOriginAccessIdentitiesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudfrontOriginAccessIdentitiesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_access_identities#comments-1">DataAwsCloudfrontOriginAccessIdentities#comments</a>.
        /// </summary>
        [<CustomOperation "comments">]
        member _.Comments(state: DataAwsCloudfrontOriginAccessIdentitiesState, value: seq<string>) : DataAwsCloudfrontOriginAccessIdentitiesState =
            state.assignments.Add(fun config -> config.Comments <- (value |> Seq.toArray))
            state : DataAwsCloudfrontOriginAccessIdentitiesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_access_identities#id-1">DataAwsCloudfrontOriginAccessIdentities#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontOriginAccessIdentitiesState, value: string) : DataAwsCloudfrontOriginAccessIdentitiesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudfrontOriginAccessIdentitiesState

        member _.Run(state: DataAwsCloudfrontOriginAccessIdentitiesState) : aws.DataAwsCloudfrontOriginAccessIdentities.DataAwsCloudfrontOriginAccessIdentities =
            let config = aws.DataAwsCloudfrontOriginAccessIdentities.DataAwsCloudfrontOriginAccessIdentitiesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontOriginAccessIdentities.DataAwsCloudfrontOriginAccessIdentities(StackContext.get (), logicalId, config)
