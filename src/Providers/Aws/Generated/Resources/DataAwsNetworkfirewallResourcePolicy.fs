namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkfirewallResourcePolicyState<'ResourceArn> = { assignments: ResizeArray<aws.DataAwsNetworkfirewallResourcePolicy.DataAwsNetworkfirewallResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_resource_policy">aws_networkfirewall_resource_policy</a>.
    /// </summary>
    type DataAwsNetworkfirewallResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkfirewallResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkfirewallResourcePolicyState<Missing>)

        member _.Zero(()) : DataAwsNetworkfirewallResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkfirewallResourcePolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_resource_policy#resource_arn-1">DataAwsNetworkfirewallResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: DataAwsNetworkfirewallResourcePolicyState<Missing>, value: string) : DataAwsNetworkfirewallResourcePolicyState<Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : DataAwsNetworkfirewallResourcePolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkfirewall_resource_policy#id-1">DataAwsNetworkfirewallResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkfirewallResourcePolicyState<'ResourceArn>, value: string) : DataAwsNetworkfirewallResourcePolicyState<'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkfirewallResourcePolicyState<'ResourceArn>

        member _.Run(state: DataAwsNetworkfirewallResourcePolicyState<Present>) : aws.DataAwsNetworkfirewallResourcePolicy.DataAwsNetworkfirewallResourcePolicy =
            let config = aws.DataAwsNetworkfirewallResourcePolicy.DataAwsNetworkfirewallResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkfirewallResourcePolicy.DataAwsNetworkfirewallResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkfirewallResourcePolicy: missing required arguments. Must call: resource_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkfirewallResourcePolicyState<_>) : aws.DataAwsNetworkfirewallResourcePolicy.DataAwsNetworkfirewallResourcePolicy =
            Unchecked.defaultof<aws.DataAwsNetworkfirewallResourcePolicy.DataAwsNetworkfirewallResourcePolicy>
