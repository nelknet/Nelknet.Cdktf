namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontOriginAccessIdentityState = { assignments: ResizeArray<aws.CloudfrontOriginAccessIdentity.CloudfrontOriginAccessIdentityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_identity">aws_cloudfront_origin_access_identity</a>.
    /// </summary>
    type CloudfrontOriginAccessIdentityBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontOriginAccessIdentityState =
            { assignments = ResizeArray() }

        member _.Zero(()) : CloudfrontOriginAccessIdentityState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_identity#comment-1">CloudfrontOriginAccessIdentity#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontOriginAccessIdentityState, value: string) : CloudfrontOriginAccessIdentityState =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontOriginAccessIdentityState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_access_identity#id-1">CloudfrontOriginAccessIdentity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontOriginAccessIdentityState, value: string) : CloudfrontOriginAccessIdentityState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontOriginAccessIdentityState

        member _.Run(state: CloudfrontOriginAccessIdentityState) : aws.CloudfrontOriginAccessIdentity.CloudfrontOriginAccessIdentity =
            let config = aws.CloudfrontOriginAccessIdentity.CloudfrontOriginAccessIdentityConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontOriginAccessIdentity.CloudfrontOriginAccessIdentity(StackContext.get (), logicalId, config)
