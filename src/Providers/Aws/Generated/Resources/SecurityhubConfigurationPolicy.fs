namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubConfigurationPolicyState<'ConfigurationPolicy, 'Name> = { assignments: ResizeArray<aws.SecurityhubConfigurationPolicy.SecurityhubConfigurationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy">aws_securityhub_configuration_policy</a>.
    /// </summary>
    type SecurityhubConfigurationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubConfigurationPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubConfigurationPolicyState<Missing, Missing>)

        member _.Zero(()) : SecurityhubConfigurationPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubConfigurationPolicyState<Missing, Missing>)

        /// <summary>
        /// configuration_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy#configuration_policy-1">SecurityhubConfigurationPolicy#configuration_policy</a>
        /// </summary>
        [<CustomOperation "configuration_policy">]
        member _.ConfigurationPolicy(state: SecurityhubConfigurationPolicyState<Missing, 'Name>, value: aws.SecurityhubConfigurationPolicy.SecurityhubConfigurationPolicyConfigurationPolicy) : SecurityhubConfigurationPolicyState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ConfigurationPolicy <- value)
            ({ assignments = state.assignments } : SecurityhubConfigurationPolicyState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy#name-1">SecurityhubConfigurationPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SecurityhubConfigurationPolicyState<'ConfigurationPolicy, Missing>, value: string) : SecurityhubConfigurationPolicyState<'ConfigurationPolicy, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SecurityhubConfigurationPolicyState<'ConfigurationPolicy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy#description-1">SecurityhubConfigurationPolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SecurityhubConfigurationPolicyState<'ConfigurationPolicy, 'Name>, value: string) : SecurityhubConfigurationPolicyState<'ConfigurationPolicy, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SecurityhubConfigurationPolicyState<'ConfigurationPolicy, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy#id-1">SecurityhubConfigurationPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubConfigurationPolicyState<'ConfigurationPolicy, 'Name>, value: string) : SecurityhubConfigurationPolicyState<'ConfigurationPolicy, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubConfigurationPolicyState<'ConfigurationPolicy, 'Name>

        member _.Run(state: SecurityhubConfigurationPolicyState<Present, Present>) : aws.SecurityhubConfigurationPolicy.SecurityhubConfigurationPolicy =
            let config = aws.SecurityhubConfigurationPolicy.SecurityhubConfigurationPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubConfigurationPolicy.SecurityhubConfigurationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubConfigurationPolicy: missing required arguments. Must call: configuration_policy, name.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubConfigurationPolicyState<_, _>) : aws.SecurityhubConfigurationPolicy.SecurityhubConfigurationPolicy =
            Unchecked.defaultof<aws.SecurityhubConfigurationPolicy.SecurityhubConfigurationPolicy>
