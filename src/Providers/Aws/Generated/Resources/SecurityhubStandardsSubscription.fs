namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubStandardsSubscriptionState<'StandardsArn> = { assignments: ResizeArray<aws.SecurityhubStandardsSubscription.SecurityhubStandardsSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_subscription">aws_securityhub_standards_subscription</a>.
    /// </summary>
    type SecurityhubStandardsSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubStandardsSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubStandardsSubscriptionState<Missing>)

        member _.Zero(()) : SecurityhubStandardsSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubStandardsSubscriptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_subscription#standards_arn-1">SecurityhubStandardsSubscription#standards_arn</a>.
        /// </summary>
        [<CustomOperation "standards_arn">]
        member _.StandardsArn(state: SecurityhubStandardsSubscriptionState<Missing>, value: string) : SecurityhubStandardsSubscriptionState<Present> =
            state.assignments.Add(fun config -> config.StandardsArn <- value)
            ({ assignments = state.assignments } : SecurityhubStandardsSubscriptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_subscription#id-1">SecurityhubStandardsSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubStandardsSubscriptionState<'StandardsArn>, value: string) : SecurityhubStandardsSubscriptionState<'StandardsArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubStandardsSubscriptionState<'StandardsArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_subscription#timeouts-1">SecurityhubStandardsSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityhubStandardsSubscriptionState<'StandardsArn>, value: aws.SecurityhubStandardsSubscription.SecurityhubStandardsSubscriptionTimeouts) : SecurityhubStandardsSubscriptionState<'StandardsArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityhubStandardsSubscriptionState<'StandardsArn>

        member _.Run(state: SecurityhubStandardsSubscriptionState<Present>) : aws.SecurityhubStandardsSubscription.SecurityhubStandardsSubscription =
            let config = aws.SecurityhubStandardsSubscription.SecurityhubStandardsSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubStandardsSubscription.SecurityhubStandardsSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubStandardsSubscription: missing required arguments. Must call: standards_arn.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubStandardsSubscriptionState<_>) : aws.SecurityhubStandardsSubscription.SecurityhubStandardsSubscription =
            Unchecked.defaultof<aws.SecurityhubStandardsSubscription.SecurityhubStandardsSubscription>
