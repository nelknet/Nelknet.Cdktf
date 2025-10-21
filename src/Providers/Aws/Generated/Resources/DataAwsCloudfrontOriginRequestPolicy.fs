namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontOriginRequestPolicyState = { assignments: ResizeArray<aws.DataAwsCloudfrontOriginRequestPolicy.DataAwsCloudfrontOriginRequestPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_request_policy">aws_cloudfront_origin_request_policy</a>.
    /// </summary>
    type DataAwsCloudfrontOriginRequestPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontOriginRequestPolicyState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudfrontOriginRequestPolicyState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_request_policy#id-1">DataAwsCloudfrontOriginRequestPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontOriginRequestPolicyState, value: string) : DataAwsCloudfrontOriginRequestPolicyState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudfrontOriginRequestPolicyState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_origin_request_policy#name-1">DataAwsCloudfrontOriginRequestPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudfrontOriginRequestPolicyState, value: string) : DataAwsCloudfrontOriginRequestPolicyState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsCloudfrontOriginRequestPolicyState

        member _.Run(state: DataAwsCloudfrontOriginRequestPolicyState) : aws.DataAwsCloudfrontOriginRequestPolicy.DataAwsCloudfrontOriginRequestPolicy =
            let config = aws.DataAwsCloudfrontOriginRequestPolicy.DataAwsCloudfrontOriginRequestPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontOriginRequestPolicy.DataAwsCloudfrontOriginRequestPolicy(StackContext.get (), logicalId, config)
