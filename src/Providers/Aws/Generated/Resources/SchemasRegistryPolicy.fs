namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SchemasRegistryPolicyState<'Policy, 'RegistryName> = { assignments: ResizeArray<aws.SchemasRegistryPolicy.SchemasRegistryPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry_policy">aws_schemas_registry_policy</a>.
    /// </summary>
    type SchemasRegistryPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SchemasRegistryPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SchemasRegistryPolicyState<Missing, Missing>)

        member _.Zero(()) : SchemasRegistryPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SchemasRegistryPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry_policy#policy-1">SchemasRegistryPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: SchemasRegistryPolicyState<Missing, 'RegistryName>, value: string) : SchemasRegistryPolicyState<Present, 'RegistryName> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : SchemasRegistryPolicyState<Present, 'RegistryName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry_policy#registry_name-1">SchemasRegistryPolicy#registry_name</a>.
        /// </summary>
        [<CustomOperation "registry_name">]
        member _.RegistryName(state: SchemasRegistryPolicyState<'Policy, Missing>, value: string) : SchemasRegistryPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.RegistryName <- value)
            ({ assignments = state.assignments } : SchemasRegistryPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/schemas_registry_policy#id-1">SchemasRegistryPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SchemasRegistryPolicyState<'Policy, 'RegistryName>, value: string) : SchemasRegistryPolicyState<'Policy, 'RegistryName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SchemasRegistryPolicyState<'Policy, 'RegistryName>

        member _.Run(state: SchemasRegistryPolicyState<Present, Present>) : aws.SchemasRegistryPolicy.SchemasRegistryPolicy =
            let config = aws.SchemasRegistryPolicy.SchemasRegistryPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SchemasRegistryPolicy.SchemasRegistryPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.schemasRegistryPolicy: missing required arguments. Must call: policy, registry_name.", 9999, IsError = true)>]
        member _.Run(_: SchemasRegistryPolicyState<_, _>) : aws.SchemasRegistryPolicy.SchemasRegistryPolicy =
            Unchecked.defaultof<aws.SchemasRegistryPolicy.SchemasRegistryPolicy>
