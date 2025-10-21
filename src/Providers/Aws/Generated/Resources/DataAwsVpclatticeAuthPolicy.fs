namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier> = { assignments: ResizeArray<aws.DataAwsVpclatticeAuthPolicy.DataAwsVpclatticeAuthPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_auth_policy">aws_vpclattice_auth_policy</a>.
    /// </summary>
    type DataAwsVpclatticeAuthPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpclatticeAuthPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpclatticeAuthPolicyState<Missing>)

        member _.Zero(()) : DataAwsVpclatticeAuthPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpclatticeAuthPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_auth_policy#resource_identifier-1">DataAwsVpclatticeAuthPolicy#resource_identifier</a>.
        /// </summary>
        [<CustomOperation "resource_identifier">]
        member _.ResourceIdentifier(state: DataAwsVpclatticeAuthPolicyState<Missing>, value: string) : DataAwsVpclatticeAuthPolicyState<Present> =
            state.assignments.Add(fun config -> config.ResourceIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsVpclatticeAuthPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_auth_policy#id-1">DataAwsVpclatticeAuthPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier>, value: string) : DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_auth_policy#policy-1">DataAwsVpclatticeAuthPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier>, value: string) : DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_auth_policy#state-1">DataAwsVpclatticeAuthPolicy#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier>, value: string) : DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier> =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsVpclatticeAuthPolicyState<'ResourceIdentifier>

        member _.Run(state: DataAwsVpclatticeAuthPolicyState<Present>) : aws.DataAwsVpclatticeAuthPolicy.DataAwsVpclatticeAuthPolicy =
            let config = aws.DataAwsVpclatticeAuthPolicy.DataAwsVpclatticeAuthPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpclatticeAuthPolicy.DataAwsVpclatticeAuthPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVpclatticeAuthPolicy: missing required arguments. Must call: resource_identifier.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVpclatticeAuthPolicyState<_>) : aws.DataAwsVpclatticeAuthPolicy.DataAwsVpclatticeAuthPolicy =
            Unchecked.defaultof<aws.DataAwsVpclatticeAuthPolicy.DataAwsVpclatticeAuthPolicy>
