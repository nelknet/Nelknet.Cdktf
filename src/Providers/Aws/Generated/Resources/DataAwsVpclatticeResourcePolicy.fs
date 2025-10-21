namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpclatticeResourcePolicyState<'ResourceArn> = { assignments: ResizeArray<aws.DataAwsVpclatticeResourcePolicy.DataAwsVpclatticeResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_resource_policy">aws_vpclattice_resource_policy</a>.
    /// </summary>
    type DataAwsVpclatticeResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpclatticeResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpclatticeResourcePolicyState<Missing>)

        member _.Zero(()) : DataAwsVpclatticeResourcePolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpclatticeResourcePolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_resource_policy#resource_arn-1">DataAwsVpclatticeResourcePolicy#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: DataAwsVpclatticeResourcePolicyState<Missing>, value: string) : DataAwsVpclatticeResourcePolicyState<Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : DataAwsVpclatticeResourcePolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_resource_policy#id-1">DataAwsVpclatticeResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpclatticeResourcePolicyState<'ResourceArn>, value: string) : DataAwsVpclatticeResourcePolicyState<'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpclatticeResourcePolicyState<'ResourceArn>

        member _.Run(state: DataAwsVpclatticeResourcePolicyState<Present>) : aws.DataAwsVpclatticeResourcePolicy.DataAwsVpclatticeResourcePolicy =
            let config = aws.DataAwsVpclatticeResourcePolicy.DataAwsVpclatticeResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpclatticeResourcePolicy.DataAwsVpclatticeResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVpclatticeResourcePolicy: missing required arguments. Must call: resource_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVpclatticeResourcePolicyState<_>) : aws.DataAwsVpclatticeResourcePolicy.DataAwsVpclatticeResourcePolicy =
            Unchecked.defaultof<aws.DataAwsVpclatticeResourcePolicy.DataAwsVpclatticeResourcePolicy>
