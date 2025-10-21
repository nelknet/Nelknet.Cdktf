namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontLogDeliveryCanonicalUserIdState = { assignments: ResizeArray<aws.DataAwsCloudfrontLogDeliveryCanonicalUserId.DataAwsCloudfrontLogDeliveryCanonicalUserIdConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_log_delivery_canonical_user_id">aws_cloudfront_log_delivery_canonical_user_id</a>.
    /// </summary>
    type DataAwsCloudfrontLogDeliveryCanonicalUserIdBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontLogDeliveryCanonicalUserIdState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsCloudfrontLogDeliveryCanonicalUserIdState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_log_delivery_canonical_user_id#id-1">DataAwsCloudfrontLogDeliveryCanonicalUserId#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontLogDeliveryCanonicalUserIdState, value: string) : DataAwsCloudfrontLogDeliveryCanonicalUserIdState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudfrontLogDeliveryCanonicalUserIdState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_log_delivery_canonical_user_id#region-1">DataAwsCloudfrontLogDeliveryCanonicalUserId#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsCloudfrontLogDeliveryCanonicalUserIdState, value: string) : DataAwsCloudfrontLogDeliveryCanonicalUserIdState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsCloudfrontLogDeliveryCanonicalUserIdState

        member _.Run(state: DataAwsCloudfrontLogDeliveryCanonicalUserIdState) : aws.DataAwsCloudfrontLogDeliveryCanonicalUserId.DataAwsCloudfrontLogDeliveryCanonicalUserId =
            let config = aws.DataAwsCloudfrontLogDeliveryCanonicalUserId.DataAwsCloudfrontLogDeliveryCanonicalUserIdConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontLogDeliveryCanonicalUserId.DataAwsCloudfrontLogDeliveryCanonicalUserId(StackContext.get (), logicalId, config)
