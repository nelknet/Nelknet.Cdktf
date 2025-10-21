namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubProductSubscriptionState<'ProductArn> = { assignments: ResizeArray<aws.SecurityhubProductSubscription.SecurityhubProductSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_product_subscription">aws_securityhub_product_subscription</a>.
    /// </summary>
    type SecurityhubProductSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubProductSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubProductSubscriptionState<Missing>)

        member _.Zero(()) : SecurityhubProductSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubProductSubscriptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_product_subscription#product_arn-1">SecurityhubProductSubscription#product_arn</a>.
        /// </summary>
        [<CustomOperation "product_arn">]
        member _.ProductArn(state: SecurityhubProductSubscriptionState<Missing>, value: string) : SecurityhubProductSubscriptionState<Present> =
            state.assignments.Add(fun config -> config.ProductArn <- value)
            ({ assignments = state.assignments } : SecurityhubProductSubscriptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_product_subscription#id-1">SecurityhubProductSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubProductSubscriptionState<'ProductArn>, value: string) : SecurityhubProductSubscriptionState<'ProductArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubProductSubscriptionState<'ProductArn>

        member _.Run(state: SecurityhubProductSubscriptionState<Present>) : aws.SecurityhubProductSubscription.SecurityhubProductSubscription =
            let config = aws.SecurityhubProductSubscription.SecurityhubProductSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubProductSubscription.SecurityhubProductSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubProductSubscription: missing required arguments. Must call: product_arn.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubProductSubscriptionState<_>) : aws.SecurityhubProductSubscription.SecurityhubProductSubscription =
            Unchecked.defaultof<aws.SecurityhubProductSubscription.SecurityhubProductSubscription>
